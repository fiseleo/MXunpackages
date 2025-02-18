using Google.FlatBuffers;
using Microsoft.Data.Sqlite;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Plana.Crypto.XXHash;
using Plana.FlatData;
using System.Reflection;
using System.Text;

namespace Plana.Crypto
{
    public static class TableService
    {
        /// <summary>
        /// General password gen by file name, encode to base64 for zips password
        /// </summary>
        /// <param name="key"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static byte[] CreatePassword(string key, int length = 20)
        {
            byte[] password = GC.AllocateUninitializedArray<byte>((int)Math.Round((decimal)(length / 4 * 3)));

            using var xxhash = XXHash32.Create();
            xxhash.ComputeHash(Encoding.UTF8.GetBytes(key));

            var mt = new MersenneTwister((int)xxhash.HashUInt32);

            int i = 0;
            while (i < password.Length)
            {
                Array.Copy(BitConverter.GetBytes(mt.Next()), 0, password, i, Math.Min(4, password.Length - i));
                i += 4;
            }

            return password;
        }


        public static void DumpExcels(string bytesDir,  string destDir)
        {
            foreach (var type in Assembly.GetAssembly(typeof(AcademyFavorScheduleExcelTable))!.GetTypes().Where(t => t.IsAssignableTo(typeof(IFlatbufferObject)) && t.Name.EndsWith("ExcelTable")))
            {

                string dataName = type.Name;
                try
                {
                    // Excel.zip
                    var bytesFilePath = Path.Join(bytesDir, $"{type.Name.ToLower()}.bytes");

                    if (File.Exists(bytesFilePath))
                    {
                        var bytes = File.ReadAllBytes(bytesFilePath);
                        TableEncryptionService.XOR(type.Name, bytes);
                        var inst = type.GetMethod($"GetRootAs{type.Name}", BindingFlags.Static | BindingFlags.Public, [typeof(ByteBuffer)])!.Invoke(null, [new ByteBuffer(bytes)]);

                        var obj = type.GetMethod("UnPack", BindingFlags.Instance | BindingFlags.Public)!.Invoke(inst, null);
                        File.WriteAllText(Path.Join(destDir, $"{type.Name}.json"), JsonConvert.SerializeObject(obj, Formatting.Indented, new StringEnumConverter()));
                        Console.WriteLine($"Dumped {type.Name} successfully");
                        continue;
                    }

                    // ExcelDB.db
                    /*
                    using var dbConnection = new SqliteConnection($"Data Source = {dbDir}");
                    dbConnection.Open();
                    var command = dbConnection.CreateCommand();
                    var schemaName = type.Name.Replace("ExcelTable", "") + "DBSchema";
                    command.CommandText = $"SELECT Bytes FROM {schemaName}";
                    dataName = dataName.Replace("ExcelTable", "") + "DBSchema";
                
                    using var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var inst = type.GetMethod($"GetRootAs{type.Name}", BindingFlags.Static | BindingFlags.Public, [typeof(ByteBuffer)])!
                        .Invoke(null, [new ByteBuffer((byte[])reader[0])]);

                        File.WriteAllText(Path.Join(destDir, $"{schemaName}.json"), JsonConvert.SerializeObject(inst, Formatting.Indented, new StringEnumConverter()));
                        Console.WriteLine($"Dumped {type.Name} from database schema {schemaName} successfully");
                    }*/
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error occurred while dumping {dataName} skipping... Error: {e.Message}");
                }
            }
        }
        
        public static List<object> excelList(Type type, string dbDir, string schema)
        {
            var excelList = new List<object>();
            using (var dbConnection = new SqliteConnection($"Data Source = {dbDir}"))
            {
                dbConnection.Open();
                var command = dbConnection.CreateCommand();
                command.CommandText = $"SELECT Bytes FROM {schema}";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        excelList.Add(type.GetMethod($"GetRootAs{type.Name}", BindingFlags.Static | BindingFlags.Public, [typeof(ByteBuffer)])!
                            .Invoke(null, [new ByteBuffer((byte[])reader[0])]));
                    }
                }
            }

            return excelList;
        }

        public static void DumpExcelDB(string dbDir, string destDir)
        {
            Directory.CreateDirectory(destDir);

            using (var dbConnection = new SqliteConnection($"Data Source = {dbDir}"))
            {
                dbConnection.Open();

                string query = "SELECT name FROM sqlite_master WHERE type='table' AND name NOT LIKE 'sqlite_%';";

                using (var command = new SqliteCommand(query, dbConnection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string schemaName = reader.GetString(0);
                        string tableName = schemaName.Replace("DBSchema", "Excel");
                        var type = Assembly.GetAssembly(typeof(AcademyFavorScheduleExcelTable))!.GetTypes().Where(t => t.IsAssignableTo(typeof(IFlatbufferObject)) && (t.Name.Equals(tableName))).FirstOrDefault();

                        try
                        {
                            var list = excelList(type, dbDir, schemaName);
                            File.WriteAllText(Path.Join(destDir, $"{type.Name}.json"), JsonConvert.SerializeObject(list, Formatting.Indented, new StringEnumConverter()));
                             
                            Console.WriteLine($"Dumped {type.Name} from {schemaName} successfully");
                        }
                        catch (Exception e)
                        {
                           Console.WriteLine($"Error occurred while dumping {schemaName} skipping... Error: {e.Message}");
                        }
                    }
                }
            }
        }

    }
}