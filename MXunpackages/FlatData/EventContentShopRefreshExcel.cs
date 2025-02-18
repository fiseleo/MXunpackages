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

public struct EventContentShopRefreshExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentShopRefreshExcel GetRootAsEventContentShopRefreshExcel(ByteBuffer _bb) { return GetRootAsEventContentShopRefreshExcel(_bb, new EventContentShopRefreshExcel()); }
  public static EventContentShopRefreshExcel GetRootAsEventContentShopRefreshExcel(ByteBuffer _bb, EventContentShopRefreshExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentShopRefreshExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Id { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public uint LocalizeEtcId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public bool IsLegacy { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long GoodsId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DisplayOrder { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.ShopCategoryType CategoryType { get { int o = __p.__offset(16); return o != 0 ? (Plana.FlatData.ShopCategoryType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ShopCategoryType.General; } }
  public int RefreshGroup { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Prob { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string BuyReportEventName { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBuyReportEventNameBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetBuyReportEventNameBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetBuyReportEventNameArray() { return __p.__vector_as_array<byte>(22); }

  public static Offset<Plana.FlatData.EventContentShopRefreshExcel> CreateEventContentShopRefreshExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      long Id = 0,
      uint LocalizeEtcId = 0,
      bool IsLegacy = false,
      long GoodsId = 0,
      long DisplayOrder = 0,
      Plana.FlatData.ShopCategoryType CategoryType = Plana.FlatData.ShopCategoryType.General,
      int RefreshGroup = 0,
      int Prob = 0,
      StringOffset BuyReportEventNameOffset = default(StringOffset)) {
    builder.StartTable(10);
    EventContentShopRefreshExcel.AddDisplayOrder(builder, DisplayOrder);
    EventContentShopRefreshExcel.AddGoodsId(builder, GoodsId);
    EventContentShopRefreshExcel.AddId(builder, Id);
    EventContentShopRefreshExcel.AddEventContentId(builder, EventContentId);
    EventContentShopRefreshExcel.AddBuyReportEventName(builder, BuyReportEventNameOffset);
    EventContentShopRefreshExcel.AddProb(builder, Prob);
    EventContentShopRefreshExcel.AddRefreshGroup(builder, RefreshGroup);
    EventContentShopRefreshExcel.AddCategoryType(builder, CategoryType);
    EventContentShopRefreshExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    EventContentShopRefreshExcel.AddIsLegacy(builder, IsLegacy);
    return EventContentShopRefreshExcel.EndEventContentShopRefreshExcel(builder);
  }

  public static void StartEventContentShopRefreshExcel(FlatBufferBuilder builder) { builder.StartTable(10); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(0, eventContentId, 0); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(1, id, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint localizeEtcId) { builder.AddUint(2, localizeEtcId, 0); }
  public static void AddIsLegacy(FlatBufferBuilder builder, bool isLegacy) { builder.AddBool(3, isLegacy, false); }
  public static void AddGoodsId(FlatBufferBuilder builder, long goodsId) { builder.AddLong(4, goodsId, 0); }
  public static void AddDisplayOrder(FlatBufferBuilder builder, long displayOrder) { builder.AddLong(5, displayOrder, 0); }
  public static void AddCategoryType(FlatBufferBuilder builder, Plana.FlatData.ShopCategoryType categoryType) { builder.AddInt(6, (int)categoryType, 0); }
  public static void AddRefreshGroup(FlatBufferBuilder builder, int refreshGroup) { builder.AddInt(7, refreshGroup, 0); }
  public static void AddProb(FlatBufferBuilder builder, int prob) { builder.AddInt(8, prob, 0); }
  public static void AddBuyReportEventName(FlatBufferBuilder builder, StringOffset buyReportEventNameOffset) { builder.AddOffset(9, buyReportEventNameOffset.Value, 0); }
  public static Offset<Plana.FlatData.EventContentShopRefreshExcel> EndEventContentShopRefreshExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.EventContentShopRefreshExcel>(o);
  }
  public EventContentShopRefreshExcelT UnPack() {
    var _o = new EventContentShopRefreshExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EventContentShopRefreshExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("EventContentShopRefresh");
    _o.EventContentId = TableEncryptionService.Convert(this.EventContentId, key);
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.LocalizeEtcId = TableEncryptionService.Convert(this.LocalizeEtcId, key);
    _o.IsLegacy = TableEncryptionService.Convert(this.IsLegacy, key);
    _o.GoodsId = TableEncryptionService.Convert(this.GoodsId, key);
    _o.DisplayOrder = TableEncryptionService.Convert(this.DisplayOrder, key);
    _o.CategoryType = TableEncryptionService.Convert(this.CategoryType, key);
    _o.RefreshGroup = TableEncryptionService.Convert(this.RefreshGroup, key);
    _o.Prob = TableEncryptionService.Convert(this.Prob, key);
    _o.BuyReportEventName = TableEncryptionService.Convert(this.BuyReportEventName, key);
  }
  public static Offset<Plana.FlatData.EventContentShopRefreshExcel> Pack(FlatBufferBuilder builder, EventContentShopRefreshExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.EventContentShopRefreshExcel>);
    var _BuyReportEventName = _o.BuyReportEventName == null ? default(StringOffset) : builder.CreateString(_o.BuyReportEventName);
    return CreateEventContentShopRefreshExcel(
      builder,
      _o.EventContentId,
      _o.Id,
      _o.LocalizeEtcId,
      _o.IsLegacy,
      _o.GoodsId,
      _o.DisplayOrder,
      _o.CategoryType,
      _o.RefreshGroup,
      _o.Prob,
      _BuyReportEventName);
  }
}

public class EventContentShopRefreshExcelT
{
  public long EventContentId { get; set; }
  public long Id { get; set; }
  public uint LocalizeEtcId { get; set; }
  public bool IsLegacy { get; set; }
  public long GoodsId { get; set; }
  public long DisplayOrder { get; set; }
  public Plana.FlatData.ShopCategoryType CategoryType { get; set; }
  public int RefreshGroup { get; set; }
  public int Prob { get; set; }
  public string BuyReportEventName { get; set; }

  public EventContentShopRefreshExcelT() {
    this.EventContentId = 0;
    this.Id = 0;
    this.LocalizeEtcId = 0;
    this.IsLegacy = false;
    this.GoodsId = 0;
    this.DisplayOrder = 0;
    this.CategoryType = Plana.FlatData.ShopCategoryType.General;
    this.RefreshGroup = 0;
    this.Prob = 0;
    this.BuyReportEventName = null;
  }
}


static public class EventContentShopRefreshExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*LocalizeEtcId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*IsLegacy*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 12 /*GoodsId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*DisplayOrder*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*CategoryType*/, 4 /*Plana.FlatData.ShopCategoryType*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*RefreshGroup*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 20 /*Prob*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 22 /*BuyReportEventName*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
