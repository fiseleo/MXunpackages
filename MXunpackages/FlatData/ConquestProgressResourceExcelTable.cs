// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct ConquestProgressResourceExcelTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ConquestProgressResourceExcelTable GetRootAsConquestProgressResourceExcelTable(ByteBuffer _bb) { return GetRootAsConquestProgressResourceExcelTable(_bb, new ConquestProgressResourceExcelTable()); }
  public static ConquestProgressResourceExcelTable GetRootAsConquestProgressResourceExcelTable(ByteBuffer _bb, ConquestProgressResourceExcelTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConquestProgressResourceExcelTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Plana.FlatData.ConquestProgressResourceExcel? DataList(int j) { int o = __p.__offset(4); return o != 0 ? (Plana.FlatData.ConquestProgressResourceExcel?)(new Plana.FlatData.ConquestProgressResourceExcel()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<Plana.FlatData.ConquestProgressResourceExcelTable> CreateConquestProgressResourceExcelTable(FlatBufferBuilder builder,
      VectorOffset DataListOffset = default(VectorOffset)) {
    builder.StartTable(1);
    ConquestProgressResourceExcelTable.AddDataList(builder, DataListOffset);
    return ConquestProgressResourceExcelTable.EndConquestProgressResourceExcelTable(builder);
  }

  public static void StartConquestProgressResourceExcelTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset dataListOffset) { builder.AddOffset(0, dataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<Plana.FlatData.ConquestProgressResourceExcel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<Plana.FlatData.ConquestProgressResourceExcel>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Plana.FlatData.ConquestProgressResourceExcel>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<Plana.FlatData.ConquestProgressResourceExcel>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Plana.FlatData.ConquestProgressResourceExcelTable> EndConquestProgressResourceExcelTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.ConquestProgressResourceExcelTable>(o);
  }
  public ConquestProgressResourceExcelTableT UnPack() {
    var _o = new ConquestProgressResourceExcelTableT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ConquestProgressResourceExcelTableT _o) {
		byte[] key = TableEncryptionService.CreateKey("ConquestProgressResourceExcel");
    _o.DataList = new List<Plana.FlatData.ConquestProgressResourceExcelT>();
    for (var _j = 0; _j < this.DataListLength; ++_j) {_o.DataList.Add(this.DataList(_j).HasValue ? this.DataList(_j).Value.UnPack() : null);}
  }
  public static Offset<Plana.FlatData.ConquestProgressResourceExcelTable> Pack(FlatBufferBuilder builder, ConquestProgressResourceExcelTableT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.ConquestProgressResourceExcelTable>);
    var _DataList = default(VectorOffset);
    if (_o.DataList != null) {
      var __DataList = new Offset<Plana.FlatData.ConquestProgressResourceExcel>[_o.DataList.Count];
      for (var _j = 0; _j < __DataList.Length; ++_j) { __DataList[_j] = Plana.FlatData.ConquestProgressResourceExcel.Pack(builder, _o.DataList[_j]); }
      _DataList = CreateDataListVector(builder, __DataList);
    }
    return CreateConquestProgressResourceExcelTable(
      builder,
      _DataList);
  }
}

public class ConquestProgressResourceExcelTableT
{
  public List<Plana.FlatData.ConquestProgressResourceExcelT> DataList { get; set; }

  public ConquestProgressResourceExcelTableT() {
    this.DataList = null;
  }
}


static public class ConquestProgressResourceExcelTableVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfTables(tablePos, 4 /*DataList*/, Plana.FlatData.ConquestProgressResourceExcelVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
