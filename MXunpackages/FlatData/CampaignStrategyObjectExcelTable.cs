// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct CampaignStrategyObjectExcelTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static CampaignStrategyObjectExcelTable GetRootAsCampaignStrategyObjectExcelTable(ByteBuffer _bb) { return GetRootAsCampaignStrategyObjectExcelTable(_bb, new CampaignStrategyObjectExcelTable()); }
  public static CampaignStrategyObjectExcelTable GetRootAsCampaignStrategyObjectExcelTable(ByteBuffer _bb, CampaignStrategyObjectExcelTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CampaignStrategyObjectExcelTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Plana.FlatData.CampaignStrategyObjectExcel? DataList(int j) { int o = __p.__offset(4); return o != 0 ? (Plana.FlatData.CampaignStrategyObjectExcel?)(new Plana.FlatData.CampaignStrategyObjectExcel()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<Plana.FlatData.CampaignStrategyObjectExcelTable> CreateCampaignStrategyObjectExcelTable(FlatBufferBuilder builder,
      VectorOffset DataListOffset = default(VectorOffset)) {
    builder.StartTable(1);
    CampaignStrategyObjectExcelTable.AddDataList(builder, DataListOffset);
    return CampaignStrategyObjectExcelTable.EndCampaignStrategyObjectExcelTable(builder);
  }

  public static void StartCampaignStrategyObjectExcelTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset dataListOffset) { builder.AddOffset(0, dataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<Plana.FlatData.CampaignStrategyObjectExcel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<Plana.FlatData.CampaignStrategyObjectExcel>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Plana.FlatData.CampaignStrategyObjectExcel>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<Plana.FlatData.CampaignStrategyObjectExcel>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Plana.FlatData.CampaignStrategyObjectExcelTable> EndCampaignStrategyObjectExcelTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.CampaignStrategyObjectExcelTable>(o);
  }
  public CampaignStrategyObjectExcelTableT UnPack() {
    var _o = new CampaignStrategyObjectExcelTableT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CampaignStrategyObjectExcelTableT _o) {
		byte[] key = TableEncryptionService.CreateKey("CampaignStrategyObjectExcel");
    _o.DataList = new List<Plana.FlatData.CampaignStrategyObjectExcelT>();
    for (var _j = 0; _j < this.DataListLength; ++_j) {_o.DataList.Add(this.DataList(_j).HasValue ? this.DataList(_j).Value.UnPack() : null);}
  }
  public static Offset<Plana.FlatData.CampaignStrategyObjectExcelTable> Pack(FlatBufferBuilder builder, CampaignStrategyObjectExcelTableT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.CampaignStrategyObjectExcelTable>);
    var _DataList = default(VectorOffset);
    if (_o.DataList != null) {
      var __DataList = new Offset<Plana.FlatData.CampaignStrategyObjectExcel>[_o.DataList.Count];
      for (var _j = 0; _j < __DataList.Length; ++_j) { __DataList[_j] = Plana.FlatData.CampaignStrategyObjectExcel.Pack(builder, _o.DataList[_j]); }
      _DataList = CreateDataListVector(builder, __DataList);
    }
    return CreateCampaignStrategyObjectExcelTable(
      builder,
      _DataList);
  }
}

public class CampaignStrategyObjectExcelTableT
{
  public List<Plana.FlatData.CampaignStrategyObjectExcelT> DataList { get; set; }

  public CampaignStrategyObjectExcelTableT() {
    this.DataList = null;
  }
}


static public class CampaignStrategyObjectExcelTableVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfTables(tablePos, 4 /*DataList*/, Plana.FlatData.CampaignStrategyObjectExcelVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
