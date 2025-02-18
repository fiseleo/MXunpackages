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

public struct CampaignStageExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static CampaignStageExcel GetRootAsCampaignStageExcel(ByteBuffer _bb) { return GetRootAsCampaignStageExcel(_bb, new CampaignStageExcel()); }
  public static CampaignStageExcel GetRootAsCampaignStageExcel(ByteBuffer _bb, CampaignStageExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CampaignStageExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool Deprecated { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string Name { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(8); }
  public string StageNumber { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStageNumberBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetStageNumberBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetStageNumberArray() { return __p.__vector_as_array<byte>(10); }
  public long CleardScenarioId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BattleDuration { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.ParcelType StageEnterCostType { get { int o = __p.__offset(16); return o != 0 ? (Plana.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ParcelType.None; } }
  public long StageEnterCostId { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int StageEnterCostAmount { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int StageEnterEchelonCount { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long StarConditionTacticRankSCount { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StarConditionTurnCount { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnterScenarioGroupId(int j) { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int EnterScenarioGroupIdLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetEnterScenarioGroupIdBytes() { return __p.__vector_as_span<long>(28, 8); }
#else
  public ArraySegment<byte>? GetEnterScenarioGroupIdBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public long[] GetEnterScenarioGroupIdArray() { return __p.__vector_as_array<long>(28); }
  public long ClearScenarioGroupId(int j) { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ClearScenarioGroupIdLength { get { int o = __p.__offset(30); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetClearScenarioGroupIdBytes() { return __p.__vector_as_span<long>(30, 8); }
#else
  public ArraySegment<byte>? GetClearScenarioGroupIdBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public long[] GetClearScenarioGroupIdArray() { return __p.__vector_as_array<long>(30); }
  public string StrategyMap { get { int o = __p.__offset(32); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStrategyMapBytes() { return __p.__vector_as_span<byte>(32, 1); }
#else
  public ArraySegment<byte>? GetStrategyMapBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public byte[] GetStrategyMapArray() { return __p.__vector_as_array<byte>(32); }
  public string StrategyMapBG { get { int o = __p.__offset(34); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStrategyMapBGBytes() { return __p.__vector_as_span<byte>(34, 1); }
#else
  public ArraySegment<byte>? GetStrategyMapBGBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public byte[] GetStrategyMapBGArray() { return __p.__vector_as_array<byte>(34); }
  public long CampaignStageRewardId { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int MaxTurn { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public Plana.FlatData.StageTopography StageTopography_ { get { int o = __p.__offset(40); return o != 0 ? (Plana.FlatData.StageTopography)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.StageTopography.Street; } }
  public int RecommandLevel { get { int o = __p.__offset(42); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string BgmId { get { int o = __p.__offset(44); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBgmIdBytes() { return __p.__vector_as_span<byte>(44, 1); }
#else
  public ArraySegment<byte>? GetBgmIdBytes() { return __p.__vector_as_arraysegment(44); }
#endif
  public byte[] GetBgmIdArray() { return __p.__vector_as_array<byte>(44); }
  public Plana.FlatData.StrategyEnvironment StrategyEnvironment_ { get { int o = __p.__offset(46); return o != 0 ? (Plana.FlatData.StrategyEnvironment)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.StrategyEnvironment.None; } }
  public long GroundId { get { int o = __p.__offset(48); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.ContentType ContentType_ { get { int o = __p.__offset(50); return o != 0 ? (Plana.FlatData.ContentType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ContentType.None; } }
  public long BGMId { get { int o = __p.__offset(52); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string FirstClearReportEventName { get { int o = __p.__offset(54); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetFirstClearReportEventNameBytes() { return __p.__vector_as_span<byte>(54, 1); }
#else
  public ArraySegment<byte>? GetFirstClearReportEventNameBytes() { return __p.__vector_as_arraysegment(54); }
#endif
  public byte[] GetFirstClearReportEventNameArray() { return __p.__vector_as_array<byte>(54); }
  public string FirstClearFunnelMessage { get { int o = __p.__offset(56); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetFirstClearFunnelMessageBytes() { return __p.__vector_as_span<byte>(56, 1); }
#else
  public ArraySegment<byte>? GetFirstClearFunnelMessageBytes() { return __p.__vector_as_arraysegment(56); }
#endif
  public byte[] GetFirstClearFunnelMessageArray() { return __p.__vector_as_array<byte>(56); }
  public string FirstClearEventMessage { get { int o = __p.__offset(58); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetFirstClearEventMessageBytes() { return __p.__vector_as_span<byte>(58, 1); }
#else
  public ArraySegment<byte>? GetFirstClearEventMessageBytes() { return __p.__vector_as_arraysegment(58); }
#endif
  public byte[] GetFirstClearEventMessageArray() { return __p.__vector_as_array<byte>(58); }
  public long TacticRewardExp { get { int o = __p.__offset(60); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long FixedEchelonId { get { int o = __p.__offset(62); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.EchelonExtensionType EchelonExtensionType_ { get { int o = __p.__offset(64); return o != 0 ? (Plana.FlatData.EchelonExtensionType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.EchelonExtensionType.Base; } }

  public static Offset<Plana.FlatData.CampaignStageExcel> CreateCampaignStageExcel(FlatBufferBuilder builder,
      long Id = 0,
      bool Deprecated = false,
      StringOffset NameOffset = default(StringOffset),
      StringOffset StageNumberOffset = default(StringOffset),
      long CleardScenarioId = 0,
      long BattleDuration = 0,
      Plana.FlatData.ParcelType StageEnterCostType = Plana.FlatData.ParcelType.None,
      long StageEnterCostId = 0,
      int StageEnterCostAmount = 0,
      int StageEnterEchelonCount = 0,
      long StarConditionTacticRankSCount = 0,
      long StarConditionTurnCount = 0,
      VectorOffset EnterScenarioGroupIdOffset = default(VectorOffset),
      VectorOffset ClearScenarioGroupIdOffset = default(VectorOffset),
      StringOffset StrategyMapOffset = default(StringOffset),
      StringOffset StrategyMapBGOffset = default(StringOffset),
      long CampaignStageRewardId = 0,
      int MaxTurn = 0,
      Plana.FlatData.StageTopography StageTopography_ = Plana.FlatData.StageTopography.Street,
      int RecommandLevel = 0,
      StringOffset BgmIdOffset = default(StringOffset),
      Plana.FlatData.StrategyEnvironment StrategyEnvironment_ = Plana.FlatData.StrategyEnvironment.None,
      long GroundId = 0,
      Plana.FlatData.ContentType ContentType_ = Plana.FlatData.ContentType.None,
      long BGMId = 0,
      StringOffset FirstClearReportEventNameOffset = default(StringOffset),
      StringOffset FirstClearFunnelMessageOffset = default(StringOffset),
      StringOffset FirstClearEventMessageOffset = default(StringOffset),
      long TacticRewardExp = 0,
      long FixedEchelonId = 0,
      Plana.FlatData.EchelonExtensionType EchelonExtensionType_ = Plana.FlatData.EchelonExtensionType.Base) {
    builder.StartTable(31);
    CampaignStageExcel.AddFixedEchelonId(builder, FixedEchelonId);
    CampaignStageExcel.AddTacticRewardExp(builder, TacticRewardExp);
    CampaignStageExcel.AddBGMId(builder, BGMId);
    CampaignStageExcel.AddGroundId(builder, GroundId);
    CampaignStageExcel.AddCampaignStageRewardId(builder, CampaignStageRewardId);
    CampaignStageExcel.AddStarConditionTurnCount(builder, StarConditionTurnCount);
    CampaignStageExcel.AddStarConditionTacticRankSCount(builder, StarConditionTacticRankSCount);
    CampaignStageExcel.AddStageEnterCostId(builder, StageEnterCostId);
    CampaignStageExcel.AddBattleDuration(builder, BattleDuration);
    CampaignStageExcel.AddCleardScenarioId(builder, CleardScenarioId);
    CampaignStageExcel.AddId(builder, Id);
    CampaignStageExcel.AddEchelonExtensionType_(builder, EchelonExtensionType_);
    CampaignStageExcel.AddFirstClearEventMessage(builder, FirstClearEventMessageOffset);
    CampaignStageExcel.AddFirstClearFunnelMessage(builder, FirstClearFunnelMessageOffset);
    CampaignStageExcel.AddFirstClearReportEventName(builder, FirstClearReportEventNameOffset);
    CampaignStageExcel.AddContentType_(builder, ContentType_);
    CampaignStageExcel.AddStrategyEnvironment_(builder, StrategyEnvironment_);
    CampaignStageExcel.AddBgmId(builder, BgmIdOffset);
    CampaignStageExcel.AddRecommandLevel(builder, RecommandLevel);
    CampaignStageExcel.AddStageTopography_(builder, StageTopography_);
    CampaignStageExcel.AddMaxTurn(builder, MaxTurn);
    CampaignStageExcel.AddStrategyMapBG(builder, StrategyMapBGOffset);
    CampaignStageExcel.AddStrategyMap(builder, StrategyMapOffset);
    CampaignStageExcel.AddClearScenarioGroupId(builder, ClearScenarioGroupIdOffset);
    CampaignStageExcel.AddEnterScenarioGroupId(builder, EnterScenarioGroupIdOffset);
    CampaignStageExcel.AddStageEnterEchelonCount(builder, StageEnterEchelonCount);
    CampaignStageExcel.AddStageEnterCostAmount(builder, StageEnterCostAmount);
    CampaignStageExcel.AddStageEnterCostType(builder, StageEnterCostType);
    CampaignStageExcel.AddStageNumber(builder, StageNumberOffset);
    CampaignStageExcel.AddName(builder, NameOffset);
    CampaignStageExcel.AddDeprecated(builder, Deprecated);
    return CampaignStageExcel.EndCampaignStageExcel(builder);
  }

  public static void StartCampaignStageExcel(FlatBufferBuilder builder) { builder.StartTable(31); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddDeprecated(FlatBufferBuilder builder, bool deprecated) { builder.AddBool(1, deprecated, false); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(2, nameOffset.Value, 0); }
  public static void AddStageNumber(FlatBufferBuilder builder, StringOffset stageNumberOffset) { builder.AddOffset(3, stageNumberOffset.Value, 0); }
  public static void AddCleardScenarioId(FlatBufferBuilder builder, long cleardScenarioId) { builder.AddLong(4, cleardScenarioId, 0); }
  public static void AddBattleDuration(FlatBufferBuilder builder, long battleDuration) { builder.AddLong(5, battleDuration, 0); }
  public static void AddStageEnterCostType(FlatBufferBuilder builder, Plana.FlatData.ParcelType stageEnterCostType) { builder.AddInt(6, (int)stageEnterCostType, 0); }
  public static void AddStageEnterCostId(FlatBufferBuilder builder, long stageEnterCostId) { builder.AddLong(7, stageEnterCostId, 0); }
  public static void AddStageEnterCostAmount(FlatBufferBuilder builder, int stageEnterCostAmount) { builder.AddInt(8, stageEnterCostAmount, 0); }
  public static void AddStageEnterEchelonCount(FlatBufferBuilder builder, int stageEnterEchelonCount) { builder.AddInt(9, stageEnterEchelonCount, 0); }
  public static void AddStarConditionTacticRankSCount(FlatBufferBuilder builder, long starConditionTacticRankSCount) { builder.AddLong(10, starConditionTacticRankSCount, 0); }
  public static void AddStarConditionTurnCount(FlatBufferBuilder builder, long starConditionTurnCount) { builder.AddLong(11, starConditionTurnCount, 0); }
  public static void AddEnterScenarioGroupId(FlatBufferBuilder builder, VectorOffset enterScenarioGroupIdOffset) { builder.AddOffset(12, enterScenarioGroupIdOffset.Value, 0); }
  public static VectorOffset CreateEnterScenarioGroupIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateEnterScenarioGroupIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEnterScenarioGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEnterScenarioGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartEnterScenarioGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddClearScenarioGroupId(FlatBufferBuilder builder, VectorOffset clearScenarioGroupIdOffset) { builder.AddOffset(13, clearScenarioGroupIdOffset.Value, 0); }
  public static VectorOffset CreateClearScenarioGroupIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateClearScenarioGroupIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateClearScenarioGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateClearScenarioGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartClearScenarioGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddStrategyMap(FlatBufferBuilder builder, StringOffset strategyMapOffset) { builder.AddOffset(14, strategyMapOffset.Value, 0); }
  public static void AddStrategyMapBG(FlatBufferBuilder builder, StringOffset strategyMapBGOffset) { builder.AddOffset(15, strategyMapBGOffset.Value, 0); }
  public static void AddCampaignStageRewardId(FlatBufferBuilder builder, long campaignStageRewardId) { builder.AddLong(16, campaignStageRewardId, 0); }
  public static void AddMaxTurn(FlatBufferBuilder builder, int maxTurn) { builder.AddInt(17, maxTurn, 0); }
  public static void AddStageTopography_(FlatBufferBuilder builder, Plana.FlatData.StageTopography stageTopography_) { builder.AddInt(18, (int)stageTopography_, 0); }
  public static void AddRecommandLevel(FlatBufferBuilder builder, int recommandLevel) { builder.AddInt(19, recommandLevel, 0); }
  public static void AddBgmId(FlatBufferBuilder builder, StringOffset bgmIdOffset) { builder.AddOffset(20, bgmIdOffset.Value, 0); }
  public static void AddStrategyEnvironment_(FlatBufferBuilder builder, Plana.FlatData.StrategyEnvironment strategyEnvironment_) { builder.AddInt(21, (int)strategyEnvironment_, 0); }
  public static void AddGroundId(FlatBufferBuilder builder, long groundId) { builder.AddLong(22, groundId, 0); }
  public static void AddContentType_(FlatBufferBuilder builder, Plana.FlatData.ContentType contentType_) { builder.AddInt(23, (int)contentType_, 0); }
  public static void AddBGMId(FlatBufferBuilder builder, long bGMId) { builder.AddLong(24, bGMId, 0); }
  public static void AddFirstClearReportEventName(FlatBufferBuilder builder, StringOffset firstClearReportEventNameOffset) { builder.AddOffset(25, firstClearReportEventNameOffset.Value, 0); }
  public static void AddFirstClearFunnelMessage(FlatBufferBuilder builder, StringOffset firstClearFunnelMessageOffset) { builder.AddOffset(26, firstClearFunnelMessageOffset.Value, 0); }
  public static void AddFirstClearEventMessage(FlatBufferBuilder builder, StringOffset firstClearEventMessageOffset) { builder.AddOffset(27, firstClearEventMessageOffset.Value, 0); }
  public static void AddTacticRewardExp(FlatBufferBuilder builder, long tacticRewardExp) { builder.AddLong(28, tacticRewardExp, 0); }
  public static void AddFixedEchelonId(FlatBufferBuilder builder, long fixedEchelonId) { builder.AddLong(29, fixedEchelonId, 0); }
  public static void AddEchelonExtensionType_(FlatBufferBuilder builder, Plana.FlatData.EchelonExtensionType echelonExtensionType_) { builder.AddInt(30, (int)echelonExtensionType_, 0); }
  public static Offset<Plana.FlatData.CampaignStageExcel> EndCampaignStageExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.CampaignStageExcel>(o);
  }
  public CampaignStageExcelT UnPack() {
    var _o = new CampaignStageExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CampaignStageExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("CampaignStage");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.Deprecated = TableEncryptionService.Convert(this.Deprecated, key);
    _o.Name = TableEncryptionService.Convert(this.Name, key);
    _o.StageNumber = TableEncryptionService.Convert(this.StageNumber, key);
    _o.CleardScenarioId = TableEncryptionService.Convert(this.CleardScenarioId, key);
    _o.BattleDuration = TableEncryptionService.Convert(this.BattleDuration, key);
    _o.StageEnterCostType = TableEncryptionService.Convert(this.StageEnterCostType, key);
    _o.StageEnterCostId = TableEncryptionService.Convert(this.StageEnterCostId, key);
    _o.StageEnterCostAmount = TableEncryptionService.Convert(this.StageEnterCostAmount, key);
    _o.StageEnterEchelonCount = TableEncryptionService.Convert(this.StageEnterEchelonCount, key);
    _o.StarConditionTacticRankSCount = TableEncryptionService.Convert(this.StarConditionTacticRankSCount, key);
    _o.StarConditionTurnCount = TableEncryptionService.Convert(this.StarConditionTurnCount, key);
    _o.EnterScenarioGroupId = new List<long>();
    for (var _j = 0; _j < this.EnterScenarioGroupIdLength; ++_j) {_o.EnterScenarioGroupId.Add(TableEncryptionService.Convert(this.EnterScenarioGroupId(_j), key));}
    _o.ClearScenarioGroupId = new List<long>();
    for (var _j = 0; _j < this.ClearScenarioGroupIdLength; ++_j) {_o.ClearScenarioGroupId.Add(TableEncryptionService.Convert(this.ClearScenarioGroupId(_j), key));}
    _o.StrategyMap = TableEncryptionService.Convert(this.StrategyMap, key);
    _o.StrategyMapBG = TableEncryptionService.Convert(this.StrategyMapBG, key);
    _o.CampaignStageRewardId = TableEncryptionService.Convert(this.CampaignStageRewardId, key);
    _o.MaxTurn = TableEncryptionService.Convert(this.MaxTurn, key);
    _o.StageTopography_ = TableEncryptionService.Convert(this.StageTopography_, key);
    _o.RecommandLevel = TableEncryptionService.Convert(this.RecommandLevel, key);
    _o.BgmId = TableEncryptionService.Convert(this.BgmId, key);
    _o.StrategyEnvironment_ = TableEncryptionService.Convert(this.StrategyEnvironment_, key);
    _o.GroundId = TableEncryptionService.Convert(this.GroundId, key);
    _o.ContentType_ = TableEncryptionService.Convert(this.ContentType_, key);
    _o.BGMId = TableEncryptionService.Convert(this.BGMId, key);
    _o.FirstClearReportEventName = TableEncryptionService.Convert(this.FirstClearReportEventName, key);
    _o.FirstClearFunnelMessage = TableEncryptionService.Convert(this.FirstClearFunnelMessage, key);
    _o.FirstClearEventMessage = TableEncryptionService.Convert(this.FirstClearEventMessage, key);
    _o.TacticRewardExp = TableEncryptionService.Convert(this.TacticRewardExp, key);
    _o.FixedEchelonId = TableEncryptionService.Convert(this.FixedEchelonId, key);
    _o.EchelonExtensionType_ = TableEncryptionService.Convert(this.EchelonExtensionType_, key);
  }
  public static Offset<Plana.FlatData.CampaignStageExcel> Pack(FlatBufferBuilder builder, CampaignStageExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.CampaignStageExcel>);
    var _Name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _StageNumber = _o.StageNumber == null ? default(StringOffset) : builder.CreateString(_o.StageNumber);
    var _EnterScenarioGroupId = default(VectorOffset);
    if (_o.EnterScenarioGroupId != null) {
      var __EnterScenarioGroupId = _o.EnterScenarioGroupId.ToArray();
      _EnterScenarioGroupId = CreateEnterScenarioGroupIdVector(builder, __EnterScenarioGroupId);
    }
    var _ClearScenarioGroupId = default(VectorOffset);
    if (_o.ClearScenarioGroupId != null) {
      var __ClearScenarioGroupId = _o.ClearScenarioGroupId.ToArray();
      _ClearScenarioGroupId = CreateClearScenarioGroupIdVector(builder, __ClearScenarioGroupId);
    }
    var _StrategyMap = _o.StrategyMap == null ? default(StringOffset) : builder.CreateString(_o.StrategyMap);
    var _StrategyMapBG = _o.StrategyMapBG == null ? default(StringOffset) : builder.CreateString(_o.StrategyMapBG);
    var _BgmId = _o.BgmId == null ? default(StringOffset) : builder.CreateString(_o.BgmId);
    var _FirstClearReportEventName = _o.FirstClearReportEventName == null ? default(StringOffset) : builder.CreateString(_o.FirstClearReportEventName);
    var _FirstClearFunnelMessage = _o.FirstClearFunnelMessage == null ? default(StringOffset) : builder.CreateString(_o.FirstClearFunnelMessage);
    var _FirstClearEventMessage = _o.FirstClearEventMessage == null ? default(StringOffset) : builder.CreateString(_o.FirstClearEventMessage);
    return CreateCampaignStageExcel(
      builder,
      _o.Id,
      _o.Deprecated,
      _Name,
      _StageNumber,
      _o.CleardScenarioId,
      _o.BattleDuration,
      _o.StageEnterCostType,
      _o.StageEnterCostId,
      _o.StageEnterCostAmount,
      _o.StageEnterEchelonCount,
      _o.StarConditionTacticRankSCount,
      _o.StarConditionTurnCount,
      _EnterScenarioGroupId,
      _ClearScenarioGroupId,
      _StrategyMap,
      _StrategyMapBG,
      _o.CampaignStageRewardId,
      _o.MaxTurn,
      _o.StageTopography_,
      _o.RecommandLevel,
      _BgmId,
      _o.StrategyEnvironment_,
      _o.GroundId,
      _o.ContentType_,
      _o.BGMId,
      _FirstClearReportEventName,
      _FirstClearFunnelMessage,
      _FirstClearEventMessage,
      _o.TacticRewardExp,
      _o.FixedEchelonId,
      _o.EchelonExtensionType_);
  }
}

public class CampaignStageExcelT
{
  public long Id { get; set; }
  public bool Deprecated { get; set; }
  public string Name { get; set; }
  public string StageNumber { get; set; }
  public long CleardScenarioId { get; set; }
  public long BattleDuration { get; set; }
  public Plana.FlatData.ParcelType StageEnterCostType { get; set; }
  public long StageEnterCostId { get; set; }
  public int StageEnterCostAmount { get; set; }
  public int StageEnterEchelonCount { get; set; }
  public long StarConditionTacticRankSCount { get; set; }
  public long StarConditionTurnCount { get; set; }
  public List<long> EnterScenarioGroupId { get; set; }
  public List<long> ClearScenarioGroupId { get; set; }
  public string StrategyMap { get; set; }
  public string StrategyMapBG { get; set; }
  public long CampaignStageRewardId { get; set; }
  public int MaxTurn { get; set; }
  public Plana.FlatData.StageTopography StageTopography_ { get; set; }
  public int RecommandLevel { get; set; }
  public string BgmId { get; set; }
  public Plana.FlatData.StrategyEnvironment StrategyEnvironment_ { get; set; }
  public long GroundId { get; set; }
  public Plana.FlatData.ContentType ContentType_ { get; set; }
  public long BGMId { get; set; }
  public string FirstClearReportEventName { get; set; }
  public string FirstClearFunnelMessage { get; set; }
  public string FirstClearEventMessage { get; set; }
  public long TacticRewardExp { get; set; }
  public long FixedEchelonId { get; set; }
  public Plana.FlatData.EchelonExtensionType EchelonExtensionType_ { get; set; }

  public CampaignStageExcelT() {
    this.Id = 0;
    this.Deprecated = false;
    this.Name = null;
    this.StageNumber = null;
    this.CleardScenarioId = 0;
    this.BattleDuration = 0;
    this.StageEnterCostType = Plana.FlatData.ParcelType.None;
    this.StageEnterCostId = 0;
    this.StageEnterCostAmount = 0;
    this.StageEnterEchelonCount = 0;
    this.StarConditionTacticRankSCount = 0;
    this.StarConditionTurnCount = 0;
    this.EnterScenarioGroupId = null;
    this.ClearScenarioGroupId = null;
    this.StrategyMap = null;
    this.StrategyMapBG = null;
    this.CampaignStageRewardId = 0;
    this.MaxTurn = 0;
    this.StageTopography_ = Plana.FlatData.StageTopography.Street;
    this.RecommandLevel = 0;
    this.BgmId = null;
    this.StrategyEnvironment_ = Plana.FlatData.StrategyEnvironment.None;
    this.GroundId = 0;
    this.ContentType_ = Plana.FlatData.ContentType.None;
    this.BGMId = 0;
    this.FirstClearReportEventName = null;
    this.FirstClearFunnelMessage = null;
    this.FirstClearEventMessage = null;
    this.TacticRewardExp = 0;
    this.FixedEchelonId = 0;
    this.EchelonExtensionType_ = Plana.FlatData.EchelonExtensionType.Base;
  }
}


static public class CampaignStageExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*Deprecated*/, 1 /*bool*/, 1, false)
      && verifier.VerifyString(tablePos, 8 /*Name*/, false)
      && verifier.VerifyString(tablePos, 10 /*StageNumber*/, false)
      && verifier.VerifyField(tablePos, 12 /*CleardScenarioId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*BattleDuration*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*StageEnterCostType*/, 4 /*Plana.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*StageEnterCostId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 20 /*StageEnterCostAmount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*StageEnterEchelonCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 24 /*StarConditionTacticRankSCount*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 26 /*StarConditionTurnCount*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 28 /*EnterScenarioGroupId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 30 /*ClearScenarioGroupId*/, 8 /*long*/, false)
      && verifier.VerifyString(tablePos, 32 /*StrategyMap*/, false)
      && verifier.VerifyString(tablePos, 34 /*StrategyMapBG*/, false)
      && verifier.VerifyField(tablePos, 36 /*CampaignStageRewardId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 38 /*MaxTurn*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 40 /*StageTopography_*/, 4 /*Plana.FlatData.StageTopography*/, 4, false)
      && verifier.VerifyField(tablePos, 42 /*RecommandLevel*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 44 /*BgmId*/, false)
      && verifier.VerifyField(tablePos, 46 /*StrategyEnvironment_*/, 4 /*Plana.FlatData.StrategyEnvironment*/, 4, false)
      && verifier.VerifyField(tablePos, 48 /*GroundId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 50 /*ContentType_*/, 4 /*Plana.FlatData.ContentType*/, 4, false)
      && verifier.VerifyField(tablePos, 52 /*BGMId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 54 /*FirstClearReportEventName*/, false)
      && verifier.VerifyString(tablePos, 56 /*FirstClearFunnelMessage*/, false)
      && verifier.VerifyString(tablePos, 58 /*FirstClearEventMessage*/, false)
      && verifier.VerifyField(tablePos, 60 /*TacticRewardExp*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 62 /*FixedEchelonId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 64 /*EchelonExtensionType_*/, 4 /*Plana.FlatData.EchelonExtensionType*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
