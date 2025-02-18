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

public struct MinigameTBGItemExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static MinigameTBGItemExcel GetRootAsMinigameTBGItemExcel(ByteBuffer _bb) { return GetRootAsMinigameTBGItemExcel(_bb, new MinigameTBGItemExcel()); }
  public static MinigameTBGItemExcel GetRootAsMinigameTBGItemExcel(ByteBuffer _bb, MinigameTBGItemExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MinigameTBGItemExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long UniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.TBGItemType ItemType { get { int o = __p.__offset(6); return o != 0 ? (Plana.FlatData.TBGItemType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.TBGItemType.None; } }
  public Plana.FlatData.TBGItemEffectType TBGItemEffectType_ { get { int o = __p.__offset(8); return o != 0 ? (Plana.FlatData.TBGItemEffectType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.TBGItemEffectType.None; } }
  public int ItemParameter { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string LocalizeETCId { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeETCIdBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetLocalizeETCIdBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetLocalizeETCIdArray() { return __p.__vector_as_array<byte>(12); }
  public string Icon { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetIconBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetIconArray() { return __p.__vector_as_array<byte>(14); }
  public string BuffIcon { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBuffIconBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetBuffIconBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetBuffIconArray() { return __p.__vector_as_array<byte>(16); }
  public int EncounterCount { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string DiceEffectAniClip { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDiceEffectAniClipBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetDiceEffectAniClipBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetDiceEffectAniClipArray() { return __p.__vector_as_array<byte>(20); }

  public static Offset<Plana.FlatData.MinigameTBGItemExcel> CreateMinigameTBGItemExcel(FlatBufferBuilder builder,
      long UniqueId = 0,
      Plana.FlatData.TBGItemType ItemType = Plana.FlatData.TBGItemType.None,
      Plana.FlatData.TBGItemEffectType TBGItemEffectType_ = Plana.FlatData.TBGItemEffectType.None,
      int ItemParameter = 0,
      StringOffset LocalizeETCIdOffset = default(StringOffset),
      StringOffset IconOffset = default(StringOffset),
      StringOffset BuffIconOffset = default(StringOffset),
      int EncounterCount = 0,
      StringOffset DiceEffectAniClipOffset = default(StringOffset)) {
    builder.StartTable(9);
    MinigameTBGItemExcel.AddUniqueId(builder, UniqueId);
    MinigameTBGItemExcel.AddDiceEffectAniClip(builder, DiceEffectAniClipOffset);
    MinigameTBGItemExcel.AddEncounterCount(builder, EncounterCount);
    MinigameTBGItemExcel.AddBuffIcon(builder, BuffIconOffset);
    MinigameTBGItemExcel.AddIcon(builder, IconOffset);
    MinigameTBGItemExcel.AddLocalizeETCId(builder, LocalizeETCIdOffset);
    MinigameTBGItemExcel.AddItemParameter(builder, ItemParameter);
    MinigameTBGItemExcel.AddTBGItemEffectType_(builder, TBGItemEffectType_);
    MinigameTBGItemExcel.AddItemType(builder, ItemType);
    return MinigameTBGItemExcel.EndMinigameTBGItemExcel(builder);
  }

  public static void StartMinigameTBGItemExcel(FlatBufferBuilder builder) { builder.StartTable(9); }
  public static void AddUniqueId(FlatBufferBuilder builder, long uniqueId) { builder.AddLong(0, uniqueId, 0); }
  public static void AddItemType(FlatBufferBuilder builder, Plana.FlatData.TBGItemType itemType) { builder.AddInt(1, (int)itemType, 0); }
  public static void AddTBGItemEffectType_(FlatBufferBuilder builder, Plana.FlatData.TBGItemEffectType tBGItemEffectType_) { builder.AddInt(2, (int)tBGItemEffectType_, 0); }
  public static void AddItemParameter(FlatBufferBuilder builder, int itemParameter) { builder.AddInt(3, itemParameter, 0); }
  public static void AddLocalizeETCId(FlatBufferBuilder builder, StringOffset localizeETCIdOffset) { builder.AddOffset(4, localizeETCIdOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset) { builder.AddOffset(5, iconOffset.Value, 0); }
  public static void AddBuffIcon(FlatBufferBuilder builder, StringOffset buffIconOffset) { builder.AddOffset(6, buffIconOffset.Value, 0); }
  public static void AddEncounterCount(FlatBufferBuilder builder, int encounterCount) { builder.AddInt(7, encounterCount, 0); }
  public static void AddDiceEffectAniClip(FlatBufferBuilder builder, StringOffset diceEffectAniClipOffset) { builder.AddOffset(8, diceEffectAniClipOffset.Value, 0); }
  public static Offset<Plana.FlatData.MinigameTBGItemExcel> EndMinigameTBGItemExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.MinigameTBGItemExcel>(o);
  }
  public MinigameTBGItemExcelT UnPack() {
    var _o = new MinigameTBGItemExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(MinigameTBGItemExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("MinigameTBGItem");
    _o.UniqueId = TableEncryptionService.Convert(this.UniqueId, key);
    _o.ItemType = TableEncryptionService.Convert(this.ItemType, key);
    _o.TBGItemEffectType_ = TableEncryptionService.Convert(this.TBGItemEffectType_, key);
    _o.ItemParameter = TableEncryptionService.Convert(this.ItemParameter, key);
    _o.LocalizeETCId = TableEncryptionService.Convert(this.LocalizeETCId, key);
    _o.Icon = TableEncryptionService.Convert(this.Icon, key);
    _o.BuffIcon = TableEncryptionService.Convert(this.BuffIcon, key);
    _o.EncounterCount = TableEncryptionService.Convert(this.EncounterCount, key);
    _o.DiceEffectAniClip = TableEncryptionService.Convert(this.DiceEffectAniClip, key);
  }
  public static Offset<Plana.FlatData.MinigameTBGItemExcel> Pack(FlatBufferBuilder builder, MinigameTBGItemExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.MinigameTBGItemExcel>);
    var _LocalizeETCId = _o.LocalizeETCId == null ? default(StringOffset) : builder.CreateString(_o.LocalizeETCId);
    var _Icon = _o.Icon == null ? default(StringOffset) : builder.CreateString(_o.Icon);
    var _BuffIcon = _o.BuffIcon == null ? default(StringOffset) : builder.CreateString(_o.BuffIcon);
    var _DiceEffectAniClip = _o.DiceEffectAniClip == null ? default(StringOffset) : builder.CreateString(_o.DiceEffectAniClip);
    return CreateMinigameTBGItemExcel(
      builder,
      _o.UniqueId,
      _o.ItemType,
      _o.TBGItemEffectType_,
      _o.ItemParameter,
      _LocalizeETCId,
      _Icon,
      _BuffIcon,
      _o.EncounterCount,
      _DiceEffectAniClip);
  }
}

public class MinigameTBGItemExcelT
{
  public long UniqueId { get; set; }
  public Plana.FlatData.TBGItemType ItemType { get; set; }
  public Plana.FlatData.TBGItemEffectType TBGItemEffectType_ { get; set; }
  public int ItemParameter { get; set; }
  public string LocalizeETCId { get; set; }
  public string Icon { get; set; }
  public string BuffIcon { get; set; }
  public int EncounterCount { get; set; }
  public string DiceEffectAniClip { get; set; }

  public MinigameTBGItemExcelT() {
    this.UniqueId = 0;
    this.ItemType = Plana.FlatData.TBGItemType.None;
    this.TBGItemEffectType_ = Plana.FlatData.TBGItemEffectType.None;
    this.ItemParameter = 0;
    this.LocalizeETCId = null;
    this.Icon = null;
    this.BuffIcon = null;
    this.EncounterCount = 0;
    this.DiceEffectAniClip = null;
  }
}


static public class MinigameTBGItemExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*UniqueId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*ItemType*/, 4 /*Plana.FlatData.TBGItemType*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*TBGItemEffectType_*/, 4 /*Plana.FlatData.TBGItemEffectType*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*ItemParameter*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 12 /*LocalizeETCId*/, false)
      && verifier.VerifyString(tablePos, 14 /*Icon*/, false)
      && verifier.VerifyString(tablePos, 16 /*BuffIcon*/, false)
      && verifier.VerifyField(tablePos, 18 /*EncounterCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 20 /*DiceEffectAniClip*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
