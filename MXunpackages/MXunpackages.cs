using Ionic.Zip;
using Plana.Crypto;

namespace ExcelExtractor
{
    public class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel.ZIP & Excel.DB files|*.zip;*.db";
                openFileDialog.Title = "Select Excel.zip and Excel.db";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string dumpDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dump");
                    string excelDir = Path.Combine(dumpDir, "Excel");
                    string dbDir = Path.Combine(dumpDir, "Exceldb");

                    Directory.CreateDirectory(dumpDir);
                    Directory.CreateDirectory(excelDir);
                    Directory.CreateDirectory(dbDir);

                    string? zipFilePath = null;
                    string? dbFilePath = null;

                    // 找出 ZIP 與 DB
                    foreach (string filePath in openFileDialog.FileNames)
                    {
                        if (filePath.EndsWith(".zip", StringComparison.OrdinalIgnoreCase))
                        {
                            zipFilePath = filePath;
                        }
                        else if (filePath.EndsWith(".db", StringComparison.OrdinalIgnoreCase))
                        {
                            dbFilePath = filePath;
                        }
                    }

                    // 解壓 zip
                    if (zipFilePath != null)
                    {
                        Console.WriteLine($"Extracting {zipFilePath} to {excelDir}");
                        string password = Convert.ToBase64String(TableService.CreatePassword(Path.GetFileName(zipFilePath)));

                        try
                        {
                            using (ZipFile zip = new ZipFile(zipFilePath))
                            {
                                zip.Password = password;
                                zip.ExtractAll(excelDir, ExtractExistingFileAction.OverwriteSilently);
                            }
                            Console.WriteLine("Excel files extracted successfully using SharpZipLib.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error extracting Excel.zip: {ex.Message}");
                        }
                    }

                    // 複製 db
                    if (dbFilePath != null)
                    {
                        string destDbPath = Path.Combine(dbDir, Path.GetFileName(dbFilePath));
                        Console.WriteLine($"Copying {dbFilePath} to {destDbPath}");
                        File.Copy(dbFilePath, destDbPath, true);
                    }

                    // Dump DB
                    if (dbFilePath != null)
                    {
                        TableService.DumpExcelDB(dbFilePath, dbDir);
                        foreach (var bytesFile in Directory.GetFiles(dbDir, "*.db", SearchOption.AllDirectories))
                        {
                            File.Delete(bytesFile);
                        }
                    }

                    // Dump Excels (將 JSON 輸出到 excelDir)
                    if (zipFilePath != null)
                    {
                        // 第二個參數改為 excelDir，讓 JSON 直接輸出到 dump\Excel
                        TableService.DumpExcels(excelDir, excelDir);

                        // 刪除 .bytes 檔案
                        foreach (var bytesFile in Directory.GetFiles(excelDir, "*.bytes", SearchOption.AllDirectories))
                        {
                            File.Delete(bytesFile);
                        }
                    }
                }
            }
        }
    }
}
