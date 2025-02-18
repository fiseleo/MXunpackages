// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct MinigameTBGSeasonExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static MinigameTBGSeasonExcel GetRootAsMinigameTBGSeasonExcel(ByteBuffer _bb) { return GetRootAsMinigameTBGSeasonExcel(_bb, new MinigameTBGSeasonExcel()); }
  public static MinigameTBGSeasonExcel GetRootAsMinigameTBGSeasonExcel(ByteBuffer _bb, MinigameTBGSeasonExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MinigameTBGSeasonExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int ItemSlot { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int DefaultEchelonHp { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long DefaultItemDiceId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EchelonSlot1CharacterId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EchelonSlot2CharacterId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EchelonSlot3CharacterId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EchelonSlot4CharacterId { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string EchelonSlot1Portrait { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEchelonSlot1PortraitBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetEchelonSlot1PortraitBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetEchelonSlot1PortraitArray() { return __p.__vector_as_array<byte>(20); }
  public string EchelonSlot2Portrait { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEchelonSlot2PortraitBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetEchelonSlot2PortraitBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetEchelonSlot2PortraitArray() { return __p.__vector_as_array<byte>(22); }
  public string EchelonSlot3Portrait { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEchelonSlot3PortraitBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetEchelonSlot3PortraitBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetEchelonSlot3PortraitArray() { return __p.__vector_as_array<byte>(24); }
  public string EchelonSlot4Portrait { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEchelonSlot4PortraitBytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetEchelonSlot4PortraitBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetEchelonSlot4PortraitArray() { return __p.__vector_as_array<byte>(26); }
  public Plana.FlatData.ParcelType EventUseCostType { get { int o = __p.__offset(28); return o != 0 ? (Plana.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ParcelType.None; } }
  public long EventUseCostId { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.ParcelType EchelonRevivalCostType { get { int o = __p.__offset(32); return o != 0 ? (Plana.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ParcelType.None; } }
  public long EchelonRevivalCostId { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int EchelonRevivalCostAmount { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int EnemyBossHP { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int EnemyMinionHP { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int AttackDamage { get { int o = __p.__offset(42); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int CriticalAttackDamage { get { int o = __p.__offset(44); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RoundItemSelectLimit { get { int o = __p.__offset(46); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int InstantClearRound { get { int o = __p.__offset(48); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int MaxHp { get { int o = __p.__offset(50); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string MapImagePath { get { int o = __p.__offset(52); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMapImagePathBytes() { return __p.__vector_as_span<byte>(52, 1); }
#else
  public ArraySegment<byte>? GetMapImagePathBytes() { return __p.__vector_as_arraysegment(52); }
#endif
  public byte[] GetMapImagePathArray() { return __p.__vector_as_array<byte>(52); }
  public string MapNameLocalize { get { int o = __p.__offset(54); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMapNameLocalizeBytes() { return __p.__vector_as_span<byte>(54, 1); }
#else
  public ArraySegment<byte>? GetMapNameLocalizeBytes() { return __p.__vector_as_arraysegment(54); }
#endif
  public byte[] GetMapNameLocalizeArray() { return __p.__vector_as_array<byte>(54); }
  public int StartThemaIndex { get { int o = __p.__offset(56); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int LoopThemaIndex { get { int o = __p.__offset(58); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int MaxDicePlus { get { int o = __p.__offset(60); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<Plana.FlatData.MinigameTBGSeasonExcel> CreateMinigameTBGSeasonExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      int ItemSlot = 0,
      int DefaultEchelonHp = 0,
      long DefaultItemDiceId = 0,
      long EchelonSlot1CharacterId = 0,
      long EchelonSlot2CharacterId = 0,
      long EchelonSlot3CharacterId = 0,
      long EchelonSlot4CharacterId = 0,
      StringOffset EchelonSlot1PortraitOffset = default(StringOffset),
      StringOffset EchelonSlot2PortraitOffset = default(StringOffset),
      StringOffset EchelonSlot3PortraitOffset = default(StringOffset),
      StringOffset EchelonSlot4PortraitOffset = default(StringOffset),
      Plana.FlatData.ParcelType EventUseCostType = Plana.FlatData.ParcelType.None,
      long EventUseCostId = 0,
      Plana.FlatData.ParcelType EchelonRevivalCostType = Plana.FlatData.ParcelType.None,
      long EchelonRevivalCostId = 0,
      int EchelonRevivalCostAmount = 0,
      int EnemyBossHP = 0,
      int EnemyMinionHP = 0,
      int AttackDamage = 0,
      int CriticalAttackDamage = 0,
      int RoundItemSelectLimit = 0,
      int InstantClearRound = 0,
      int MaxHp = 0,
      StringOffset MapImagePathOffset = default(StringOffset),
      StringOffset MapNameLocalizeOffset = default(StringOffset),
      int StartThemaIndex = 0,
      int LoopThemaIndex = 0,
      int MaxDicePlus = 0) {
    builder.StartTable(29);
    MinigameTBGSeasonExcel.AddEchelonRevivalCostId(builder, EchelonRevivalCostId);
    MinigameTBGSeasonExcel.AddEventUseCostId(builder, EventUseCostId);
    MinigameTBGSeasonExcel.AddEchelonSlot4CharacterId(builder, EchelonSlot4CharacterId);
    MinigameTBGSeasonExcel.AddEchelonSlot3CharacterId(builder, EchelonSlot3CharacterId);
    MinigameTBGSeasonExcel.AddEchelonSlot2CharacterId(builder, EchelonSlot2CharacterId);
    MinigameTBGSeasonExcel.AddEchelonSlot1CharacterId(builder, EchelonSlot1CharacterId);
    MinigameTBGSeasonExcel.AddDefaultItemDiceId(builder, DefaultItemDiceId);
    MinigameTBGSeasonExcel.AddEventContentId(builder, EventContentId);
    MinigameTBGSeasonExcel.AddMaxDicePlus(builder, MaxDicePlus);
    MinigameTBGSeasonExcel.AddLoopThemaIndex(builder, LoopThemaIndex);
    MinigameTBGSeasonExcel.AddStartThemaIndex(builder, StartThemaIndex);
    MinigameTBGSeasonExcel.AddMapNameLocalize(builder, MapNameLocalizeOffset);
    MinigameTBGSeasonExcel.AddMapImagePath(builder, MapImagePathOffset);
    MinigameTBGSeasonExcel.AddMaxHp(builder, MaxHp);
    MinigameTBGSeasonExcel.AddInstantClearRound(builder, InstantClearRound);
    MinigameTBGSeasonExcel.AddRoundItemSelectLimit(builder, RoundItemSelectLimit);
    MinigameTBGSeasonExcel.AddCriticalAttackDamage(builder, CriticalAttackDamage);
    MinigameTBGSeasonExcel.AddAttackDamage(builder, AttackDamage);
    MinigameTBGSeasonExcel.AddEnemyMinionHP(builder, EnemyMinionHP);
    MinigameTBGSeasonExcel.AddEnemyBossHP(builder, EnemyBossHP);
    MinigameTBGSeasonExcel.AddEchelonRevivalCostAmount(builder, EchelonRevivalCostAmount);
    MinigameTBGSeasonExcel.AddEchelonRevivalCostType(builder, EchelonRevivalCostType);
    MinigameTBGSeasonExcel.AddEventUseCostType(builder, EventUseCostType);
    MinigameTBGSeasonExcel.AddEchelonSlot4Portrait(builder, EchelonSlot4PortraitOffset);
    MinigameTBGSeasonExcel.AddEchelonSlot3Portrait(builder, EchelonSlot3PortraitOffset);
    MinigameTBGSeasonExcel.AddEchelonSlot2Portrait(builder, EchelonSlot2PortraitOffset);
    MinigameTBGSeasonExcel.AddEchelonSlot1Portrait(builder, EchelonSlot1PortraitOffset);
    MinigameTBGSeasonExcel.AddDefaultEchelonHp(builder, DefaultEchelonHp);
    MinigameTBGSeasonExcel.AddItemSlot(builder, ItemSlot);
    return MinigameTBGSeasonExcel.EndMinigameTBGSeasonExcel(builder);
  }

  public static void StartMinigameTBGSeasonExcel(FlatBufferBuilder builder) { builder.StartTable(29); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(0, eventContentId, 0); }
  public static void AddItemSlot(FlatBufferBuilder builder, int itemSlot) { builder.AddInt(1, itemSlot, 0); }
  public static void AddDefaultEchelonHp(FlatBufferBuilder builder, int defaultEchelonHp) { builder.AddInt(2, defaultEchelonHp, 0); }
  public static void AddDefaultItemDiceId(FlatBufferBuilder builder, long defaultItemDiceId) { builder.AddLong(3, defaultItemDiceId, 0); }
  public static void AddEchelonSlot1CharacterId(FlatBufferBuilder builder, long echelonSlot1CharacterId) { builder.AddLong(4, echelonSlot1CharacterId, 0); }
  public static void AddEchelonSlot2CharacterId(FlatBufferBuilder builder, long echelonSlot2CharacterId) { builder.AddLong(5, echelonSlot2CharacterId, 0); }
  public static void AddEchelonSlot3CharacterId(FlatBufferBuilder builder, long echelonSlot3CharacterId) { builder.AddLong(6, echelonSlot3CharacterId, 0); }
  public static void AddEchelonSlot4CharacterId(FlatBufferBuilder builder, long echelonSlot4CharacterId) { builder.AddLong(7, echelonSlot4CharacterId, 0); }
  public static void AddEchelonSlot1Portrait(FlatBufferBuilder builder, StringOffset echelonSlot1PortraitOffset) { builder.AddOffset(8, echelonSlot1PortraitOffset.Value, 0); }
  public static void AddEchelonSlot2Portrait(FlatBufferBuilder builder, StringOffset echelonSlot2PortraitOffset) { builder.AddOffset(9, echelonSlot2PortraitOffset.Value, 0); }
  public static void AddEchelonSlot3Portrait(FlatBufferBuilder builder, StringOffset echelonSlot3PortraitOffset) { builder.AddOffset(10, echelonSlot3PortraitOffset.Value, 0); }
  public static void AddEchelonSlot4Portrait(FlatBufferBuilder builder, StringOffset echelonSlot4PortraitOffset) { builder.AddOffset(11, echelonSlot4PortraitOffset.Value, 0); }
  public static void AddEventUseCostType(FlatBufferBuilder builder, Plana.FlatData.ParcelType eventUseCostType) { builder.AddInt(12, (int)eventUseCostType, 0); }
  public static void AddEventUseCostId(FlatBufferBuilder builder, long eventUseCostId) { builder.AddLong(13, eventUseCostId, 0); }
  public static void AddEchelonRevivalCostType(FlatBufferBuilder builder, Plana.FlatData.ParcelType echelonRevivalCostType) { builder.AddInt(14, (int)echelonRevivalCostType, 0); }
  public static void AddEchelonRevivalCostId(FlatBufferBuilder builder, long echelonRevivalCostId) { builder.AddLong(15, echelonRevivalCostId, 0); }
  public static void AddEchelonRevivalCostAmount(FlatBufferBuilder builder, int echelonRevivalCostAmount) { builder.AddInt(16, echelonRevivalCostAmount, 0); }
  public static void AddEnemyBossHP(FlatBufferBuilder builder, int enemyBossHP) { builder.AddInt(17, enemyBossHP, 0); }
  public static void AddEnemyMinionHP(FlatBufferBuilder builder, int enemyMinionHP) { builder.AddInt(18, enemyMinionHP, 0); }
  public static void AddAttackDamage(FlatBufferBuilder builder, int attackDamage) { builder.AddInt(19, attackDamage, 0); }
  public static void AddCriticalAttackDamage(FlatBufferBuilder builder, int criticalAttackDamage) { builder.AddInt(20, criticalAttackDamage, 0); }
  public static void AddRoundItemSelectLimit(FlatBufferBuilder builder, int roundItemSelectLimit) { builder.AddInt(21, roundItemSelectLimit, 0); }
  public static void AddInstantClearRound(FlatBufferBuilder builder, int instantClearRound) { builder.AddInt(22, instantClearRound, 0); }
  public static void AddMaxHp(FlatBufferBuilder builder, int maxHp) { builder.AddInt(23, maxHp, 0); }
  public static void AddMapImagePath(FlatBufferBuilder builder, StringOffset mapImagePathOffset) { builder.AddOffset(24, mapImagePathOffset.Value, 0); }
  public static void AddMapNameLocalize(FlatBufferBuilder builder, StringOffset mapNameLocalizeOffset) { builder.AddOffset(25, mapNameLocalizeOffset.Value, 0); }
  public static void AddStartThemaIndex(FlatBufferBuilder builder, int startThemaIndex) { builder.AddInt(26, startThemaIndex, 0); }
  public static void AddLoopThemaIndex(FlatBufferBuilder builder, int loopThemaIndex) { builder.AddInt(27, loopThemaIndex, 0); }
  public static void AddMaxDicePlus(FlatBufferBuilder builder, int maxDicePlus) { builder.AddInt(28, maxDicePlus, 0); }
  public static Offset<Plana.FlatData.MinigameTBGSeasonExcel> EndMinigameTBGSeasonExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.MinigameTBGSeasonExcel>(o);
  }
  public MinigameTBGSeasonExcelT UnPack() {
    var _o = new MinigameTBGSeasonExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(MinigameTBGSeasonExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("MinigameTBGSeason");
    _o.EventContentId = TableEncryptionService.Convert(this.EventContentId, key);
    _o.ItemSlot = TableEncryptionService.Convert(this.ItemSlot, key);
    _o.DefaultEchelonHp = TableEncryptionService.Convert(this.DefaultEchelonHp, key);
    _o.DefaultItemDiceId = TableEncryptionService.Convert(this.DefaultItemDiceId, key);
    _o.EchelonSlot1CharacterId = TableEncryptionService.Convert(this.EchelonSlot1CharacterId, key);
    _o.EchelonSlot2CharacterId = TableEncryptionService.Convert(this.EchelonSlot2CharacterId, key);
    _o.EchelonSlot3CharacterId = TableEncryptionService.Convert(this.EchelonSlot3CharacterId, key);
    _o.EchelonSlot4CharacterId = TableEncryptionService.Convert(this.EchelonSlot4CharacterId, key);
    _o.EchelonSlot1Portrait = TableEncryptionService.Convert(this.EchelonSlot1Portrait, key);
    _o.EchelonSlot2Portrait = TableEncryptionService.Convert(this.EchelonSlot2Portrait, key);
    _o.EchelonSlot3Portrait = TableEncryptionService.Convert(this.EchelonSlot3Portrait, key);
    _o.EchelonSlot4Portrait = TableEncryptionService.Convert(this.EchelonSlot4Portrait, key);
    _o.EventUseCostType = TableEncryptionService.Convert(this.EventUseCostType, key);
    _o.EventUseCostId = TableEncryptionService.Convert(this.EventUseCostId, key);
    _o.EchelonRevivalCostType = TableEncryptionService.Convert(this.EchelonRevivalCostType, key);
    _o.EchelonRevivalCostId = TableEncryptionService.Convert(this.EchelonRevivalCostId, key);
    _o.EchelonRevivalCostAmount = TableEncryptionService.Convert(this.EchelonRevivalCostAmount, key);
    _o.EnemyBossHP = TableEncryptionService.Convert(this.EnemyBossHP, key);
    _o.EnemyMinionHP = TableEncryptionService.Convert(this.EnemyMinionHP, key);
    _o.AttackDamage = TableEncryptionService.Convert(this.AttackDamage, key);
    _o.CriticalAttackDamage = TableEncryptionService.Convert(this.CriticalAttackDamage, key);
    _o.RoundItemSelectLimit = TableEncryptionService.Convert(this.RoundItemSelectLimit, key);
    _o.InstantClearRound = TableEncryptionService.Convert(this.InstantClearRound, key);
    _o.MaxHp = TableEncryptionService.Convert(this.MaxHp, key);
    _o.MapImagePath = TableEncryptionService.Convert(this.MapImagePath, key);
    _o.MapNameLocalize = TableEncryptionService.Convert(this.MapNameLocalize, key);
    _o.StartThemaIndex = TableEncryptionService.Convert(this.StartThemaIndex, key);
    _o.LoopThemaIndex = TableEncryptionService.Convert(this.LoopThemaIndex, key);
    _o.MaxDicePlus = TableEncryptionService.Convert(this.MaxDicePlus, key);
  }
  public static Offset<Plana.FlatData.MinigameTBGSeasonExcel> Pack(FlatBufferBuilder builder, MinigameTBGSeasonExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.MinigameTBGSeasonExcel>);
    var _EchelonSlot1Portrait = _o.EchelonSlot1Portrait == null ? default(StringOffset) : builder.CreateString(_o.EchelonSlot1Portrait);
    var _EchelonSlot2Portrait = _o.EchelonSlot2Portrait == null ? default(StringOffset) : builder.CreateString(_o.EchelonSlot2Portrait);
    var _EchelonSlot3Portrait = _o.EchelonSlot3Portrait == null ? default(StringOffset) : builder.CreateString(_o.EchelonSlot3Portrait);
    var _EchelonSlot4Portrait = _o.EchelonSlot4Portrait == null ? default(StringOffset) : builder.CreateString(_o.EchelonSlot4Portrait);
    var _MapImagePath = _o.MapImagePath == null ? default(StringOffset) : builder.CreateString(_o.MapImagePath);
    var _MapNameLocalize = _o.MapNameLocalize == null ? default(StringOffset) : builder.CreateString(_o.MapNameLocalize);
    return CreateMinigameTBGSeasonExcel(
      builder,
      _o.EventContentId,
      _o.ItemSlot,
      _o.DefaultEchelonHp,
      _o.DefaultItemDiceId,
      _o.EchelonSlot1CharacterId,
      _o.EchelonSlot2CharacterId,
      _o.EchelonSlot3CharacterId,
      _o.EchelonSlot4CharacterId,
      _EchelonSlot1Portrait,
      _EchelonSlot2Portrait,
      _EchelonSlot3Portrait,
      _EchelonSlot4Portrait,
      _o.EventUseCostType,
      _o.EventUseCostId,
      _o.EchelonRevivalCostType,
      _o.EchelonRevivalCostId,
      _o.EchelonRevivalCostAmount,
      _o.EnemyBossHP,
      _o.EnemyMinionHP,
      _o.AttackDamage,
      _o.CriticalAttackDamage,
      _o.RoundItemSelectLimit,
      _o.InstantClearRound,
      _o.MaxHp,
      _MapImagePath,
      _MapNameLocalize,
      _o.StartThemaIndex,
      _o.LoopThemaIndex,
      _o.MaxDicePlus);
  }
}

public class MinigameTBGSeasonExcelT
{
  public long EventContentId { get; set; }
  public int ItemSlot { get; set; }
  public int DefaultEchelonHp { get; set; }
  public long DefaultItemDiceId { get; set; }
  public long EchelonSlot1CharacterId { get; set; }
  public long EchelonSlot2CharacterId { get; set; }
  public long EchelonSlot3CharacterId { get; set; }
  public long EchelonSlot4CharacterId { get; set; }
  public string EchelonSlot1Portrait { get; set; }
  public string EchelonSlot2Portrait { get; set; }
  public string EchelonSlot3Portrait { get; set; }
  public string EchelonSlot4Portrait { get; set; }
  public Plana.FlatData.ParcelType EventUseCostType { get; set; }
  public long EventUseCostId { get; set; }
  public Plana.FlatData.ParcelType EchelonRevivalCostType { get; set; }
  public long EchelonRevivalCostId { get; set; }
  public int EchelonRevivalCostAmount { get; set; }
  public int EnemyBossHP { get; set; }
  public int EnemyMinionHP { get; set; }
  public int AttackDamage { get; set; }
  public int CriticalAttackDamage { get; set; }
  public int RoundItemSelectLimit { get; set; }
  public int InstantClearRound { get; set; }
  public int MaxHp { get; set; }
  public string MapImagePath { get; set; }
  public string MapNameLocalize { get; set; }
  public int StartThemaIndex { get; set; }
  public int LoopThemaIndex { get; set; }
  public int MaxDicePlus { get; set; }

  public MinigameTBGSeasonExcelT() {
    this.EventContentId = 0;
    this.ItemSlot = 0;
    this.DefaultEchelonHp = 0;
    this.DefaultItemDiceId = 0;
    this.EchelonSlot1CharacterId = 0;
    this.EchelonSlot2CharacterId = 0;
    this.EchelonSlot3CharacterId = 0;
    this.EchelonSlot4CharacterId = 0;
    this.EchelonSlot1Portrait = null;
    this.EchelonSlot2Portrait = null;
    this.EchelonSlot3Portrait = null;
    this.EchelonSlot4Portrait = null;
    this.EventUseCostType = Plana.FlatData.ParcelType.None;
    this.EventUseCostId = 0;
    this.EchelonRevivalCostType = Plana.FlatData.ParcelType.None;
    this.EchelonRevivalCostId = 0;
    this.EchelonRevivalCostAmount = 0;
    this.EnemyBossHP = 0;
    this.EnemyMinionHP = 0;
    this.AttackDamage = 0;
    this.CriticalAttackDamage = 0;
    this.RoundItemSelectLimit = 0;
    this.InstantClearRound = 0;
    this.MaxHp = 0;
    this.MapImagePath = null;
    this.MapNameLocalize = null;
    this.StartThemaIndex = 0;
    this.LoopThemaIndex = 0;
    this.MaxDicePlus = 0;
  }
}


static public class MinigameTBGSeasonExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*ItemSlot*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*DefaultEchelonHp*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*DefaultItemDiceId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*EchelonSlot1CharacterId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*EchelonSlot2CharacterId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*EchelonSlot3CharacterId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*EchelonSlot4CharacterId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 20 /*EchelonSlot1Portrait*/, false)
      && verifier.VerifyString(tablePos, 22 /*EchelonSlot2Portrait*/, false)
      && verifier.VerifyString(tablePos, 24 /*EchelonSlot3Portrait*/, false)
      && verifier.VerifyString(tablePos, 26 /*EchelonSlot4Portrait*/, false)
      && verifier.VerifyField(tablePos, 28 /*EventUseCostType*/, 4 /*Plana.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 30 /*EventUseCostId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 32 /*EchelonRevivalCostType*/, 4 /*Plana.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 34 /*EchelonRevivalCostId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 36 /*EchelonRevivalCostAmount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 38 /*EnemyBossHP*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 40 /*EnemyMinionHP*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 42 /*AttackDamage*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 44 /*CriticalAttackDamage*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 46 /*RoundItemSelectLimit*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 48 /*InstantClearRound*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 50 /*MaxHp*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 52 /*MapImagePath*/, false)
      && verifier.VerifyString(tablePos, 54 /*MapNameLocalize*/, false)
      && verifier.VerifyField(tablePos, 56 /*StartThemaIndex*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 58 /*LoopThemaIndex*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 60 /*MaxDicePlus*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
