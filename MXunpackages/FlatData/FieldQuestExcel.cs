// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct FieldQuestExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static FieldQuestExcel GetRootAsFieldQuestExcel(ByteBuffer _bb) { return GetRootAsFieldQuestExcel(_bb, new FieldQuestExcel()); }
  public static FieldQuestExcel GetRootAsFieldQuestExcel(ByteBuffer _bb, FieldQuestExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FieldQuestExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long FieldSeasonId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long UniqueId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool IsDaily { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long FieldDateId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Opendate { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string AssetPath { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAssetPathBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetAssetPathBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetAssetPathArray() { return __p.__vector_as_array<byte>(14); }
  public long RewardId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int Prob { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public uint QuestNamKey { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint QuestDescKey { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }

  public static Offset<Plana.FlatData.FieldQuestExcel> CreateFieldQuestExcel(FlatBufferBuilder builder,
      long FieldSeasonId = 0,
      long UniqueId = 0,
      bool IsDaily = false,
      long FieldDateId = 0,
      long Opendate = 0,
      StringOffset AssetPathOffset = default(StringOffset),
      long RewardId = 0,
      int Prob = 0,
      uint QuestNamKey = 0,
      uint QuestDescKey = 0) {
    builder.StartTable(10);
    FieldQuestExcel.AddRewardId(builder, RewardId);
    FieldQuestExcel.AddOpendate(builder, Opendate);
    FieldQuestExcel.AddFieldDateId(builder, FieldDateId);
    FieldQuestExcel.AddUniqueId(builder, UniqueId);
    FieldQuestExcel.AddFieldSeasonId(builder, FieldSeasonId);
    FieldQuestExcel.AddQuestDescKey(builder, QuestDescKey);
    FieldQuestExcel.AddQuestNamKey(builder, QuestNamKey);
    FieldQuestExcel.AddProb(builder, Prob);
    FieldQuestExcel.AddAssetPath(builder, AssetPathOffset);
    FieldQuestExcel.AddIsDaily(builder, IsDaily);
    return FieldQuestExcel.EndFieldQuestExcel(builder);
  }

  public static void StartFieldQuestExcel(FlatBufferBuilder builder) { builder.StartTable(10); }
  public static void AddFieldSeasonId(FlatBufferBuilder builder, long fieldSeasonId) { builder.AddLong(0, fieldSeasonId, 0); }
  public static void AddUniqueId(FlatBufferBuilder builder, long uniqueId) { builder.AddLong(1, uniqueId, 0); }
  public static void AddIsDaily(FlatBufferBuilder builder, bool isDaily) { builder.AddBool(2, isDaily, false); }
  public static void AddFieldDateId(FlatBufferBuilder builder, long fieldDateId) { builder.AddLong(3, fieldDateId, 0); }
  public static void AddOpendate(FlatBufferBuilder builder, long opendate) { builder.AddLong(4, opendate, 0); }
  public static void AddAssetPath(FlatBufferBuilder builder, StringOffset assetPathOffset) { builder.AddOffset(5, assetPathOffset.Value, 0); }
  public static void AddRewardId(FlatBufferBuilder builder, long rewardId) { builder.AddLong(6, rewardId, 0); }
  public static void AddProb(FlatBufferBuilder builder, int prob) { builder.AddInt(7, prob, 0); }
  public static void AddQuestNamKey(FlatBufferBuilder builder, uint questNamKey) { builder.AddUint(8, questNamKey, 0); }
  public static void AddQuestDescKey(FlatBufferBuilder builder, uint questDescKey) { builder.AddUint(9, questDescKey, 0); }
  public static Offset<Plana.FlatData.FieldQuestExcel> EndFieldQuestExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.FieldQuestExcel>(o);
  }
  public FieldQuestExcelT UnPack() {
    var _o = new FieldQuestExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FieldQuestExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("FieldQuest");
    _o.FieldSeasonId = TableEncryptionService.Convert(this.FieldSeasonId, key);
    _o.UniqueId = TableEncryptionService.Convert(this.UniqueId, key);
    _o.IsDaily = TableEncryptionService.Convert(this.IsDaily, key);
    _o.FieldDateId = TableEncryptionService.Convert(this.FieldDateId, key);
    _o.Opendate = TableEncryptionService.Convert(this.Opendate, key);
    _o.AssetPath = TableEncryptionService.Convert(this.AssetPath, key);
    _o.RewardId = TableEncryptionService.Convert(this.RewardId, key);
    _o.Prob = TableEncryptionService.Convert(this.Prob, key);
    _o.QuestNamKey = TableEncryptionService.Convert(this.QuestNamKey, key);
    _o.QuestDescKey = TableEncryptionService.Convert(this.QuestDescKey, key);
  }
  public static Offset<Plana.FlatData.FieldQuestExcel> Pack(FlatBufferBuilder builder, FieldQuestExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.FieldQuestExcel>);
    var _AssetPath = _o.AssetPath == null ? default(StringOffset) : builder.CreateString(_o.AssetPath);
    return CreateFieldQuestExcel(
      builder,
      _o.FieldSeasonId,
      _o.UniqueId,
      _o.IsDaily,
      _o.FieldDateId,
      _o.Opendate,
      _AssetPath,
      _o.RewardId,
      _o.Prob,
      _o.QuestNamKey,
      _o.QuestDescKey);
  }
}

public class FieldQuestExcelT
{
  public long FieldSeasonId { get; set; }
  public long UniqueId { get; set; }
  public bool IsDaily { get; set; }
  public long FieldDateId { get; set; }
  public long Opendate { get; set; }
  public string AssetPath { get; set; }
  public long RewardId { get; set; }
  public int Prob { get; set; }
  public uint QuestNamKey { get; set; }
  public uint QuestDescKey { get; set; }

  public FieldQuestExcelT() {
    this.FieldSeasonId = 0;
    this.UniqueId = 0;
    this.IsDaily = false;
    this.FieldDateId = 0;
    this.Opendate = 0;
    this.AssetPath = null;
    this.RewardId = 0;
    this.Prob = 0;
    this.QuestNamKey = 0;
    this.QuestDescKey = 0;
  }
}


static public class FieldQuestExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*FieldSeasonId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*UniqueId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*IsDaily*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 10 /*FieldDateId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*Opendate*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 14 /*AssetPath*/, false)
      && verifier.VerifyField(tablePos, 16 /*RewardId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*Prob*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 20 /*QuestNamKey*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*QuestDescKey*/, 4 /*uint*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
