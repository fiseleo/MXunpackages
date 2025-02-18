// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct TacticalSupportSystemExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static TacticalSupportSystemExcel GetRootAsTacticalSupportSystemExcel(ByteBuffer _bb) { return GetRootAsTacticalSupportSystemExcel(_bb, new TacticalSupportSystemExcel()); }
  public static TacticalSupportSystemExcel GetRootAsTacticalSupportSystemExcel(ByteBuffer _bb, TacticalSupportSystemExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TacticalSupportSystemExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long SummonedTime { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DefaultPersonalityId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool CanTargeting { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool CanCover { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string ObstacleUniqueName { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetObstacleUniqueNameBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetObstacleUniqueNameBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetObstacleUniqueNameArray() { return __p.__vector_as_array<byte>(14); }
  public long ObstacleCoverRange { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string SummonSkilllGroupId { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSummonSkilllGroupIdBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetSummonSkilllGroupIdBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetSummonSkilllGroupIdArray() { return __p.__vector_as_array<byte>(18); }
  public long CrashObstacleOBBWidth { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CrashObstacleOBBHeight { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool IsTSSBlockedNodeCheck { get { int o = __p.__offset(24); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int NumberOfUses { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public float InventoryOffsetX { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float InventoryOffsetY { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float InventoryOffsetZ { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public long InteractionChar { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CharacterInteractionStartDelay { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string GetOnStartEffectPath { get { int o = __p.__offset(38); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetGetOnStartEffectPathBytes() { return __p.__vector_as_span<byte>(38, 1); }
#else
  public ArraySegment<byte>? GetGetOnStartEffectPathBytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public byte[] GetGetOnStartEffectPathArray() { return __p.__vector_as_array<byte>(38); }
  public string GetOnEndEffectPath { get { int o = __p.__offset(40); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetGetOnEndEffectPathBytes() { return __p.__vector_as_span<byte>(40, 1); }
#else
  public ArraySegment<byte>? GetGetOnEndEffectPathBytes() { return __p.__vector_as_arraysegment(40); }
#endif
  public byte[] GetGetOnEndEffectPathArray() { return __p.__vector_as_array<byte>(40); }
  public long SummonerCharacterId { get { int o = __p.__offset(42); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int InteractionFrame { get { int o = __p.__offset(44); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long TSAInteractionAddDuration { get { int o = __p.__offset(46); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string InteractionStudentExSkillGroupId { get { int o = __p.__offset(48); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetInteractionStudentExSkillGroupIdBytes() { return __p.__vector_as_span<byte>(48, 1); }
#else
  public ArraySegment<byte>? GetInteractionStudentExSkillGroupIdBytes() { return __p.__vector_as_arraysegment(48); }
#endif
  public byte[] GetInteractionStudentExSkillGroupIdArray() { return __p.__vector_as_array<byte>(48); }
  public string InteractionSkillCardTexture { get { int o = __p.__offset(50); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetInteractionSkillCardTextureBytes() { return __p.__vector_as_span<byte>(50, 1); }
#else
  public ArraySegment<byte>? GetInteractionSkillCardTextureBytes() { return __p.__vector_as_arraysegment(50); }
#endif
  public byte[] GetInteractionSkillCardTextureArray() { return __p.__vector_as_array<byte>(50); }
  public string InteractionSkillSpine { get { int o = __p.__offset(52); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetInteractionSkillSpineBytes() { return __p.__vector_as_span<byte>(52, 1); }
#else
  public ArraySegment<byte>? GetInteractionSkillSpineBytes() { return __p.__vector_as_arraysegment(52); }
#endif
  public byte[] GetInteractionSkillSpineArray() { return __p.__vector_as_array<byte>(52); }
  public int RetreatFrame { get { int o = __p.__offset(54); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int DestroyFrame { get { int o = __p.__offset(56); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<Plana.FlatData.TacticalSupportSystemExcel> CreateTacticalSupportSystemExcel(FlatBufferBuilder builder,
      long Id = 0,
      long SummonedTime = 0,
      long DefaultPersonalityId = 0,
      bool CanTargeting = false,
      bool CanCover = false,
      StringOffset ObstacleUniqueNameOffset = default(StringOffset),
      long ObstacleCoverRange = 0,
      StringOffset SummonSkilllGroupIdOffset = default(StringOffset),
      long CrashObstacleOBBWidth = 0,
      long CrashObstacleOBBHeight = 0,
      bool IsTSSBlockedNodeCheck = false,
      int NumberOfUses = 0,
      float InventoryOffsetX = 0.0f,
      float InventoryOffsetY = 0.0f,
      float InventoryOffsetZ = 0.0f,
      long InteractionChar = 0,
      long CharacterInteractionStartDelay = 0,
      StringOffset GetOnStartEffectPathOffset = default(StringOffset),
      StringOffset GetOnEndEffectPathOffset = default(StringOffset),
      long SummonerCharacterId = 0,
      int InteractionFrame = 0,
      long TSAInteractionAddDuration = 0,
      StringOffset InteractionStudentExSkillGroupIdOffset = default(StringOffset),
      StringOffset InteractionSkillCardTextureOffset = default(StringOffset),
      StringOffset InteractionSkillSpineOffset = default(StringOffset),
      int RetreatFrame = 0,
      int DestroyFrame = 0) {
    builder.StartTable(27);
    TacticalSupportSystemExcel.AddTSAInteractionAddDuration(builder, TSAInteractionAddDuration);
    TacticalSupportSystemExcel.AddSummonerCharacterId(builder, SummonerCharacterId);
    TacticalSupportSystemExcel.AddCharacterInteractionStartDelay(builder, CharacterInteractionStartDelay);
    TacticalSupportSystemExcel.AddInteractionChar(builder, InteractionChar);
    TacticalSupportSystemExcel.AddCrashObstacleOBBHeight(builder, CrashObstacleOBBHeight);
    TacticalSupportSystemExcel.AddCrashObstacleOBBWidth(builder, CrashObstacleOBBWidth);
    TacticalSupportSystemExcel.AddObstacleCoverRange(builder, ObstacleCoverRange);
    TacticalSupportSystemExcel.AddDefaultPersonalityId(builder, DefaultPersonalityId);
    TacticalSupportSystemExcel.AddSummonedTime(builder, SummonedTime);
    TacticalSupportSystemExcel.AddId(builder, Id);
    TacticalSupportSystemExcel.AddDestroyFrame(builder, DestroyFrame);
    TacticalSupportSystemExcel.AddRetreatFrame(builder, RetreatFrame);
    TacticalSupportSystemExcel.AddInteractionSkillSpine(builder, InteractionSkillSpineOffset);
    TacticalSupportSystemExcel.AddInteractionSkillCardTexture(builder, InteractionSkillCardTextureOffset);
    TacticalSupportSystemExcel.AddInteractionStudentExSkillGroupId(builder, InteractionStudentExSkillGroupIdOffset);
    TacticalSupportSystemExcel.AddInteractionFrame(builder, InteractionFrame);
    TacticalSupportSystemExcel.AddGetOnEndEffectPath(builder, GetOnEndEffectPathOffset);
    TacticalSupportSystemExcel.AddGetOnStartEffectPath(builder, GetOnStartEffectPathOffset);
    TacticalSupportSystemExcel.AddInventoryOffsetZ(builder, InventoryOffsetZ);
    TacticalSupportSystemExcel.AddInventoryOffsetY(builder, InventoryOffsetY);
    TacticalSupportSystemExcel.AddInventoryOffsetX(builder, InventoryOffsetX);
    TacticalSupportSystemExcel.AddNumberOfUses(builder, NumberOfUses);
    TacticalSupportSystemExcel.AddSummonSkilllGroupId(builder, SummonSkilllGroupIdOffset);
    TacticalSupportSystemExcel.AddObstacleUniqueName(builder, ObstacleUniqueNameOffset);
    TacticalSupportSystemExcel.AddIsTSSBlockedNodeCheck(builder, IsTSSBlockedNodeCheck);
    TacticalSupportSystemExcel.AddCanCover(builder, CanCover);
    TacticalSupportSystemExcel.AddCanTargeting(builder, CanTargeting);
    return TacticalSupportSystemExcel.EndTacticalSupportSystemExcel(builder);
  }

  public static void StartTacticalSupportSystemExcel(FlatBufferBuilder builder) { builder.StartTable(27); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddSummonedTime(FlatBufferBuilder builder, long summonedTime) { builder.AddLong(1, summonedTime, 0); }
  public static void AddDefaultPersonalityId(FlatBufferBuilder builder, long defaultPersonalityId) { builder.AddLong(2, defaultPersonalityId, 0); }
  public static void AddCanTargeting(FlatBufferBuilder builder, bool canTargeting) { builder.AddBool(3, canTargeting, false); }
  public static void AddCanCover(FlatBufferBuilder builder, bool canCover) { builder.AddBool(4, canCover, false); }
  public static void AddObstacleUniqueName(FlatBufferBuilder builder, StringOffset obstacleUniqueNameOffset) { builder.AddOffset(5, obstacleUniqueNameOffset.Value, 0); }
  public static void AddObstacleCoverRange(FlatBufferBuilder builder, long obstacleCoverRange) { builder.AddLong(6, obstacleCoverRange, 0); }
  public static void AddSummonSkilllGroupId(FlatBufferBuilder builder, StringOffset summonSkilllGroupIdOffset) { builder.AddOffset(7, summonSkilllGroupIdOffset.Value, 0); }
  public static void AddCrashObstacleOBBWidth(FlatBufferBuilder builder, long crashObstacleOBBWidth) { builder.AddLong(8, crashObstacleOBBWidth, 0); }
  public static void AddCrashObstacleOBBHeight(FlatBufferBuilder builder, long crashObstacleOBBHeight) { builder.AddLong(9, crashObstacleOBBHeight, 0); }
  public static void AddIsTSSBlockedNodeCheck(FlatBufferBuilder builder, bool isTSSBlockedNodeCheck) { builder.AddBool(10, isTSSBlockedNodeCheck, false); }
  public static void AddNumberOfUses(FlatBufferBuilder builder, int numberOfUses) { builder.AddInt(11, numberOfUses, 0); }
  public static void AddInventoryOffsetX(FlatBufferBuilder builder, float inventoryOffsetX) { builder.AddFloat(12, inventoryOffsetX, 0.0f); }
  public static void AddInventoryOffsetY(FlatBufferBuilder builder, float inventoryOffsetY) { builder.AddFloat(13, inventoryOffsetY, 0.0f); }
  public static void AddInventoryOffsetZ(FlatBufferBuilder builder, float inventoryOffsetZ) { builder.AddFloat(14, inventoryOffsetZ, 0.0f); }
  public static void AddInteractionChar(FlatBufferBuilder builder, long interactionChar) { builder.AddLong(15, interactionChar, 0); }
  public static void AddCharacterInteractionStartDelay(FlatBufferBuilder builder, long characterInteractionStartDelay) { builder.AddLong(16, characterInteractionStartDelay, 0); }
  public static void AddGetOnStartEffectPath(FlatBufferBuilder builder, StringOffset getOnStartEffectPathOffset) { builder.AddOffset(17, getOnStartEffectPathOffset.Value, 0); }
  public static void AddGetOnEndEffectPath(FlatBufferBuilder builder, StringOffset getOnEndEffectPathOffset) { builder.AddOffset(18, getOnEndEffectPathOffset.Value, 0); }
  public static void AddSummonerCharacterId(FlatBufferBuilder builder, long summonerCharacterId) { builder.AddLong(19, summonerCharacterId, 0); }
  public static void AddInteractionFrame(FlatBufferBuilder builder, int interactionFrame) { builder.AddInt(20, interactionFrame, 0); }
  public static void AddTSAInteractionAddDuration(FlatBufferBuilder builder, long tSAInteractionAddDuration) { builder.AddLong(21, tSAInteractionAddDuration, 0); }
  public static void AddInteractionStudentExSkillGroupId(FlatBufferBuilder builder, StringOffset interactionStudentExSkillGroupIdOffset) { builder.AddOffset(22, interactionStudentExSkillGroupIdOffset.Value, 0); }
  public static void AddInteractionSkillCardTexture(FlatBufferBuilder builder, StringOffset interactionSkillCardTextureOffset) { builder.AddOffset(23, interactionSkillCardTextureOffset.Value, 0); }
  public static void AddInteractionSkillSpine(FlatBufferBuilder builder, StringOffset interactionSkillSpineOffset) { builder.AddOffset(24, interactionSkillSpineOffset.Value, 0); }
  public static void AddRetreatFrame(FlatBufferBuilder builder, int retreatFrame) { builder.AddInt(25, retreatFrame, 0); }
  public static void AddDestroyFrame(FlatBufferBuilder builder, int destroyFrame) { builder.AddInt(26, destroyFrame, 0); }
  public static Offset<Plana.FlatData.TacticalSupportSystemExcel> EndTacticalSupportSystemExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.TacticalSupportSystemExcel>(o);
  }
  public TacticalSupportSystemExcelT UnPack() {
    var _o = new TacticalSupportSystemExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(TacticalSupportSystemExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("TacticalSupportSystem");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.SummonedTime = TableEncryptionService.Convert(this.SummonedTime, key);
    _o.DefaultPersonalityId = TableEncryptionService.Convert(this.DefaultPersonalityId, key);
    _o.CanTargeting = TableEncryptionService.Convert(this.CanTargeting, key);
    _o.CanCover = TableEncryptionService.Convert(this.CanCover, key);
    _o.ObstacleUniqueName = TableEncryptionService.Convert(this.ObstacleUniqueName, key);
    _o.ObstacleCoverRange = TableEncryptionService.Convert(this.ObstacleCoverRange, key);
    _o.SummonSkilllGroupId = TableEncryptionService.Convert(this.SummonSkilllGroupId, key);
    _o.CrashObstacleOBBWidth = TableEncryptionService.Convert(this.CrashObstacleOBBWidth, key);
    _o.CrashObstacleOBBHeight = TableEncryptionService.Convert(this.CrashObstacleOBBHeight, key);
    _o.IsTSSBlockedNodeCheck = TableEncryptionService.Convert(this.IsTSSBlockedNodeCheck, key);
    _o.NumberOfUses = TableEncryptionService.Convert(this.NumberOfUses, key);
    _o.InventoryOffsetX = TableEncryptionService.Convert(this.InventoryOffsetX, key);
    _o.InventoryOffsetY = TableEncryptionService.Convert(this.InventoryOffsetY, key);
    _o.InventoryOffsetZ = TableEncryptionService.Convert(this.InventoryOffsetZ, key);
    _o.InteractionChar = TableEncryptionService.Convert(this.InteractionChar, key);
    _o.CharacterInteractionStartDelay = TableEncryptionService.Convert(this.CharacterInteractionStartDelay, key);
    _o.GetOnStartEffectPath = TableEncryptionService.Convert(this.GetOnStartEffectPath, key);
    _o.GetOnEndEffectPath = TableEncryptionService.Convert(this.GetOnEndEffectPath, key);
    _o.SummonerCharacterId = TableEncryptionService.Convert(this.SummonerCharacterId, key);
    _o.InteractionFrame = TableEncryptionService.Convert(this.InteractionFrame, key);
    _o.TSAInteractionAddDuration = TableEncryptionService.Convert(this.TSAInteractionAddDuration, key);
    _o.InteractionStudentExSkillGroupId = TableEncryptionService.Convert(this.InteractionStudentExSkillGroupId, key);
    _o.InteractionSkillCardTexture = TableEncryptionService.Convert(this.InteractionSkillCardTexture, key);
    _o.InteractionSkillSpine = TableEncryptionService.Convert(this.InteractionSkillSpine, key);
    _o.RetreatFrame = TableEncryptionService.Convert(this.RetreatFrame, key);
    _o.DestroyFrame = TableEncryptionService.Convert(this.DestroyFrame, key);
  }
  public static Offset<Plana.FlatData.TacticalSupportSystemExcel> Pack(FlatBufferBuilder builder, TacticalSupportSystemExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.TacticalSupportSystemExcel>);
    var _ObstacleUniqueName = _o.ObstacleUniqueName == null ? default(StringOffset) : builder.CreateString(_o.ObstacleUniqueName);
    var _SummonSkilllGroupId = _o.SummonSkilllGroupId == null ? default(StringOffset) : builder.CreateString(_o.SummonSkilllGroupId);
    var _GetOnStartEffectPath = _o.GetOnStartEffectPath == null ? default(StringOffset) : builder.CreateString(_o.GetOnStartEffectPath);
    var _GetOnEndEffectPath = _o.GetOnEndEffectPath == null ? default(StringOffset) : builder.CreateString(_o.GetOnEndEffectPath);
    var _InteractionStudentExSkillGroupId = _o.InteractionStudentExSkillGroupId == null ? default(StringOffset) : builder.CreateString(_o.InteractionStudentExSkillGroupId);
    var _InteractionSkillCardTexture = _o.InteractionSkillCardTexture == null ? default(StringOffset) : builder.CreateString(_o.InteractionSkillCardTexture);
    var _InteractionSkillSpine = _o.InteractionSkillSpine == null ? default(StringOffset) : builder.CreateString(_o.InteractionSkillSpine);
    return CreateTacticalSupportSystemExcel(
      builder,
      _o.Id,
      _o.SummonedTime,
      _o.DefaultPersonalityId,
      _o.CanTargeting,
      _o.CanCover,
      _ObstacleUniqueName,
      _o.ObstacleCoverRange,
      _SummonSkilllGroupId,
      _o.CrashObstacleOBBWidth,
      _o.CrashObstacleOBBHeight,
      _o.IsTSSBlockedNodeCheck,
      _o.NumberOfUses,
      _o.InventoryOffsetX,
      _o.InventoryOffsetY,
      _o.InventoryOffsetZ,
      _o.InteractionChar,
      _o.CharacterInteractionStartDelay,
      _GetOnStartEffectPath,
      _GetOnEndEffectPath,
      _o.SummonerCharacterId,
      _o.InteractionFrame,
      _o.TSAInteractionAddDuration,
      _InteractionStudentExSkillGroupId,
      _InteractionSkillCardTexture,
      _InteractionSkillSpine,
      _o.RetreatFrame,
      _o.DestroyFrame);
  }
}

public class TacticalSupportSystemExcelT
{
  public long Id { get; set; }
  public long SummonedTime { get; set; }
  public long DefaultPersonalityId { get; set; }
  public bool CanTargeting { get; set; }
  public bool CanCover { get; set; }
  public string ObstacleUniqueName { get; set; }
  public long ObstacleCoverRange { get; set; }
  public string SummonSkilllGroupId { get; set; }
  public long CrashObstacleOBBWidth { get; set; }
  public long CrashObstacleOBBHeight { get; set; }
  public bool IsTSSBlockedNodeCheck { get; set; }
  public int NumberOfUses { get; set; }
  public float InventoryOffsetX { get; set; }
  public float InventoryOffsetY { get; set; }
  public float InventoryOffsetZ { get; set; }
  public long InteractionChar { get; set; }
  public long CharacterInteractionStartDelay { get; set; }
  public string GetOnStartEffectPath { get; set; }
  public string GetOnEndEffectPath { get; set; }
  public long SummonerCharacterId { get; set; }
  public int InteractionFrame { get; set; }
  public long TSAInteractionAddDuration { get; set; }
  public string InteractionStudentExSkillGroupId { get; set; }
  public string InteractionSkillCardTexture { get; set; }
  public string InteractionSkillSpine { get; set; }
  public int RetreatFrame { get; set; }
  public int DestroyFrame { get; set; }

  public TacticalSupportSystemExcelT() {
    this.Id = 0;
    this.SummonedTime = 0;
    this.DefaultPersonalityId = 0;
    this.CanTargeting = false;
    this.CanCover = false;
    this.ObstacleUniqueName = null;
    this.ObstacleCoverRange = 0;
    this.SummonSkilllGroupId = null;
    this.CrashObstacleOBBWidth = 0;
    this.CrashObstacleOBBHeight = 0;
    this.IsTSSBlockedNodeCheck = false;
    this.NumberOfUses = 0;
    this.InventoryOffsetX = 0.0f;
    this.InventoryOffsetY = 0.0f;
    this.InventoryOffsetZ = 0.0f;
    this.InteractionChar = 0;
    this.CharacterInteractionStartDelay = 0;
    this.GetOnStartEffectPath = null;
    this.GetOnEndEffectPath = null;
    this.SummonerCharacterId = 0;
    this.InteractionFrame = 0;
    this.TSAInteractionAddDuration = 0;
    this.InteractionStudentExSkillGroupId = null;
    this.InteractionSkillCardTexture = null;
    this.InteractionSkillSpine = null;
    this.RetreatFrame = 0;
    this.DestroyFrame = 0;
  }
}


static public class TacticalSupportSystemExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*SummonedTime*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*DefaultPersonalityId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*CanTargeting*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 12 /*CanCover*/, 1 /*bool*/, 1, false)
      && verifier.VerifyString(tablePos, 14 /*ObstacleUniqueName*/, false)
      && verifier.VerifyField(tablePos, 16 /*ObstacleCoverRange*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 18 /*SummonSkilllGroupId*/, false)
      && verifier.VerifyField(tablePos, 20 /*CrashObstacleOBBWidth*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 22 /*CrashObstacleOBBHeight*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 24 /*IsTSSBlockedNodeCheck*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 26 /*NumberOfUses*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 28 /*InventoryOffsetX*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 30 /*InventoryOffsetY*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 32 /*InventoryOffsetZ*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 34 /*InteractionChar*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 36 /*CharacterInteractionStartDelay*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 38 /*GetOnStartEffectPath*/, false)
      && verifier.VerifyString(tablePos, 40 /*GetOnEndEffectPath*/, false)
      && verifier.VerifyField(tablePos, 42 /*SummonerCharacterId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 44 /*InteractionFrame*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 46 /*TSAInteractionAddDuration*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 48 /*InteractionStudentExSkillGroupId*/, false)
      && verifier.VerifyString(tablePos, 50 /*InteractionSkillCardTexture*/, false)
      && verifier.VerifyString(tablePos, 52 /*InteractionSkillSpine*/, false)
      && verifier.VerifyField(tablePos, 54 /*RetreatFrame*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 56 /*DestroyFrame*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
