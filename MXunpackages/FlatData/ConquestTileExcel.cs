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

public struct ConquestTileExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ConquestTileExcel GetRootAsConquestTileExcel(ByteBuffer _bb) { return GetRootAsConquestTileExcel(_bb, new ConquestTileExcel()); }
  public static ConquestTileExcel GetRootAsConquestTileExcel(ByteBuffer _bb, ConquestTileExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConquestTileExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }
  public long EventId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int Step { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string PrefabName { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPrefabNameBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetPrefabNameBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetPrefabNameArray() { return __p.__vector_as_array<byte>(12); }
  public string TileNameLocalize { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTileNameLocalizeBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetTileNameLocalizeBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetTileNameLocalizeArray() { return __p.__vector_as_array<byte>(14); }
  public string TileImageName { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTileImageNameBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetTileImageNameBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetTileImageNameArray() { return __p.__vector_as_array<byte>(16); }
  public bool Playable { get { int o = __p.__offset(18); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public Plana.FlatData.ConquestTileType TileType { get { int o = __p.__offset(20); return o != 0 ? (Plana.FlatData.ConquestTileType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ConquestTileType.None; } }
  public bool NotMapFog { get { int o = __p.__offset(22); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long GroupBonusId { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.ParcelType ConquestCostType { get { int o = __p.__offset(26); return o != 0 ? (Plana.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ParcelType.None; } }
  public long ConquestCostId { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int ConquestCostAmount { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public Plana.FlatData.ParcelType ManageCostType { get { int o = __p.__offset(32); return o != 0 ? (Plana.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ParcelType.None; } }
  public long ManageCostId { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int ManageCostAmount { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long ConquestRewardId { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MassErosionId { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.ParcelType Upgrade2CostType { get { int o = __p.__offset(42); return o != 0 ? (Plana.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ParcelType.None; } }
  public long Upgrade2CostId { get { int o = __p.__offset(44); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int Upgrade2CostAmount { get { int o = __p.__offset(46); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public Plana.FlatData.ParcelType Upgrade3CostType { get { int o = __p.__offset(48); return o != 0 ? (Plana.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ParcelType.None; } }
  public long Upgrade3CostId { get { int o = __p.__offset(50); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int Upgrade3CostAmount { get { int o = __p.__offset(52); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<Plana.FlatData.ConquestTileExcel> CreateConquestTileExcel(FlatBufferBuilder builder,
      long Id = 0,
      StringOffset NameOffset = default(StringOffset),
      long EventId = 0,
      int Step = 0,
      StringOffset PrefabNameOffset = default(StringOffset),
      StringOffset TileNameLocalizeOffset = default(StringOffset),
      StringOffset TileImageNameOffset = default(StringOffset),
      bool Playable = false,
      Plana.FlatData.ConquestTileType TileType = Plana.FlatData.ConquestTileType.None,
      bool NotMapFog = false,
      long GroupBonusId = 0,
      Plana.FlatData.ParcelType ConquestCostType = Plana.FlatData.ParcelType.None,
      long ConquestCostId = 0,
      int ConquestCostAmount = 0,
      Plana.FlatData.ParcelType ManageCostType = Plana.FlatData.ParcelType.None,
      long ManageCostId = 0,
      int ManageCostAmount = 0,
      long ConquestRewardId = 0,
      long MassErosionId = 0,
      Plana.FlatData.ParcelType Upgrade2CostType = Plana.FlatData.ParcelType.None,
      long Upgrade2CostId = 0,
      int Upgrade2CostAmount = 0,
      Plana.FlatData.ParcelType Upgrade3CostType = Plana.FlatData.ParcelType.None,
      long Upgrade3CostId = 0,
      int Upgrade3CostAmount = 0) {
    builder.StartTable(25);
    ConquestTileExcel.AddUpgrade3CostId(builder, Upgrade3CostId);
    ConquestTileExcel.AddUpgrade2CostId(builder, Upgrade2CostId);
    ConquestTileExcel.AddMassErosionId(builder, MassErosionId);
    ConquestTileExcel.AddConquestRewardId(builder, ConquestRewardId);
    ConquestTileExcel.AddManageCostId(builder, ManageCostId);
    ConquestTileExcel.AddConquestCostId(builder, ConquestCostId);
    ConquestTileExcel.AddGroupBonusId(builder, GroupBonusId);
    ConquestTileExcel.AddEventId(builder, EventId);
    ConquestTileExcel.AddId(builder, Id);
    ConquestTileExcel.AddUpgrade3CostAmount(builder, Upgrade3CostAmount);
    ConquestTileExcel.AddUpgrade3CostType(builder, Upgrade3CostType);
    ConquestTileExcel.AddUpgrade2CostAmount(builder, Upgrade2CostAmount);
    ConquestTileExcel.AddUpgrade2CostType(builder, Upgrade2CostType);
    ConquestTileExcel.AddManageCostAmount(builder, ManageCostAmount);
    ConquestTileExcel.AddManageCostType(builder, ManageCostType);
    ConquestTileExcel.AddConquestCostAmount(builder, ConquestCostAmount);
    ConquestTileExcel.AddConquestCostType(builder, ConquestCostType);
    ConquestTileExcel.AddTileType(builder, TileType);
    ConquestTileExcel.AddTileImageName(builder, TileImageNameOffset);
    ConquestTileExcel.AddTileNameLocalize(builder, TileNameLocalizeOffset);
    ConquestTileExcel.AddPrefabName(builder, PrefabNameOffset);
    ConquestTileExcel.AddStep(builder, Step);
    ConquestTileExcel.AddName(builder, NameOffset);
    ConquestTileExcel.AddNotMapFog(builder, NotMapFog);
    ConquestTileExcel.AddPlayable(builder, Playable);
    return ConquestTileExcel.EndConquestTileExcel(builder);
  }

  public static void StartConquestTileExcel(FlatBufferBuilder builder) { builder.StartTable(25); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static void AddEventId(FlatBufferBuilder builder, long eventId) { builder.AddLong(2, eventId, 0); }
  public static void AddStep(FlatBufferBuilder builder, int step) { builder.AddInt(3, step, 0); }
  public static void AddPrefabName(FlatBufferBuilder builder, StringOffset prefabNameOffset) { builder.AddOffset(4, prefabNameOffset.Value, 0); }
  public static void AddTileNameLocalize(FlatBufferBuilder builder, StringOffset tileNameLocalizeOffset) { builder.AddOffset(5, tileNameLocalizeOffset.Value, 0); }
  public static void AddTileImageName(FlatBufferBuilder builder, StringOffset tileImageNameOffset) { builder.AddOffset(6, tileImageNameOffset.Value, 0); }
  public static void AddPlayable(FlatBufferBuilder builder, bool playable) { builder.AddBool(7, playable, false); }
  public static void AddTileType(FlatBufferBuilder builder, Plana.FlatData.ConquestTileType tileType) { builder.AddInt(8, (int)tileType, 0); }
  public static void AddNotMapFog(FlatBufferBuilder builder, bool notMapFog) { builder.AddBool(9, notMapFog, false); }
  public static void AddGroupBonusId(FlatBufferBuilder builder, long groupBonusId) { builder.AddLong(10, groupBonusId, 0); }
  public static void AddConquestCostType(FlatBufferBuilder builder, Plana.FlatData.ParcelType conquestCostType) { builder.AddInt(11, (int)conquestCostType, 0); }
  public static void AddConquestCostId(FlatBufferBuilder builder, long conquestCostId) { builder.AddLong(12, conquestCostId, 0); }
  public static void AddConquestCostAmount(FlatBufferBuilder builder, int conquestCostAmount) { builder.AddInt(13, conquestCostAmount, 0); }
  public static void AddManageCostType(FlatBufferBuilder builder, Plana.FlatData.ParcelType manageCostType) { builder.AddInt(14, (int)manageCostType, 0); }
  public static void AddManageCostId(FlatBufferBuilder builder, long manageCostId) { builder.AddLong(15, manageCostId, 0); }
  public static void AddManageCostAmount(FlatBufferBuilder builder, int manageCostAmount) { builder.AddInt(16, manageCostAmount, 0); }
  public static void AddConquestRewardId(FlatBufferBuilder builder, long conquestRewardId) { builder.AddLong(17, conquestRewardId, 0); }
  public static void AddMassErosionId(FlatBufferBuilder builder, long massErosionId) { builder.AddLong(18, massErosionId, 0); }
  public static void AddUpgrade2CostType(FlatBufferBuilder builder, Plana.FlatData.ParcelType upgrade2CostType) { builder.AddInt(19, (int)upgrade2CostType, 0); }
  public static void AddUpgrade2CostId(FlatBufferBuilder builder, long upgrade2CostId) { builder.AddLong(20, upgrade2CostId, 0); }
  public static void AddUpgrade2CostAmount(FlatBufferBuilder builder, int upgrade2CostAmount) { builder.AddInt(21, upgrade2CostAmount, 0); }
  public static void AddUpgrade3CostType(FlatBufferBuilder builder, Plana.FlatData.ParcelType upgrade3CostType) { builder.AddInt(22, (int)upgrade3CostType, 0); }
  public static void AddUpgrade3CostId(FlatBufferBuilder builder, long upgrade3CostId) { builder.AddLong(23, upgrade3CostId, 0); }
  public static void AddUpgrade3CostAmount(FlatBufferBuilder builder, int upgrade3CostAmount) { builder.AddInt(24, upgrade3CostAmount, 0); }
  public static Offset<Plana.FlatData.ConquestTileExcel> EndConquestTileExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.ConquestTileExcel>(o);
  }
  public ConquestTileExcelT UnPack() {
    var _o = new ConquestTileExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ConquestTileExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("ConquestTile");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.Name = TableEncryptionService.Convert(this.Name, key);
    _o.EventId = TableEncryptionService.Convert(this.EventId, key);
    _o.Step = TableEncryptionService.Convert(this.Step, key);
    _o.PrefabName = TableEncryptionService.Convert(this.PrefabName, key);
    _o.TileNameLocalize = TableEncryptionService.Convert(this.TileNameLocalize, key);
    _o.TileImageName = TableEncryptionService.Convert(this.TileImageName, key);
    _o.Playable = TableEncryptionService.Convert(this.Playable, key);
    _o.TileType = TableEncryptionService.Convert(this.TileType, key);
    _o.NotMapFog = TableEncryptionService.Convert(this.NotMapFog, key);
    _o.GroupBonusId = TableEncryptionService.Convert(this.GroupBonusId, key);
    _o.ConquestCostType = TableEncryptionService.Convert(this.ConquestCostType, key);
    _o.ConquestCostId = TableEncryptionService.Convert(this.ConquestCostId, key);
    _o.ConquestCostAmount = TableEncryptionService.Convert(this.ConquestCostAmount, key);
    _o.ManageCostType = TableEncryptionService.Convert(this.ManageCostType, key);
    _o.ManageCostId = TableEncryptionService.Convert(this.ManageCostId, key);
    _o.ManageCostAmount = TableEncryptionService.Convert(this.ManageCostAmount, key);
    _o.ConquestRewardId = TableEncryptionService.Convert(this.ConquestRewardId, key);
    _o.MassErosionId = TableEncryptionService.Convert(this.MassErosionId, key);
    _o.Upgrade2CostType = TableEncryptionService.Convert(this.Upgrade2CostType, key);
    _o.Upgrade2CostId = TableEncryptionService.Convert(this.Upgrade2CostId, key);
    _o.Upgrade2CostAmount = TableEncryptionService.Convert(this.Upgrade2CostAmount, key);
    _o.Upgrade3CostType = TableEncryptionService.Convert(this.Upgrade3CostType, key);
    _o.Upgrade3CostId = TableEncryptionService.Convert(this.Upgrade3CostId, key);
    _o.Upgrade3CostAmount = TableEncryptionService.Convert(this.Upgrade3CostAmount, key);
  }
  public static Offset<Plana.FlatData.ConquestTileExcel> Pack(FlatBufferBuilder builder, ConquestTileExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.ConquestTileExcel>);
    var _Name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _PrefabName = _o.PrefabName == null ? default(StringOffset) : builder.CreateString(_o.PrefabName);
    var _TileNameLocalize = _o.TileNameLocalize == null ? default(StringOffset) : builder.CreateString(_o.TileNameLocalize);
    var _TileImageName = _o.TileImageName == null ? default(StringOffset) : builder.CreateString(_o.TileImageName);
    return CreateConquestTileExcel(
      builder,
      _o.Id,
      _Name,
      _o.EventId,
      _o.Step,
      _PrefabName,
      _TileNameLocalize,
      _TileImageName,
      _o.Playable,
      _o.TileType,
      _o.NotMapFog,
      _o.GroupBonusId,
      _o.ConquestCostType,
      _o.ConquestCostId,
      _o.ConquestCostAmount,
      _o.ManageCostType,
      _o.ManageCostId,
      _o.ManageCostAmount,
      _o.ConquestRewardId,
      _o.MassErosionId,
      _o.Upgrade2CostType,
      _o.Upgrade2CostId,
      _o.Upgrade2CostAmount,
      _o.Upgrade3CostType,
      _o.Upgrade3CostId,
      _o.Upgrade3CostAmount);
  }
}

public class ConquestTileExcelT
{
  public long Id { get; set; }
  public string Name { get; set; }
  public long EventId { get; set; }
  public int Step { get; set; }
  public string PrefabName { get; set; }
  public string TileNameLocalize { get; set; }
  public string TileImageName { get; set; }
  public bool Playable { get; set; }
  public Plana.FlatData.ConquestTileType TileType { get; set; }
  public bool NotMapFog { get; set; }
  public long GroupBonusId { get; set; }
  public Plana.FlatData.ParcelType ConquestCostType { get; set; }
  public long ConquestCostId { get; set; }
  public int ConquestCostAmount { get; set; }
  public Plana.FlatData.ParcelType ManageCostType { get; set; }
  public long ManageCostId { get; set; }
  public int ManageCostAmount { get; set; }
  public long ConquestRewardId { get; set; }
  public long MassErosionId { get; set; }
  public Plana.FlatData.ParcelType Upgrade2CostType { get; set; }
  public long Upgrade2CostId { get; set; }
  public int Upgrade2CostAmount { get; set; }
  public Plana.FlatData.ParcelType Upgrade3CostType { get; set; }
  public long Upgrade3CostId { get; set; }
  public int Upgrade3CostAmount { get; set; }

  public ConquestTileExcelT() {
    this.Id = 0;
    this.Name = null;
    this.EventId = 0;
    this.Step = 0;
    this.PrefabName = null;
    this.TileNameLocalize = null;
    this.TileImageName = null;
    this.Playable = false;
    this.TileType = Plana.FlatData.ConquestTileType.None;
    this.NotMapFog = false;
    this.GroupBonusId = 0;
    this.ConquestCostType = Plana.FlatData.ParcelType.None;
    this.ConquestCostId = 0;
    this.ConquestCostAmount = 0;
    this.ManageCostType = Plana.FlatData.ParcelType.None;
    this.ManageCostId = 0;
    this.ManageCostAmount = 0;
    this.ConquestRewardId = 0;
    this.MassErosionId = 0;
    this.Upgrade2CostType = Plana.FlatData.ParcelType.None;
    this.Upgrade2CostId = 0;
    this.Upgrade2CostAmount = 0;
    this.Upgrade3CostType = Plana.FlatData.ParcelType.None;
    this.Upgrade3CostId = 0;
    this.Upgrade3CostAmount = 0;
  }
}


static public class ConquestTileExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 6 /*Name*/, false)
      && verifier.VerifyField(tablePos, 8 /*EventId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*Step*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 12 /*PrefabName*/, false)
      && verifier.VerifyString(tablePos, 14 /*TileNameLocalize*/, false)
      && verifier.VerifyString(tablePos, 16 /*TileImageName*/, false)
      && verifier.VerifyField(tablePos, 18 /*Playable*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 20 /*TileType*/, 4 /*Plana.FlatData.ConquestTileType*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*NotMapFog*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 24 /*GroupBonusId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 26 /*ConquestCostType*/, 4 /*Plana.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 28 /*ConquestCostId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 30 /*ConquestCostAmount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 32 /*ManageCostType*/, 4 /*Plana.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 34 /*ManageCostId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 36 /*ManageCostAmount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 38 /*ConquestRewardId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 40 /*MassErosionId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 42 /*Upgrade2CostType*/, 4 /*Plana.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 44 /*Upgrade2CostId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 46 /*Upgrade2CostAmount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 48 /*Upgrade3CostType*/, 4 /*Plana.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 50 /*Upgrade3CostId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 52 /*Upgrade3CostAmount*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
