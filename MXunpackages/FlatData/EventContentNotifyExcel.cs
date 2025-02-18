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

public struct EventContentNotifyExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentNotifyExcel GetRootAsEventContentNotifyExcel(ByteBuffer _bb) { return GetRootAsEventContentNotifyExcel(_bb, new EventContentNotifyExcel()); }
  public static EventContentNotifyExcel GetRootAsEventContentNotifyExcel(ByteBuffer _bb, EventContentNotifyExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentNotifyExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public uint LocalizeEtcId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string IconPath { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconPathBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetIconPathBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetIconPathArray() { return __p.__vector_as_array<byte>(8); }
  public Plana.FlatData.EventNotifyType EventNotifyType_ { get { int o = __p.__offset(10); return o != 0 ? (Plana.FlatData.EventNotifyType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.EventNotifyType.RewardIncreaseEvent; } }
  public Plana.FlatData.EventTargetType EventTargetType_ { get { int o = __p.__offset(12); return o != 0 ? (Plana.FlatData.EventTargetType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.EventTargetType.WeekDungeon; } }
  public Plana.FlatData.EventTargetType ShortcutEventTargetType { get { int o = __p.__offset(14); return o != 0 ? (Plana.FlatData.EventTargetType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.EventTargetType.WeekDungeon; } }
  public bool IsShortcutEnable { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<Plana.FlatData.EventContentNotifyExcel> CreateEventContentNotifyExcel(FlatBufferBuilder builder,
      int Id = 0,
      uint LocalizeEtcId = 0,
      StringOffset IconPathOffset = default(StringOffset),
      Plana.FlatData.EventNotifyType EventNotifyType_ = Plana.FlatData.EventNotifyType.RewardIncreaseEvent,
      Plana.FlatData.EventTargetType EventTargetType_ = Plana.FlatData.EventTargetType.WeekDungeon,
      Plana.FlatData.EventTargetType ShortcutEventTargetType = Plana.FlatData.EventTargetType.WeekDungeon,
      bool IsShortcutEnable = false) {
    builder.StartTable(7);
    EventContentNotifyExcel.AddShortcutEventTargetType(builder, ShortcutEventTargetType);
    EventContentNotifyExcel.AddEventTargetType_(builder, EventTargetType_);
    EventContentNotifyExcel.AddEventNotifyType_(builder, EventNotifyType_);
    EventContentNotifyExcel.AddIconPath(builder, IconPathOffset);
    EventContentNotifyExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    EventContentNotifyExcel.AddId(builder, Id);
    EventContentNotifyExcel.AddIsShortcutEnable(builder, IsShortcutEnable);
    return EventContentNotifyExcel.EndEventContentNotifyExcel(builder);
  }

  public static void StartEventContentNotifyExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint localizeEtcId) { builder.AddUint(1, localizeEtcId, 0); }
  public static void AddIconPath(FlatBufferBuilder builder, StringOffset iconPathOffset) { builder.AddOffset(2, iconPathOffset.Value, 0); }
  public static void AddEventNotifyType_(FlatBufferBuilder builder, Plana.FlatData.EventNotifyType eventNotifyType_) { builder.AddInt(3, (int)eventNotifyType_, 0); }
  public static void AddEventTargetType_(FlatBufferBuilder builder, Plana.FlatData.EventTargetType eventTargetType_) { builder.AddInt(4, (int)eventTargetType_, 0); }
  public static void AddShortcutEventTargetType(FlatBufferBuilder builder, Plana.FlatData.EventTargetType shortcutEventTargetType) { builder.AddInt(5, (int)shortcutEventTargetType, 0); }
  public static void AddIsShortcutEnable(FlatBufferBuilder builder, bool isShortcutEnable) { builder.AddBool(6, isShortcutEnable, false); }
  public static Offset<Plana.FlatData.EventContentNotifyExcel> EndEventContentNotifyExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.EventContentNotifyExcel>(o);
  }
  public EventContentNotifyExcelT UnPack() {
    var _o = new EventContentNotifyExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EventContentNotifyExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("EventContentNotify");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.LocalizeEtcId = TableEncryptionService.Convert(this.LocalizeEtcId, key);
    _o.IconPath = TableEncryptionService.Convert(this.IconPath, key);
    _o.EventNotifyType_ = TableEncryptionService.Convert(this.EventNotifyType_, key);
    _o.EventTargetType_ = TableEncryptionService.Convert(this.EventTargetType_, key);
    _o.ShortcutEventTargetType = TableEncryptionService.Convert(this.ShortcutEventTargetType, key);
    _o.IsShortcutEnable = TableEncryptionService.Convert(this.IsShortcutEnable, key);
  }
  public static Offset<Plana.FlatData.EventContentNotifyExcel> Pack(FlatBufferBuilder builder, EventContentNotifyExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.EventContentNotifyExcel>);
    var _IconPath = _o.IconPath == null ? default(StringOffset) : builder.CreateString(_o.IconPath);
    return CreateEventContentNotifyExcel(
      builder,
      _o.Id,
      _o.LocalizeEtcId,
      _IconPath,
      _o.EventNotifyType_,
      _o.EventTargetType_,
      _o.ShortcutEventTargetType,
      _o.IsShortcutEnable);
  }
}

public class EventContentNotifyExcelT
{
  public int Id { get; set; }
  public uint LocalizeEtcId { get; set; }
  public string IconPath { get; set; }
  public Plana.FlatData.EventNotifyType EventNotifyType_ { get; set; }
  public Plana.FlatData.EventTargetType EventTargetType_ { get; set; }
  public Plana.FlatData.EventTargetType ShortcutEventTargetType { get; set; }
  public bool IsShortcutEnable { get; set; }

  public EventContentNotifyExcelT() {
    this.Id = 0;
    this.LocalizeEtcId = 0;
    this.IconPath = null;
    this.EventNotifyType_ = Plana.FlatData.EventNotifyType.RewardIncreaseEvent;
    this.EventTargetType_ = Plana.FlatData.EventTargetType.WeekDungeon;
    this.ShortcutEventTargetType = Plana.FlatData.EventTargetType.WeekDungeon;
    this.IsShortcutEnable = false;
  }
}


static public class EventContentNotifyExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*LocalizeEtcId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyString(tablePos, 8 /*IconPath*/, false)
      && verifier.VerifyField(tablePos, 10 /*EventNotifyType_*/, 4 /*Plana.FlatData.EventNotifyType*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*EventTargetType_*/, 4 /*Plana.FlatData.EventTargetType*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*ShortcutEventTargetType*/, 4 /*Plana.FlatData.EventTargetType*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*IsShortcutEnable*/, 1 /*bool*/, 1, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
