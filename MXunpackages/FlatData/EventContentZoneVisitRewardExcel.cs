// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct EventContentZoneVisitRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentZoneVisitRewardExcel GetRootAsEventContentZoneVisitRewardExcel(ByteBuffer _bb) { return GetRootAsEventContentZoneVisitRewardExcel(_bb, new EventContentZoneVisitRewardExcel()); }
  public static EventContentZoneVisitRewardExcel GetRootAsEventContentZoneVisitRewardExcel(ByteBuffer _bb, EventContentZoneVisitRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentZoneVisitRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EventContentLocationId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string DevName { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDevNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetDevNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetDevNameArray() { return __p.__vector_as_array<byte>(8); }
  public long CharacterId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string CharacterDevName { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetCharacterDevNameBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetCharacterDevNameBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetCharacterDevNameArray() { return __p.__vector_as_array<byte>(12); }
  public Plana.FlatData.ParcelType VisitRewardParcelType(int j) { int o = __p.__offset(14); return o != 0 ? (Plana.FlatData.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (Plana.FlatData.ParcelType)0; }
  public int VisitRewardParcelTypeLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<Plana.FlatData.ParcelType> GetVisitRewardParcelTypeBytes() { return __p.__vector_as_span<Plana.FlatData.ParcelType>(14, 4); }
#else
  public ArraySegment<byte>? GetVisitRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public Plana.FlatData.ParcelType[] GetVisitRewardParcelTypeArray() { int o = __p.__offset(14); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); Plana.FlatData.ParcelType[] a = new Plana.FlatData.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (Plana.FlatData.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long VisitRewardParcelId(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int VisitRewardParcelIdLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetVisitRewardParcelIdBytes() { return __p.__vector_as_span<long>(16, 8); }
#else
  public ArraySegment<byte>? GetVisitRewardParcelIdBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public long[] GetVisitRewardParcelIdArray() { return __p.__vector_as_array<long>(16); }
  public long VisitRewardAmount(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int VisitRewardAmountLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetVisitRewardAmountBytes() { return __p.__vector_as_span<long>(18, 8); }
#else
  public ArraySegment<byte>? GetVisitRewardAmountBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public long[] GetVisitRewardAmountArray() { return __p.__vector_as_array<long>(18); }
  public long VisitRewardProb(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int VisitRewardProbLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetVisitRewardProbBytes() { return __p.__vector_as_span<long>(20, 8); }
#else
  public ArraySegment<byte>? GetVisitRewardProbBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public long[] GetVisitRewardProbArray() { return __p.__vector_as_array<long>(20); }

  public static Offset<Plana.FlatData.EventContentZoneVisitRewardExcel> CreateEventContentZoneVisitRewardExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      long EventContentLocationId = 0,
      StringOffset DevNameOffset = default(StringOffset),
      long CharacterId = 0,
      StringOffset CharacterDevNameOffset = default(StringOffset),
      VectorOffset VisitRewardParcelTypeOffset = default(VectorOffset),
      VectorOffset VisitRewardParcelIdOffset = default(VectorOffset),
      VectorOffset VisitRewardAmountOffset = default(VectorOffset),
      VectorOffset VisitRewardProbOffset = default(VectorOffset)) {
    builder.StartTable(9);
    EventContentZoneVisitRewardExcel.AddCharacterId(builder, CharacterId);
    EventContentZoneVisitRewardExcel.AddEventContentLocationId(builder, EventContentLocationId);
    EventContentZoneVisitRewardExcel.AddEventContentId(builder, EventContentId);
    EventContentZoneVisitRewardExcel.AddVisitRewardProb(builder, VisitRewardProbOffset);
    EventContentZoneVisitRewardExcel.AddVisitRewardAmount(builder, VisitRewardAmountOffset);
    EventContentZoneVisitRewardExcel.AddVisitRewardParcelId(builder, VisitRewardParcelIdOffset);
    EventContentZoneVisitRewardExcel.AddVisitRewardParcelType(builder, VisitRewardParcelTypeOffset);
    EventContentZoneVisitRewardExcel.AddCharacterDevName(builder, CharacterDevNameOffset);
    EventContentZoneVisitRewardExcel.AddDevName(builder, DevNameOffset);
    return EventContentZoneVisitRewardExcel.EndEventContentZoneVisitRewardExcel(builder);
  }

  public static void StartEventContentZoneVisitRewardExcel(FlatBufferBuilder builder) { builder.StartTable(9); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(0, eventContentId, 0); }
  public static void AddEventContentLocationId(FlatBufferBuilder builder, long eventContentLocationId) { builder.AddLong(1, eventContentLocationId, 0); }
  public static void AddDevName(FlatBufferBuilder builder, StringOffset devNameOffset) { builder.AddOffset(2, devNameOffset.Value, 0); }
  public static void AddCharacterId(FlatBufferBuilder builder, long characterId) { builder.AddLong(3, characterId, 0); }
  public static void AddCharacterDevName(FlatBufferBuilder builder, StringOffset characterDevNameOffset) { builder.AddOffset(4, characterDevNameOffset.Value, 0); }
  public static void AddVisitRewardParcelType(FlatBufferBuilder builder, VectorOffset visitRewardParcelTypeOffset) { builder.AddOffset(5, visitRewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateVisitRewardParcelTypeVector(FlatBufferBuilder builder, Plana.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateVisitRewardParcelTypeVectorBlock(FlatBufferBuilder builder, Plana.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVisitRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<Plana.FlatData.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVisitRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Plana.FlatData.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVisitRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddVisitRewardParcelId(FlatBufferBuilder builder, VectorOffset visitRewardParcelIdOffset) { builder.AddOffset(6, visitRewardParcelIdOffset.Value, 0); }
  public static VectorOffset CreateVisitRewardParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateVisitRewardParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVisitRewardParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVisitRewardParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVisitRewardParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddVisitRewardAmount(FlatBufferBuilder builder, VectorOffset visitRewardAmountOffset) { builder.AddOffset(7, visitRewardAmountOffset.Value, 0); }
  public static VectorOffset CreateVisitRewardAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateVisitRewardAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVisitRewardAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVisitRewardAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVisitRewardAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddVisitRewardProb(FlatBufferBuilder builder, VectorOffset visitRewardProbOffset) { builder.AddOffset(8, visitRewardProbOffset.Value, 0); }
  public static VectorOffset CreateVisitRewardProbVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateVisitRewardProbVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVisitRewardProbVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVisitRewardProbVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVisitRewardProbVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<Plana.FlatData.EventContentZoneVisitRewardExcel> EndEventContentZoneVisitRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.EventContentZoneVisitRewardExcel>(o);
  }
  public EventContentZoneVisitRewardExcelT UnPack() {
    var _o = new EventContentZoneVisitRewardExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EventContentZoneVisitRewardExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("EventContentZoneVisitReward");
    _o.EventContentId = TableEncryptionService.Convert(this.EventContentId, key);
    _o.EventContentLocationId = TableEncryptionService.Convert(this.EventContentLocationId, key);
    _o.DevName = TableEncryptionService.Convert(this.DevName, key);
    _o.CharacterId = TableEncryptionService.Convert(this.CharacterId, key);
    _o.CharacterDevName = TableEncryptionService.Convert(this.CharacterDevName, key);
    _o.VisitRewardParcelType = new List<Plana.FlatData.ParcelType>();
    for (var _j = 0; _j < this.VisitRewardParcelTypeLength; ++_j) {_o.VisitRewardParcelType.Add(TableEncryptionService.Convert(this.VisitRewardParcelType(_j), key));}
    _o.VisitRewardParcelId = new List<long>();
    for (var _j = 0; _j < this.VisitRewardParcelIdLength; ++_j) {_o.VisitRewardParcelId.Add(TableEncryptionService.Convert(this.VisitRewardParcelId(_j), key));}
    _o.VisitRewardAmount = new List<long>();
    for (var _j = 0; _j < this.VisitRewardAmountLength; ++_j) {_o.VisitRewardAmount.Add(TableEncryptionService.Convert(this.VisitRewardAmount(_j), key));}
    _o.VisitRewardProb = new List<long>();
    for (var _j = 0; _j < this.VisitRewardProbLength; ++_j) {_o.VisitRewardProb.Add(TableEncryptionService.Convert(this.VisitRewardProb(_j), key));}
  }
  public static Offset<Plana.FlatData.EventContentZoneVisitRewardExcel> Pack(FlatBufferBuilder builder, EventContentZoneVisitRewardExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.EventContentZoneVisitRewardExcel>);
    var _DevName = _o.DevName == null ? default(StringOffset) : builder.CreateString(_o.DevName);
    var _CharacterDevName = _o.CharacterDevName == null ? default(StringOffset) : builder.CreateString(_o.CharacterDevName);
    var _VisitRewardParcelType = default(VectorOffset);
    if (_o.VisitRewardParcelType != null) {
      var __VisitRewardParcelType = _o.VisitRewardParcelType.ToArray();
      _VisitRewardParcelType = CreateVisitRewardParcelTypeVector(builder, __VisitRewardParcelType);
    }
    var _VisitRewardParcelId = default(VectorOffset);
    if (_o.VisitRewardParcelId != null) {
      var __VisitRewardParcelId = _o.VisitRewardParcelId.ToArray();
      _VisitRewardParcelId = CreateVisitRewardParcelIdVector(builder, __VisitRewardParcelId);
    }
    var _VisitRewardAmount = default(VectorOffset);
    if (_o.VisitRewardAmount != null) {
      var __VisitRewardAmount = _o.VisitRewardAmount.ToArray();
      _VisitRewardAmount = CreateVisitRewardAmountVector(builder, __VisitRewardAmount);
    }
    var _VisitRewardProb = default(VectorOffset);
    if (_o.VisitRewardProb != null) {
      var __VisitRewardProb = _o.VisitRewardProb.ToArray();
      _VisitRewardProb = CreateVisitRewardProbVector(builder, __VisitRewardProb);
    }
    return CreateEventContentZoneVisitRewardExcel(
      builder,
      _o.EventContentId,
      _o.EventContentLocationId,
      _DevName,
      _o.CharacterId,
      _CharacterDevName,
      _VisitRewardParcelType,
      _VisitRewardParcelId,
      _VisitRewardAmount,
      _VisitRewardProb);
  }
}

public class EventContentZoneVisitRewardExcelT
{
  public long EventContentId { get; set; }
  public long EventContentLocationId { get; set; }
  public string DevName { get; set; }
  public long CharacterId { get; set; }
  public string CharacterDevName { get; set; }
  public List<Plana.FlatData.ParcelType> VisitRewardParcelType { get; set; }
  public List<long> VisitRewardParcelId { get; set; }
  public List<long> VisitRewardAmount { get; set; }
  public List<long> VisitRewardProb { get; set; }

  public EventContentZoneVisitRewardExcelT() {
    this.EventContentId = 0;
    this.EventContentLocationId = 0;
    this.DevName = null;
    this.CharacterId = 0;
    this.CharacterDevName = null;
    this.VisitRewardParcelType = null;
    this.VisitRewardParcelId = null;
    this.VisitRewardAmount = null;
    this.VisitRewardProb = null;
  }
}


static public class EventContentZoneVisitRewardExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*EventContentLocationId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 8 /*DevName*/, false)
      && verifier.VerifyField(tablePos, 10 /*CharacterId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 12 /*CharacterDevName*/, false)
      && verifier.VerifyVectorOfData(tablePos, 14 /*VisitRewardParcelType*/, 4 /*Plana.FlatData.ParcelType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 16 /*VisitRewardParcelId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 18 /*VisitRewardAmount*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 20 /*VisitRewardProb*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
