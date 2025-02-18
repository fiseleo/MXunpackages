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

public struct CampaignStrategyObjectExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static CampaignStrategyObjectExcel GetRootAsCampaignStrategyObjectExcel(ByteBuffer _bb) { return GetRootAsCampaignStrategyObjectExcel(_bb, new CampaignStrategyObjectExcel()); }
  public static CampaignStrategyObjectExcel GetRootAsCampaignStrategyObjectExcel(ByteBuffer _bb, CampaignStrategyObjectExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CampaignStrategyObjectExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public uint Key { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string Name { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(8); }
  public string PrefabName { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPrefabNameBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetPrefabNameBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetPrefabNameArray() { return __p.__vector_as_array<byte>(10); }
  public Plana.FlatData.StrategyObjectType StrategyObjectType_ { get { int o = __p.__offset(12); return o != 0 ? (Plana.FlatData.StrategyObjectType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.StrategyObjectType.None; } }
  public Plana.FlatData.ParcelType StrategyRewardParcelType { get { int o = __p.__offset(14); return o != 0 ? (Plana.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ParcelType.None; } }
  public long StrategyRewardID { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string StrategyRewardName { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStrategyRewardNameBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetStrategyRewardNameBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetStrategyRewardNameArray() { return __p.__vector_as_array<byte>(18); }
  public int StrategyRewardAmount { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long StrategySightRange { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int PortalId { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int HealValue { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int SwithId { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int BuffId { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool Disposable { get { int o = __p.__offset(32); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<Plana.FlatData.CampaignStrategyObjectExcel> CreateCampaignStrategyObjectExcel(FlatBufferBuilder builder,
      long Id = 0,
      uint Key = 0,
      StringOffset NameOffset = default(StringOffset),
      StringOffset PrefabNameOffset = default(StringOffset),
      Plana.FlatData.StrategyObjectType StrategyObjectType_ = Plana.FlatData.StrategyObjectType.None,
      Plana.FlatData.ParcelType StrategyRewardParcelType = Plana.FlatData.ParcelType.None,
      long StrategyRewardID = 0,
      StringOffset StrategyRewardNameOffset = default(StringOffset),
      int StrategyRewardAmount = 0,
      long StrategySightRange = 0,
      int PortalId = 0,
      int HealValue = 0,
      int SwithId = 0,
      int BuffId = 0,
      bool Disposable = false) {
    builder.StartTable(15);
    CampaignStrategyObjectExcel.AddStrategySightRange(builder, StrategySightRange);
    CampaignStrategyObjectExcel.AddStrategyRewardID(builder, StrategyRewardID);
    CampaignStrategyObjectExcel.AddId(builder, Id);
    CampaignStrategyObjectExcel.AddBuffId(builder, BuffId);
    CampaignStrategyObjectExcel.AddSwithId(builder, SwithId);
    CampaignStrategyObjectExcel.AddHealValue(builder, HealValue);
    CampaignStrategyObjectExcel.AddPortalId(builder, PortalId);
    CampaignStrategyObjectExcel.AddStrategyRewardAmount(builder, StrategyRewardAmount);
    CampaignStrategyObjectExcel.AddStrategyRewardName(builder, StrategyRewardNameOffset);
    CampaignStrategyObjectExcel.AddStrategyRewardParcelType(builder, StrategyRewardParcelType);
    CampaignStrategyObjectExcel.AddStrategyObjectType_(builder, StrategyObjectType_);
    CampaignStrategyObjectExcel.AddPrefabName(builder, PrefabNameOffset);
    CampaignStrategyObjectExcel.AddName(builder, NameOffset);
    CampaignStrategyObjectExcel.AddKey(builder, Key);
    CampaignStrategyObjectExcel.AddDisposable(builder, Disposable);
    return CampaignStrategyObjectExcel.EndCampaignStrategyObjectExcel(builder);
  }

  public static void StartCampaignStrategyObjectExcel(FlatBufferBuilder builder) { builder.StartTable(15); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddKey(FlatBufferBuilder builder, uint key) { builder.AddUint(1, key, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(2, nameOffset.Value, 0); }
  public static void AddPrefabName(FlatBufferBuilder builder, StringOffset prefabNameOffset) { builder.AddOffset(3, prefabNameOffset.Value, 0); }
  public static void AddStrategyObjectType_(FlatBufferBuilder builder, Plana.FlatData.StrategyObjectType strategyObjectType_) { builder.AddInt(4, (int)strategyObjectType_, 0); }
  public static void AddStrategyRewardParcelType(FlatBufferBuilder builder, Plana.FlatData.ParcelType strategyRewardParcelType) { builder.AddInt(5, (int)strategyRewardParcelType, 0); }
  public static void AddStrategyRewardID(FlatBufferBuilder builder, long strategyRewardID) { builder.AddLong(6, strategyRewardID, 0); }
  public static void AddStrategyRewardName(FlatBufferBuilder builder, StringOffset strategyRewardNameOffset) { builder.AddOffset(7, strategyRewardNameOffset.Value, 0); }
  public static void AddStrategyRewardAmount(FlatBufferBuilder builder, int strategyRewardAmount) { builder.AddInt(8, strategyRewardAmount, 0); }
  public static void AddStrategySightRange(FlatBufferBuilder builder, long strategySightRange) { builder.AddLong(9, strategySightRange, 0); }
  public static void AddPortalId(FlatBufferBuilder builder, int portalId) { builder.AddInt(10, portalId, 0); }
  public static void AddHealValue(FlatBufferBuilder builder, int healValue) { builder.AddInt(11, healValue, 0); }
  public static void AddSwithId(FlatBufferBuilder builder, int swithId) { builder.AddInt(12, swithId, 0); }
  public static void AddBuffId(FlatBufferBuilder builder, int buffId) { builder.AddInt(13, buffId, 0); }
  public static void AddDisposable(FlatBufferBuilder builder, bool disposable) { builder.AddBool(14, disposable, false); }
  public static Offset<Plana.FlatData.CampaignStrategyObjectExcel> EndCampaignStrategyObjectExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.CampaignStrategyObjectExcel>(o);
  }
  public CampaignStrategyObjectExcelT UnPack() {
    var _o = new CampaignStrategyObjectExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CampaignStrategyObjectExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("CampaignStrategyObject");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.Key = TableEncryptionService.Convert(this.Key, key);
    _o.Name = TableEncryptionService.Convert(this.Name, key);
    _o.PrefabName = TableEncryptionService.Convert(this.PrefabName, key);
    _o.StrategyObjectType_ = TableEncryptionService.Convert(this.StrategyObjectType_, key);
    _o.StrategyRewardParcelType = TableEncryptionService.Convert(this.StrategyRewardParcelType, key);
    _o.StrategyRewardID = TableEncryptionService.Convert(this.StrategyRewardID, key);
    _o.StrategyRewardName = TableEncryptionService.Convert(this.StrategyRewardName, key);
    _o.StrategyRewardAmount = TableEncryptionService.Convert(this.StrategyRewardAmount, key);
    _o.StrategySightRange = TableEncryptionService.Convert(this.StrategySightRange, key);
    _o.PortalId = TableEncryptionService.Convert(this.PortalId, key);
    _o.HealValue = TableEncryptionService.Convert(this.HealValue, key);
    _o.SwithId = TableEncryptionService.Convert(this.SwithId, key);
    _o.BuffId = TableEncryptionService.Convert(this.BuffId, key);
    _o.Disposable = TableEncryptionService.Convert(this.Disposable, key);
  }
  public static Offset<Plana.FlatData.CampaignStrategyObjectExcel> Pack(FlatBufferBuilder builder, CampaignStrategyObjectExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.CampaignStrategyObjectExcel>);
    var _Name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _PrefabName = _o.PrefabName == null ? default(StringOffset) : builder.CreateString(_o.PrefabName);
    var _StrategyRewardName = _o.StrategyRewardName == null ? default(StringOffset) : builder.CreateString(_o.StrategyRewardName);
    return CreateCampaignStrategyObjectExcel(
      builder,
      _o.Id,
      _o.Key,
      _Name,
      _PrefabName,
      _o.StrategyObjectType_,
      _o.StrategyRewardParcelType,
      _o.StrategyRewardID,
      _StrategyRewardName,
      _o.StrategyRewardAmount,
      _o.StrategySightRange,
      _o.PortalId,
      _o.HealValue,
      _o.SwithId,
      _o.BuffId,
      _o.Disposable);
  }
}

public class CampaignStrategyObjectExcelT
{
  public long Id { get; set; }
  public uint Key { get; set; }
  public string Name { get; set; }
  public string PrefabName { get; set; }
  public Plana.FlatData.StrategyObjectType StrategyObjectType_ { get; set; }
  public Plana.FlatData.ParcelType StrategyRewardParcelType { get; set; }
  public long StrategyRewardID { get; set; }
  public string StrategyRewardName { get; set; }
  public int StrategyRewardAmount { get; set; }
  public long StrategySightRange { get; set; }
  public int PortalId { get; set; }
  public int HealValue { get; set; }
  public int SwithId { get; set; }
  public int BuffId { get; set; }
  public bool Disposable { get; set; }

  public CampaignStrategyObjectExcelT() {
    this.Id = 0;
    this.Key = 0;
    this.Name = null;
    this.PrefabName = null;
    this.StrategyObjectType_ = Plana.FlatData.StrategyObjectType.None;
    this.StrategyRewardParcelType = Plana.FlatData.ParcelType.None;
    this.StrategyRewardID = 0;
    this.StrategyRewardName = null;
    this.StrategyRewardAmount = 0;
    this.StrategySightRange = 0;
    this.PortalId = 0;
    this.HealValue = 0;
    this.SwithId = 0;
    this.BuffId = 0;
    this.Disposable = false;
  }
}


static public class CampaignStrategyObjectExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*Key*/, 4 /*uint*/, 4, false)
      && verifier.VerifyString(tablePos, 8 /*Name*/, false)
      && verifier.VerifyString(tablePos, 10 /*PrefabName*/, false)
      && verifier.VerifyField(tablePos, 12 /*StrategyObjectType_*/, 4 /*Plana.FlatData.StrategyObjectType*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*StrategyRewardParcelType*/, 4 /*Plana.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*StrategyRewardID*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 18 /*StrategyRewardName*/, false)
      && verifier.VerifyField(tablePos, 20 /*StrategyRewardAmount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*StrategySightRange*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 24 /*PortalId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 26 /*HealValue*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 28 /*SwithId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 30 /*BuffId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 32 /*Disposable*/, 1 /*bool*/, 1, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
