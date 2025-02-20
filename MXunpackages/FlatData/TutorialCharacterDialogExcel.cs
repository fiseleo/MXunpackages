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

public struct TutorialCharacterDialogExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static TutorialCharacterDialogExcel GetRootAsTutorialCharacterDialogExcel(ByteBuffer _bb) { return GetRootAsTutorialCharacterDialogExcel(_bb, new TutorialCharacterDialogExcel()); }
  public static TutorialCharacterDialogExcel GetRootAsTutorialCharacterDialogExcel(ByteBuffer _bb, TutorialCharacterDialogExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TutorialCharacterDialogExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long TalkId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string AnimationName { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAnimationNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetAnimationNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetAnimationNameArray() { return __p.__vector_as_array<byte>(6); }
  public string LocalizeKR { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeKRBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetLocalizeKRBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetLocalizeKRArray() { return __p.__vector_as_array<byte>(8); }
  public string LocalizeJP { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeJPBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetLocalizeJPBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetLocalizeJPArray() { return __p.__vector_as_array<byte>(10); }
  public string LocalizeTH { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeTHBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetLocalizeTHBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetLocalizeTHArray() { return __p.__vector_as_array<byte>(12); }
  public string LocalizeTW { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeTWBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetLocalizeTWBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetLocalizeTWArray() { return __p.__vector_as_array<byte>(14); }
  public string LocalizeEN { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeENBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetLocalizeENBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetLocalizeENArray() { return __p.__vector_as_array<byte>(16); }
  public uint VoiceId { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }

  public static Offset<Plana.FlatData.TutorialCharacterDialogExcel> CreateTutorialCharacterDialogExcel(FlatBufferBuilder builder,
      long TalkId = 0,
      StringOffset AnimationNameOffset = default(StringOffset),
      StringOffset LocalizeKROffset = default(StringOffset),
      StringOffset LocalizeJPOffset = default(StringOffset),
      StringOffset LocalizeTHOffset = default(StringOffset),
      StringOffset LocalizeTWOffset = default(StringOffset),
      StringOffset LocalizeENOffset = default(StringOffset),
      uint VoiceId = 0) {
    builder.StartTable(8);
    TutorialCharacterDialogExcel.AddTalkId(builder, TalkId);
    TutorialCharacterDialogExcel.AddVoiceId(builder, VoiceId);
    TutorialCharacterDialogExcel.AddLocalizeEN(builder, LocalizeENOffset);
    TutorialCharacterDialogExcel.AddLocalizeTW(builder, LocalizeTWOffset);
    TutorialCharacterDialogExcel.AddLocalizeTH(builder, LocalizeTHOffset);
    TutorialCharacterDialogExcel.AddLocalizeJP(builder, LocalizeJPOffset);
    TutorialCharacterDialogExcel.AddLocalizeKR(builder, LocalizeKROffset);
    TutorialCharacterDialogExcel.AddAnimationName(builder, AnimationNameOffset);
    return TutorialCharacterDialogExcel.EndTutorialCharacterDialogExcel(builder);
  }

  public static void StartTutorialCharacterDialogExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddTalkId(FlatBufferBuilder builder, long talkId) { builder.AddLong(0, talkId, 0); }
  public static void AddAnimationName(FlatBufferBuilder builder, StringOffset animationNameOffset) { builder.AddOffset(1, animationNameOffset.Value, 0); }
  public static void AddLocalizeKR(FlatBufferBuilder builder, StringOffset localizeKROffset) { builder.AddOffset(2, localizeKROffset.Value, 0); }
  public static void AddLocalizeJP(FlatBufferBuilder builder, StringOffset localizeJPOffset) { builder.AddOffset(3, localizeJPOffset.Value, 0); }
  public static void AddLocalizeTH(FlatBufferBuilder builder, StringOffset localizeTHOffset) { builder.AddOffset(4, localizeTHOffset.Value, 0); }
  public static void AddLocalizeTW(FlatBufferBuilder builder, StringOffset localizeTWOffset) { builder.AddOffset(5, localizeTWOffset.Value, 0); }
  public static void AddLocalizeEN(FlatBufferBuilder builder, StringOffset localizeENOffset) { builder.AddOffset(6, localizeENOffset.Value, 0); }
  public static void AddVoiceId(FlatBufferBuilder builder, uint voiceId) { builder.AddUint(7, voiceId, 0); }
  public static Offset<Plana.FlatData.TutorialCharacterDialogExcel> EndTutorialCharacterDialogExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.TutorialCharacterDialogExcel>(o);
  }
  public TutorialCharacterDialogExcelT UnPack() {
    var _o = new TutorialCharacterDialogExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(TutorialCharacterDialogExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("TutorialCharacterDialog");
    _o.TalkId = TableEncryptionService.Convert(this.TalkId, key);
    _o.AnimationName = TableEncryptionService.Convert(this.AnimationName, key);
    _o.LocalizeKR = TableEncryptionService.Convert(this.LocalizeKR, key);
    _o.LocalizeJP = TableEncryptionService.Convert(this.LocalizeJP, key);
    _o.LocalizeTH = TableEncryptionService.Convert(this.LocalizeTH, key);
    _o.LocalizeTW = TableEncryptionService.Convert(this.LocalizeTW, key);
    _o.LocalizeEN = TableEncryptionService.Convert(this.LocalizeEN, key);
    _o.VoiceId = TableEncryptionService.Convert(this.VoiceId, key);
  }
  public static Offset<Plana.FlatData.TutorialCharacterDialogExcel> Pack(FlatBufferBuilder builder, TutorialCharacterDialogExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.TutorialCharacterDialogExcel>);
    var _AnimationName = _o.AnimationName == null ? default(StringOffset) : builder.CreateString(_o.AnimationName);
    var _LocalizeKR = _o.LocalizeKR == null ? default(StringOffset) : builder.CreateString(_o.LocalizeKR);
    var _LocalizeJP = _o.LocalizeJP == null ? default(StringOffset) : builder.CreateString(_o.LocalizeJP);
    var _LocalizeTH = _o.LocalizeTH == null ? default(StringOffset) : builder.CreateString(_o.LocalizeTH);
    var _LocalizeTW = _o.LocalizeTW == null ? default(StringOffset) : builder.CreateString(_o.LocalizeTW);
    var _LocalizeEN = _o.LocalizeEN == null ? default(StringOffset) : builder.CreateString(_o.LocalizeEN);
    return CreateTutorialCharacterDialogExcel(
      builder,
      _o.TalkId,
      _AnimationName,
      _LocalizeKR,
      _LocalizeJP,
      _LocalizeTH,
      _LocalizeTW,
      _LocalizeEN,
      _o.VoiceId);
  }
}

public class TutorialCharacterDialogExcelT
{
  public long TalkId { get; set; }
  public string AnimationName { get; set; }
  public string LocalizeKR { get; set; }
  public string LocalizeJP { get; set; }
  public string LocalizeTH { get; set; }
  public string LocalizeTW { get; set; }
  public string LocalizeEN { get; set; }
  public uint VoiceId { get; set; }

  public TutorialCharacterDialogExcelT() {
    this.TalkId = 0;
    this.AnimationName = null;
    this.LocalizeKR = null;
    this.LocalizeJP = null;
    this.LocalizeTH = null;
    this.LocalizeTW = null;
    this.LocalizeEN = null;
    this.VoiceId = 0;
  }
}


static public class TutorialCharacterDialogExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*TalkId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 6 /*AnimationName*/, false)
      && verifier.VerifyString(tablePos, 8 /*LocalizeKR*/, false)
      && verifier.VerifyString(tablePos, 10 /*LocalizeJP*/, false)
      && verifier.VerifyString(tablePos, 12 /*LocalizeTH*/, false)
      && verifier.VerifyString(tablePos, 14 /*LocalizeTW*/, false)
      && verifier.VerifyString(tablePos, 16 /*LocalizeEN*/, false)
      && verifier.VerifyField(tablePos, 18 /*VoiceId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
