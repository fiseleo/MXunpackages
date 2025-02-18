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

public struct AcademyMessanger3Excel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static AcademyMessanger3Excel GetRootAsAcademyMessanger3Excel(ByteBuffer _bb) { return GetRootAsAcademyMessanger3Excel(_bb, new AcademyMessanger3Excel()); }
  public static AcademyMessanger3Excel GetRootAsAcademyMessanger3Excel(ByteBuffer _bb, AcademyMessanger3Excel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AcademyMessanger3Excel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long MessageGroupId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Id { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CharacterId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.AcademyMessageConditions MessageCondition { get { int o = __p.__offset(10); return o != 0 ? (Plana.FlatData.AcademyMessageConditions)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.AcademyMessageConditions.None; } }
  public long ConditionValue { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PreConditionGroupId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PreConditionFavorScheduleId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long FavorScheduleId { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long NextGroupId { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long FeedbackTimeMillisec { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.AcademyMessageTypes MessageType { get { int o = __p.__offset(24); return o != 0 ? (Plana.FlatData.AcademyMessageTypes)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.AcademyMessageTypes.None; } }
  public string ImagePath { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetImagePathBytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetImagePathBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetImagePathArray() { return __p.__vector_as_array<byte>(26); }
  public string MessageKR { get { int o = __p.__offset(28); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMessageKRBytes() { return __p.__vector_as_span<byte>(28, 1); }
#else
  public ArraySegment<byte>? GetMessageKRBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public byte[] GetMessageKRArray() { return __p.__vector_as_array<byte>(28); }
  public string MessageJP { get { int o = __p.__offset(30); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMessageJPBytes() { return __p.__vector_as_span<byte>(30, 1); }
#else
  public ArraySegment<byte>? GetMessageJPBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public byte[] GetMessageJPArray() { return __p.__vector_as_array<byte>(30); }
  public string MessageTH { get { int o = __p.__offset(32); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMessageTHBytes() { return __p.__vector_as_span<byte>(32, 1); }
#else
  public ArraySegment<byte>? GetMessageTHBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public byte[] GetMessageTHArray() { return __p.__vector_as_array<byte>(32); }
  public string MessageTW { get { int o = __p.__offset(34); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMessageTWBytes() { return __p.__vector_as_span<byte>(34, 1); }
#else
  public ArraySegment<byte>? GetMessageTWBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public byte[] GetMessageTWArray() { return __p.__vector_as_array<byte>(34); }
  public string MessageEN { get { int o = __p.__offset(36); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMessageENBytes() { return __p.__vector_as_span<byte>(36, 1); }
#else
  public ArraySegment<byte>? GetMessageENBytes() { return __p.__vector_as_arraysegment(36); }
#endif
  public byte[] GetMessageENArray() { return __p.__vector_as_array<byte>(36); }

  public static Offset<Plana.FlatData.AcademyMessanger3Excel> CreateAcademyMessanger3Excel(FlatBufferBuilder builder,
      long MessageGroupId = 0,
      long Id = 0,
      long CharacterId = 0,
      Plana.FlatData.AcademyMessageConditions MessageCondition = Plana.FlatData.AcademyMessageConditions.None,
      long ConditionValue = 0,
      long PreConditionGroupId = 0,
      long PreConditionFavorScheduleId = 0,
      long FavorScheduleId = 0,
      long NextGroupId = 0,
      long FeedbackTimeMillisec = 0,
      Plana.FlatData.AcademyMessageTypes MessageType = Plana.FlatData.AcademyMessageTypes.None,
      StringOffset ImagePathOffset = default(StringOffset),
      StringOffset MessageKROffset = default(StringOffset),
      StringOffset MessageJPOffset = default(StringOffset),
      StringOffset MessageTHOffset = default(StringOffset),
      StringOffset MessageTWOffset = default(StringOffset),
      StringOffset MessageENOffset = default(StringOffset)) {
    builder.StartTable(17);
    AcademyMessanger3Excel.AddFeedbackTimeMillisec(builder, FeedbackTimeMillisec);
    AcademyMessanger3Excel.AddNextGroupId(builder, NextGroupId);
    AcademyMessanger3Excel.AddFavorScheduleId(builder, FavorScheduleId);
    AcademyMessanger3Excel.AddPreConditionFavorScheduleId(builder, PreConditionFavorScheduleId);
    AcademyMessanger3Excel.AddPreConditionGroupId(builder, PreConditionGroupId);
    AcademyMessanger3Excel.AddConditionValue(builder, ConditionValue);
    AcademyMessanger3Excel.AddCharacterId(builder, CharacterId);
    AcademyMessanger3Excel.AddId(builder, Id);
    AcademyMessanger3Excel.AddMessageGroupId(builder, MessageGroupId);
    AcademyMessanger3Excel.AddMessageEN(builder, MessageENOffset);
    AcademyMessanger3Excel.AddMessageTW(builder, MessageTWOffset);
    AcademyMessanger3Excel.AddMessageTH(builder, MessageTHOffset);
    AcademyMessanger3Excel.AddMessageJP(builder, MessageJPOffset);
    AcademyMessanger3Excel.AddMessageKR(builder, MessageKROffset);
    AcademyMessanger3Excel.AddImagePath(builder, ImagePathOffset);
    AcademyMessanger3Excel.AddMessageType(builder, MessageType);
    AcademyMessanger3Excel.AddMessageCondition(builder, MessageCondition);
    return AcademyMessanger3Excel.EndAcademyMessanger3Excel(builder);
  }

  public static void StartAcademyMessanger3Excel(FlatBufferBuilder builder) { builder.StartTable(17); }
  public static void AddMessageGroupId(FlatBufferBuilder builder, long messageGroupId) { builder.AddLong(0, messageGroupId, 0); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(1, id, 0); }
  public static void AddCharacterId(FlatBufferBuilder builder, long characterId) { builder.AddLong(2, characterId, 0); }
  public static void AddMessageCondition(FlatBufferBuilder builder, Plana.FlatData.AcademyMessageConditions messageCondition) { builder.AddInt(3, (int)messageCondition, 0); }
  public static void AddConditionValue(FlatBufferBuilder builder, long conditionValue) { builder.AddLong(4, conditionValue, 0); }
  public static void AddPreConditionGroupId(FlatBufferBuilder builder, long preConditionGroupId) { builder.AddLong(5, preConditionGroupId, 0); }
  public static void AddPreConditionFavorScheduleId(FlatBufferBuilder builder, long preConditionFavorScheduleId) { builder.AddLong(6, preConditionFavorScheduleId, 0); }
  public static void AddFavorScheduleId(FlatBufferBuilder builder, long favorScheduleId) { builder.AddLong(7, favorScheduleId, 0); }
  public static void AddNextGroupId(FlatBufferBuilder builder, long nextGroupId) { builder.AddLong(8, nextGroupId, 0); }
  public static void AddFeedbackTimeMillisec(FlatBufferBuilder builder, long feedbackTimeMillisec) { builder.AddLong(9, feedbackTimeMillisec, 0); }
  public static void AddMessageType(FlatBufferBuilder builder, Plana.FlatData.AcademyMessageTypes messageType) { builder.AddInt(10, (int)messageType, 0); }
  public static void AddImagePath(FlatBufferBuilder builder, StringOffset imagePathOffset) { builder.AddOffset(11, imagePathOffset.Value, 0); }
  public static void AddMessageKR(FlatBufferBuilder builder, StringOffset messageKROffset) { builder.AddOffset(12, messageKROffset.Value, 0); }
  public static void AddMessageJP(FlatBufferBuilder builder, StringOffset messageJPOffset) { builder.AddOffset(13, messageJPOffset.Value, 0); }
  public static void AddMessageTH(FlatBufferBuilder builder, StringOffset messageTHOffset) { builder.AddOffset(14, messageTHOffset.Value, 0); }
  public static void AddMessageTW(FlatBufferBuilder builder, StringOffset messageTWOffset) { builder.AddOffset(15, messageTWOffset.Value, 0); }
  public static void AddMessageEN(FlatBufferBuilder builder, StringOffset messageENOffset) { builder.AddOffset(16, messageENOffset.Value, 0); }
  public static Offset<Plana.FlatData.AcademyMessanger3Excel> EndAcademyMessanger3Excel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.AcademyMessanger3Excel>(o);
  }
  public AcademyMessanger3ExcelT UnPack() {
    var _o = new AcademyMessanger3ExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(AcademyMessanger3ExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("AcademyMessanger3");
    _o.MessageGroupId = TableEncryptionService.Convert(this.MessageGroupId, key);
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.CharacterId = TableEncryptionService.Convert(this.CharacterId, key);
    _o.MessageCondition = TableEncryptionService.Convert(this.MessageCondition, key);
    _o.ConditionValue = TableEncryptionService.Convert(this.ConditionValue, key);
    _o.PreConditionGroupId = TableEncryptionService.Convert(this.PreConditionGroupId, key);
    _o.PreConditionFavorScheduleId = TableEncryptionService.Convert(this.PreConditionFavorScheduleId, key);
    _o.FavorScheduleId = TableEncryptionService.Convert(this.FavorScheduleId, key);
    _o.NextGroupId = TableEncryptionService.Convert(this.NextGroupId, key);
    _o.FeedbackTimeMillisec = TableEncryptionService.Convert(this.FeedbackTimeMillisec, key);
    _o.MessageType = TableEncryptionService.Convert(this.MessageType, key);
    _o.ImagePath = TableEncryptionService.Convert(this.ImagePath, key);
    _o.MessageKR = TableEncryptionService.Convert(this.MessageKR, key);
    _o.MessageJP = TableEncryptionService.Convert(this.MessageJP, key);
    _o.MessageTH = TableEncryptionService.Convert(this.MessageTH, key);
    _o.MessageTW = TableEncryptionService.Convert(this.MessageTW, key);
    _o.MessageEN = TableEncryptionService.Convert(this.MessageEN, key);
  }
  public static Offset<Plana.FlatData.AcademyMessanger3Excel> Pack(FlatBufferBuilder builder, AcademyMessanger3ExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.AcademyMessanger3Excel>);
    var _ImagePath = _o.ImagePath == null ? default(StringOffset) : builder.CreateString(_o.ImagePath);
    var _MessageKR = _o.MessageKR == null ? default(StringOffset) : builder.CreateString(_o.MessageKR);
    var _MessageJP = _o.MessageJP == null ? default(StringOffset) : builder.CreateString(_o.MessageJP);
    var _MessageTH = _o.MessageTH == null ? default(StringOffset) : builder.CreateString(_o.MessageTH);
    var _MessageTW = _o.MessageTW == null ? default(StringOffset) : builder.CreateString(_o.MessageTW);
    var _MessageEN = _o.MessageEN == null ? default(StringOffset) : builder.CreateString(_o.MessageEN);
    return CreateAcademyMessanger3Excel(
      builder,
      _o.MessageGroupId,
      _o.Id,
      _o.CharacterId,
      _o.MessageCondition,
      _o.ConditionValue,
      _o.PreConditionGroupId,
      _o.PreConditionFavorScheduleId,
      _o.FavorScheduleId,
      _o.NextGroupId,
      _o.FeedbackTimeMillisec,
      _o.MessageType,
      _ImagePath,
      _MessageKR,
      _MessageJP,
      _MessageTH,
      _MessageTW,
      _MessageEN);
  }
}

public class AcademyMessanger3ExcelT
{
  public long MessageGroupId { get; set; }
  public long Id { get; set; }
  public long CharacterId { get; set; }
  public Plana.FlatData.AcademyMessageConditions MessageCondition { get; set; }
  public long ConditionValue { get; set; }
  public long PreConditionGroupId { get; set; }
  public long PreConditionFavorScheduleId { get; set; }
  public long FavorScheduleId { get; set; }
  public long NextGroupId { get; set; }
  public long FeedbackTimeMillisec { get; set; }
  public Plana.FlatData.AcademyMessageTypes MessageType { get; set; }
  public string ImagePath { get; set; }
  public string MessageKR { get; set; }
  public string MessageJP { get; set; }
  public string MessageTH { get; set; }
  public string MessageTW { get; set; }
  public string MessageEN { get; set; }

  public AcademyMessanger3ExcelT() {
    this.MessageGroupId = 0;
    this.Id = 0;
    this.CharacterId = 0;
    this.MessageCondition = Plana.FlatData.AcademyMessageConditions.None;
    this.ConditionValue = 0;
    this.PreConditionGroupId = 0;
    this.PreConditionFavorScheduleId = 0;
    this.FavorScheduleId = 0;
    this.NextGroupId = 0;
    this.FeedbackTimeMillisec = 0;
    this.MessageType = Plana.FlatData.AcademyMessageTypes.None;
    this.ImagePath = null;
    this.MessageKR = null;
    this.MessageJP = null;
    this.MessageTH = null;
    this.MessageTW = null;
    this.MessageEN = null;
  }
}


static public class AcademyMessanger3ExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*MessageGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*CharacterId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*MessageCondition*/, 4 /*Plana.FlatData.AcademyMessageConditions*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*ConditionValue*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*PreConditionGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*PreConditionFavorScheduleId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*FavorScheduleId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 20 /*NextGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 22 /*FeedbackTimeMillisec*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 24 /*MessageType*/, 4 /*Plana.FlatData.AcademyMessageTypes*/, 4, false)
      && verifier.VerifyString(tablePos, 26 /*ImagePath*/, false)
      && verifier.VerifyString(tablePos, 28 /*MessageKR*/, false)
      && verifier.VerifyString(tablePos, 30 /*MessageJP*/, false)
      && verifier.VerifyString(tablePos, 32 /*MessageTH*/, false)
      && verifier.VerifyString(tablePos, 34 /*MessageTW*/, false)
      && verifier.VerifyString(tablePos, 36 /*MessageEN*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
