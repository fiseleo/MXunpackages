// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct PresetCharacterGroupSettingExcelTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static PresetCharacterGroupSettingExcelTable GetRootAsPresetCharacterGroupSettingExcelTable(ByteBuffer _bb) { return GetRootAsPresetCharacterGroupSettingExcelTable(_bb, new PresetCharacterGroupSettingExcelTable()); }
  public static PresetCharacterGroupSettingExcelTable GetRootAsPresetCharacterGroupSettingExcelTable(ByteBuffer _bb, PresetCharacterGroupSettingExcelTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public PresetCharacterGroupSettingExcelTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Plana.FlatData.PresetCharacterGroupSettingExcel? DataList(int j) { int o = __p.__offset(4); return o != 0 ? (Plana.FlatData.PresetCharacterGroupSettingExcel?)(new Plana.FlatData.PresetCharacterGroupSettingExcel()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<Plana.FlatData.PresetCharacterGroupSettingExcelTable> CreatePresetCharacterGroupSettingExcelTable(FlatBufferBuilder builder,
      VectorOffset DataListOffset = default(VectorOffset)) {
    builder.StartTable(1);
    PresetCharacterGroupSettingExcelTable.AddDataList(builder, DataListOffset);
    return PresetCharacterGroupSettingExcelTable.EndPresetCharacterGroupSettingExcelTable(builder);
  }

  public static void StartPresetCharacterGroupSettingExcelTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset dataListOffset) { builder.AddOffset(0, dataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<Plana.FlatData.PresetCharacterGroupSettingExcel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<Plana.FlatData.PresetCharacterGroupSettingExcel>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Plana.FlatData.PresetCharacterGroupSettingExcel>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<Plana.FlatData.PresetCharacterGroupSettingExcel>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Plana.FlatData.PresetCharacterGroupSettingExcelTable> EndPresetCharacterGroupSettingExcelTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.PresetCharacterGroupSettingExcelTable>(o);
  }
  public PresetCharacterGroupSettingExcelTableT UnPack() {
    var _o = new PresetCharacterGroupSettingExcelTableT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(PresetCharacterGroupSettingExcelTableT _o) {
		byte[] key = TableEncryptionService.CreateKey("PresetCharacterGroupSettingExcel");
    _o.DataList = new List<Plana.FlatData.PresetCharacterGroupSettingExcelT>();
    for (var _j = 0; _j < this.DataListLength; ++_j) {_o.DataList.Add(this.DataList(_j).HasValue ? this.DataList(_j).Value.UnPack() : null);}
  }
  public static Offset<Plana.FlatData.PresetCharacterGroupSettingExcelTable> Pack(FlatBufferBuilder builder, PresetCharacterGroupSettingExcelTableT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.PresetCharacterGroupSettingExcelTable>);
    var _DataList = default(VectorOffset);
    if (_o.DataList != null) {
      var __DataList = new Offset<Plana.FlatData.PresetCharacterGroupSettingExcel>[_o.DataList.Count];
      for (var _j = 0; _j < __DataList.Length; ++_j) { __DataList[_j] = Plana.FlatData.PresetCharacterGroupSettingExcel.Pack(builder, _o.DataList[_j]); }
      _DataList = CreateDataListVector(builder, __DataList);
    }
    return CreatePresetCharacterGroupSettingExcelTable(
      builder,
      _DataList);
  }
}

public class PresetCharacterGroupSettingExcelTableT
{
  public List<Plana.FlatData.PresetCharacterGroupSettingExcelT> DataList { get; set; }

  public PresetCharacterGroupSettingExcelTableT() {
    this.DataList = null;
  }
}


static public class PresetCharacterGroupSettingExcelTableVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfTables(tablePos, 4 /*DataList*/, Plana.FlatData.PresetCharacterGroupSettingExcelVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
