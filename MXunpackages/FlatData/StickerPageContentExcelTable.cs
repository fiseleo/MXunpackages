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

public struct StickerPageContentExcelTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static StickerPageContentExcelTable GetRootAsStickerPageContentExcelTable(ByteBuffer _bb) { return GetRootAsStickerPageContentExcelTable(_bb, new StickerPageContentExcelTable()); }
  public static StickerPageContentExcelTable GetRootAsStickerPageContentExcelTable(ByteBuffer _bb, StickerPageContentExcelTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public StickerPageContentExcelTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Plana.FlatData.StickerPageContentExcel? DataList(int j) { int o = __p.__offset(4); return o != 0 ? (Plana.FlatData.StickerPageContentExcel?)(new Plana.FlatData.StickerPageContentExcel()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<Plana.FlatData.StickerPageContentExcelTable> CreateStickerPageContentExcelTable(FlatBufferBuilder builder,
      VectorOffset DataListOffset = default(VectorOffset)) {
    builder.StartTable(1);
    StickerPageContentExcelTable.AddDataList(builder, DataListOffset);
    return StickerPageContentExcelTable.EndStickerPageContentExcelTable(builder);
  }

  public static void StartStickerPageContentExcelTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset dataListOffset) { builder.AddOffset(0, dataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<Plana.FlatData.StickerPageContentExcel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<Plana.FlatData.StickerPageContentExcel>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Plana.FlatData.StickerPageContentExcel>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<Plana.FlatData.StickerPageContentExcel>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Plana.FlatData.StickerPageContentExcelTable> EndStickerPageContentExcelTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.StickerPageContentExcelTable>(o);
  }
  public StickerPageContentExcelTableT UnPack() {
    var _o = new StickerPageContentExcelTableT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(StickerPageContentExcelTableT _o) {
        byte[] key = TableEncryptionService.CreateKey("StickerPageContentExcel");
    _o.DataList = new List<Plana.FlatData.StickerPageContentExcelT>();
    for (var _j = 0; _j < this.DataListLength; ++_j) {_o.DataList.Add(this.DataList(_j).HasValue ? this.DataList(_j).Value.UnPack() : null);}
  }
  public static Offset<Plana.FlatData.StickerPageContentExcelTable> Pack(FlatBufferBuilder builder, StickerPageContentExcelTableT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.StickerPageContentExcelTable>);
    var _DataList = default(VectorOffset);
    if (_o.DataList != null) {
      var __DataList = new Offset<Plana.FlatData.StickerPageContentExcel>[_o.DataList.Count];
      for (var _j = 0; _j < __DataList.Length; ++_j) { __DataList[_j] = Plana.FlatData.StickerPageContentExcel.Pack(builder, _o.DataList[_j]); }
      _DataList = CreateDataListVector(builder, __DataList);
    }
    return CreateStickerPageContentExcelTable(
      builder,
      _DataList);
  }
}

public class StickerPageContentExcelTableT
{
  public List<Plana.FlatData.StickerPageContentExcelT> DataList { get; set; }

  public StickerPageContentExcelTableT() {
    this.DataList = null;
  }
}


static public class StickerPageContentExcelTableVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfTables(tablePos, 4 /*DataList*/, Plana.FlatData.StickerPageContentExcelVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
