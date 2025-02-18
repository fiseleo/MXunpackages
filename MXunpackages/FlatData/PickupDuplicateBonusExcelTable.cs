// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct PickupDuplicateBonusExcelTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static PickupDuplicateBonusExcelTable GetRootAsPickupDuplicateBonusExcelTable(ByteBuffer _bb) { return GetRootAsPickupDuplicateBonusExcelTable(_bb, new PickupDuplicateBonusExcelTable()); }
  public static PickupDuplicateBonusExcelTable GetRootAsPickupDuplicateBonusExcelTable(ByteBuffer _bb, PickupDuplicateBonusExcelTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public PickupDuplicateBonusExcelTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Plana.FlatData.PickupDuplicateBonusExcel? DataList(int j) { int o = __p.__offset(4); return o != 0 ? (Plana.FlatData.PickupDuplicateBonusExcel?)(new Plana.FlatData.PickupDuplicateBonusExcel()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<Plana.FlatData.PickupDuplicateBonusExcelTable> CreatePickupDuplicateBonusExcelTable(FlatBufferBuilder builder,
      VectorOffset DataListOffset = default(VectorOffset)) {
    builder.StartTable(1);
    PickupDuplicateBonusExcelTable.AddDataList(builder, DataListOffset);
    return PickupDuplicateBonusExcelTable.EndPickupDuplicateBonusExcelTable(builder);
  }

  public static void StartPickupDuplicateBonusExcelTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset dataListOffset) { builder.AddOffset(0, dataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<Plana.FlatData.PickupDuplicateBonusExcel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<Plana.FlatData.PickupDuplicateBonusExcel>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Plana.FlatData.PickupDuplicateBonusExcel>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<Plana.FlatData.PickupDuplicateBonusExcel>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Plana.FlatData.PickupDuplicateBonusExcelTable> EndPickupDuplicateBonusExcelTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.PickupDuplicateBonusExcelTable>(o);
  }
  public PickupDuplicateBonusExcelTableT UnPack() {
    var _o = new PickupDuplicateBonusExcelTableT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(PickupDuplicateBonusExcelTableT _o) {
		byte[] key = TableEncryptionService.CreateKey("PickupDuplicateBonusExcel");
    _o.DataList = new List<Plana.FlatData.PickupDuplicateBonusExcelT>();
    for (var _j = 0; _j < this.DataListLength; ++_j) {_o.DataList.Add(this.DataList(_j).HasValue ? this.DataList(_j).Value.UnPack() : null);}
  }
  public static Offset<Plana.FlatData.PickupDuplicateBonusExcelTable> Pack(FlatBufferBuilder builder, PickupDuplicateBonusExcelTableT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.PickupDuplicateBonusExcelTable>);
    var _DataList = default(VectorOffset);
    if (_o.DataList != null) {
      var __DataList = new Offset<Plana.FlatData.PickupDuplicateBonusExcel>[_o.DataList.Count];
      for (var _j = 0; _j < __DataList.Length; ++_j) { __DataList[_j] = Plana.FlatData.PickupDuplicateBonusExcel.Pack(builder, _o.DataList[_j]); }
      _DataList = CreateDataListVector(builder, __DataList);
    }
    return CreatePickupDuplicateBonusExcelTable(
      builder,
      _DataList);
  }
}

public class PickupDuplicateBonusExcelTableT
{
  public List<Plana.FlatData.PickupDuplicateBonusExcelT> DataList { get; set; }

  public PickupDuplicateBonusExcelTableT() {
    this.DataList = null;
  }
}


static public class PickupDuplicateBonusExcelTableVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfTables(tablePos, 4 /*DataList*/, Plana.FlatData.PickupDuplicateBonusExcelVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
