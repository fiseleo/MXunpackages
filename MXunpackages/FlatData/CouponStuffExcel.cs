// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct CouponStuffExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static CouponStuffExcel GetRootAsCouponStuffExcel(ByteBuffer _bb) { return GetRootAsCouponStuffExcel(_bb, new CouponStuffExcel()); }
  public static CouponStuffExcel GetRootAsCouponStuffExcel(ByteBuffer _bb, CouponStuffExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CouponStuffExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long StuffId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.ParcelType ParcelType { get { int o = __p.__offset(6); return o != 0 ? (Plana.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ParcelType.None; } }
  public long ParcelId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int LimitAmount { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string CouponStuffNameLocalizeKey { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetCouponStuffNameLocalizeKeyBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetCouponStuffNameLocalizeKeyBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetCouponStuffNameLocalizeKeyArray() { return __p.__vector_as_array<byte>(12); }

  public static Offset<Plana.FlatData.CouponStuffExcel> CreateCouponStuffExcel(FlatBufferBuilder builder,
      long StuffId = 0,
      Plana.FlatData.ParcelType ParcelType = Plana.FlatData.ParcelType.None,
      long ParcelId = 0,
      int LimitAmount = 0,
      StringOffset CouponStuffNameLocalizeKeyOffset = default(StringOffset)) {
    builder.StartTable(5);
    CouponStuffExcel.AddParcelId(builder, ParcelId);
    CouponStuffExcel.AddStuffId(builder, StuffId);
    CouponStuffExcel.AddCouponStuffNameLocalizeKey(builder, CouponStuffNameLocalizeKeyOffset);
    CouponStuffExcel.AddLimitAmount(builder, LimitAmount);
    CouponStuffExcel.AddParcelType(builder, ParcelType);
    return CouponStuffExcel.EndCouponStuffExcel(builder);
  }

  public static void StartCouponStuffExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddStuffId(FlatBufferBuilder builder, long stuffId) { builder.AddLong(0, stuffId, 0); }
  public static void AddParcelType(FlatBufferBuilder builder, Plana.FlatData.ParcelType parcelType) { builder.AddInt(1, (int)parcelType, 0); }
  public static void AddParcelId(FlatBufferBuilder builder, long parcelId) { builder.AddLong(2, parcelId, 0); }
  public static void AddLimitAmount(FlatBufferBuilder builder, int limitAmount) { builder.AddInt(3, limitAmount, 0); }
  public static void AddCouponStuffNameLocalizeKey(FlatBufferBuilder builder, StringOffset couponStuffNameLocalizeKeyOffset) { builder.AddOffset(4, couponStuffNameLocalizeKeyOffset.Value, 0); }
  public static Offset<Plana.FlatData.CouponStuffExcel> EndCouponStuffExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.CouponStuffExcel>(o);
  }
  public CouponStuffExcelT UnPack() {
    var _o = new CouponStuffExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CouponStuffExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("CouponStuff");
    _o.StuffId = TableEncryptionService.Convert(this.StuffId, key);
    _o.ParcelType = TableEncryptionService.Convert(this.ParcelType, key);
    _o.ParcelId = TableEncryptionService.Convert(this.ParcelId, key);
    _o.LimitAmount = TableEncryptionService.Convert(this.LimitAmount, key);
    _o.CouponStuffNameLocalizeKey = TableEncryptionService.Convert(this.CouponStuffNameLocalizeKey, key);
  }
  public static Offset<Plana.FlatData.CouponStuffExcel> Pack(FlatBufferBuilder builder, CouponStuffExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.CouponStuffExcel>);
    var _CouponStuffNameLocalizeKey = _o.CouponStuffNameLocalizeKey == null ? default(StringOffset) : builder.CreateString(_o.CouponStuffNameLocalizeKey);
    return CreateCouponStuffExcel(
      builder,
      _o.StuffId,
      _o.ParcelType,
      _o.ParcelId,
      _o.LimitAmount,
      _CouponStuffNameLocalizeKey);
  }
}

public class CouponStuffExcelT
{
  public long StuffId { get; set; }
  public Plana.FlatData.ParcelType ParcelType { get; set; }
  public long ParcelId { get; set; }
  public int LimitAmount { get; set; }
  public string CouponStuffNameLocalizeKey { get; set; }

  public CouponStuffExcelT() {
    this.StuffId = 0;
    this.ParcelType = Plana.FlatData.ParcelType.None;
    this.ParcelId = 0;
    this.LimitAmount = 0;
    this.CouponStuffNameLocalizeKey = null;
  }
}


static public class CouponStuffExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*StuffId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*ParcelType*/, 4 /*Plana.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*ParcelId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*LimitAmount*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 12 /*CouponStuffNameLocalizeKey*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
