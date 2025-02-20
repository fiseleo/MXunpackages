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

public struct MinigameTBGEncounterRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static MinigameTBGEncounterRewardExcel GetRootAsMinigameTBGEncounterRewardExcel(ByteBuffer _bb) { return GetRootAsMinigameTBGEncounterRewardExcel(_bb, new MinigameTBGEncounterRewardExcel()); }
  public static MinigameTBGEncounterRewardExcel GetRootAsMinigameTBGEncounterRewardExcel(ByteBuffer _bb, MinigameTBGEncounterRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MinigameTBGEncounterRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long GroupId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long UniqueId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.TBGOptionSuccessType TBGOptionSuccessType_ { get { int o = __p.__offset(8); return o != 0 ? (Plana.FlatData.TBGOptionSuccessType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.TBGOptionSuccessType.None; } }
  public long Paremeter { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.ParcelType ParcelType_ { get { int o = __p.__offset(12); return o != 0 ? (Plana.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ParcelType.None; } }
  public long ParcelId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Amount { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int Prob { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<Plana.FlatData.MinigameTBGEncounterRewardExcel> CreateMinigameTBGEncounterRewardExcel(FlatBufferBuilder builder,
      long GroupId = 0,
      long UniqueId = 0,
      Plana.FlatData.TBGOptionSuccessType TBGOptionSuccessType_ = Plana.FlatData.TBGOptionSuccessType.None,
      long Paremeter = 0,
      Plana.FlatData.ParcelType ParcelType_ = Plana.FlatData.ParcelType.None,
      long ParcelId = 0,
      long Amount = 0,
      int Prob = 0) {
    builder.StartTable(8);
    MinigameTBGEncounterRewardExcel.AddAmount(builder, Amount);
    MinigameTBGEncounterRewardExcel.AddParcelId(builder, ParcelId);
    MinigameTBGEncounterRewardExcel.AddParemeter(builder, Paremeter);
    MinigameTBGEncounterRewardExcel.AddUniqueId(builder, UniqueId);
    MinigameTBGEncounterRewardExcel.AddGroupId(builder, GroupId);
    MinigameTBGEncounterRewardExcel.AddProb(builder, Prob);
    MinigameTBGEncounterRewardExcel.AddParcelType_(builder, ParcelType_);
    MinigameTBGEncounterRewardExcel.AddTBGOptionSuccessType_(builder, TBGOptionSuccessType_);
    return MinigameTBGEncounterRewardExcel.EndMinigameTBGEncounterRewardExcel(builder);
  }

  public static void StartMinigameTBGEncounterRewardExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddGroupId(FlatBufferBuilder builder, long groupId) { builder.AddLong(0, groupId, 0); }
  public static void AddUniqueId(FlatBufferBuilder builder, long uniqueId) { builder.AddLong(1, uniqueId, 0); }
  public static void AddTBGOptionSuccessType_(FlatBufferBuilder builder, Plana.FlatData.TBGOptionSuccessType tBGOptionSuccessType_) { builder.AddInt(2, (int)tBGOptionSuccessType_, 0); }
  public static void AddParemeter(FlatBufferBuilder builder, long paremeter) { builder.AddLong(3, paremeter, 0); }
  public static void AddParcelType_(FlatBufferBuilder builder, Plana.FlatData.ParcelType parcelType_) { builder.AddInt(4, (int)parcelType_, 0); }
  public static void AddParcelId(FlatBufferBuilder builder, long parcelId) { builder.AddLong(5, parcelId, 0); }
  public static void AddAmount(FlatBufferBuilder builder, long amount) { builder.AddLong(6, amount, 0); }
  public static void AddProb(FlatBufferBuilder builder, int prob) { builder.AddInt(7, prob, 0); }
  public static Offset<Plana.FlatData.MinigameTBGEncounterRewardExcel> EndMinigameTBGEncounterRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.MinigameTBGEncounterRewardExcel>(o);
  }
  public MinigameTBGEncounterRewardExcelT UnPack() {
    var _o = new MinigameTBGEncounterRewardExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(MinigameTBGEncounterRewardExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("MinigameTBGEncounterReward");
    _o.GroupId = TableEncryptionService.Convert(this.GroupId, key);
    _o.UniqueId = TableEncryptionService.Convert(this.UniqueId, key);
    _o.TBGOptionSuccessType_ = TableEncryptionService.Convert(this.TBGOptionSuccessType_, key);
    _o.Paremeter = TableEncryptionService.Convert(this.Paremeter, key);
    _o.ParcelType_ = TableEncryptionService.Convert(this.ParcelType_, key);
    _o.ParcelId = TableEncryptionService.Convert(this.ParcelId, key);
    _o.Amount = TableEncryptionService.Convert(this.Amount, key);
    _o.Prob = TableEncryptionService.Convert(this.Prob, key);
  }
  public static Offset<Plana.FlatData.MinigameTBGEncounterRewardExcel> Pack(FlatBufferBuilder builder, MinigameTBGEncounterRewardExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.MinigameTBGEncounterRewardExcel>);
    return CreateMinigameTBGEncounterRewardExcel(
      builder,
      _o.GroupId,
      _o.UniqueId,
      _o.TBGOptionSuccessType_,
      _o.Paremeter,
      _o.ParcelType_,
      _o.ParcelId,
      _o.Amount,
      _o.Prob);
  }
}

public class MinigameTBGEncounterRewardExcelT
{
  public long GroupId { get; set; }
  public long UniqueId { get; set; }
  public Plana.FlatData.TBGOptionSuccessType TBGOptionSuccessType_ { get; set; }
  public long Paremeter { get; set; }
  public Plana.FlatData.ParcelType ParcelType_ { get; set; }
  public long ParcelId { get; set; }
  public long Amount { get; set; }
  public int Prob { get; set; }

  public MinigameTBGEncounterRewardExcelT() {
    this.GroupId = 0;
    this.UniqueId = 0;
    this.TBGOptionSuccessType_ = Plana.FlatData.TBGOptionSuccessType.None;
    this.Paremeter = 0;
    this.ParcelType_ = Plana.FlatData.ParcelType.None;
    this.ParcelId = 0;
    this.Amount = 0;
    this.Prob = 0;
  }
}


static public class MinigameTBGEncounterRewardExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*GroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*UniqueId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*TBGOptionSuccessType_*/, 4 /*Plana.FlatData.TBGOptionSuccessType*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*Paremeter*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*ParcelType_*/, 4 /*Plana.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*ParcelId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*Amount*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*Prob*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
