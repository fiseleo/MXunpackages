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

public struct WebEventSeasonExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static WebEventSeasonExcel GetRootAsWebEventSeasonExcel(ByteBuffer _bb) { return GetRootAsWebEventSeasonExcel(_bb, new WebEventSeasonExcel()); }
  public static WebEventSeasonExcel GetRootAsWebEventSeasonExcel(ByteBuffer _bb, WebEventSeasonExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public WebEventSeasonExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool Enabled { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string StartDate { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStartDateBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetStartDateBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetStartDateArray() { return __p.__vector_as_array<byte>(8); }
  public string EndDate { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEndDateBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetEndDateBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetEndDateArray() { return __p.__vector_as_array<byte>(10); }
  public string LobbyBannerImage { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLobbyBannerImageBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetLobbyBannerImageBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetLobbyBannerImageArray() { return __p.__vector_as_array<byte>(12); }
  public string PopupTitleLocalizeKey { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPopupTitleLocalizeKeyBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetPopupTitleLocalizeKeyBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetPopupTitleLocalizeKeyArray() { return __p.__vector_as_array<byte>(14); }
  public string EventUrl { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEventUrlBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetEventUrlBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetEventUrlArray() { return __p.__vector_as_array<byte>(16); }

  public static Offset<Plana.FlatData.WebEventSeasonExcel> CreateWebEventSeasonExcel(FlatBufferBuilder builder,
      long Id = 0,
      bool Enabled = false,
      StringOffset StartDateOffset = default(StringOffset),
      StringOffset EndDateOffset = default(StringOffset),
      StringOffset LobbyBannerImageOffset = default(StringOffset),
      StringOffset PopupTitleLocalizeKeyOffset = default(StringOffset),
      StringOffset EventUrlOffset = default(StringOffset)) {
    builder.StartTable(7);
    WebEventSeasonExcel.AddId(builder, Id);
    WebEventSeasonExcel.AddEventUrl(builder, EventUrlOffset);
    WebEventSeasonExcel.AddPopupTitleLocalizeKey(builder, PopupTitleLocalizeKeyOffset);
    WebEventSeasonExcel.AddLobbyBannerImage(builder, LobbyBannerImageOffset);
    WebEventSeasonExcel.AddEndDate(builder, EndDateOffset);
    WebEventSeasonExcel.AddStartDate(builder, StartDateOffset);
    WebEventSeasonExcel.AddEnabled(builder, Enabled);
    return WebEventSeasonExcel.EndWebEventSeasonExcel(builder);
  }

  public static void StartWebEventSeasonExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddEnabled(FlatBufferBuilder builder, bool enabled) { builder.AddBool(1, enabled, false); }
  public static void AddStartDate(FlatBufferBuilder builder, StringOffset startDateOffset) { builder.AddOffset(2, startDateOffset.Value, 0); }
  public static void AddEndDate(FlatBufferBuilder builder, StringOffset endDateOffset) { builder.AddOffset(3, endDateOffset.Value, 0); }
  public static void AddLobbyBannerImage(FlatBufferBuilder builder, StringOffset lobbyBannerImageOffset) { builder.AddOffset(4, lobbyBannerImageOffset.Value, 0); }
  public static void AddPopupTitleLocalizeKey(FlatBufferBuilder builder, StringOffset popupTitleLocalizeKeyOffset) { builder.AddOffset(5, popupTitleLocalizeKeyOffset.Value, 0); }
  public static void AddEventUrl(FlatBufferBuilder builder, StringOffset eventUrlOffset) { builder.AddOffset(6, eventUrlOffset.Value, 0); }
  public static Offset<Plana.FlatData.WebEventSeasonExcel> EndWebEventSeasonExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.WebEventSeasonExcel>(o);
  }
  public WebEventSeasonExcelT UnPack() {
    var _o = new WebEventSeasonExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(WebEventSeasonExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("WebEventSeason");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.Enabled = TableEncryptionService.Convert(this.Enabled, key);
    _o.StartDate = TableEncryptionService.Convert(this.StartDate, key);
    _o.EndDate = TableEncryptionService.Convert(this.EndDate, key);
    _o.LobbyBannerImage = TableEncryptionService.Convert(this.LobbyBannerImage, key);
    _o.PopupTitleLocalizeKey = TableEncryptionService.Convert(this.PopupTitleLocalizeKey, key);
    _o.EventUrl = TableEncryptionService.Convert(this.EventUrl, key);
  }
  public static Offset<Plana.FlatData.WebEventSeasonExcel> Pack(FlatBufferBuilder builder, WebEventSeasonExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.WebEventSeasonExcel>);
    var _StartDate = _o.StartDate == null ? default(StringOffset) : builder.CreateString(_o.StartDate);
    var _EndDate = _o.EndDate == null ? default(StringOffset) : builder.CreateString(_o.EndDate);
    var _LobbyBannerImage = _o.LobbyBannerImage == null ? default(StringOffset) : builder.CreateString(_o.LobbyBannerImage);
    var _PopupTitleLocalizeKey = _o.PopupTitleLocalizeKey == null ? default(StringOffset) : builder.CreateString(_o.PopupTitleLocalizeKey);
    var _EventUrl = _o.EventUrl == null ? default(StringOffset) : builder.CreateString(_o.EventUrl);
    return CreateWebEventSeasonExcel(
      builder,
      _o.Id,
      _o.Enabled,
      _StartDate,
      _EndDate,
      _LobbyBannerImage,
      _PopupTitleLocalizeKey,
      _EventUrl);
  }
}

public class WebEventSeasonExcelT
{
  public long Id { get; set; }
  public bool Enabled { get; set; }
  public string StartDate { get; set; }
  public string EndDate { get; set; }
  public string LobbyBannerImage { get; set; }
  public string PopupTitleLocalizeKey { get; set; }
  public string EventUrl { get; set; }

  public WebEventSeasonExcelT() {
    this.Id = 0;
    this.Enabled = false;
    this.StartDate = null;
    this.EndDate = null;
    this.LobbyBannerImage = null;
    this.PopupTitleLocalizeKey = null;
    this.EventUrl = null;
  }
}


static public class WebEventSeasonExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*Enabled*/, 1 /*bool*/, 1, false)
      && verifier.VerifyString(tablePos, 8 /*StartDate*/, false)
      && verifier.VerifyString(tablePos, 10 /*EndDate*/, false)
      && verifier.VerifyString(tablePos, 12 /*LobbyBannerImage*/, false)
      && verifier.VerifyString(tablePos, 14 /*PopupTitleLocalizeKey*/, false)
      && verifier.VerifyString(tablePos, 16 /*EventUrl*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
