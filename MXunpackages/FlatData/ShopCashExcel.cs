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

public struct ShopCashExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ShopCashExcel GetRootAsShopCashExcel(ByteBuffer _bb) { return GetRootAsShopCashExcel(_bb, new ShopCashExcel()); }
  public static ShopCashExcel GetRootAsShopCashExcel(ByteBuffer _bb, ShopCashExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ShopCashExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CashProductId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public uint LocalizeEtcId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string IconPath { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconPathBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetIconPathBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetIconPathArray() { return __p.__vector_as_array<byte>(10); }
  public long DisplayOrder { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RenewalDisplayOrder { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.ProductCategory CategoryType { get { int o = __p.__offset(16); return o != 0 ? (Plana.FlatData.ProductCategory)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ProductCategory.None; } }
  public Plana.FlatData.ProductDisplayTag DisplayTag { get { int o = __p.__offset(18); return o != 0 ? (Plana.FlatData.ProductDisplayTag)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ProductDisplayTag.None; } }
  public string SalePeriodFrom { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSalePeriodFromBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetSalePeriodFromBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetSalePeriodFromArray() { return __p.__vector_as_array<byte>(20); }
  public string SalePeriodTo { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSalePeriodToBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetSalePeriodToBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetSalePeriodToArray() { return __p.__vector_as_array<byte>(22); }
  public bool PeriodTag { get { int o = __p.__offset(24); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long AccountLevelLimit { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool AccountLevelHide { get { int o = __p.__offset(28); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long ClearMissionLimit { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool ClearMissionHide { get { int o = __p.__offset(32); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string PurchaseReportEventName { get { int o = __p.__offset(34); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPurchaseReportEventNameBytes() { return __p.__vector_as_span<byte>(34, 1); }
#else
  public ArraySegment<byte>? GetPurchaseReportEventNameBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public byte[] GetPurchaseReportEventNameArray() { return __p.__vector_as_array<byte>(34); }
  public Plana.FlatData.PurchaseSourceType PackageClientType { get { int o = __p.__offset(36); return o != 0 ? (Plana.FlatData.PurchaseSourceType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.PurchaseSourceType.None; } }
  public bool IsStartDash { get { int o = __p.__offset(38); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool ViewFlag { get { int o = __p.__offset(40); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<Plana.FlatData.ShopCashExcel> CreateShopCashExcel(FlatBufferBuilder builder,
      long Id = 0,
      long CashProductId = 0,
      uint LocalizeEtcId = 0,
      StringOffset IconPathOffset = default(StringOffset),
      long DisplayOrder = 0,
      long RenewalDisplayOrder = 0,
      Plana.FlatData.ProductCategory CategoryType = Plana.FlatData.ProductCategory.None,
      Plana.FlatData.ProductDisplayTag DisplayTag = Plana.FlatData.ProductDisplayTag.None,
      StringOffset SalePeriodFromOffset = default(StringOffset),
      StringOffset SalePeriodToOffset = default(StringOffset),
      bool PeriodTag = false,
      long AccountLevelLimit = 0,
      bool AccountLevelHide = false,
      long ClearMissionLimit = 0,
      bool ClearMissionHide = false,
      StringOffset PurchaseReportEventNameOffset = default(StringOffset),
      Plana.FlatData.PurchaseSourceType PackageClientType = Plana.FlatData.PurchaseSourceType.None,
      bool IsStartDash = false,
      bool ViewFlag = false) {
    builder.StartTable(19);
    ShopCashExcel.AddClearMissionLimit(builder, ClearMissionLimit);
    ShopCashExcel.AddAccountLevelLimit(builder, AccountLevelLimit);
    ShopCashExcel.AddRenewalDisplayOrder(builder, RenewalDisplayOrder);
    ShopCashExcel.AddDisplayOrder(builder, DisplayOrder);
    ShopCashExcel.AddCashProductId(builder, CashProductId);
    ShopCashExcel.AddId(builder, Id);
    ShopCashExcel.AddPackageClientType(builder, PackageClientType);
    ShopCashExcel.AddPurchaseReportEventName(builder, PurchaseReportEventNameOffset);
    ShopCashExcel.AddSalePeriodTo(builder, SalePeriodToOffset);
    ShopCashExcel.AddSalePeriodFrom(builder, SalePeriodFromOffset);
    ShopCashExcel.AddDisplayTag(builder, DisplayTag);
    ShopCashExcel.AddCategoryType(builder, CategoryType);
    ShopCashExcel.AddIconPath(builder, IconPathOffset);
    ShopCashExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    ShopCashExcel.AddViewFlag(builder, ViewFlag);
    ShopCashExcel.AddIsStartDash(builder, IsStartDash);
    ShopCashExcel.AddClearMissionHide(builder, ClearMissionHide);
    ShopCashExcel.AddAccountLevelHide(builder, AccountLevelHide);
    ShopCashExcel.AddPeriodTag(builder, PeriodTag);
    return ShopCashExcel.EndShopCashExcel(builder);
  }

  public static void StartShopCashExcel(FlatBufferBuilder builder) { builder.StartTable(19); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddCashProductId(FlatBufferBuilder builder, long cashProductId) { builder.AddLong(1, cashProductId, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint localizeEtcId) { builder.AddUint(2, localizeEtcId, 0); }
  public static void AddIconPath(FlatBufferBuilder builder, StringOffset iconPathOffset) { builder.AddOffset(3, iconPathOffset.Value, 0); }
  public static void AddDisplayOrder(FlatBufferBuilder builder, long displayOrder) { builder.AddLong(4, displayOrder, 0); }
  public static void AddRenewalDisplayOrder(FlatBufferBuilder builder, long renewalDisplayOrder) { builder.AddLong(5, renewalDisplayOrder, 0); }
  public static void AddCategoryType(FlatBufferBuilder builder, Plana.FlatData.ProductCategory categoryType) { builder.AddInt(6, (int)categoryType, 0); }
  public static void AddDisplayTag(FlatBufferBuilder builder, Plana.FlatData.ProductDisplayTag displayTag) { builder.AddInt(7, (int)displayTag, 0); }
  public static void AddSalePeriodFrom(FlatBufferBuilder builder, StringOffset salePeriodFromOffset) { builder.AddOffset(8, salePeriodFromOffset.Value, 0); }
  public static void AddSalePeriodTo(FlatBufferBuilder builder, StringOffset salePeriodToOffset) { builder.AddOffset(9, salePeriodToOffset.Value, 0); }
  public static void AddPeriodTag(FlatBufferBuilder builder, bool periodTag) { builder.AddBool(10, periodTag, false); }
  public static void AddAccountLevelLimit(FlatBufferBuilder builder, long accountLevelLimit) { builder.AddLong(11, accountLevelLimit, 0); }
  public static void AddAccountLevelHide(FlatBufferBuilder builder, bool accountLevelHide) { builder.AddBool(12, accountLevelHide, false); }
  public static void AddClearMissionLimit(FlatBufferBuilder builder, long clearMissionLimit) { builder.AddLong(13, clearMissionLimit, 0); }
  public static void AddClearMissionHide(FlatBufferBuilder builder, bool clearMissionHide) { builder.AddBool(14, clearMissionHide, false); }
  public static void AddPurchaseReportEventName(FlatBufferBuilder builder, StringOffset purchaseReportEventNameOffset) { builder.AddOffset(15, purchaseReportEventNameOffset.Value, 0); }
  public static void AddPackageClientType(FlatBufferBuilder builder, Plana.FlatData.PurchaseSourceType packageClientType) { builder.AddInt(16, (int)packageClientType, 0); }
  public static void AddIsStartDash(FlatBufferBuilder builder, bool isStartDash) { builder.AddBool(17, isStartDash, false); }
  public static void AddViewFlag(FlatBufferBuilder builder, bool viewFlag) { builder.AddBool(18, viewFlag, false); }
  public static Offset<Plana.FlatData.ShopCashExcel> EndShopCashExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.ShopCashExcel>(o);
  }
  public ShopCashExcelT UnPack() {
    var _o = new ShopCashExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ShopCashExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("ShopCash");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.CashProductId = TableEncryptionService.Convert(this.CashProductId, key);
    _o.LocalizeEtcId = TableEncryptionService.Convert(this.LocalizeEtcId, key);
    _o.IconPath = TableEncryptionService.Convert(this.IconPath, key);
    _o.DisplayOrder = TableEncryptionService.Convert(this.DisplayOrder, key);
    _o.RenewalDisplayOrder = TableEncryptionService.Convert(this.RenewalDisplayOrder, key);
    _o.CategoryType = TableEncryptionService.Convert(this.CategoryType, key);
    _o.DisplayTag = TableEncryptionService.Convert(this.DisplayTag, key);
    _o.SalePeriodFrom = TableEncryptionService.Convert(this.SalePeriodFrom, key);
    _o.SalePeriodTo = TableEncryptionService.Convert(this.SalePeriodTo, key);
    _o.PeriodTag = TableEncryptionService.Convert(this.PeriodTag, key);
    _o.AccountLevelLimit = TableEncryptionService.Convert(this.AccountLevelLimit, key);
    _o.AccountLevelHide = TableEncryptionService.Convert(this.AccountLevelHide, key);
    _o.ClearMissionLimit = TableEncryptionService.Convert(this.ClearMissionLimit, key);
    _o.ClearMissionHide = TableEncryptionService.Convert(this.ClearMissionHide, key);
    _o.PurchaseReportEventName = TableEncryptionService.Convert(this.PurchaseReportEventName, key);
    _o.PackageClientType = TableEncryptionService.Convert(this.PackageClientType, key);
    _o.IsStartDash = TableEncryptionService.Convert(this.IsStartDash, key);
    _o.ViewFlag = TableEncryptionService.Convert(this.ViewFlag, key);
  }
  public static Offset<Plana.FlatData.ShopCashExcel> Pack(FlatBufferBuilder builder, ShopCashExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.ShopCashExcel>);
    var _IconPath = _o.IconPath == null ? default(StringOffset) : builder.CreateString(_o.IconPath);
    var _SalePeriodFrom = _o.SalePeriodFrom == null ? default(StringOffset) : builder.CreateString(_o.SalePeriodFrom);
    var _SalePeriodTo = _o.SalePeriodTo == null ? default(StringOffset) : builder.CreateString(_o.SalePeriodTo);
    var _PurchaseReportEventName = _o.PurchaseReportEventName == null ? default(StringOffset) : builder.CreateString(_o.PurchaseReportEventName);
    return CreateShopCashExcel(
      builder,
      _o.Id,
      _o.CashProductId,
      _o.LocalizeEtcId,
      _IconPath,
      _o.DisplayOrder,
      _o.RenewalDisplayOrder,
      _o.CategoryType,
      _o.DisplayTag,
      _SalePeriodFrom,
      _SalePeriodTo,
      _o.PeriodTag,
      _o.AccountLevelLimit,
      _o.AccountLevelHide,
      _o.ClearMissionLimit,
      _o.ClearMissionHide,
      _PurchaseReportEventName,
      _o.PackageClientType,
      _o.IsStartDash,
      _o.ViewFlag);
  }
}

public class ShopCashExcelT
{
  public long Id { get; set; }
  public long CashProductId { get; set; }
  public uint LocalizeEtcId { get; set; }
  public string IconPath { get; set; }
  public long DisplayOrder { get; set; }
  public long RenewalDisplayOrder { get; set; }
  public Plana.FlatData.ProductCategory CategoryType { get; set; }
  public Plana.FlatData.ProductDisplayTag DisplayTag { get; set; }
  public string SalePeriodFrom { get; set; }
  public string SalePeriodTo { get; set; }
  public bool PeriodTag { get; set; }
  public long AccountLevelLimit { get; set; }
  public bool AccountLevelHide { get; set; }
  public long ClearMissionLimit { get; set; }
  public bool ClearMissionHide { get; set; }
  public string PurchaseReportEventName { get; set; }
  public Plana.FlatData.PurchaseSourceType PackageClientType { get; set; }
  public bool IsStartDash { get; set; }
  public bool ViewFlag { get; set; }

  public ShopCashExcelT() {
    this.Id = 0;
    this.CashProductId = 0;
    this.LocalizeEtcId = 0;
    this.IconPath = null;
    this.DisplayOrder = 0;
    this.RenewalDisplayOrder = 0;
    this.CategoryType = Plana.FlatData.ProductCategory.None;
    this.DisplayTag = Plana.FlatData.ProductDisplayTag.None;
    this.SalePeriodFrom = null;
    this.SalePeriodTo = null;
    this.PeriodTag = false;
    this.AccountLevelLimit = 0;
    this.AccountLevelHide = false;
    this.ClearMissionLimit = 0;
    this.ClearMissionHide = false;
    this.PurchaseReportEventName = null;
    this.PackageClientType = Plana.FlatData.PurchaseSourceType.None;
    this.IsStartDash = false;
    this.ViewFlag = false;
  }
}


static public class ShopCashExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*CashProductId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*LocalizeEtcId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyString(tablePos, 10 /*IconPath*/, false)
      && verifier.VerifyField(tablePos, 12 /*DisplayOrder*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*RenewalDisplayOrder*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*CategoryType*/, 4 /*Plana.FlatData.ProductCategory*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*DisplayTag*/, 4 /*Plana.FlatData.ProductDisplayTag*/, 4, false)
      && verifier.VerifyString(tablePos, 20 /*SalePeriodFrom*/, false)
      && verifier.VerifyString(tablePos, 22 /*SalePeriodTo*/, false)
      && verifier.VerifyField(tablePos, 24 /*PeriodTag*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 26 /*AccountLevelLimit*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 28 /*AccountLevelHide*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 30 /*ClearMissionLimit*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 32 /*ClearMissionHide*/, 1 /*bool*/, 1, false)
      && verifier.VerifyString(tablePos, 34 /*PurchaseReportEventName*/, false)
      && verifier.VerifyField(tablePos, 36 /*PackageClientType*/, 4 /*Plana.FlatData.PurchaseSourceType*/, 4, false)
      && verifier.VerifyField(tablePos, 38 /*IsStartDash*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 40 /*ViewFlag*/, 1 /*bool*/, 1, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
