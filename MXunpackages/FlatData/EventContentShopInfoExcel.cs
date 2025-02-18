// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct EventContentShopInfoExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentShopInfoExcel GetRootAsEventContentShopInfoExcel(ByteBuffer _bb) { return GetRootAsEventContentShopInfoExcel(_bb, new EventContentShopInfoExcel()); }
  public static EventContentShopInfoExcel GetRootAsEventContentShopInfoExcel(ByteBuffer _bb, EventContentShopInfoExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentShopInfoExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.ShopCategoryType CategoryType { get { int o = __p.__offset(6); return o != 0 ? (Plana.FlatData.ShopCategoryType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ShopCategoryType.General; } }
  public uint LocalizeCode { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public Plana.FlatData.ParcelType CostParcelType(int j) { int o = __p.__offset(10); return o != 0 ? (Plana.FlatData.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (Plana.FlatData.ParcelType)0; }
  public int CostParcelTypeLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<Plana.FlatData.ParcelType> GetCostParcelTypeBytes() { return __p.__vector_as_span<Plana.FlatData.ParcelType>(10, 4); }
#else
  public ArraySegment<byte>? GetCostParcelTypeBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public Plana.FlatData.ParcelType[] GetCostParcelTypeArray() { int o = __p.__offset(10); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); Plana.FlatData.ParcelType[] a = new Plana.FlatData.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (Plana.FlatData.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long CostParcelId(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int CostParcelIdLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetCostParcelIdBytes() { return __p.__vector_as_span<long>(12, 8); }
#else
  public ArraySegment<byte>? GetCostParcelIdBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public long[] GetCostParcelIdArray() { return __p.__vector_as_array<long>(12); }
  public bool IsRefresh { get { int o = __p.__offset(14); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool IsSoldOutDimmed { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long AutoRefreshCoolTime { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RefreshAbleCount { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GoodsId(int j) { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int GoodsIdLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetGoodsIdBytes() { return __p.__vector_as_span<long>(22, 8); }
#else
  public ArraySegment<byte>? GetGoodsIdBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public long[] GetGoodsIdArray() { return __p.__vector_as_array<long>(22); }
  public string OpenPeriodFrom { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOpenPeriodFromBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetOpenPeriodFromBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetOpenPeriodFromArray() { return __p.__vector_as_array<byte>(24); }
  public string OpenPeriodTo { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOpenPeriodToBytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetOpenPeriodToBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetOpenPeriodToArray() { return __p.__vector_as_array<byte>(26); }
  public string ShopProductUpdateDate { get { int o = __p.__offset(28); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetShopProductUpdateDateBytes() { return __p.__vector_as_span<byte>(28, 1); }
#else
  public ArraySegment<byte>? GetShopProductUpdateDateBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public byte[] GetShopProductUpdateDateArray() { return __p.__vector_as_array<byte>(28); }

  public static Offset<Plana.FlatData.EventContentShopInfoExcel> CreateEventContentShopInfoExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      Plana.FlatData.ShopCategoryType CategoryType = Plana.FlatData.ShopCategoryType.General,
      uint LocalizeCode = 0,
      VectorOffset CostParcelTypeOffset = default(VectorOffset),
      VectorOffset CostParcelIdOffset = default(VectorOffset),
      bool IsRefresh = false,
      bool IsSoldOutDimmed = false,
      long AutoRefreshCoolTime = 0,
      long RefreshAbleCount = 0,
      VectorOffset GoodsIdOffset = default(VectorOffset),
      StringOffset OpenPeriodFromOffset = default(StringOffset),
      StringOffset OpenPeriodToOffset = default(StringOffset),
      StringOffset ShopProductUpdateDateOffset = default(StringOffset)) {
    builder.StartTable(13);
    EventContentShopInfoExcel.AddRefreshAbleCount(builder, RefreshAbleCount);
    EventContentShopInfoExcel.AddAutoRefreshCoolTime(builder, AutoRefreshCoolTime);
    EventContentShopInfoExcel.AddEventContentId(builder, EventContentId);
    EventContentShopInfoExcel.AddShopProductUpdateDate(builder, ShopProductUpdateDateOffset);
    EventContentShopInfoExcel.AddOpenPeriodTo(builder, OpenPeriodToOffset);
    EventContentShopInfoExcel.AddOpenPeriodFrom(builder, OpenPeriodFromOffset);
    EventContentShopInfoExcel.AddGoodsId(builder, GoodsIdOffset);
    EventContentShopInfoExcel.AddCostParcelId(builder, CostParcelIdOffset);
    EventContentShopInfoExcel.AddCostParcelType(builder, CostParcelTypeOffset);
    EventContentShopInfoExcel.AddLocalizeCode(builder, LocalizeCode);
    EventContentShopInfoExcel.AddCategoryType(builder, CategoryType);
    EventContentShopInfoExcel.AddIsSoldOutDimmed(builder, IsSoldOutDimmed);
    EventContentShopInfoExcel.AddIsRefresh(builder, IsRefresh);
    return EventContentShopInfoExcel.EndEventContentShopInfoExcel(builder);
  }

  public static void StartEventContentShopInfoExcel(FlatBufferBuilder builder) { builder.StartTable(13); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(0, eventContentId, 0); }
  public static void AddCategoryType(FlatBufferBuilder builder, Plana.FlatData.ShopCategoryType categoryType) { builder.AddInt(1, (int)categoryType, 0); }
  public static void AddLocalizeCode(FlatBufferBuilder builder, uint localizeCode) { builder.AddUint(2, localizeCode, 0); }
  public static void AddCostParcelType(FlatBufferBuilder builder, VectorOffset costParcelTypeOffset) { builder.AddOffset(3, costParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateCostParcelTypeVector(FlatBufferBuilder builder, Plana.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateCostParcelTypeVectorBlock(FlatBufferBuilder builder, Plana.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCostParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<Plana.FlatData.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCostParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Plana.FlatData.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCostParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCostParcelId(FlatBufferBuilder builder, VectorOffset costParcelIdOffset) { builder.AddOffset(4, costParcelIdOffset.Value, 0); }
  public static VectorOffset CreateCostParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateCostParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCostParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCostParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCostParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddIsRefresh(FlatBufferBuilder builder, bool isRefresh) { builder.AddBool(5, isRefresh, false); }
  public static void AddIsSoldOutDimmed(FlatBufferBuilder builder, bool isSoldOutDimmed) { builder.AddBool(6, isSoldOutDimmed, false); }
  public static void AddAutoRefreshCoolTime(FlatBufferBuilder builder, long autoRefreshCoolTime) { builder.AddLong(7, autoRefreshCoolTime, 0); }
  public static void AddRefreshAbleCount(FlatBufferBuilder builder, long refreshAbleCount) { builder.AddLong(8, refreshAbleCount, 0); }
  public static void AddGoodsId(FlatBufferBuilder builder, VectorOffset goodsIdOffset) { builder.AddOffset(9, goodsIdOffset.Value, 0); }
  public static VectorOffset CreateGoodsIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateGoodsIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateGoodsIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateGoodsIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartGoodsIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddOpenPeriodFrom(FlatBufferBuilder builder, StringOffset openPeriodFromOffset) { builder.AddOffset(10, openPeriodFromOffset.Value, 0); }
  public static void AddOpenPeriodTo(FlatBufferBuilder builder, StringOffset openPeriodToOffset) { builder.AddOffset(11, openPeriodToOffset.Value, 0); }
  public static void AddShopProductUpdateDate(FlatBufferBuilder builder, StringOffset shopProductUpdateDateOffset) { builder.AddOffset(12, shopProductUpdateDateOffset.Value, 0); }
  public static Offset<Plana.FlatData.EventContentShopInfoExcel> EndEventContentShopInfoExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.EventContentShopInfoExcel>(o);
  }
  public EventContentShopInfoExcelT UnPack() {
    var _o = new EventContentShopInfoExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EventContentShopInfoExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("EventContentShopInfo");
    _o.EventContentId = TableEncryptionService.Convert(this.EventContentId, key);
    _o.CategoryType = TableEncryptionService.Convert(this.CategoryType, key);
    _o.LocalizeCode = TableEncryptionService.Convert(this.LocalizeCode, key);
    _o.CostParcelType = new List<Plana.FlatData.ParcelType>();
    for (var _j = 0; _j < this.CostParcelTypeLength; ++_j) {_o.CostParcelType.Add(TableEncryptionService.Convert(this.CostParcelType(_j), key));}
    _o.CostParcelId = new List<long>();
    for (var _j = 0; _j < this.CostParcelIdLength; ++_j) {_o.CostParcelId.Add(TableEncryptionService.Convert(this.CostParcelId(_j), key));}
    _o.IsRefresh = TableEncryptionService.Convert(this.IsRefresh, key);
    _o.IsSoldOutDimmed = TableEncryptionService.Convert(this.IsSoldOutDimmed, key);
    _o.AutoRefreshCoolTime = TableEncryptionService.Convert(this.AutoRefreshCoolTime, key);
    _o.RefreshAbleCount = TableEncryptionService.Convert(this.RefreshAbleCount, key);
    _o.GoodsId = new List<long>();
    for (var _j = 0; _j < this.GoodsIdLength; ++_j) {_o.GoodsId.Add(TableEncryptionService.Convert(this.GoodsId(_j), key));}
    _o.OpenPeriodFrom = TableEncryptionService.Convert(this.OpenPeriodFrom, key);
    _o.OpenPeriodTo = TableEncryptionService.Convert(this.OpenPeriodTo, key);
    _o.ShopProductUpdateDate = TableEncryptionService.Convert(this.ShopProductUpdateDate, key);
  }
  public static Offset<Plana.FlatData.EventContentShopInfoExcel> Pack(FlatBufferBuilder builder, EventContentShopInfoExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.EventContentShopInfoExcel>);
    var _CostParcelType = default(VectorOffset);
    if (_o.CostParcelType != null) {
      var __CostParcelType = _o.CostParcelType.ToArray();
      _CostParcelType = CreateCostParcelTypeVector(builder, __CostParcelType);
    }
    var _CostParcelId = default(VectorOffset);
    if (_o.CostParcelId != null) {
      var __CostParcelId = _o.CostParcelId.ToArray();
      _CostParcelId = CreateCostParcelIdVector(builder, __CostParcelId);
    }
    var _GoodsId = default(VectorOffset);
    if (_o.GoodsId != null) {
      var __GoodsId = _o.GoodsId.ToArray();
      _GoodsId = CreateGoodsIdVector(builder, __GoodsId);
    }
    var _OpenPeriodFrom = _o.OpenPeriodFrom == null ? default(StringOffset) : builder.CreateString(_o.OpenPeriodFrom);
    var _OpenPeriodTo = _o.OpenPeriodTo == null ? default(StringOffset) : builder.CreateString(_o.OpenPeriodTo);
    var _ShopProductUpdateDate = _o.ShopProductUpdateDate == null ? default(StringOffset) : builder.CreateString(_o.ShopProductUpdateDate);
    return CreateEventContentShopInfoExcel(
      builder,
      _o.EventContentId,
      _o.CategoryType,
      _o.LocalizeCode,
      _CostParcelType,
      _CostParcelId,
      _o.IsRefresh,
      _o.IsSoldOutDimmed,
      _o.AutoRefreshCoolTime,
      _o.RefreshAbleCount,
      _GoodsId,
      _OpenPeriodFrom,
      _OpenPeriodTo,
      _ShopProductUpdateDate);
  }
}

public class EventContentShopInfoExcelT
{
  public long EventContentId { get; set; }
  public Plana.FlatData.ShopCategoryType CategoryType { get; set; }
  public uint LocalizeCode { get; set; }
  public List<Plana.FlatData.ParcelType> CostParcelType { get; set; }
  public List<long> CostParcelId { get; set; }
  public bool IsRefresh { get; set; }
  public bool IsSoldOutDimmed { get; set; }
  public long AutoRefreshCoolTime { get; set; }
  public long RefreshAbleCount { get; set; }
  public List<long> GoodsId { get; set; }
  public string OpenPeriodFrom { get; set; }
  public string OpenPeriodTo { get; set; }
  public string ShopProductUpdateDate { get; set; }

  public EventContentShopInfoExcelT() {
    this.EventContentId = 0;
    this.CategoryType = Plana.FlatData.ShopCategoryType.General;
    this.LocalizeCode = 0;
    this.CostParcelType = null;
    this.CostParcelId = null;
    this.IsRefresh = false;
    this.IsSoldOutDimmed = false;
    this.AutoRefreshCoolTime = 0;
    this.RefreshAbleCount = 0;
    this.GoodsId = null;
    this.OpenPeriodFrom = null;
    this.OpenPeriodTo = null;
    this.ShopProductUpdateDate = null;
  }
}


static public class EventContentShopInfoExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*CategoryType*/, 4 /*Plana.FlatData.ShopCategoryType*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*LocalizeCode*/, 4 /*uint*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*CostParcelType*/, 4 /*Plana.FlatData.ParcelType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*CostParcelId*/, 8 /*long*/, false)
      && verifier.VerifyField(tablePos, 14 /*IsRefresh*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 16 /*IsSoldOutDimmed*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 18 /*AutoRefreshCoolTime*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 20 /*RefreshAbleCount*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 22 /*GoodsId*/, 8 /*long*/, false)
      && verifier.VerifyString(tablePos, 24 /*OpenPeriodFrom*/, false)
      && verifier.VerifyString(tablePos, 26 /*OpenPeriodTo*/, false)
      && verifier.VerifyString(tablePos, 28 /*ShopProductUpdateDate*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
