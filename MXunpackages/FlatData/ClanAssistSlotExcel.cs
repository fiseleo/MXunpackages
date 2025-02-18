// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct ClanAssistSlotExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ClanAssistSlotExcel GetRootAsClanAssistSlotExcel(ByteBuffer _bb) { return GetRootAsClanAssistSlotExcel(_bb, new ClanAssistSlotExcel()); }
  public static ClanAssistSlotExcel GetRootAsClanAssistSlotExcel(ByteBuffer _bb, ClanAssistSlotExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ClanAssistSlotExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long SlotId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.EchelonType EchelonType { get { int o = __p.__offset(6); return o != 0 ? (Plana.FlatData.EchelonType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.EchelonType.None; } }
  public long SlotNumber { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AssistTermRewardPeriodFromSec { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AssistRewardLimit { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AssistRentRewardDailyMaxCount { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AssistRentalFeeAmount { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AssistRentalFeeAmountStranger { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<Plana.FlatData.ClanAssistSlotExcel> CreateClanAssistSlotExcel(FlatBufferBuilder builder,
      long SlotId = 0,
      Plana.FlatData.EchelonType EchelonType = Plana.FlatData.EchelonType.None,
      long SlotNumber = 0,
      long AssistTermRewardPeriodFromSec = 0,
      long AssistRewardLimit = 0,
      long AssistRentRewardDailyMaxCount = 0,
      long AssistRentalFeeAmount = 0,
      long AssistRentalFeeAmountStranger = 0) {
    builder.StartTable(8);
    ClanAssistSlotExcel.AddAssistRentalFeeAmountStranger(builder, AssistRentalFeeAmountStranger);
    ClanAssistSlotExcel.AddAssistRentalFeeAmount(builder, AssistRentalFeeAmount);
    ClanAssistSlotExcel.AddAssistRentRewardDailyMaxCount(builder, AssistRentRewardDailyMaxCount);
    ClanAssistSlotExcel.AddAssistRewardLimit(builder, AssistRewardLimit);
    ClanAssistSlotExcel.AddAssistTermRewardPeriodFromSec(builder, AssistTermRewardPeriodFromSec);
    ClanAssistSlotExcel.AddSlotNumber(builder, SlotNumber);
    ClanAssistSlotExcel.AddSlotId(builder, SlotId);
    ClanAssistSlotExcel.AddEchelonType(builder, EchelonType);
    return ClanAssistSlotExcel.EndClanAssistSlotExcel(builder);
  }

  public static void StartClanAssistSlotExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddSlotId(FlatBufferBuilder builder, long slotId) { builder.AddLong(0, slotId, 0); }
  public static void AddEchelonType(FlatBufferBuilder builder, Plana.FlatData.EchelonType echelonType) { builder.AddInt(1, (int)echelonType, 0); }
  public static void AddSlotNumber(FlatBufferBuilder builder, long slotNumber) { builder.AddLong(2, slotNumber, 0); }
  public static void AddAssistTermRewardPeriodFromSec(FlatBufferBuilder builder, long assistTermRewardPeriodFromSec) { builder.AddLong(3, assistTermRewardPeriodFromSec, 0); }
  public static void AddAssistRewardLimit(FlatBufferBuilder builder, long assistRewardLimit) { builder.AddLong(4, assistRewardLimit, 0); }
  public static void AddAssistRentRewardDailyMaxCount(FlatBufferBuilder builder, long assistRentRewardDailyMaxCount) { builder.AddLong(5, assistRentRewardDailyMaxCount, 0); }
  public static void AddAssistRentalFeeAmount(FlatBufferBuilder builder, long assistRentalFeeAmount) { builder.AddLong(6, assistRentalFeeAmount, 0); }
  public static void AddAssistRentalFeeAmountStranger(FlatBufferBuilder builder, long assistRentalFeeAmountStranger) { builder.AddLong(7, assistRentalFeeAmountStranger, 0); }
  public static Offset<Plana.FlatData.ClanAssistSlotExcel> EndClanAssistSlotExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.ClanAssistSlotExcel>(o);
  }
  public ClanAssistSlotExcelT UnPack() {
    var _o = new ClanAssistSlotExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ClanAssistSlotExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("ClanAssistSlot");
    _o.SlotId = TableEncryptionService.Convert(this.SlotId, key);
    _o.EchelonType = TableEncryptionService.Convert(this.EchelonType, key);
    _o.SlotNumber = TableEncryptionService.Convert(this.SlotNumber, key);
    _o.AssistTermRewardPeriodFromSec = TableEncryptionService.Convert(this.AssistTermRewardPeriodFromSec, key);
    _o.AssistRewardLimit = TableEncryptionService.Convert(this.AssistRewardLimit, key);
    _o.AssistRentRewardDailyMaxCount = TableEncryptionService.Convert(this.AssistRentRewardDailyMaxCount, key);
    _o.AssistRentalFeeAmount = TableEncryptionService.Convert(this.AssistRentalFeeAmount, key);
    _o.AssistRentalFeeAmountStranger = TableEncryptionService.Convert(this.AssistRentalFeeAmountStranger, key);
  }
  public static Offset<Plana.FlatData.ClanAssistSlotExcel> Pack(FlatBufferBuilder builder, ClanAssistSlotExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.ClanAssistSlotExcel>);
    return CreateClanAssistSlotExcel(
      builder,
      _o.SlotId,
      _o.EchelonType,
      _o.SlotNumber,
      _o.AssistTermRewardPeriodFromSec,
      _o.AssistRewardLimit,
      _o.AssistRentRewardDailyMaxCount,
      _o.AssistRentalFeeAmount,
      _o.AssistRentalFeeAmountStranger);
  }
}

public class ClanAssistSlotExcelT
{
  public long SlotId { get; set; }
  public Plana.FlatData.EchelonType EchelonType { get; set; }
  public long SlotNumber { get; set; }
  public long AssistTermRewardPeriodFromSec { get; set; }
  public long AssistRewardLimit { get; set; }
  public long AssistRentRewardDailyMaxCount { get; set; }
  public long AssistRentalFeeAmount { get; set; }
  public long AssistRentalFeeAmountStranger { get; set; }

  public ClanAssistSlotExcelT() {
    this.SlotId = 0;
    this.EchelonType = Plana.FlatData.EchelonType.None;
    this.SlotNumber = 0;
    this.AssistTermRewardPeriodFromSec = 0;
    this.AssistRewardLimit = 0;
    this.AssistRentRewardDailyMaxCount = 0;
    this.AssistRentalFeeAmount = 0;
    this.AssistRentalFeeAmountStranger = 0;
  }
}


static public class ClanAssistSlotExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*SlotId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*EchelonType*/, 4 /*Plana.FlatData.EchelonType*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*SlotNumber*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*AssistTermRewardPeriodFromSec*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*AssistRewardLimit*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*AssistRentRewardDailyMaxCount*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*AssistRentalFeeAmount*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*AssistRentalFeeAmountStranger*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
