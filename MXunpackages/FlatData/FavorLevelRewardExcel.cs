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

public struct FavorLevelRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static FavorLevelRewardExcel GetRootAsFavorLevelRewardExcel(ByteBuffer _bb) { return GetRootAsFavorLevelRewardExcel(_bb, new FavorLevelRewardExcel()); }
  public static FavorLevelRewardExcel GetRootAsFavorLevelRewardExcel(ByteBuffer _bb, FavorLevelRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FavorLevelRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long CharacterId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long FavorLevel { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.EquipmentOptionType StatType(int j) { int o = __p.__offset(8); return o != 0 ? (Plana.FlatData.EquipmentOptionType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (Plana.FlatData.EquipmentOptionType)0; }
  public int StatTypeLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<Plana.FlatData.EquipmentOptionType> GetStatTypeBytes() { return __p.__vector_as_span<Plana.FlatData.EquipmentOptionType>(8, 4); }
#else
  public ArraySegment<byte>? GetStatTypeBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public Plana.FlatData.EquipmentOptionType[] GetStatTypeArray() { int o = __p.__offset(8); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); Plana.FlatData.EquipmentOptionType[] a = new Plana.FlatData.EquipmentOptionType[l]; for (int i = 0; i < l; i++) { a[i] = (Plana.FlatData.EquipmentOptionType)__p.bb.GetInt(p + i * 4); } return a; }
  public long StatValue(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int StatValueLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetStatValueBytes() { return __p.__vector_as_span<long>(10, 8); }
#else
  public ArraySegment<byte>? GetStatValueBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public long[] GetStatValueArray() { return __p.__vector_as_array<long>(10); }
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
  public long RewardAmount(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardAmountLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardAmountBytes() { return __p.__vector_as_span<long>(16, 8); }
#else
  public ArraySegment<byte>? GetRewardAmountBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public long[] GetRewardAmountArray() { return __p.__vector_as_array<long>(16); }

  public static Offset<Plana.FlatData.FavorLevelRewardExcel> CreateFavorLevelRewardExcel(FlatBufferBuilder builder,
      long CharacterId = 0,
      long FavorLevel = 0,
      VectorOffset StatTypeOffset = default(VectorOffset),
      VectorOffset StatValueOffset = default(VectorOffset),
      VectorOffset RewardParcelTypeOffset = default(VectorOffset),
      VectorOffset RewardParcelIdOffset = default(VectorOffset),
      VectorOffset RewardAmountOffset = default(VectorOffset)) {
    builder.StartTable(7);
    FavorLevelRewardExcel.AddFavorLevel(builder, FavorLevel);
    FavorLevelRewardExcel.AddCharacterId(builder, CharacterId);
    FavorLevelRewardExcel.AddRewardAmount(builder, RewardAmountOffset);
    FavorLevelRewardExcel.AddRewardParcelId(builder, RewardParcelIdOffset);
    FavorLevelRewardExcel.AddRewardParcelType(builder, RewardParcelTypeOffset);
    FavorLevelRewardExcel.AddStatValue(builder, StatValueOffset);
    FavorLevelRewardExcel.AddStatType(builder, StatTypeOffset);
    return FavorLevelRewardExcel.EndFavorLevelRewardExcel(builder);
  }

  public static void StartFavorLevelRewardExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddCharacterId(FlatBufferBuilder builder, long characterId) { builder.AddLong(0, characterId, 0); }
  public static void AddFavorLevel(FlatBufferBuilder builder, long favorLevel) { builder.AddLong(1, favorLevel, 0); }
  public static void AddStatType(FlatBufferBuilder builder, VectorOffset statTypeOffset) { builder.AddOffset(2, statTypeOffset.Value, 0); }
  public static VectorOffset CreateStatTypeVector(FlatBufferBuilder builder, Plana.FlatData.EquipmentOptionType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStatTypeVectorBlock(FlatBufferBuilder builder, Plana.FlatData.EquipmentOptionType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<Plana.FlatData.EquipmentOptionType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Plana.FlatData.EquipmentOptionType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStatTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddStatValue(FlatBufferBuilder builder, VectorOffset statValueOffset) { builder.AddOffset(3, statValueOffset.Value, 0); }
  public static VectorOffset CreateStatValueVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStatValueVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatValueVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatValueVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStatValueVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
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
  public static void AddRewardAmount(FlatBufferBuilder builder, VectorOffset rewardAmountOffset) { builder.AddOffset(6, rewardAmountOffset.Value, 0); }
  public static VectorOffset CreateRewardAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<Plana.FlatData.FavorLevelRewardExcel> EndFavorLevelRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.FavorLevelRewardExcel>(o);
  }
  public FavorLevelRewardExcelT UnPack() {
    var _o = new FavorLevelRewardExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FavorLevelRewardExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("FavorLevelReward");
    _o.CharacterId = TableEncryptionService.Convert(this.CharacterId, key);
    _o.FavorLevel = TableEncryptionService.Convert(this.FavorLevel, key);
    _o.StatType = new List<Plana.FlatData.EquipmentOptionType>();
    for (var _j = 0; _j < this.StatTypeLength; ++_j) {_o.StatType.Add(TableEncryptionService.Convert(this.StatType(_j), key));}
    _o.StatValue = new List<long>();
    for (var _j = 0; _j < this.StatValueLength; ++_j) {_o.StatValue.Add(TableEncryptionService.Convert(this.StatValue(_j), key));}
    _o.RewardParcelType = new List<Plana.FlatData.ParcelType>();
    for (var _j = 0; _j < this.RewardParcelTypeLength; ++_j) {_o.RewardParcelType.Add(TableEncryptionService.Convert(this.RewardParcelType(_j), key));}
    _o.RewardParcelId = new List<long>();
    for (var _j = 0; _j < this.RewardParcelIdLength; ++_j) {_o.RewardParcelId.Add(TableEncryptionService.Convert(this.RewardParcelId(_j), key));}
    _o.RewardAmount = new List<long>();
    for (var _j = 0; _j < this.RewardAmountLength; ++_j) {_o.RewardAmount.Add(TableEncryptionService.Convert(this.RewardAmount(_j), key));}
  }
  public static Offset<Plana.FlatData.FavorLevelRewardExcel> Pack(FlatBufferBuilder builder, FavorLevelRewardExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.FavorLevelRewardExcel>);
    var _StatType = default(VectorOffset);
    if (_o.StatType != null) {
      var __StatType = _o.StatType.ToArray();
      _StatType = CreateStatTypeVector(builder, __StatType);
    }
    var _StatValue = default(VectorOffset);
    if (_o.StatValue != null) {
      var __StatValue = _o.StatValue.ToArray();
      _StatValue = CreateStatValueVector(builder, __StatValue);
    }
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
    var _RewardAmount = default(VectorOffset);
    if (_o.RewardAmount != null) {
      var __RewardAmount = _o.RewardAmount.ToArray();
      _RewardAmount = CreateRewardAmountVector(builder, __RewardAmount);
    }
    return CreateFavorLevelRewardExcel(
      builder,
      _o.CharacterId,
      _o.FavorLevel,
      _StatType,
      _StatValue,
      _RewardParcelType,
      _RewardParcelId,
      _RewardAmount);
  }
}

public class FavorLevelRewardExcelT
{
  public long CharacterId { get; set; }
  public long FavorLevel { get; set; }
  public List<Plana.FlatData.EquipmentOptionType> StatType { get; set; }
  public List<long> StatValue { get; set; }
  public List<Plana.FlatData.ParcelType> RewardParcelType { get; set; }
  public List<long> RewardParcelId { get; set; }
  public List<long> RewardAmount { get; set; }

  public FavorLevelRewardExcelT() {
    this.CharacterId = 0;
    this.FavorLevel = 0;
    this.StatType = null;
    this.StatValue = null;
    this.RewardParcelType = null;
    this.RewardParcelId = null;
    this.RewardAmount = null;
  }
}


static public class FavorLevelRewardExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*CharacterId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*FavorLevel*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 8 /*StatType*/, 4 /*Plana.FlatData.EquipmentOptionType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*StatValue*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*RewardParcelType*/, 4 /*Plana.FlatData.ParcelType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 14 /*RewardParcelId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 16 /*RewardAmount*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
