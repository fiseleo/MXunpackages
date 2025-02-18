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

public struct ContentSpoilerPopupExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ContentSpoilerPopupExcel GetRootAsContentSpoilerPopupExcel(ByteBuffer _bb) { return GetRootAsContentSpoilerPopupExcel(_bb, new ContentSpoilerPopupExcel()); }
  public static ContentSpoilerPopupExcel GetRootAsContentSpoilerPopupExcel(ByteBuffer _bb, ContentSpoilerPopupExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ContentSpoilerPopupExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Plana.FlatData.ContentType ContentType_ { get { int o = __p.__offset(4); return o != 0 ? (Plana.FlatData.ContentType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ContentType.None; } }
  public string SpoilerPopupTitle { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSpoilerPopupTitleBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetSpoilerPopupTitleBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetSpoilerPopupTitleArray() { return __p.__vector_as_array<byte>(6); }
  public string SpoilerPopupDescription { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSpoilerPopupDescriptionBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetSpoilerPopupDescriptionBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetSpoilerPopupDescriptionArray() { return __p.__vector_as_array<byte>(8); }
  public bool IsWarningPopUp { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long ConditionScenarioModeId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<Plana.FlatData.ContentSpoilerPopupExcel> CreateContentSpoilerPopupExcel(FlatBufferBuilder builder,
      Plana.FlatData.ContentType ContentType_ = Plana.FlatData.ContentType.None,
      StringOffset SpoilerPopupTitleOffset = default(StringOffset),
      StringOffset SpoilerPopupDescriptionOffset = default(StringOffset),
      bool IsWarningPopUp = false,
      long ConditionScenarioModeId = 0) {
    builder.StartTable(5);
    ContentSpoilerPopupExcel.AddConditionScenarioModeId(builder, ConditionScenarioModeId);
    ContentSpoilerPopupExcel.AddSpoilerPopupDescription(builder, SpoilerPopupDescriptionOffset);
    ContentSpoilerPopupExcel.AddSpoilerPopupTitle(builder, SpoilerPopupTitleOffset);
    ContentSpoilerPopupExcel.AddContentType_(builder, ContentType_);
    ContentSpoilerPopupExcel.AddIsWarningPopUp(builder, IsWarningPopUp);
    return ContentSpoilerPopupExcel.EndContentSpoilerPopupExcel(builder);
  }

  public static void StartContentSpoilerPopupExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddContentType_(FlatBufferBuilder builder, Plana.FlatData.ContentType contentType_) { builder.AddInt(0, (int)contentType_, 0); }
  public static void AddSpoilerPopupTitle(FlatBufferBuilder builder, StringOffset spoilerPopupTitleOffset) { builder.AddOffset(1, spoilerPopupTitleOffset.Value, 0); }
  public static void AddSpoilerPopupDescription(FlatBufferBuilder builder, StringOffset spoilerPopupDescriptionOffset) { builder.AddOffset(2, spoilerPopupDescriptionOffset.Value, 0); }
  public static void AddIsWarningPopUp(FlatBufferBuilder builder, bool isWarningPopUp) { builder.AddBool(3, isWarningPopUp, false); }
  public static void AddConditionScenarioModeId(FlatBufferBuilder builder, long conditionScenarioModeId) { builder.AddLong(4, conditionScenarioModeId, 0); }
  public static Offset<Plana.FlatData.ContentSpoilerPopupExcel> EndContentSpoilerPopupExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.ContentSpoilerPopupExcel>(o);
  }
  public ContentSpoilerPopupExcelT UnPack() {
    var _o = new ContentSpoilerPopupExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ContentSpoilerPopupExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("ContentSpoilerPopup");
    _o.ContentType_ = TableEncryptionService.Convert(this.ContentType_, key);
    _o.SpoilerPopupTitle = TableEncryptionService.Convert(this.SpoilerPopupTitle, key);
    _o.SpoilerPopupDescription = TableEncryptionService.Convert(this.SpoilerPopupDescription, key);
    _o.IsWarningPopUp = TableEncryptionService.Convert(this.IsWarningPopUp, key);
    _o.ConditionScenarioModeId = TableEncryptionService.Convert(this.ConditionScenarioModeId, key);
  }
  public static Offset<Plana.FlatData.ContentSpoilerPopupExcel> Pack(FlatBufferBuilder builder, ContentSpoilerPopupExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.ContentSpoilerPopupExcel>);
    var _SpoilerPopupTitle = _o.SpoilerPopupTitle == null ? default(StringOffset) : builder.CreateString(_o.SpoilerPopupTitle);
    var _SpoilerPopupDescription = _o.SpoilerPopupDescription == null ? default(StringOffset) : builder.CreateString(_o.SpoilerPopupDescription);
    return CreateContentSpoilerPopupExcel(
      builder,
      _o.ContentType_,
      _SpoilerPopupTitle,
      _SpoilerPopupDescription,
      _o.IsWarningPopUp,
      _o.ConditionScenarioModeId);
  }
}

public class ContentSpoilerPopupExcelT
{
  public Plana.FlatData.ContentType ContentType_ { get; set; }
  public string SpoilerPopupTitle { get; set; }
  public string SpoilerPopupDescription { get; set; }
  public bool IsWarningPopUp { get; set; }
  public long ConditionScenarioModeId { get; set; }

  public ContentSpoilerPopupExcelT() {
    this.ContentType_ = Plana.FlatData.ContentType.None;
    this.SpoilerPopupTitle = null;
    this.SpoilerPopupDescription = null;
    this.IsWarningPopUp = false;
    this.ConditionScenarioModeId = 0;
  }
}


static public class ContentSpoilerPopupExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*ContentType_*/, 4 /*Plana.FlatData.ContentType*/, 4, false)
      && verifier.VerifyString(tablePos, 6 /*SpoilerPopupTitle*/, false)
      && verifier.VerifyString(tablePos, 8 /*SpoilerPopupDescription*/, false)
      && verifier.VerifyField(tablePos, 10 /*IsWarningPopUp*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 12 /*ConditionScenarioModeId*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
