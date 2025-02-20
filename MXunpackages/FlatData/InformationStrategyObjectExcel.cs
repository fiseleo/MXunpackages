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

public struct InformationStrategyObjectExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static InformationStrategyObjectExcel GetRootAsInformationStrategyObjectExcel(ByteBuffer _bb) { return GetRootAsInformationStrategyObjectExcel(_bb, new InformationStrategyObjectExcel()); }
  public static InformationStrategyObjectExcel GetRootAsInformationStrategyObjectExcel(ByteBuffer _bb, InformationStrategyObjectExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public InformationStrategyObjectExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StageId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string PageName { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPageNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetPageNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetPageNameArray() { return __p.__vector_as_array<byte>(8); }
  public string LocalizeCodeId { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeCodeIdBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetLocalizeCodeIdBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetLocalizeCodeIdArray() { return __p.__vector_as_array<byte>(10); }

  public static Offset<Plana.FlatData.InformationStrategyObjectExcel> CreateInformationStrategyObjectExcel(FlatBufferBuilder builder,
      long Id = 0,
      long StageId = 0,
      StringOffset PageNameOffset = default(StringOffset),
      StringOffset LocalizeCodeIdOffset = default(StringOffset)) {
    builder.StartTable(4);
    InformationStrategyObjectExcel.AddStageId(builder, StageId);
    InformationStrategyObjectExcel.AddId(builder, Id);
    InformationStrategyObjectExcel.AddLocalizeCodeId(builder, LocalizeCodeIdOffset);
    InformationStrategyObjectExcel.AddPageName(builder, PageNameOffset);
    return InformationStrategyObjectExcel.EndInformationStrategyObjectExcel(builder);
  }

  public static void StartInformationStrategyObjectExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddStageId(FlatBufferBuilder builder, long stageId) { builder.AddLong(1, stageId, 0); }
  public static void AddPageName(FlatBufferBuilder builder, StringOffset pageNameOffset) { builder.AddOffset(2, pageNameOffset.Value, 0); }
  public static void AddLocalizeCodeId(FlatBufferBuilder builder, StringOffset localizeCodeIdOffset) { builder.AddOffset(3, localizeCodeIdOffset.Value, 0); }
  public static Offset<Plana.FlatData.InformationStrategyObjectExcel> EndInformationStrategyObjectExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.InformationStrategyObjectExcel>(o);
  }
  public InformationStrategyObjectExcelT UnPack() {
    var _o = new InformationStrategyObjectExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(InformationStrategyObjectExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("InformationStrategyObject");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.StageId = TableEncryptionService.Convert(this.StageId, key);
    _o.PageName = TableEncryptionService.Convert(this.PageName, key);
    _o.LocalizeCodeId = TableEncryptionService.Convert(this.LocalizeCodeId, key);
  }
  public static Offset<Plana.FlatData.InformationStrategyObjectExcel> Pack(FlatBufferBuilder builder, InformationStrategyObjectExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.InformationStrategyObjectExcel>);
    var _PageName = _o.PageName == null ? default(StringOffset) : builder.CreateString(_o.PageName);
    var _LocalizeCodeId = _o.LocalizeCodeId == null ? default(StringOffset) : builder.CreateString(_o.LocalizeCodeId);
    return CreateInformationStrategyObjectExcel(
      builder,
      _o.Id,
      _o.StageId,
      _PageName,
      _LocalizeCodeId);
  }
}

public class InformationStrategyObjectExcelT
{
  public long Id { get; set; }
  public long StageId { get; set; }
  public string PageName { get; set; }
  public string LocalizeCodeId { get; set; }

  public InformationStrategyObjectExcelT() {
    this.Id = 0;
    this.StageId = 0;
    this.PageName = null;
    this.LocalizeCodeId = null;
  }
}


static public class InformationStrategyObjectExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*StageId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 8 /*PageName*/, false)
      && verifier.VerifyString(tablePos, 10 /*LocalizeCodeId*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
