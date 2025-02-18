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

public struct EventContentLobbyMenuExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentLobbyMenuExcel GetRootAsEventContentLobbyMenuExcel(ByteBuffer _bb) { return GetRootAsEventContentLobbyMenuExcel(_bb, new EventContentLobbyMenuExcel()); }
  public static EventContentLobbyMenuExcel GetRootAsEventContentLobbyMenuExcel(ByteBuffer _bb, EventContentLobbyMenuExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentLobbyMenuExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.EventContentType EventContentType_ { get { int o = __p.__offset(6); return o != 0 ? (Plana.FlatData.EventContentType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.EventContentType.Stage; } }
  public string IconSpriteName { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconSpriteNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetIconSpriteNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetIconSpriteNameArray() { return __p.__vector_as_array<byte>(8); }
  public string ButtonText { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetButtonTextBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetButtonTextBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetButtonTextArray() { return __p.__vector_as_array<byte>(10); }
  public int DisplayOrder { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public float IconOffsetX { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float IconOffsetY { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public string ReddotSpriteName { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetReddotSpriteNameBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetReddotSpriteNameBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetReddotSpriteNameArray() { return __p.__vector_as_array<byte>(18); }

  public static Offset<Plana.FlatData.EventContentLobbyMenuExcel> CreateEventContentLobbyMenuExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      Plana.FlatData.EventContentType EventContentType_ = Plana.FlatData.EventContentType.Stage,
      StringOffset IconSpriteNameOffset = default(StringOffset),
      StringOffset ButtonTextOffset = default(StringOffset),
      int DisplayOrder = 0,
      float IconOffsetX = 0.0f,
      float IconOffsetY = 0.0f,
      StringOffset ReddotSpriteNameOffset = default(StringOffset)) {
    builder.StartTable(8);
    EventContentLobbyMenuExcel.AddEventContentId(builder, EventContentId);
    EventContentLobbyMenuExcel.AddReddotSpriteName(builder, ReddotSpriteNameOffset);
    EventContentLobbyMenuExcel.AddIconOffsetY(builder, IconOffsetY);
    EventContentLobbyMenuExcel.AddIconOffsetX(builder, IconOffsetX);
    EventContentLobbyMenuExcel.AddDisplayOrder(builder, DisplayOrder);
    EventContentLobbyMenuExcel.AddButtonText(builder, ButtonTextOffset);
    EventContentLobbyMenuExcel.AddIconSpriteName(builder, IconSpriteNameOffset);
    EventContentLobbyMenuExcel.AddEventContentType_(builder, EventContentType_);
    return EventContentLobbyMenuExcel.EndEventContentLobbyMenuExcel(builder);
  }

  public static void StartEventContentLobbyMenuExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(0, eventContentId, 0); }
  public static void AddEventContentType_(FlatBufferBuilder builder, Plana.FlatData.EventContentType eventContentType_) { builder.AddInt(1, (int)eventContentType_, 0); }
  public static void AddIconSpriteName(FlatBufferBuilder builder, StringOffset iconSpriteNameOffset) { builder.AddOffset(2, iconSpriteNameOffset.Value, 0); }
  public static void AddButtonText(FlatBufferBuilder builder, StringOffset buttonTextOffset) { builder.AddOffset(3, buttonTextOffset.Value, 0); }
  public static void AddDisplayOrder(FlatBufferBuilder builder, int displayOrder) { builder.AddInt(4, displayOrder, 0); }
  public static void AddIconOffsetX(FlatBufferBuilder builder, float iconOffsetX) { builder.AddFloat(5, iconOffsetX, 0.0f); }
  public static void AddIconOffsetY(FlatBufferBuilder builder, float iconOffsetY) { builder.AddFloat(6, iconOffsetY, 0.0f); }
  public static void AddReddotSpriteName(FlatBufferBuilder builder, StringOffset reddotSpriteNameOffset) { builder.AddOffset(7, reddotSpriteNameOffset.Value, 0); }
  public static Offset<Plana.FlatData.EventContentLobbyMenuExcel> EndEventContentLobbyMenuExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.EventContentLobbyMenuExcel>(o);
  }
  public EventContentLobbyMenuExcelT UnPack() {
    var _o = new EventContentLobbyMenuExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EventContentLobbyMenuExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("EventContentLobbyMenu");
    _o.EventContentId = TableEncryptionService.Convert(this.EventContentId, key);
    _o.EventContentType_ = TableEncryptionService.Convert(this.EventContentType_, key);
    _o.IconSpriteName = TableEncryptionService.Convert(this.IconSpriteName, key);
    _o.ButtonText = TableEncryptionService.Convert(this.ButtonText, key);
    _o.DisplayOrder = TableEncryptionService.Convert(this.DisplayOrder, key);
    _o.IconOffsetX = TableEncryptionService.Convert(this.IconOffsetX, key);
    _o.IconOffsetY = TableEncryptionService.Convert(this.IconOffsetY, key);
    _o.ReddotSpriteName = TableEncryptionService.Convert(this.ReddotSpriteName, key);
  }
  public static Offset<Plana.FlatData.EventContentLobbyMenuExcel> Pack(FlatBufferBuilder builder, EventContentLobbyMenuExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.EventContentLobbyMenuExcel>);
    var _IconSpriteName = _o.IconSpriteName == null ? default(StringOffset) : builder.CreateString(_o.IconSpriteName);
    var _ButtonText = _o.ButtonText == null ? default(StringOffset) : builder.CreateString(_o.ButtonText);
    var _ReddotSpriteName = _o.ReddotSpriteName == null ? default(StringOffset) : builder.CreateString(_o.ReddotSpriteName);
    return CreateEventContentLobbyMenuExcel(
      builder,
      _o.EventContentId,
      _o.EventContentType_,
      _IconSpriteName,
      _ButtonText,
      _o.DisplayOrder,
      _o.IconOffsetX,
      _o.IconOffsetY,
      _ReddotSpriteName);
  }
}

public class EventContentLobbyMenuExcelT
{
  public long EventContentId { get; set; }
  public Plana.FlatData.EventContentType EventContentType_ { get; set; }
  public string IconSpriteName { get; set; }
  public string ButtonText { get; set; }
  public int DisplayOrder { get; set; }
  public float IconOffsetX { get; set; }
  public float IconOffsetY { get; set; }
  public string ReddotSpriteName { get; set; }

  public EventContentLobbyMenuExcelT() {
    this.EventContentId = 0;
    this.EventContentType_ = Plana.FlatData.EventContentType.Stage;
    this.IconSpriteName = null;
    this.ButtonText = null;
    this.DisplayOrder = 0;
    this.IconOffsetX = 0.0f;
    this.IconOffsetY = 0.0f;
    this.ReddotSpriteName = null;
  }
}


static public class EventContentLobbyMenuExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*EventContentType_*/, 4 /*Plana.FlatData.EventContentType*/, 4, false)
      && verifier.VerifyString(tablePos, 8 /*IconSpriteName*/, false)
      && verifier.VerifyString(tablePos, 10 /*ButtonText*/, false)
      && verifier.VerifyField(tablePos, 12 /*DisplayOrder*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*IconOffsetX*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*IconOffsetY*/, 4 /*float*/, 4, false)
      && verifier.VerifyString(tablePos, 18 /*ReddotSpriteName*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
