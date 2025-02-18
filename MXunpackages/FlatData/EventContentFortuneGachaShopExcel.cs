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

public struct EventContentFortuneGachaShopExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentFortuneGachaShopExcel GetRootAsEventContentFortuneGachaShopExcel(ByteBuffer _bb) { return GetRootAsEventContentFortuneGachaShopExcel(_bb, new EventContentFortuneGachaShopExcel()); }
  public static EventContentFortuneGachaShopExcel GetRootAsEventContentFortuneGachaShopExcel(ByteBuffer _bb, EventContentFortuneGachaShopExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentFortuneGachaShopExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Id { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int Grade { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long CostGoodsId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool IsLegacy { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int FortuneGachaGroupId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Prob { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ProbModifyValue { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ProbModifyLimit { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public Plana.FlatData.ParcelType RewardParcelType(int j) { int o = __p.__offset(22); return o != 0 ? (Plana.FlatData.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (Plana.FlatData.ParcelType)0; }
  public int RewardParcelTypeLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<Plana.FlatData.ParcelType> GetRewardParcelTypeBytes() { return __p.__vector_as_span<Plana.FlatData.ParcelType>(22, 4); }
#else
  public ArraySegment<byte>? GetRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public Plana.FlatData.ParcelType[] GetRewardParcelTypeArray() { int o = __p.__offset(22); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); Plana.FlatData.ParcelType[] a = new Plana.FlatData.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (Plana.FlatData.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long RewardParcelId(int j) { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelIdLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelIdBytes() { return __p.__vector_as_span<long>(24, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelIdBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public long[] GetRewardParcelIdArray() { return __p.__vector_as_array<long>(24); }
  public long RewardParcelAmount(int j) { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelAmountLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelAmountBytes() { return __p.__vector_as_span<long>(26, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelAmountBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public long[] GetRewardParcelAmountArray() { return __p.__vector_as_array<long>(26); }

  public static Offset<Plana.FlatData.EventContentFortuneGachaShopExcel> CreateEventContentFortuneGachaShopExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      long Id = 0,
      int Grade = 0,
      long CostGoodsId = 0,
      bool IsLegacy = false,
      int FortuneGachaGroupId = 0,
      int Prob = 0,
      int ProbModifyValue = 0,
      int ProbModifyLimit = 0,
      VectorOffset RewardParcelTypeOffset = default(VectorOffset),
      VectorOffset RewardParcelIdOffset = default(VectorOffset),
      VectorOffset RewardParcelAmountOffset = default(VectorOffset)) {
    builder.StartTable(12);
    EventContentFortuneGachaShopExcel.AddCostGoodsId(builder, CostGoodsId);
    EventContentFortuneGachaShopExcel.AddId(builder, Id);
    EventContentFortuneGachaShopExcel.AddEventContentId(builder, EventContentId);
    EventContentFortuneGachaShopExcel.AddRewardParcelAmount(builder, RewardParcelAmountOffset);
    EventContentFortuneGachaShopExcel.AddRewardParcelId(builder, RewardParcelIdOffset);
    EventContentFortuneGachaShopExcel.AddRewardParcelType(builder, RewardParcelTypeOffset);
    EventContentFortuneGachaShopExcel.AddProbModifyLimit(builder, ProbModifyLimit);
    EventContentFortuneGachaShopExcel.AddProbModifyValue(builder, ProbModifyValue);
    EventContentFortuneGachaShopExcel.AddProb(builder, Prob);
    EventContentFortuneGachaShopExcel.AddFortuneGachaGroupId(builder, FortuneGachaGroupId);
    EventContentFortuneGachaShopExcel.AddGrade(builder, Grade);
    EventContentFortuneGachaShopExcel.AddIsLegacy(builder, IsLegacy);
    return EventContentFortuneGachaShopExcel.EndEventContentFortuneGachaShopExcel(builder);
  }

  public static void StartEventContentFortuneGachaShopExcel(FlatBufferBuilder builder) { builder.StartTable(12); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(0, eventContentId, 0); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(1, id, 0); }
  public static void AddGrade(FlatBufferBuilder builder, int grade) { builder.AddInt(2, grade, 0); }
  public static void AddCostGoodsId(FlatBufferBuilder builder, long costGoodsId) { builder.AddLong(3, costGoodsId, 0); }
  public static void AddIsLegacy(FlatBufferBuilder builder, bool isLegacy) { builder.AddBool(4, isLegacy, false); }
  public static void AddFortuneGachaGroupId(FlatBufferBuilder builder, int fortuneGachaGroupId) { builder.AddInt(5, fortuneGachaGroupId, 0); }
  public static void AddProb(FlatBufferBuilder builder, int prob) { builder.AddInt(6, prob, 0); }
  public static void AddProbModifyValue(FlatBufferBuilder builder, int probModifyValue) { builder.AddInt(7, probModifyValue, 0); }
  public static void AddProbModifyLimit(FlatBufferBuilder builder, int probModifyLimit) { builder.AddInt(8, probModifyLimit, 0); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, VectorOffset rewardParcelTypeOffset) { builder.AddOffset(9, rewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelTypeVector(FlatBufferBuilder builder, Plana.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, Plana.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<Plana.FlatData.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Plana.FlatData.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardParcelId(FlatBufferBuilder builder, VectorOffset rewardParcelIdOffset) { builder.AddOffset(10, rewardParcelIdOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddRewardParcelAmount(FlatBufferBuilder builder, VectorOffset rewardParcelAmountOffset) { builder.AddOffset(11, rewardParcelAmountOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<Plana.FlatData.EventContentFortuneGachaShopExcel> EndEventContentFortuneGachaShopExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.EventContentFortuneGachaShopExcel>(o);
  }
  public EventContentFortuneGachaShopExcelT UnPack() {
    var _o = new EventContentFortuneGachaShopExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EventContentFortuneGachaShopExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("EventContentFortuneGachaShop");
    _o.EventContentId = TableEncryptionService.Convert(this.EventContentId, key);
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.Grade = TableEncryptionService.Convert(this.Grade, key);
    _o.CostGoodsId = TableEncryptionService.Convert(this.CostGoodsId, key);
    _o.IsLegacy = TableEncryptionService.Convert(this.IsLegacy, key);
    _o.FortuneGachaGroupId = TableEncryptionService.Convert(this.FortuneGachaGroupId, key);
    _o.Prob = TableEncryptionService.Convert(this.Prob, key);
    _o.ProbModifyValue = TableEncryptionService.Convert(this.ProbModifyValue, key);
    _o.ProbModifyLimit = TableEncryptionService.Convert(this.ProbModifyLimit, key);
    _o.RewardParcelType = new List<Plana.FlatData.ParcelType>();
    for (var _j = 0; _j < this.RewardParcelTypeLength; ++_j) {_o.RewardParcelType.Add(TableEncryptionService.Convert(this.RewardParcelType(_j), key));}
    _o.RewardParcelId = new List<long>();
    for (var _j = 0; _j < this.RewardParcelIdLength; ++_j) {_o.RewardParcelId.Add(TableEncryptionService.Convert(this.RewardParcelId(_j), key));}
    _o.RewardParcelAmount = new List<long>();
    for (var _j = 0; _j < this.RewardParcelAmountLength; ++_j) {_o.RewardParcelAmount.Add(TableEncryptionService.Convert(this.RewardParcelAmount(_j), key));}
  }
  public static Offset<Plana.FlatData.EventContentFortuneGachaShopExcel> Pack(FlatBufferBuilder builder, EventContentFortuneGachaShopExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.EventContentFortuneGachaShopExcel>);
    var _RewardParcelType = default(VectorOffset);
    if (_o.RewardParcelType != null) {
      var __RewardParcelType = _o.RewardParcelType.ToArray();
      _RewardParcelType = CreateRewardParcelTypeVector(builder, __RewardParcelType);
    }
    var _RewardParcelId = default(VectorOffset);
    if (_o.RewardParcelId != null) {
      var __RewardParcelId = _o.RewardParcelId.ToArray();
      _RewardParcelId = CreateRewardParcelIdVector(builder, __RewardParcelId);
    }
    var _RewardParcelAmount = default(VectorOffset);
    if (_o.RewardParcelAmount != null) {
      var __RewardParcelAmount = _o.RewardParcelAmount.ToArray();
      _RewardParcelAmount = CreateRewardParcelAmountVector(builder, __RewardParcelAmount);
    }
    return CreateEventContentFortuneGachaShopExcel(
      builder,
      _o.EventContentId,
      _o.Id,
      _o.Grade,
      _o.CostGoodsId,
      _o.IsLegacy,
      _o.FortuneGachaGroupId,
      _o.Prob,
      _o.ProbModifyValue,
      _o.ProbModifyLimit,
      _RewardParcelType,
      _RewardParcelId,
      _RewardParcelAmount);
  }
}

public class EventContentFortuneGachaShopExcelT
{
  public long EventContentId { get; set; }
  public long Id { get; set; }
  public int Grade { get; set; }
  public long CostGoodsId { get; set; }
  public bool IsLegacy { get; set; }
  public int FortuneGachaGroupId { get; set; }
  public int Prob { get; set; }
  public int ProbModifyValue { get; set; }
  public int ProbModifyLimit { get; set; }
  public List<Plana.FlatData.ParcelType> RewardParcelType { get; set; }
  public List<long> RewardParcelId { get; set; }
  public List<long> RewardParcelAmount { get; set; }

  public EventContentFortuneGachaShopExcelT() {
    this.EventContentId = 0;
    this.Id = 0;
    this.Grade = 0;
    this.CostGoodsId = 0;
    this.IsLegacy = false;
    this.FortuneGachaGroupId = 0;
    this.Prob = 0;
    this.ProbModifyValue = 0;
    this.ProbModifyLimit = 0;
    this.RewardParcelType = null;
    this.RewardParcelId = null;
    this.RewardParcelAmount = null;
  }
}


static public class EventContentFortuneGachaShopExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*Grade*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*CostGoodsId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*IsLegacy*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 14 /*FortuneGachaGroupId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*Prob*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*ProbModifyValue*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 20 /*ProbModifyLimit*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 22 /*RewardParcelType*/, 4 /*Plana.FlatData.ParcelType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 24 /*RewardParcelId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 26 /*RewardParcelAmount*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
