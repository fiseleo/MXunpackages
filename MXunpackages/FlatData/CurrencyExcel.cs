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

public struct CurrencyExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static CurrencyExcel GetRootAsCurrencyExcel(ByteBuffer _bb) { return GetRootAsCurrencyExcel(_bb, new CurrencyExcel()); }
  public static CurrencyExcel GetRootAsCurrencyExcel(ByteBuffer _bb, CurrencyExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CurrencyExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long ID { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public uint LocalizeEtcId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public Plana.FlatData.CurrencyTypes CurrencyType { get { int o = __p.__offset(8); return o != 0 ? (Plana.FlatData.CurrencyTypes)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.CurrencyTypes.Invalid; } }
  public string CurrencyName { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetCurrencyNameBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetCurrencyNameBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetCurrencyNameArray() { return __p.__vector_as_array<byte>(10); }
  public string Icon { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetIconBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetIconArray() { return __p.__vector_as_array<byte>(12); }
  public Plana.FlatData.Rarity Rarity_ { get { int o = __p.__offset(14); return o != 0 ? (Plana.FlatData.Rarity)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.Rarity.N; } }
  public int AutoChargeMsc { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int AutoChargeAmount { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public Plana.FlatData.CurrencyOverChargeType CurrencyOverChargeType_ { get { int o = __p.__offset(20); return o != 0 ? (Plana.FlatData.CurrencyOverChargeType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.CurrencyOverChargeType.CanNotCharge; } }
  public Plana.FlatData.CurrencyAdditionalChargeType CurrencyAdditionalChargeType_ { get { int o = __p.__offset(22); return o != 0 ? (Plana.FlatData.CurrencyAdditionalChargeType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.CurrencyAdditionalChargeType.EnableAutoChargeOverLimit; } }
  public long ChargeLimit { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long OverChargeLimit { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string SpriteName { get { int o = __p.__offset(28); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSpriteNameBytes() { return __p.__vector_as_span<byte>(28, 1); }
#else
  public ArraySegment<byte>? GetSpriteNameBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public byte[] GetSpriteNameArray() { return __p.__vector_as_array<byte>(28); }
  public Plana.FlatData.DailyRefillType DailyRefillType_ { get { int o = __p.__offset(30); return o != 0 ? (Plana.FlatData.DailyRefillType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.DailyRefillType.None; } }
  public long DailyRefillAmount { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DailyRefillTime(int j) { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int DailyRefillTimeLength { get { int o = __p.__offset(34); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetDailyRefillTimeBytes() { return __p.__vector_as_span<long>(34, 8); }
#else
  public ArraySegment<byte>? GetDailyRefillTimeBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public long[] GetDailyRefillTimeArray() { return __p.__vector_as_array<long>(34); }

  public static Offset<Plana.FlatData.CurrencyExcel> CreateCurrencyExcel(FlatBufferBuilder builder,
      long ID = 0,
      uint LocalizeEtcId = 0,
      Plana.FlatData.CurrencyTypes CurrencyType = Plana.FlatData.CurrencyTypes.Invalid,
      StringOffset CurrencyNameOffset = default(StringOffset),
      StringOffset IconOffset = default(StringOffset),
      Plana.FlatData.Rarity Rarity_ = Plana.FlatData.Rarity.N,
      int AutoChargeMsc = 0,
      int AutoChargeAmount = 0,
      Plana.FlatData.CurrencyOverChargeType CurrencyOverChargeType_ = Plana.FlatData.CurrencyOverChargeType.CanNotCharge,
      Plana.FlatData.CurrencyAdditionalChargeType CurrencyAdditionalChargeType_ = Plana.FlatData.CurrencyAdditionalChargeType.EnableAutoChargeOverLimit,
      long ChargeLimit = 0,
      long OverChargeLimit = 0,
      StringOffset SpriteNameOffset = default(StringOffset),
      Plana.FlatData.DailyRefillType DailyRefillType_ = Plana.FlatData.DailyRefillType.None,
      long DailyRefillAmount = 0,
      VectorOffset DailyRefillTimeOffset = default(VectorOffset)) {
    builder.StartTable(16);
    CurrencyExcel.AddDailyRefillAmount(builder, DailyRefillAmount);
    CurrencyExcel.AddOverChargeLimit(builder, OverChargeLimit);
    CurrencyExcel.AddChargeLimit(builder, ChargeLimit);
    CurrencyExcel.AddID(builder, ID);
    CurrencyExcel.AddDailyRefillTime(builder, DailyRefillTimeOffset);
    CurrencyExcel.AddDailyRefillType_(builder, DailyRefillType_);
    CurrencyExcel.AddSpriteName(builder, SpriteNameOffset);
    CurrencyExcel.AddCurrencyAdditionalChargeType_(builder, CurrencyAdditionalChargeType_);
    CurrencyExcel.AddCurrencyOverChargeType_(builder, CurrencyOverChargeType_);
    CurrencyExcel.AddAutoChargeAmount(builder, AutoChargeAmount);
    CurrencyExcel.AddAutoChargeMsc(builder, AutoChargeMsc);
    CurrencyExcel.AddRarity_(builder, Rarity_);
    CurrencyExcel.AddIcon(builder, IconOffset);
    CurrencyExcel.AddCurrencyName(builder, CurrencyNameOffset);
    CurrencyExcel.AddCurrencyType(builder, CurrencyType);
    CurrencyExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    return CurrencyExcel.EndCurrencyExcel(builder);
  }

  public static void StartCurrencyExcel(FlatBufferBuilder builder) { builder.StartTable(16); }
  public static void AddID(FlatBufferBuilder builder, long iD) { builder.AddLong(0, iD, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint localizeEtcId) { builder.AddUint(1, localizeEtcId, 0); }
  public static void AddCurrencyType(FlatBufferBuilder builder, Plana.FlatData.CurrencyTypes currencyType) { builder.AddInt(2, (int)currencyType, 0); }
  public static void AddCurrencyName(FlatBufferBuilder builder, StringOffset currencyNameOffset) { builder.AddOffset(3, currencyNameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset) { builder.AddOffset(4, iconOffset.Value, 0); }
  public static void AddRarity_(FlatBufferBuilder builder, Plana.FlatData.Rarity rarity_) { builder.AddInt(5, (int)rarity_, 0); }
  public static void AddAutoChargeMsc(FlatBufferBuilder builder, int autoChargeMsc) { builder.AddInt(6, autoChargeMsc, 0); }
  public static void AddAutoChargeAmount(FlatBufferBuilder builder, int autoChargeAmount) { builder.AddInt(7, autoChargeAmount, 0); }
  public static void AddCurrencyOverChargeType_(FlatBufferBuilder builder, Plana.FlatData.CurrencyOverChargeType currencyOverChargeType_) { builder.AddInt(8, (int)currencyOverChargeType_, 0); }
  public static void AddCurrencyAdditionalChargeType_(FlatBufferBuilder builder, Plana.FlatData.CurrencyAdditionalChargeType currencyAdditionalChargeType_) { builder.AddInt(9, (int)currencyAdditionalChargeType_, 0); }
  public static void AddChargeLimit(FlatBufferBuilder builder, long chargeLimit) { builder.AddLong(10, chargeLimit, 0); }
  public static void AddOverChargeLimit(FlatBufferBuilder builder, long overChargeLimit) { builder.AddLong(11, overChargeLimit, 0); }
  public static void AddSpriteName(FlatBufferBuilder builder, StringOffset spriteNameOffset) { builder.AddOffset(12, spriteNameOffset.Value, 0); }
  public static void AddDailyRefillType_(FlatBufferBuilder builder, Plana.FlatData.DailyRefillType dailyRefillType_) { builder.AddInt(13, (int)dailyRefillType_, 0); }
  public static void AddDailyRefillAmount(FlatBufferBuilder builder, long dailyRefillAmount) { builder.AddLong(14, dailyRefillAmount, 0); }
  public static void AddDailyRefillTime(FlatBufferBuilder builder, VectorOffset dailyRefillTimeOffset) { builder.AddOffset(15, dailyRefillTimeOffset.Value, 0); }
  public static VectorOffset CreateDailyRefillTimeVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateDailyRefillTimeVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDailyRefillTimeVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDailyRefillTimeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDailyRefillTimeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<Plana.FlatData.CurrencyExcel> EndCurrencyExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.CurrencyExcel>(o);
  }
  public CurrencyExcelT UnPack() {
    var _o = new CurrencyExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CurrencyExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("Currency");
    _o.ID = TableEncryptionService.Convert(this.ID, key);
    _o.LocalizeEtcId = TableEncryptionService.Convert(this.LocalizeEtcId, key);
    _o.CurrencyType = TableEncryptionService.Convert(this.CurrencyType, key);
    _o.CurrencyName = TableEncryptionService.Convert(this.CurrencyName, key);
    _o.Icon = TableEncryptionService.Convert(this.Icon, key);
    _o.Rarity_ = TableEncryptionService.Convert(this.Rarity_, key);
    _o.AutoChargeMsc = TableEncryptionService.Convert(this.AutoChargeMsc, key);
    _o.AutoChargeAmount = TableEncryptionService.Convert(this.AutoChargeAmount, key);
    _o.CurrencyOverChargeType_ = TableEncryptionService.Convert(this.CurrencyOverChargeType_, key);
    _o.CurrencyAdditionalChargeType_ = TableEncryptionService.Convert(this.CurrencyAdditionalChargeType_, key);
    _o.ChargeLimit = TableEncryptionService.Convert(this.ChargeLimit, key);
    _o.OverChargeLimit = TableEncryptionService.Convert(this.OverChargeLimit, key);
    _o.SpriteName = TableEncryptionService.Convert(this.SpriteName, key);
    _o.DailyRefillType_ = TableEncryptionService.Convert(this.DailyRefillType_, key);
    _o.DailyRefillAmount = TableEncryptionService.Convert(this.DailyRefillAmount, key);
    _o.DailyRefillTime = new List<long>();
    for (var _j = 0; _j < this.DailyRefillTimeLength; ++_j) {_o.DailyRefillTime.Add(TableEncryptionService.Convert(this.DailyRefillTime(_j), key));}
  }
  public static Offset<Plana.FlatData.CurrencyExcel> Pack(FlatBufferBuilder builder, CurrencyExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.CurrencyExcel>);
    var _CurrencyName = _o.CurrencyName == null ? default(StringOffset) : builder.CreateString(_o.CurrencyName);
    var _Icon = _o.Icon == null ? default(StringOffset) : builder.CreateString(_o.Icon);
    var _SpriteName = _o.SpriteName == null ? default(StringOffset) : builder.CreateString(_o.SpriteName);
    var _DailyRefillTime = default(VectorOffset);
    if (_o.DailyRefillTime != null) {
      var __DailyRefillTime = _o.DailyRefillTime.ToArray();
      _DailyRefillTime = CreateDailyRefillTimeVector(builder, __DailyRefillTime);
    }
    return CreateCurrencyExcel(
      builder,
      _o.ID,
      _o.LocalizeEtcId,
      _o.CurrencyType,
      _CurrencyName,
      _Icon,
      _o.Rarity_,
      _o.AutoChargeMsc,
      _o.AutoChargeAmount,
      _o.CurrencyOverChargeType_,
      _o.CurrencyAdditionalChargeType_,
      _o.ChargeLimit,
      _o.OverChargeLimit,
      _SpriteName,
      _o.DailyRefillType_,
      _o.DailyRefillAmount,
      _DailyRefillTime);
  }
}

public class CurrencyExcelT
{
  public long ID { get; set; }
  public uint LocalizeEtcId { get; set; }
  public Plana.FlatData.CurrencyTypes CurrencyType { get; set; }
  public string CurrencyName { get; set; }
  public string Icon { get; set; }
  public Plana.FlatData.Rarity Rarity_ { get; set; }
  public int AutoChargeMsc { get; set; }
  public int AutoChargeAmount { get; set; }
  public Plana.FlatData.CurrencyOverChargeType CurrencyOverChargeType_ { get; set; }
  public Plana.FlatData.CurrencyAdditionalChargeType CurrencyAdditionalChargeType_ { get; set; }
  public long ChargeLimit { get; set; }
  public long OverChargeLimit { get; set; }
  public string SpriteName { get; set; }
  public Plana.FlatData.DailyRefillType DailyRefillType_ { get; set; }
  public long DailyRefillAmount { get; set; }
  public List<long> DailyRefillTime { get; set; }

  public CurrencyExcelT() {
    this.ID = 0;
    this.LocalizeEtcId = 0;
    this.CurrencyType = Plana.FlatData.CurrencyTypes.Invalid;
    this.CurrencyName = null;
    this.Icon = null;
    this.Rarity_ = Plana.FlatData.Rarity.N;
    this.AutoChargeMsc = 0;
    this.AutoChargeAmount = 0;
    this.CurrencyOverChargeType_ = Plana.FlatData.CurrencyOverChargeType.CanNotCharge;
    this.CurrencyAdditionalChargeType_ = Plana.FlatData.CurrencyAdditionalChargeType.EnableAutoChargeOverLimit;
    this.ChargeLimit = 0;
    this.OverChargeLimit = 0;
    this.SpriteName = null;
    this.DailyRefillType_ = Plana.FlatData.DailyRefillType.None;
    this.DailyRefillAmount = 0;
    this.DailyRefillTime = null;
  }
}


static public class CurrencyExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*ID*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*LocalizeEtcId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*CurrencyType*/, 4 /*Plana.FlatData.CurrencyTypes*/, 4, false)
      && verifier.VerifyString(tablePos, 10 /*CurrencyName*/, false)
      && verifier.VerifyString(tablePos, 12 /*Icon*/, false)
      && verifier.VerifyField(tablePos, 14 /*Rarity_*/, 4 /*Plana.FlatData.Rarity*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*AutoChargeMsc*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*AutoChargeAmount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 20 /*CurrencyOverChargeType_*/, 4 /*Plana.FlatData.CurrencyOverChargeType*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*CurrencyAdditionalChargeType_*/, 4 /*Plana.FlatData.CurrencyAdditionalChargeType*/, 4, false)
      && verifier.VerifyField(tablePos, 24 /*ChargeLimit*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 26 /*OverChargeLimit*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 28 /*SpriteName*/, false)
      && verifier.VerifyField(tablePos, 30 /*DailyRefillType_*/, 4 /*Plana.FlatData.DailyRefillType*/, 4, false)
      && verifier.VerifyField(tablePos, 32 /*DailyRefillAmount*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 34 /*DailyRefillTime*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
