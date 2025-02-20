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

public struct FieldMasteryExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static FieldMasteryExcel GetRootAsFieldMasteryExcel(ByteBuffer _bb) { return GetRootAsFieldMasteryExcel(_bb, new FieldMasteryExcel()); }
  public static FieldMasteryExcel GetRootAsFieldMasteryExcel(ByteBuffer _bb, FieldMasteryExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FieldMasteryExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long UniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long SeasonId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int Order { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long ExpAmount { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.ParcelType TokenType { get { int o = __p.__offset(12); return o != 0 ? (Plana.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ParcelType.None; } }
  public long TokenId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long TokenRequirement { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.FieldConditionType AccomplishmentConditionType { get { int o = __p.__offset(18); return o != 0 ? (Plana.FlatData.FieldConditionType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.FieldConditionType.Invalid; } }
  public long AccomplishmentConditionId { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<Plana.FlatData.FieldMasteryExcel> CreateFieldMasteryExcel(FlatBufferBuilder builder,
      long UniqueId = 0,
      long SeasonId = 0,
      int Order = 0,
      long ExpAmount = 0,
      Plana.FlatData.ParcelType TokenType = Plana.FlatData.ParcelType.None,
      long TokenId = 0,
      long TokenRequirement = 0,
      Plana.FlatData.FieldConditionType AccomplishmentConditionType = Plana.FlatData.FieldConditionType.Invalid,
      long AccomplishmentConditionId = 0) {
    builder.StartTable(9);
    FieldMasteryExcel.AddAccomplishmentConditionId(builder, AccomplishmentConditionId);
    FieldMasteryExcel.AddTokenRequirement(builder, TokenRequirement);
    FieldMasteryExcel.AddTokenId(builder, TokenId);
    FieldMasteryExcel.AddExpAmount(builder, ExpAmount);
    FieldMasteryExcel.AddSeasonId(builder, SeasonId);
    FieldMasteryExcel.AddUniqueId(builder, UniqueId);
    FieldMasteryExcel.AddAccomplishmentConditionType(builder, AccomplishmentConditionType);
    FieldMasteryExcel.AddTokenType(builder, TokenType);
    FieldMasteryExcel.AddOrder(builder, Order);
    return FieldMasteryExcel.EndFieldMasteryExcel(builder);
  }

  public static void StartFieldMasteryExcel(FlatBufferBuilder builder) { builder.StartTable(9); }
  public static void AddUniqueId(FlatBufferBuilder builder, long uniqueId) { builder.AddLong(0, uniqueId, 0); }
  public static void AddSeasonId(FlatBufferBuilder builder, long seasonId) { builder.AddLong(1, seasonId, 0); }
  public static void AddOrder(FlatBufferBuilder builder, int order) { builder.AddInt(2, order, 0); }
  public static void AddExpAmount(FlatBufferBuilder builder, long expAmount) { builder.AddLong(3, expAmount, 0); }
  public static void AddTokenType(FlatBufferBuilder builder, Plana.FlatData.ParcelType tokenType) { builder.AddInt(4, (int)tokenType, 0); }
  public static void AddTokenId(FlatBufferBuilder builder, long tokenId) { builder.AddLong(5, tokenId, 0); }
  public static void AddTokenRequirement(FlatBufferBuilder builder, long tokenRequirement) { builder.AddLong(6, tokenRequirement, 0); }
  public static void AddAccomplishmentConditionType(FlatBufferBuilder builder, Plana.FlatData.FieldConditionType accomplishmentConditionType) { builder.AddInt(7, (int)accomplishmentConditionType, 0); }
  public static void AddAccomplishmentConditionId(FlatBufferBuilder builder, long accomplishmentConditionId) { builder.AddLong(8, accomplishmentConditionId, 0); }
  public static Offset<Plana.FlatData.FieldMasteryExcel> EndFieldMasteryExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.FieldMasteryExcel>(o);
  }
  public FieldMasteryExcelT UnPack() {
    var _o = new FieldMasteryExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FieldMasteryExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("FieldMastery");
    _o.UniqueId = TableEncryptionService.Convert(this.UniqueId, key);
    _o.SeasonId = TableEncryptionService.Convert(this.SeasonId, key);
    _o.Order = TableEncryptionService.Convert(this.Order, key);
    _o.ExpAmount = TableEncryptionService.Convert(this.ExpAmount, key);
    _o.TokenType = TableEncryptionService.Convert(this.TokenType, key);
    _o.TokenId = TableEncryptionService.Convert(this.TokenId, key);
    _o.TokenRequirement = TableEncryptionService.Convert(this.TokenRequirement, key);
    _o.AccomplishmentConditionType = TableEncryptionService.Convert(this.AccomplishmentConditionType, key);
    _o.AccomplishmentConditionId = TableEncryptionService.Convert(this.AccomplishmentConditionId, key);
  }
  public static Offset<Plana.FlatData.FieldMasteryExcel> Pack(FlatBufferBuilder builder, FieldMasteryExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.FieldMasteryExcel>);
    return CreateFieldMasteryExcel(
      builder,
      _o.UniqueId,
      _o.SeasonId,
      _o.Order,
      _o.ExpAmount,
      _o.TokenType,
      _o.TokenId,
      _o.TokenRequirement,
      _o.AccomplishmentConditionType,
      _o.AccomplishmentConditionId);
  }
}

public class FieldMasteryExcelT
{
  public long UniqueId { get; set; }
  public long SeasonId { get; set; }
  public int Order { get; set; }
  public long ExpAmount { get; set; }
  public Plana.FlatData.ParcelType TokenType { get; set; }
  public long TokenId { get; set; }
  public long TokenRequirement { get; set; }
  public Plana.FlatData.FieldConditionType AccomplishmentConditionType { get; set; }
  public long AccomplishmentConditionId { get; set; }

  public FieldMasteryExcelT() {
    this.UniqueId = 0;
    this.SeasonId = 0;
    this.Order = 0;
    this.ExpAmount = 0;
    this.TokenType = Plana.FlatData.ParcelType.None;
    this.TokenId = 0;
    this.TokenRequirement = 0;
    this.AccomplishmentConditionType = Plana.FlatData.FieldConditionType.Invalid;
    this.AccomplishmentConditionId = 0;
  }
}


static public class FieldMasteryExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*UniqueId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*SeasonId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*Order*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*ExpAmount*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*TokenType*/, 4 /*Plana.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*TokenId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*TokenRequirement*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*AccomplishmentConditionType*/, 4 /*Plana.FlatData.FieldConditionType*/, 4, false)
      && verifier.VerifyField(tablePos, 20 /*AccomplishmentConditionId*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
