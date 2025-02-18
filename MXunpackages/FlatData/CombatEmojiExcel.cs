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

public struct CombatEmojiExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static CombatEmojiExcel GetRootAsCombatEmojiExcel(ByteBuffer _bb) { return GetRootAsCombatEmojiExcel(_bb, new CombatEmojiExcel()); }
  public static CombatEmojiExcel GetRootAsCombatEmojiExcel(ByteBuffer _bb, CombatEmojiExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CombatEmojiExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long UniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.EmojiEvent EmojiEvent_ { get { int o = __p.__offset(6); return o != 0 ? (Plana.FlatData.EmojiEvent)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.EmojiEvent.EnterConver; } }
  public int OrderOfPriority { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool EmojiDuration { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool EmojiReversal { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool EmojiTurnOn { get { int o = __p.__offset(14); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int ShowEmojiDelay { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool ShowDefaultBG { get { int o = __p.__offset(18); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<Plana.FlatData.CombatEmojiExcel> CreateCombatEmojiExcel(FlatBufferBuilder builder,
      long UniqueId = 0,
      Plana.FlatData.EmojiEvent EmojiEvent_ = Plana.FlatData.EmojiEvent.EnterConver,
      int OrderOfPriority = 0,
      bool EmojiDuration = false,
      bool EmojiReversal = false,
      bool EmojiTurnOn = false,
      int ShowEmojiDelay = 0,
      bool ShowDefaultBG = false) {
    builder.StartTable(8);
    CombatEmojiExcel.AddUniqueId(builder, UniqueId);
    CombatEmojiExcel.AddShowEmojiDelay(builder, ShowEmojiDelay);
    CombatEmojiExcel.AddOrderOfPriority(builder, OrderOfPriority);
    CombatEmojiExcel.AddEmojiEvent_(builder, EmojiEvent_);
    CombatEmojiExcel.AddShowDefaultBG(builder, ShowDefaultBG);
    CombatEmojiExcel.AddEmojiTurnOn(builder, EmojiTurnOn);
    CombatEmojiExcel.AddEmojiReversal(builder, EmojiReversal);
    CombatEmojiExcel.AddEmojiDuration(builder, EmojiDuration);
    return CombatEmojiExcel.EndCombatEmojiExcel(builder);
  }

  public static void StartCombatEmojiExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddUniqueId(FlatBufferBuilder builder, long uniqueId) { builder.AddLong(0, uniqueId, 0); }
  public static void AddEmojiEvent_(FlatBufferBuilder builder, Plana.FlatData.EmojiEvent emojiEvent_) { builder.AddInt(1, (int)emojiEvent_, 0); }
  public static void AddOrderOfPriority(FlatBufferBuilder builder, int orderOfPriority) { builder.AddInt(2, orderOfPriority, 0); }
  public static void AddEmojiDuration(FlatBufferBuilder builder, bool emojiDuration) { builder.AddBool(3, emojiDuration, false); }
  public static void AddEmojiReversal(FlatBufferBuilder builder, bool emojiReversal) { builder.AddBool(4, emojiReversal, false); }
  public static void AddEmojiTurnOn(FlatBufferBuilder builder, bool emojiTurnOn) { builder.AddBool(5, emojiTurnOn, false); }
  public static void AddShowEmojiDelay(FlatBufferBuilder builder, int showEmojiDelay) { builder.AddInt(6, showEmojiDelay, 0); }
  public static void AddShowDefaultBG(FlatBufferBuilder builder, bool showDefaultBG) { builder.AddBool(7, showDefaultBG, false); }
  public static Offset<Plana.FlatData.CombatEmojiExcel> EndCombatEmojiExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.CombatEmojiExcel>(o);
  }
  public CombatEmojiExcelT UnPack() {
    var _o = new CombatEmojiExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CombatEmojiExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("CombatEmoji");
    _o.UniqueId = TableEncryptionService.Convert(this.UniqueId, key);
    _o.EmojiEvent_ = TableEncryptionService.Convert(this.EmojiEvent_, key);
    _o.OrderOfPriority = TableEncryptionService.Convert(this.OrderOfPriority, key);
    _o.EmojiDuration = TableEncryptionService.Convert(this.EmojiDuration, key);
    _o.EmojiReversal = TableEncryptionService.Convert(this.EmojiReversal, key);
    _o.EmojiTurnOn = TableEncryptionService.Convert(this.EmojiTurnOn, key);
    _o.ShowEmojiDelay = TableEncryptionService.Convert(this.ShowEmojiDelay, key);
    _o.ShowDefaultBG = TableEncryptionService.Convert(this.ShowDefaultBG, key);
  }
  public static Offset<Plana.FlatData.CombatEmojiExcel> Pack(FlatBufferBuilder builder, CombatEmojiExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.CombatEmojiExcel>);
    return CreateCombatEmojiExcel(
      builder,
      _o.UniqueId,
      _o.EmojiEvent_,
      _o.OrderOfPriority,
      _o.EmojiDuration,
      _o.EmojiReversal,
      _o.EmojiTurnOn,
      _o.ShowEmojiDelay,
      _o.ShowDefaultBG);
  }
}

public class CombatEmojiExcelT
{
  public long UniqueId { get; set; }
  public Plana.FlatData.EmojiEvent EmojiEvent_ { get; set; }
  public int OrderOfPriority { get; set; }
  public bool EmojiDuration { get; set; }
  public bool EmojiReversal { get; set; }
  public bool EmojiTurnOn { get; set; }
  public int ShowEmojiDelay { get; set; }
  public bool ShowDefaultBG { get; set; }

  public CombatEmojiExcelT() {
    this.UniqueId = 0;
    this.EmojiEvent_ = Plana.FlatData.EmojiEvent.EnterConver;
    this.OrderOfPriority = 0;
    this.EmojiDuration = false;
    this.EmojiReversal = false;
    this.EmojiTurnOn = false;
    this.ShowEmojiDelay = 0;
    this.ShowDefaultBG = false;
  }
}


static public class CombatEmojiExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*UniqueId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*EmojiEvent_*/, 4 /*Plana.FlatData.EmojiEvent*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*OrderOfPriority*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*EmojiDuration*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 12 /*EmojiReversal*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 14 /*EmojiTurnOn*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 16 /*ShowEmojiDelay*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*ShowDefaultBG*/, 1 /*bool*/, 1, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
