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

public struct DefaultParcelExcelTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static DefaultParcelExcelTable GetRootAsDefaultParcelExcelTable(ByteBuffer _bb) { return GetRootAsDefaultParcelExcelTable(_bb, new DefaultParcelExcelTable()); }
  public static DefaultParcelExcelTable GetRootAsDefaultParcelExcelTable(ByteBuffer _bb, DefaultParcelExcelTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public DefaultParcelExcelTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Plana.FlatData.DefaultParcelExcel? DataList(int j) { int o = __p.__offset(4); return o != 0 ? (Plana.FlatData.DefaultParcelExcel?)(new Plana.FlatData.DefaultParcelExcel()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<Plana.FlatData.DefaultParcelExcelTable> CreateDefaultParcelExcelTable(FlatBufferBuilder builder,
      VectorOffset DataListOffset = default(VectorOffset)) {
    builder.StartTable(1);
    DefaultParcelExcelTable.AddDataList(builder, DataListOffset);
    return DefaultParcelExcelTable.EndDefaultParcelExcelTable(builder);
  }

  public static void StartDefaultParcelExcelTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset dataListOffset) { builder.AddOffset(0, dataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<Plana.FlatData.DefaultParcelExcel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<Plana.FlatData.DefaultParcelExcel>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Plana.FlatData.DefaultParcelExcel>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<Plana.FlatData.DefaultParcelExcel>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Plana.FlatData.DefaultParcelExcelTable> EndDefaultParcelExcelTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.DefaultParcelExcelTable>(o);
  }
  public DefaultParcelExcelTableT UnPack() {
    var _o = new DefaultParcelExcelTableT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(DefaultParcelExcelTableT _o) {
        byte[] key = TableEncryptionService.CreateKey("DefaultParcelExcel");
    _o.DataList = new List<Plana.FlatData.DefaultParcelExcelT>();
    for (var _j = 0; _j < this.DataListLength; ++_j) {_o.DataList.Add(this.DataList(_j).HasValue ? this.DataList(_j).Value.UnPack() : null);}
  }
  public static Offset<Plana.FlatData.DefaultParcelExcelTable> Pack(FlatBufferBuilder builder, DefaultParcelExcelTableT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.DefaultParcelExcelTable>);
    var _DataList = default(VectorOffset);
    if (_o.DataList != null) {
      var __DataList = new Offset<Plana.FlatData.DefaultParcelExcel>[_o.DataList.Count];
      for (var _j = 0; _j < __DataList.Length; ++_j) { __DataList[_j] = Plana.FlatData.DefaultParcelExcel.Pack(builder, _o.DataList[_j]); }
      _DataList = CreateDataListVector(builder, __DataList);
    }
    return CreateDefaultParcelExcelTable(
      builder,
      _DataList);
  }
}

public class DefaultParcelExcelTableT
{
  public List<Plana.FlatData.DefaultParcelExcelT> DataList { get; set; }

  public DefaultParcelExcelTableT() {
    this.DataList = null;
  }
}


static public class DefaultParcelExcelTableVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfTables(tablePos, 4 /*DataList*/, Plana.FlatData.DefaultParcelExcelVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
