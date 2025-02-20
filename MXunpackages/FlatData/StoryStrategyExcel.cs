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

public struct StoryStrategyExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static StoryStrategyExcel GetRootAsStoryStrategyExcel(ByteBuffer _bb) { return GetRootAsStoryStrategyExcel(_bb, new StoryStrategyExcel()); }
  public static StoryStrategyExcel GetRootAsStoryStrategyExcel(ByteBuffer _bb, StoryStrategyExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public StoryStrategyExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }
  public string Localize { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetLocalizeBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetLocalizeArray() { return __p.__vector_as_array<byte>(8); }
  public int StageEnterEchelonCount { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long BattleDuration { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long WhiteListId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string StrategyMap { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStrategyMapBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetStrategyMapBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetStrategyMapArray() { return __p.__vector_as_array<byte>(16); }
  public string StrategyMapBG { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStrategyMapBGBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetStrategyMapBGBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetStrategyMapBGArray() { return __p.__vector_as_array<byte>(18); }
  public int MaxTurn { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public Plana.FlatData.StageTopography StageTopography_ { get { int o = __p.__offset(22); return o != 0 ? (Plana.FlatData.StageTopography)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.StageTopography.Street; } }
  public Plana.FlatData.StrategyEnvironment StrategyEnvironment_ { get { int o = __p.__offset(24); return o != 0 ? (Plana.FlatData.StrategyEnvironment)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.StrategyEnvironment.None; } }
  public Plana.FlatData.ContentType ContentType_ { get { int o = __p.__offset(26); return o != 0 ? (Plana.FlatData.ContentType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ContentType.None; } }
  public long BGMId { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string FirstClearReportEventName { get { int o = __p.__offset(30); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetFirstClearReportEventNameBytes() { return __p.__vector_as_span<byte>(30, 1); }
#else
  public ArraySegment<byte>? GetFirstClearReportEventNameBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public byte[] GetFirstClearReportEventNameArray() { return __p.__vector_as_array<byte>(30); }

  public static Offset<Plana.FlatData.StoryStrategyExcel> CreateStoryStrategyExcel(FlatBufferBuilder builder,
      long Id = 0,
      StringOffset NameOffset = default(StringOffset),
      StringOffset LocalizeOffset = default(StringOffset),
      int StageEnterEchelonCount = 0,
      long BattleDuration = 0,
      long WhiteListId = 0,
      StringOffset StrategyMapOffset = default(StringOffset),
      StringOffset StrategyMapBGOffset = default(StringOffset),
      int MaxTurn = 0,
      Plana.FlatData.StageTopography StageTopography_ = Plana.FlatData.StageTopography.Street,
      Plana.FlatData.StrategyEnvironment StrategyEnvironment_ = Plana.FlatData.StrategyEnvironment.None,
      Plana.FlatData.ContentType ContentType_ = Plana.FlatData.ContentType.None,
      long BGMId = 0,
      StringOffset FirstClearReportEventNameOffset = default(StringOffset)) {
    builder.StartTable(14);
    StoryStrategyExcel.AddBGMId(builder, BGMId);
    StoryStrategyExcel.AddWhiteListId(builder, WhiteListId);
    StoryStrategyExcel.AddBattleDuration(builder, BattleDuration);
    StoryStrategyExcel.AddId(builder, Id);
    StoryStrategyExcel.AddFirstClearReportEventName(builder, FirstClearReportEventNameOffset);
    StoryStrategyExcel.AddContentType_(builder, ContentType_);
    StoryStrategyExcel.AddStrategyEnvironment_(builder, StrategyEnvironment_);
    StoryStrategyExcel.AddStageTopography_(builder, StageTopography_);
    StoryStrategyExcel.AddMaxTurn(builder, MaxTurn);
    StoryStrategyExcel.AddStrategyMapBG(builder, StrategyMapBGOffset);
    StoryStrategyExcel.AddStrategyMap(builder, StrategyMapOffset);
    StoryStrategyExcel.AddStageEnterEchelonCount(builder, StageEnterEchelonCount);
    StoryStrategyExcel.AddLocalize(builder, LocalizeOffset);
    StoryStrategyExcel.AddName(builder, NameOffset);
    return StoryStrategyExcel.EndStoryStrategyExcel(builder);
  }

  public static void StartStoryStrategyExcel(FlatBufferBuilder builder) { builder.StartTable(14); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static void AddLocalize(FlatBufferBuilder builder, StringOffset localizeOffset) { builder.AddOffset(2, localizeOffset.Value, 0); }
  public static void AddStageEnterEchelonCount(FlatBufferBuilder builder, int stageEnterEchelonCount) { builder.AddInt(3, stageEnterEchelonCount, 0); }
  public static void AddBattleDuration(FlatBufferBuilder builder, long battleDuration) { builder.AddLong(4, battleDuration, 0); }
  public static void AddWhiteListId(FlatBufferBuilder builder, long whiteListId) { builder.AddLong(5, whiteListId, 0); }
  public static void AddStrategyMap(FlatBufferBuilder builder, StringOffset strategyMapOffset) { builder.AddOffset(6, strategyMapOffset.Value, 0); }
  public static void AddStrategyMapBG(FlatBufferBuilder builder, StringOffset strategyMapBGOffset) { builder.AddOffset(7, strategyMapBGOffset.Value, 0); }
  public static void AddMaxTurn(FlatBufferBuilder builder, int maxTurn) { builder.AddInt(8, maxTurn, 0); }
  public static void AddStageTopography_(FlatBufferBuilder builder, Plana.FlatData.StageTopography stageTopography_) { builder.AddInt(9, (int)stageTopography_, 0); }
  public static void AddStrategyEnvironment_(FlatBufferBuilder builder, Plana.FlatData.StrategyEnvironment strategyEnvironment_) { builder.AddInt(10, (int)strategyEnvironment_, 0); }
  public static void AddContentType_(FlatBufferBuilder builder, Plana.FlatData.ContentType contentType_) { builder.AddInt(11, (int)contentType_, 0); }
  public static void AddBGMId(FlatBufferBuilder builder, long bGMId) { builder.AddLong(12, bGMId, 0); }
  public static void AddFirstClearReportEventName(FlatBufferBuilder builder, StringOffset firstClearReportEventNameOffset) { builder.AddOffset(13, firstClearReportEventNameOffset.Value, 0); }
  public static Offset<Plana.FlatData.StoryStrategyExcel> EndStoryStrategyExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.StoryStrategyExcel>(o);
  }
  public StoryStrategyExcelT UnPack() {
    var _o = new StoryStrategyExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(StoryStrategyExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("StoryStrategy");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.Name = TableEncryptionService.Convert(this.Name, key);
    _o.Localize = TableEncryptionService.Convert(this.Localize, key);
    _o.StageEnterEchelonCount = TableEncryptionService.Convert(this.StageEnterEchelonCount, key);
    _o.BattleDuration = TableEncryptionService.Convert(this.BattleDuration, key);
    _o.WhiteListId = TableEncryptionService.Convert(this.WhiteListId, key);
    _o.StrategyMap = TableEncryptionService.Convert(this.StrategyMap, key);
    _o.StrategyMapBG = TableEncryptionService.Convert(this.StrategyMapBG, key);
    _o.MaxTurn = TableEncryptionService.Convert(this.MaxTurn, key);
    _o.StageTopography_ = TableEncryptionService.Convert(this.StageTopography_, key);
    _o.StrategyEnvironment_ = TableEncryptionService.Convert(this.StrategyEnvironment_, key);
    _o.ContentType_ = TableEncryptionService.Convert(this.ContentType_, key);
    _o.BGMId = TableEncryptionService.Convert(this.BGMId, key);
    _o.FirstClearReportEventName = TableEncryptionService.Convert(this.FirstClearReportEventName, key);
  }
  public static Offset<Plana.FlatData.StoryStrategyExcel> Pack(FlatBufferBuilder builder, StoryStrategyExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.StoryStrategyExcel>);
    var _Name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _Localize = _o.Localize == null ? default(StringOffset) : builder.CreateString(_o.Localize);
    var _StrategyMap = _o.StrategyMap == null ? default(StringOffset) : builder.CreateString(_o.StrategyMap);
    var _StrategyMapBG = _o.StrategyMapBG == null ? default(StringOffset) : builder.CreateString(_o.StrategyMapBG);
    var _FirstClearReportEventName = _o.FirstClearReportEventName == null ? default(StringOffset) : builder.CreateString(_o.FirstClearReportEventName);
    return CreateStoryStrategyExcel(
      builder,
      _o.Id,
      _Name,
      _Localize,
      _o.StageEnterEchelonCount,
      _o.BattleDuration,
      _o.WhiteListId,
      _StrategyMap,
      _StrategyMapBG,
      _o.MaxTurn,
      _o.StageTopography_,
      _o.StrategyEnvironment_,
      _o.ContentType_,
      _o.BGMId,
      _FirstClearReportEventName);
  }
}

public class StoryStrategyExcelT
{
  public long Id { get; set; }
  public string Name { get; set; }
  public string Localize { get; set; }
  public int StageEnterEchelonCount { get; set; }
  public long BattleDuration { get; set; }
  public long WhiteListId { get; set; }
  public string StrategyMap { get; set; }
  public string StrategyMapBG { get; set; }
  public int MaxTurn { get; set; }
  public Plana.FlatData.StageTopography StageTopography_ { get; set; }
  public Plana.FlatData.StrategyEnvironment StrategyEnvironment_ { get; set; }
  public Plana.FlatData.ContentType ContentType_ { get; set; }
  public long BGMId { get; set; }
  public string FirstClearReportEventName { get; set; }

  public StoryStrategyExcelT() {
    this.Id = 0;
    this.Name = null;
    this.Localize = null;
    this.StageEnterEchelonCount = 0;
    this.BattleDuration = 0;
    this.WhiteListId = 0;
    this.StrategyMap = null;
    this.StrategyMapBG = null;
    this.MaxTurn = 0;
    this.StageTopography_ = Plana.FlatData.StageTopography.Street;
    this.StrategyEnvironment_ = Plana.FlatData.StrategyEnvironment.None;
    this.ContentType_ = Plana.FlatData.ContentType.None;
    this.BGMId = 0;
    this.FirstClearReportEventName = null;
  }
}


static public class StoryStrategyExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 6 /*Name*/, false)
      && verifier.VerifyString(tablePos, 8 /*Localize*/, false)
      && verifier.VerifyField(tablePos, 10 /*StageEnterEchelonCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*BattleDuration*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*WhiteListId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 16 /*StrategyMap*/, false)
      && verifier.VerifyString(tablePos, 18 /*StrategyMapBG*/, false)
      && verifier.VerifyField(tablePos, 20 /*MaxTurn*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*StageTopography_*/, 4 /*Plana.FlatData.StageTopography*/, 4, false)
      && verifier.VerifyField(tablePos, 24 /*StrategyEnvironment_*/, 4 /*Plana.FlatData.StrategyEnvironment*/, 4, false)
      && verifier.VerifyField(tablePos, 26 /*ContentType_*/, 4 /*Plana.FlatData.ContentType*/, 4, false)
      && verifier.VerifyField(tablePos, 28 /*BGMId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 30 /*FirstClearReportEventName*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
