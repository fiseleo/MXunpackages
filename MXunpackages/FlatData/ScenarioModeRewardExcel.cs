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

public struct ScenarioModeRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ScenarioModeRewardExcel GetRootAsScenarioModeRewardExcel(ByteBuffer _bb) { return GetRootAsScenarioModeRewardExcel(_bb, new ScenarioModeRewardExcel()); }
  public static ScenarioModeRewardExcel GetRootAsScenarioModeRewardExcel(ByteBuffer _bb, ScenarioModeRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ScenarioModeRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long ScenarioModeRewardId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.RewardTag RewardTag_ { get { int o = __p.__offset(6); return o != 0 ? (Plana.FlatData.RewardTag)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.RewardTag.Default; } }
  public int RewardProb { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public Plana.FlatData.ParcelType RewardParcelType { get { int o = __p.__offset(10); return o != 0 ? (Plana.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ParcelType.None; } }
  public long RewardParcelId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int RewardParcelAmount { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool IsDisplayed { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<Plana.FlatData.ScenarioModeRewardExcel> CreateScenarioModeRewardExcel(FlatBufferBuilder builder,
      long ScenarioModeRewardId = 0,
      Plana.FlatData.RewardTag RewardTag_ = Plana.FlatData.RewardTag.Default,
      int RewardProb = 0,
      Plana.FlatData.ParcelType RewardParcelType = Plana.FlatData.ParcelType.None,
      long RewardParcelId = 0,
      int RewardParcelAmount = 0,
      bool IsDisplayed = false) {
    builder.StartTable(7);
    ScenarioModeRewardExcel.AddRewardParcelId(builder, RewardParcelId);
    ScenarioModeRewardExcel.AddScenarioModeRewardId(builder, ScenarioModeRewardId);
    ScenarioModeRewardExcel.AddRewardParcelAmount(builder, RewardParcelAmount);
    ScenarioModeRewardExcel.AddRewardParcelType(builder, RewardParcelType);
    ScenarioModeRewardExcel.AddRewardProb(builder, RewardProb);
    ScenarioModeRewardExcel.AddRewardTag_(builder, RewardTag_);
    ScenarioModeRewardExcel.AddIsDisplayed(builder, IsDisplayed);
    return ScenarioModeRewardExcel.EndScenarioModeRewardExcel(builder);
  }

  public static void StartScenarioModeRewardExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddScenarioModeRewardId(FlatBufferBuilder builder, long scenarioModeRewardId) { builder.AddLong(0, scenarioModeRewardId, 0); }
  public static void AddRewardTag_(FlatBufferBuilder builder, Plana.FlatData.RewardTag rewardTag_) { builder.AddInt(1, (int)rewardTag_, 0); }
  public static void AddRewardProb(FlatBufferBuilder builder, int rewardProb) { builder.AddInt(2, rewardProb, 0); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, Plana.FlatData.ParcelType rewardParcelType) { builder.AddInt(3, (int)rewardParcelType, 0); }
  public static void AddRewardParcelId(FlatBufferBuilder builder, long rewardParcelId) { builder.AddLong(4, rewardParcelId, 0); }
  public static void AddRewardParcelAmount(FlatBufferBuilder builder, int rewardParcelAmount) { builder.AddInt(5, rewardParcelAmount, 0); }
  public static void AddIsDisplayed(FlatBufferBuilder builder, bool isDisplayed) { builder.AddBool(6, isDisplayed, false); }
  public static Offset<Plana.FlatData.ScenarioModeRewardExcel> EndScenarioModeRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.ScenarioModeRewardExcel>(o);
  }
  public ScenarioModeRewardExcelT UnPack() {
    var _o = new ScenarioModeRewardExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ScenarioModeRewardExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("ScenarioModeReward");
    _o.ScenarioModeRewardId = TableEncryptionService.Convert(this.ScenarioModeRewardId, key);
    _o.RewardTag_ = TableEncryptionService.Convert(this.RewardTag_, key);
    _o.RewardProb = TableEncryptionService.Convert(this.RewardProb, key);
    _o.RewardParcelType = TableEncryptionService.Convert(this.RewardParcelType, key);
    _o.RewardParcelId = TableEncryptionService.Convert(this.RewardParcelId, key);
    _o.RewardParcelAmount = TableEncryptionService.Convert(this.RewardParcelAmount, key);
    _o.IsDisplayed = TableEncryptionService.Convert(this.IsDisplayed, key);
  }
  public static Offset<Plana.FlatData.ScenarioModeRewardExcel> Pack(FlatBufferBuilder builder, ScenarioModeRewardExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.ScenarioModeRewardExcel>);
    return CreateScenarioModeRewardExcel(
      builder,
      _o.ScenarioModeRewardId,
      _o.RewardTag_,
      _o.RewardProb,
      _o.RewardParcelType,
      _o.RewardParcelId,
      _o.RewardParcelAmount,
      _o.IsDisplayed);
  }
}

public class ScenarioModeRewardExcelT
{
  public long ScenarioModeRewardId { get; set; }
  public Plana.FlatData.RewardTag RewardTag_ { get; set; }
  public int RewardProb { get; set; }
  public Plana.FlatData.ParcelType RewardParcelType { get; set; }
  public long RewardParcelId { get; set; }
  public int RewardParcelAmount { get; set; }
  public bool IsDisplayed { get; set; }

  public ScenarioModeRewardExcelT() {
    this.ScenarioModeRewardId = 0;
    this.RewardTag_ = Plana.FlatData.RewardTag.Default;
    this.RewardProb = 0;
    this.RewardParcelType = Plana.FlatData.ParcelType.None;
    this.RewardParcelId = 0;
    this.RewardParcelAmount = 0;
    this.IsDisplayed = false;
  }
}


static public class ScenarioModeRewardExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*ScenarioModeRewardId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*RewardTag_*/, 4 /*Plana.FlatData.RewardTag*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*RewardProb*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*RewardParcelType*/, 4 /*Plana.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*RewardParcelId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*RewardParcelAmount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*IsDisplayed*/, 1 /*bool*/, 1, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
