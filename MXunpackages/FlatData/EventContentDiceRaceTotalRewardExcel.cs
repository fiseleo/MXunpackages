// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct EventContentDiceRaceTotalRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentDiceRaceTotalRewardExcel GetRootAsEventContentDiceRaceTotalRewardExcel(ByteBuffer _bb) { return GetRootAsEventContentDiceRaceTotalRewardExcel(_bb, new EventContentDiceRaceTotalRewardExcel()); }
  public static EventContentDiceRaceTotalRewardExcel GetRootAsEventContentDiceRaceTotalRewardExcel(ByteBuffer _bb, EventContentDiceRaceTotalRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentDiceRaceTotalRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RewardID { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int RequiredLapFinishCount { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int DisplayLapFinishCount { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public Plana.FlatData.ParcelType RewardParcelType(int j) { int o = __p.__offset(12); return o != 0 ? (Plana.FlatData.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (Plana.FlatData.ParcelType)0; }
  public int RewardParcelTypeLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<Plana.FlatData.ParcelType> GetRewardParcelTypeBytes() { return __p.__vector_as_span<Plana.FlatData.ParcelType>(12, 4); }
#else
  public ArraySegment<byte>? GetRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public Plana.FlatData.ParcelType[] GetRewardParcelTypeArray() { int o = __p.__offset(12); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); Plana.FlatData.ParcelType[] a = new Plana.FlatData.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (Plana.FlatData.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long RewardParcelId(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelIdLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelIdBytes() { return __p.__vector_as_span<long>(14, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelIdBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public long[] GetRewardParcelIdArray() { return __p.__vector_as_array<long>(14); }
  public long RewardParcelAmount(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelAmountLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelAmountBytes() { return __p.__vector_as_span<long>(16, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelAmountBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public long[] GetRewardParcelAmountArray() { return __p.__vector_as_array<long>(16); }

  public static Offset<Plana.FlatData.EventContentDiceRaceTotalRewardExcel> CreateEventContentDiceRaceTotalRewardExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      long RewardID = 0,
      int RequiredLapFinishCount = 0,
      int DisplayLapFinishCount = 0,
      VectorOffset RewardParcelTypeOffset = default(VectorOffset),
      VectorOffset RewardParcelIdOffset = default(VectorOffset),
      VectorOffset RewardParcelAmountOffset = default(VectorOffset)) {
    builder.StartTable(7);
    EventContentDiceRaceTotalRewardExcel.AddRewardID(builder, RewardID);
    EventContentDiceRaceTotalRewardExcel.AddEventContentId(builder, EventContentId);
    EventContentDiceRaceTotalRewardExcel.AddRewardParcelAmount(builder, RewardParcelAmountOffset);
    EventContentDiceRaceTotalRewardExcel.AddRewardParcelId(builder, RewardParcelIdOffset);
    EventContentDiceRaceTotalRewardExcel.AddRewardParcelType(builder, RewardParcelTypeOffset);
    EventContentDiceRaceTotalRewardExcel.AddDisplayLapFinishCount(builder, DisplayLapFinishCount);
    EventContentDiceRaceTotalRewardExcel.AddRequiredLapFinishCount(builder, RequiredLapFinishCount);
    return EventContentDiceRaceTotalRewardExcel.EndEventContentDiceRaceTotalRewardExcel(builder);
  }

  public static void StartEventContentDiceRaceTotalRewardExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(0, eventContentId, 0); }
  public static void AddRewardID(FlatBufferBuilder builder, long rewardID) { builder.AddLong(1, rewardID, 0); }
  public static void AddRequiredLapFinishCount(FlatBufferBuilder builder, int requiredLapFinishCount) { builder.AddInt(2, requiredLapFinishCount, 0); }
  public static void AddDisplayLapFinishCount(FlatBufferBuilder builder, int displayLapFinishCount) { builder.AddInt(3, displayLapFinishCount, 0); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, VectorOffset rewardParcelTypeOffset) { builder.AddOffset(4, rewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelTypeVector(FlatBufferBuilder builder, Plana.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, Plana.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<Plana.FlatData.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Plana.FlatData.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardParcelId(FlatBufferBuilder builder, VectorOffset rewardParcelIdOffset) { builder.AddOffset(5, rewardParcelIdOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddRewardParcelAmount(FlatBufferBuilder builder, VectorOffset rewardParcelAmountOffset) { builder.AddOffset(6, rewardParcelAmountOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<Plana.FlatData.EventContentDiceRaceTotalRewardExcel> EndEventContentDiceRaceTotalRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.EventContentDiceRaceTotalRewardExcel>(o);
  }
  public EventContentDiceRaceTotalRewardExcelT UnPack() {
    var _o = new EventContentDiceRaceTotalRewardExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EventContentDiceRaceTotalRewardExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("EventContentDiceRaceTotalReward");
    _o.EventContentId = TableEncryptionService.Convert(this.EventContentId, key);
    _o.RewardID = TableEncryptionService.Convert(this.RewardID, key);
    _o.RequiredLapFinishCount = TableEncryptionService.Convert(this.RequiredLapFinishCount, key);
    _o.DisplayLapFinishCount = TableEncryptionService.Convert(this.DisplayLapFinishCount, key);
    _o.RewardParcelType = new List<Plana.FlatData.ParcelType>();
    for (var _j = 0; _j < this.RewardParcelTypeLength; ++_j) {_o.RewardParcelType.Add(TableEncryptionService.Convert(this.RewardParcelType(_j), key));}
    _o.RewardParcelId = new List<long>();
    for (var _j = 0; _j < this.RewardParcelIdLength; ++_j) {_o.RewardParcelId.Add(TableEncryptionService.Convert(this.RewardParcelId(_j), key));}
    _o.RewardParcelAmount = new List<long>();
    for (var _j = 0; _j < this.RewardParcelAmountLength; ++_j) {_o.RewardParcelAmount.Add(TableEncryptionService.Convert(this.RewardParcelAmount(_j), key));}
  }
  public static Offset<Plana.FlatData.EventContentDiceRaceTotalRewardExcel> Pack(FlatBufferBuilder builder, EventContentDiceRaceTotalRewardExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.EventContentDiceRaceTotalRewardExcel>);
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
    return CreateEventContentDiceRaceTotalRewardExcel(
      builder,
      _o.EventContentId,
      _o.RewardID,
      _o.RequiredLapFinishCount,
      _o.DisplayLapFinishCount,
      _RewardParcelType,
      _RewardParcelId,
      _RewardParcelAmount);
  }
}

public class EventContentDiceRaceTotalRewardExcelT
{
  public long EventContentId { get; set; }
  public long RewardID { get; set; }
  public int RequiredLapFinishCount { get; set; }
  public int DisplayLapFinishCount { get; set; }
  public List<Plana.FlatData.ParcelType> RewardParcelType { get; set; }
  public List<long> RewardParcelId { get; set; }
  public List<long> RewardParcelAmount { get; set; }

  public EventContentDiceRaceTotalRewardExcelT() {
    this.EventContentId = 0;
    this.RewardID = 0;
    this.RequiredLapFinishCount = 0;
    this.DisplayLapFinishCount = 0;
    this.RewardParcelType = null;
    this.RewardParcelId = null;
    this.RewardParcelAmount = null;
  }
}


static public class EventContentDiceRaceTotalRewardExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*RewardID*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*RequiredLapFinishCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*DisplayLapFinishCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*RewardParcelType*/, 4 /*Plana.FlatData.ParcelType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 14 /*RewardParcelId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 16 /*RewardParcelAmount*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
