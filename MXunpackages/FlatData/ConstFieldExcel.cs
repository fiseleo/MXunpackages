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

public struct ConstFieldExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ConstFieldExcel GetRootAsConstFieldExcel(ByteBuffer _bb) { return GetRootAsConstFieldExcel(_bb, new ConstFieldExcel()); }
  public static ConstFieldExcel GetRootAsConstFieldExcel(ByteBuffer _bb, ConstFieldExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConstFieldExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int DialogSmoothTime { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int TalkDialogDurationDefault { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ThinkDialogDurationDefault { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int IdleThinkDelayMin { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int IdleThinkDelayMax { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ExclaimDurationDefault { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int QuestionDurationDefault { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int UpsetDurationDefault { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int SurpriseDurationDefault { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int BulbDurationDefault { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int HeartDurationDefault { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int SweatDurationDefault { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int AngryDurationDefault { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int MusicDurationDefault { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int DotDurationDefault { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int MomotalkDurationDefault { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int PhoneDurationDefault { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int KeywordDurationDefault { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int EvidenceDurationDefault { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<Plana.FlatData.ConstFieldExcel> CreateConstFieldExcel(FlatBufferBuilder builder,
      int DialogSmoothTime = 0,
      int TalkDialogDurationDefault = 0,
      int ThinkDialogDurationDefault = 0,
      int IdleThinkDelayMin = 0,
      int IdleThinkDelayMax = 0,
      int ExclaimDurationDefault = 0,
      int QuestionDurationDefault = 0,
      int UpsetDurationDefault = 0,
      int SurpriseDurationDefault = 0,
      int BulbDurationDefault = 0,
      int HeartDurationDefault = 0,
      int SweatDurationDefault = 0,
      int AngryDurationDefault = 0,
      int MusicDurationDefault = 0,
      int DotDurationDefault = 0,
      int MomotalkDurationDefault = 0,
      int PhoneDurationDefault = 0,
      int KeywordDurationDefault = 0,
      int EvidenceDurationDefault = 0) {
    builder.StartTable(19);
    ConstFieldExcel.AddEvidenceDurationDefault(builder, EvidenceDurationDefault);
    ConstFieldExcel.AddKeywordDurationDefault(builder, KeywordDurationDefault);
    ConstFieldExcel.AddPhoneDurationDefault(builder, PhoneDurationDefault);
    ConstFieldExcel.AddMomotalkDurationDefault(builder, MomotalkDurationDefault);
    ConstFieldExcel.AddDotDurationDefault(builder, DotDurationDefault);
    ConstFieldExcel.AddMusicDurationDefault(builder, MusicDurationDefault);
    ConstFieldExcel.AddAngryDurationDefault(builder, AngryDurationDefault);
    ConstFieldExcel.AddSweatDurationDefault(builder, SweatDurationDefault);
    ConstFieldExcel.AddHeartDurationDefault(builder, HeartDurationDefault);
    ConstFieldExcel.AddBulbDurationDefault(builder, BulbDurationDefault);
    ConstFieldExcel.AddSurpriseDurationDefault(builder, SurpriseDurationDefault);
    ConstFieldExcel.AddUpsetDurationDefault(builder, UpsetDurationDefault);
    ConstFieldExcel.AddQuestionDurationDefault(builder, QuestionDurationDefault);
    ConstFieldExcel.AddExclaimDurationDefault(builder, ExclaimDurationDefault);
    ConstFieldExcel.AddIdleThinkDelayMax(builder, IdleThinkDelayMax);
    ConstFieldExcel.AddIdleThinkDelayMin(builder, IdleThinkDelayMin);
    ConstFieldExcel.AddThinkDialogDurationDefault(builder, ThinkDialogDurationDefault);
    ConstFieldExcel.AddTalkDialogDurationDefault(builder, TalkDialogDurationDefault);
    ConstFieldExcel.AddDialogSmoothTime(builder, DialogSmoothTime);
    return ConstFieldExcel.EndConstFieldExcel(builder);
  }

  public static void StartConstFieldExcel(FlatBufferBuilder builder) { builder.StartTable(19); }
  public static void AddDialogSmoothTime(FlatBufferBuilder builder, int dialogSmoothTime) { builder.AddInt(0, dialogSmoothTime, 0); }
  public static void AddTalkDialogDurationDefault(FlatBufferBuilder builder, int talkDialogDurationDefault) { builder.AddInt(1, talkDialogDurationDefault, 0); }
  public static void AddThinkDialogDurationDefault(FlatBufferBuilder builder, int thinkDialogDurationDefault) { builder.AddInt(2, thinkDialogDurationDefault, 0); }
  public static void AddIdleThinkDelayMin(FlatBufferBuilder builder, int idleThinkDelayMin) { builder.AddInt(3, idleThinkDelayMin, 0); }
  public static void AddIdleThinkDelayMax(FlatBufferBuilder builder, int idleThinkDelayMax) { builder.AddInt(4, idleThinkDelayMax, 0); }
  public static void AddExclaimDurationDefault(FlatBufferBuilder builder, int exclaimDurationDefault) { builder.AddInt(5, exclaimDurationDefault, 0); }
  public static void AddQuestionDurationDefault(FlatBufferBuilder builder, int questionDurationDefault) { builder.AddInt(6, questionDurationDefault, 0); }
  public static void AddUpsetDurationDefault(FlatBufferBuilder builder, int upsetDurationDefault) { builder.AddInt(7, upsetDurationDefault, 0); }
  public static void AddSurpriseDurationDefault(FlatBufferBuilder builder, int surpriseDurationDefault) { builder.AddInt(8, surpriseDurationDefault, 0); }
  public static void AddBulbDurationDefault(FlatBufferBuilder builder, int bulbDurationDefault) { builder.AddInt(9, bulbDurationDefault, 0); }
  public static void AddHeartDurationDefault(FlatBufferBuilder builder, int heartDurationDefault) { builder.AddInt(10, heartDurationDefault, 0); }
  public static void AddSweatDurationDefault(FlatBufferBuilder builder, int sweatDurationDefault) { builder.AddInt(11, sweatDurationDefault, 0); }
  public static void AddAngryDurationDefault(FlatBufferBuilder builder, int angryDurationDefault) { builder.AddInt(12, angryDurationDefault, 0); }
  public static void AddMusicDurationDefault(FlatBufferBuilder builder, int musicDurationDefault) { builder.AddInt(13, musicDurationDefault, 0); }
  public static void AddDotDurationDefault(FlatBufferBuilder builder, int dotDurationDefault) { builder.AddInt(14, dotDurationDefault, 0); }
  public static void AddMomotalkDurationDefault(FlatBufferBuilder builder, int momotalkDurationDefault) { builder.AddInt(15, momotalkDurationDefault, 0); }
  public static void AddPhoneDurationDefault(FlatBufferBuilder builder, int phoneDurationDefault) { builder.AddInt(16, phoneDurationDefault, 0); }
  public static void AddKeywordDurationDefault(FlatBufferBuilder builder, int keywordDurationDefault) { builder.AddInt(17, keywordDurationDefault, 0); }
  public static void AddEvidenceDurationDefault(FlatBufferBuilder builder, int evidenceDurationDefault) { builder.AddInt(18, evidenceDurationDefault, 0); }
  public static Offset<Plana.FlatData.ConstFieldExcel> EndConstFieldExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.ConstFieldExcel>(o);
  }
  public ConstFieldExcelT UnPack() {
    var _o = new ConstFieldExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ConstFieldExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("ConstField");
    _o.DialogSmoothTime = TableEncryptionService.Convert(this.DialogSmoothTime, key);
    _o.TalkDialogDurationDefault = TableEncryptionService.Convert(this.TalkDialogDurationDefault, key);
    _o.ThinkDialogDurationDefault = TableEncryptionService.Convert(this.ThinkDialogDurationDefault, key);
    _o.IdleThinkDelayMin = TableEncryptionService.Convert(this.IdleThinkDelayMin, key);
    _o.IdleThinkDelayMax = TableEncryptionService.Convert(this.IdleThinkDelayMax, key);
    _o.ExclaimDurationDefault = TableEncryptionService.Convert(this.ExclaimDurationDefault, key);
    _o.QuestionDurationDefault = TableEncryptionService.Convert(this.QuestionDurationDefault, key);
    _o.UpsetDurationDefault = TableEncryptionService.Convert(this.UpsetDurationDefault, key);
    _o.SurpriseDurationDefault = TableEncryptionService.Convert(this.SurpriseDurationDefault, key);
    _o.BulbDurationDefault = TableEncryptionService.Convert(this.BulbDurationDefault, key);
    _o.HeartDurationDefault = TableEncryptionService.Convert(this.HeartDurationDefault, key);
    _o.SweatDurationDefault = TableEncryptionService.Convert(this.SweatDurationDefault, key);
    _o.AngryDurationDefault = TableEncryptionService.Convert(this.AngryDurationDefault, key);
    _o.MusicDurationDefault = TableEncryptionService.Convert(this.MusicDurationDefault, key);
    _o.DotDurationDefault = TableEncryptionService.Convert(this.DotDurationDefault, key);
    _o.MomotalkDurationDefault = TableEncryptionService.Convert(this.MomotalkDurationDefault, key);
    _o.PhoneDurationDefault = TableEncryptionService.Convert(this.PhoneDurationDefault, key);
    _o.KeywordDurationDefault = TableEncryptionService.Convert(this.KeywordDurationDefault, key);
    _o.EvidenceDurationDefault = TableEncryptionService.Convert(this.EvidenceDurationDefault, key);
  }
  public static Offset<Plana.FlatData.ConstFieldExcel> Pack(FlatBufferBuilder builder, ConstFieldExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.ConstFieldExcel>);
    return CreateConstFieldExcel(
      builder,
      _o.DialogSmoothTime,
      _o.TalkDialogDurationDefault,
      _o.ThinkDialogDurationDefault,
      _o.IdleThinkDelayMin,
      _o.IdleThinkDelayMax,
      _o.ExclaimDurationDefault,
      _o.QuestionDurationDefault,
      _o.UpsetDurationDefault,
      _o.SurpriseDurationDefault,
      _o.BulbDurationDefault,
      _o.HeartDurationDefault,
      _o.SweatDurationDefault,
      _o.AngryDurationDefault,
      _o.MusicDurationDefault,
      _o.DotDurationDefault,
      _o.MomotalkDurationDefault,
      _o.PhoneDurationDefault,
      _o.KeywordDurationDefault,
      _o.EvidenceDurationDefault);
  }
}

public class ConstFieldExcelT
{
  public int DialogSmoothTime { get; set; }
  public int TalkDialogDurationDefault { get; set; }
  public int ThinkDialogDurationDefault { get; set; }
  public int IdleThinkDelayMin { get; set; }
  public int IdleThinkDelayMax { get; set; }
  public int ExclaimDurationDefault { get; set; }
  public int QuestionDurationDefault { get; set; }
  public int UpsetDurationDefault { get; set; }
  public int SurpriseDurationDefault { get; set; }
  public int BulbDurationDefault { get; set; }
  public int HeartDurationDefault { get; set; }
  public int SweatDurationDefault { get; set; }
  public int AngryDurationDefault { get; set; }
  public int MusicDurationDefault { get; set; }
  public int DotDurationDefault { get; set; }
  public int MomotalkDurationDefault { get; set; }
  public int PhoneDurationDefault { get; set; }
  public int KeywordDurationDefault { get; set; }
  public int EvidenceDurationDefault { get; set; }

  public ConstFieldExcelT() {
    this.DialogSmoothTime = 0;
    this.TalkDialogDurationDefault = 0;
    this.ThinkDialogDurationDefault = 0;
    this.IdleThinkDelayMin = 0;
    this.IdleThinkDelayMax = 0;
    this.ExclaimDurationDefault = 0;
    this.QuestionDurationDefault = 0;
    this.UpsetDurationDefault = 0;
    this.SurpriseDurationDefault = 0;
    this.BulbDurationDefault = 0;
    this.HeartDurationDefault = 0;
    this.SweatDurationDefault = 0;
    this.AngryDurationDefault = 0;
    this.MusicDurationDefault = 0;
    this.DotDurationDefault = 0;
    this.MomotalkDurationDefault = 0;
    this.PhoneDurationDefault = 0;
    this.KeywordDurationDefault = 0;
    this.EvidenceDurationDefault = 0;
  }
}


static public class ConstFieldExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*DialogSmoothTime*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*TalkDialogDurationDefault*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*ThinkDialogDurationDefault*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*IdleThinkDelayMin*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*IdleThinkDelayMax*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*ExclaimDurationDefault*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*QuestionDurationDefault*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*UpsetDurationDefault*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 20 /*SurpriseDurationDefault*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*BulbDurationDefault*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 24 /*HeartDurationDefault*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 26 /*SweatDurationDefault*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 28 /*AngryDurationDefault*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 30 /*MusicDurationDefault*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 32 /*DotDurationDefault*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 34 /*MomotalkDurationDefault*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 36 /*PhoneDurationDefault*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 38 /*KeywordDurationDefault*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 40 /*EvidenceDurationDefault*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
