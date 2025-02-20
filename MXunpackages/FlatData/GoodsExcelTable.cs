// <auto-generated>
//  automatically generated by the PlanaBuffers compiler, do not modify
//PlanaBuffer. Custom Flatbuff Compiler
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct GoodsExcelTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static GoodsExcelTable GetRootAsGoodsExcelTable(ByteBuffer _bb) { return GetRootAsGoodsExcelTable(_bb, new GoodsExcelTable()); }
  public static GoodsExcelTable GetRootAsGoodsExcelTable(ByteBuffer _bb, GoodsExcelTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GoodsExcelTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Plana.FlatData.GoodsExcel? DataList(int j) { int o = __p.__offset(4); return o != 0 ? (Plana.FlatData.GoodsExcel?)(new Plana.FlatData.GoodsExcel()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<Plana.FlatData.GoodsExcelTable> CreateGoodsExcelTable(FlatBufferBuilder builder,
      VectorOffset DataListOffset = default(VectorOffset)) {
    builder.StartTable(1);
    GoodsExcelTable.AddDataList(builder, DataListOffset);
    return GoodsExcelTable.EndGoodsExcelTable(builder);
  }

  public static void StartGoodsExcelTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset dataListOffset) { builder.AddOffset(0, dataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<Plana.FlatData.GoodsExcel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<Plana.FlatData.GoodsExcel>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Plana.FlatData.GoodsExcel>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<Plana.FlatData.GoodsExcel>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Plana.FlatData.GoodsExcelTable> EndGoodsExcelTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.GoodsExcelTable>(o);
  }
  public GoodsExcelTableT UnPack() {
    var _o = new GoodsExcelTableT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(GoodsExcelTableT _o) {
        byte[] key = TableEncryptionService.CreateKey("GoodsExcel");
    _o.DataList = new List<Plana.FlatData.GoodsExcelT>();
    for (var _j = 0; _j < this.DataListLength; ++_j) {_o.DataList.Add(this.DataList(_j).HasValue ? this.DataList(_j).Value.UnPack() : null);}
  }
  public static Offset<Plana.FlatData.GoodsExcelTable> Pack(FlatBufferBuilder builder, GoodsExcelTableT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.GoodsExcelTable>);
    var _DataList = default(VectorOffset);
    if (_o.DataList != null) {
      var __DataList = new Offset<Plana.FlatData.GoodsExcel>[_o.DataList.Count];
      for (var _j = 0; _j < __DataList.Length; ++_j) { __DataList[_j] = Plana.FlatData.GoodsExcel.Pack(builder, _o.DataList[_j]); }
      _DataList = CreateDataListVector(builder, __DataList);
    }
    return CreateGoodsExcelTable(
      builder,
      _DataList);
  }
}

public class GoodsExcelTableT
{
  public List<Plana.FlatData.GoodsExcelT> DataList { get; set; }

  public GoodsExcelTableT() {
    this.DataList = null;
  }
}


static public class GoodsExcelTableVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfTables(tablePos, 4 /*DataList*/, Plana.FlatData.GoodsExcelVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
