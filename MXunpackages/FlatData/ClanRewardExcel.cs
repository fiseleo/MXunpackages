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

public struct ClanRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ClanRewardExcel GetRootAsClanRewardExcel(ByteBuffer _bb) { return GetRootAsClanRewardExcel(_bb, new ClanRewardExcel()); }
  public static ClanRewardExcel GetRootAsClanRewardExcel(ByteBuffer _bb, ClanRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ClanRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Plana.FlatData.ClanRewardType ClanRewardType_ { get { int o = __p.__offset(4); return o != 0 ? (Plana.FlatData.ClanRewardType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ClanRewardType.None; } }
  public Plana.FlatData.EchelonType EchelonType_ { get { int o = __p.__offset(6); return o != 0 ? (Plana.FlatData.EchelonType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.EchelonType.None; } }
  public Plana.FlatData.ParcelType RewardParcelType { get { int o = __p.__offset(8); return o != 0 ? (Plana.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ParcelType.None; } }
  public long RewardParcelId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RewardParcelAmount { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<Plana.FlatData.ClanRewardExcel> CreateClanRewardExcel(FlatBufferBuilder builder,
      Plana.FlatData.ClanRewardType ClanRewardType_ = Plana.FlatData.ClanRewardType.None,
      Plana.FlatData.EchelonType EchelonType_ = Plana.FlatData.EchelonType.None,
      Plana.FlatData.ParcelType RewardParcelType = Plana.FlatData.ParcelType.None,
      long RewardParcelId = 0,
      long RewardParcelAmount = 0) {
    builder.StartTable(5);
    ClanRewardExcel.AddRewardParcelAmount(builder, RewardParcelAmount);
    ClanRewardExcel.AddRewardParcelId(builder, RewardParcelId);
    ClanRewardExcel.AddRewardParcelType(builder, RewardParcelType);
    ClanRewardExcel.AddEchelonType_(builder, EchelonType_);
    ClanRewardExcel.AddClanRewardType_(builder, ClanRewardType_);
    return ClanRewardExcel.EndClanRewardExcel(builder);
  }

  public static void StartClanRewardExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddClanRewardType_(FlatBufferBuilder builder, Plana.FlatData.ClanRewardType clanRewardType_) { builder.AddInt(0, (int)clanRewardType_, 0); }
  public static void AddEchelonType_(FlatBufferBuilder builder, Plana.FlatData.EchelonType echelonType_) { builder.AddInt(1, (int)echelonType_, 0); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, Plana.FlatData.ParcelType rewardParcelType) { builder.AddInt(2, (int)rewardParcelType, 0); }
  public static void AddRewardParcelId(FlatBufferBuilder builder, long rewardParcelId) { builder.AddLong(3, rewardParcelId, 0); }
  public static void AddRewardParcelAmount(FlatBufferBuilder builder, long rewardParcelAmount) { builder.AddLong(4, rewardParcelAmount, 0); }
  public static Offset<Plana.FlatData.ClanRewardExcel> EndClanRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.ClanRewardExcel>(o);
  }
  public ClanRewardExcelT UnPack() {
    var _o = new ClanRewardExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ClanRewardExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("ClanReward");
    _o.ClanRewardType_ = TableEncryptionService.Convert(this.ClanRewardType_, key);
    _o.EchelonType_ = TableEncryptionService.Convert(this.EchelonType_, key);
    _o.RewardParcelType = TableEncryptionService.Convert(this.RewardParcelType, key);
    _o.RewardParcelId = TableEncryptionService.Convert(this.RewardParcelId, key);
    _o.RewardParcelAmount = TableEncryptionService.Convert(this.RewardParcelAmount, key);
  }
  public static Offset<Plana.FlatData.ClanRewardExcel> Pack(FlatBufferBuilder builder, ClanRewardExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.ClanRewardExcel>);
    return CreateClanRewardExcel(
      builder,
      _o.ClanRewardType_,
      _o.EchelonType_,
      _o.RewardParcelType,
      _o.RewardParcelId,
      _o.RewardParcelAmount);
  }
}

public class ClanRewardExcelT
{
  public Plana.FlatData.ClanRewardType ClanRewardType_ { get; set; }
  public Plana.FlatData.EchelonType EchelonType_ { get; set; }
  public Plana.FlatData.ParcelType RewardParcelType { get; set; }
  public long RewardParcelId { get; set; }
  public long RewardParcelAmount { get; set; }

  public ClanRewardExcelT() {
    this.ClanRewardType_ = Plana.FlatData.ClanRewardType.None;
    this.EchelonType_ = Plana.FlatData.EchelonType.None;
    this.RewardParcelType = Plana.FlatData.ParcelType.None;
    this.RewardParcelId = 0;
    this.RewardParcelAmount = 0;
  }
}


static public class ClanRewardExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*ClanRewardType_*/, 4 /*Plana.FlatData.ClanRewardType*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*EchelonType_*/, 4 /*Plana.FlatData.EchelonType*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*RewardParcelType*/, 4 /*Plana.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*RewardParcelId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*RewardParcelAmount*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
