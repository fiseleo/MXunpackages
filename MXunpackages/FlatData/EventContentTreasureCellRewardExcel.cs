// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct EventContentTreasureCellRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentTreasureCellRewardExcel GetRootAsEventContentTreasureCellRewardExcel(ByteBuffer _bb) { return GetRootAsEventContentTreasureCellRewardExcel(_bb, new EventContentTreasureCellRewardExcel()); }
  public static EventContentTreasureCellRewardExcel GetRootAsEventContentTreasureCellRewardExcel(ByteBuffer _bb, EventContentTreasureCellRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentTreasureCellRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string LocalizeCodeID { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocalizeCodeIDBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetLocalizeCodeIDBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetLocalizeCodeIDArray() { return __p.__vector_as_array<byte>(6); }
  public Plana.FlatData.ParcelType RewardParcelType(int j) { int o = __p.__offset(8); return o != 0 ? (Plana.FlatData.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (Plana.FlatData.ParcelType)0; }
  public int RewardParcelTypeLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<Plana.FlatData.ParcelType> GetRewardParcelTypeBytes() { return __p.__vector_as_span<Plana.FlatData.ParcelType>(8, 4); }
#else
  public ArraySegment<byte>? GetRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public Plana.FlatData.ParcelType[] GetRewardParcelTypeArray() { int o = __p.__offset(8); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); Plana.FlatData.ParcelType[] a = new Plana.FlatData.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (Plana.FlatData.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long RewardParcelId(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelIdLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelIdBytes() { return __p.__vector_as_span<long>(10, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelIdBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public long[] GetRewardParcelIdArray() { return __p.__vector_as_array<long>(10); }
  public long RewardParcelAmount(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelAmountLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelAmountBytes() { return __p.__vector_as_span<long>(12, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelAmountBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public long[] GetRewardParcelAmountArray() { return __p.__vector_as_array<long>(12); }

  public static Offset<Plana.FlatData.EventContentTreasureCellRewardExcel> CreateEventContentTreasureCellRewardExcel(FlatBufferBuilder builder,
      long Id = 0,
      StringOffset LocalizeCodeIDOffset = default(StringOffset),
      VectorOffset RewardParcelTypeOffset = default(VectorOffset),
      VectorOffset RewardParcelIdOffset = default(VectorOffset),
      VectorOffset RewardParcelAmountOffset = default(VectorOffset)) {
    builder.StartTable(5);
    EventContentTreasureCellRewardExcel.AddId(builder, Id);
    EventContentTreasureCellRewardExcel.AddRewardParcelAmount(builder, RewardParcelAmountOffset);
    EventContentTreasureCellRewardExcel.AddRewardParcelId(builder, RewardParcelIdOffset);
    EventContentTreasureCellRewardExcel.AddRewardParcelType(builder, RewardParcelTypeOffset);
    EventContentTreasureCellRewardExcel.AddLocalizeCodeID(builder, LocalizeCodeIDOffset);
    return EventContentTreasureCellRewardExcel.EndEventContentTreasureCellRewardExcel(builder);
  }

  public static void StartEventContentTreasureCellRewardExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddLocalizeCodeID(FlatBufferBuilder builder, StringOffset localizeCodeIDOffset) { builder.AddOffset(1, localizeCodeIDOffset.Value, 0); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, VectorOffset rewardParcelTypeOffset) { builder.AddOffset(2, rewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelTypeVector(FlatBufferBuilder builder, Plana.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, Plana.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<Plana.FlatData.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Plana.FlatData.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardParcelId(FlatBufferBuilder builder, VectorOffset rewardParcelIdOffset) { builder.AddOffset(3, rewardParcelIdOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddRewardParcelAmount(FlatBufferBuilder builder, VectorOffset rewardParcelAmountOffset) { builder.AddOffset(4, rewardParcelAmountOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<Plana.FlatData.EventContentTreasureCellRewardExcel> EndEventContentTreasureCellRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.EventContentTreasureCellRewardExcel>(o);
  }
  public EventContentTreasureCellRewardExcelT UnPack() {
    var _o = new EventContentTreasureCellRewardExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EventContentTreasureCellRewardExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("EventContentTreasureCellReward");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.LocalizeCodeID = TableEncryptionService.Convert(this.LocalizeCodeID, key);
    _o.RewardParcelType = new List<Plana.FlatData.ParcelType>();
    for (var _j = 0; _j < this.RewardParcelTypeLength; ++_j) {_o.RewardParcelType.Add(TableEncryptionService.Convert(this.RewardParcelType(_j), key));}
    _o.RewardParcelId = new List<long>();
    for (var _j = 0; _j < this.RewardParcelIdLength; ++_j) {_o.RewardParcelId.Add(TableEncryptionService.Convert(this.RewardParcelId(_j), key));}
    _o.RewardParcelAmount = new List<long>();
    for (var _j = 0; _j < this.RewardParcelAmountLength; ++_j) {_o.RewardParcelAmount.Add(TableEncryptionService.Convert(this.RewardParcelAmount(_j), key));}
  }
  public static Offset<Plana.FlatData.EventContentTreasureCellRewardExcel> Pack(FlatBufferBuilder builder, EventContentTreasureCellRewardExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.EventContentTreasureCellRewardExcel>);
    var _LocalizeCodeID = _o.LocalizeCodeID == null ? default(StringOffset) : builder.CreateString(_o.LocalizeCodeID);
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
    return CreateEventContentTreasureCellRewardExcel(
      builder,
      _o.Id,
      _LocalizeCodeID,
      _RewardParcelType,
      _RewardParcelId,
      _RewardParcelAmount);
  }
}

public class EventContentTreasureCellRewardExcelT
{
  public long Id { get; set; }
  public string LocalizeCodeID { get; set; }
  public List<Plana.FlatData.ParcelType> RewardParcelType { get; set; }
  public List<long> RewardParcelId { get; set; }
  public List<long> RewardParcelAmount { get; set; }

  public EventContentTreasureCellRewardExcelT() {
    this.Id = 0;
    this.LocalizeCodeID = null;
    this.RewardParcelType = null;
    this.RewardParcelId = null;
    this.RewardParcelAmount = null;
  }
}


static public class EventContentTreasureCellRewardExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 6 /*LocalizeCodeID*/, false)
      && verifier.VerifyVectorOfData(tablePos, 8 /*RewardParcelType*/, 4 /*Plana.FlatData.ParcelType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*RewardParcelId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*RewardParcelAmount*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
