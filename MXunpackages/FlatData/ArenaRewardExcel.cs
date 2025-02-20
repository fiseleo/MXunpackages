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

public struct ArenaRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ArenaRewardExcel GetRootAsArenaRewardExcel(ByteBuffer _bb) { return GetRootAsArenaRewardExcel(_bb, new ArenaRewardExcel()); }
  public static ArenaRewardExcel GetRootAsArenaRewardExcel(ByteBuffer _bb, ArenaRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ArenaRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long UniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.ArenaRewardType ArenaRewardType_ { get { int o = __p.__offset(6); return o != 0 ? (Plana.FlatData.ArenaRewardType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ArenaRewardType.None; } }
  public long RankStart { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RankEnd { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string RankIconPath { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRankIconPathBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetRankIconPathBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetRankIconPathArray() { return __p.__vector_as_array<byte>(12); }
  public Plana.FlatData.ParcelType RewardParcelType(int j) { int o = __p.__offset(14); return o != 0 ? (Plana.FlatData.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (Plana.FlatData.ParcelType)0; }
  public int RewardParcelTypeLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<Plana.FlatData.ParcelType> GetRewardParcelTypeBytes() { return __p.__vector_as_span<Plana.FlatData.ParcelType>(14, 4); }
#else
  public ArraySegment<byte>? GetRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public Plana.FlatData.ParcelType[] GetRewardParcelTypeArray() { int o = __p.__offset(14); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); Plana.FlatData.ParcelType[] a = new Plana.FlatData.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (Plana.FlatData.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long RewardParcelUniqueId(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelUniqueIdLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelUniqueIdBytes() { return __p.__vector_as_span<long>(16, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelUniqueIdBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public long[] GetRewardParcelUniqueIdArray() { return __p.__vector_as_array<long>(16); }
  public string RewardParcelUniqueName(int j) { int o = __p.__offset(18); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int RewardParcelUniqueNameLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
  public long RewardParcelAmount(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelAmountLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelAmountBytes() { return __p.__vector_as_span<long>(20, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelAmountBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public long[] GetRewardParcelAmountArray() { return __p.__vector_as_array<long>(20); }

  public static Offset<Plana.FlatData.ArenaRewardExcel> CreateArenaRewardExcel(FlatBufferBuilder builder,
      long UniqueId = 0,
      Plana.FlatData.ArenaRewardType ArenaRewardType_ = Plana.FlatData.ArenaRewardType.None,
      long RankStart = 0,
      long RankEnd = 0,
      StringOffset RankIconPathOffset = default(StringOffset),
      VectorOffset RewardParcelTypeOffset = default(VectorOffset),
      VectorOffset RewardParcelUniqueIdOffset = default(VectorOffset),
      VectorOffset RewardParcelUniqueNameOffset = default(VectorOffset),
      VectorOffset RewardParcelAmountOffset = default(VectorOffset)) {
    builder.StartTable(9);
    ArenaRewardExcel.AddRankEnd(builder, RankEnd);
    ArenaRewardExcel.AddRankStart(builder, RankStart);
    ArenaRewardExcel.AddUniqueId(builder, UniqueId);
    ArenaRewardExcel.AddRewardParcelAmount(builder, RewardParcelAmountOffset);
    ArenaRewardExcel.AddRewardParcelUniqueName(builder, RewardParcelUniqueNameOffset);
    ArenaRewardExcel.AddRewardParcelUniqueId(builder, RewardParcelUniqueIdOffset);
    ArenaRewardExcel.AddRewardParcelType(builder, RewardParcelTypeOffset);
    ArenaRewardExcel.AddRankIconPath(builder, RankIconPathOffset);
    ArenaRewardExcel.AddArenaRewardType_(builder, ArenaRewardType_);
    return ArenaRewardExcel.EndArenaRewardExcel(builder);
  }

  public static void StartArenaRewardExcel(FlatBufferBuilder builder) { builder.StartTable(9); }
  public static void AddUniqueId(FlatBufferBuilder builder, long uniqueId) { builder.AddLong(0, uniqueId, 0); }
  public static void AddArenaRewardType_(FlatBufferBuilder builder, Plana.FlatData.ArenaRewardType arenaRewardType_) { builder.AddInt(1, (int)arenaRewardType_, 0); }
  public static void AddRankStart(FlatBufferBuilder builder, long rankStart) { builder.AddLong(2, rankStart, 0); }
  public static void AddRankEnd(FlatBufferBuilder builder, long rankEnd) { builder.AddLong(3, rankEnd, 0); }
  public static void AddRankIconPath(FlatBufferBuilder builder, StringOffset rankIconPathOffset) { builder.AddOffset(4, rankIconPathOffset.Value, 0); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, VectorOffset rewardParcelTypeOffset) { builder.AddOffset(5, rewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelTypeVector(FlatBufferBuilder builder, Plana.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, Plana.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<Plana.FlatData.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Plana.FlatData.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardParcelUniqueId(FlatBufferBuilder builder, VectorOffset rewardParcelUniqueIdOffset) { builder.AddOffset(6, rewardParcelUniqueIdOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelUniqueIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelUniqueIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelUniqueIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelUniqueIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelUniqueIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddRewardParcelUniqueName(FlatBufferBuilder builder, VectorOffset rewardParcelUniqueNameOffset) { builder.AddOffset(7, rewardParcelUniqueNameOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelUniqueNameVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelUniqueNameVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelUniqueNameVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelUniqueNameVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelUniqueNameVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardParcelAmount(FlatBufferBuilder builder, VectorOffset rewardParcelAmountOffset) { builder.AddOffset(8, rewardParcelAmountOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<Plana.FlatData.ArenaRewardExcel> EndArenaRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.ArenaRewardExcel>(o);
  }
  public ArenaRewardExcelT UnPack() {
    var _o = new ArenaRewardExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ArenaRewardExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("ArenaReward");
    _o.UniqueId = TableEncryptionService.Convert(this.UniqueId, key);
    _o.ArenaRewardType_ = TableEncryptionService.Convert(this.ArenaRewardType_, key);
    _o.RankStart = TableEncryptionService.Convert(this.RankStart, key);
    _o.RankEnd = TableEncryptionService.Convert(this.RankEnd, key);
    _o.RankIconPath = TableEncryptionService.Convert(this.RankIconPath, key);
    _o.RewardParcelType = new List<Plana.FlatData.ParcelType>();
    for (var _j = 0; _j < this.RewardParcelTypeLength; ++_j) {_o.RewardParcelType.Add(TableEncryptionService.Convert(this.RewardParcelType(_j), key));}
    _o.RewardParcelUniqueId = new List<long>();
    for (var _j = 0; _j < this.RewardParcelUniqueIdLength; ++_j) {_o.RewardParcelUniqueId.Add(TableEncryptionService.Convert(this.RewardParcelUniqueId(_j), key));}
    _o.RewardParcelUniqueName = new List<string>();
    for (var _j = 0; _j < this.RewardParcelUniqueNameLength; ++_j) {_o.RewardParcelUniqueName.Add(TableEncryptionService.Convert(this.RewardParcelUniqueName(_j), key));}
    _o.RewardParcelAmount = new List<long>();
    for (var _j = 0; _j < this.RewardParcelAmountLength; ++_j) {_o.RewardParcelAmount.Add(TableEncryptionService.Convert(this.RewardParcelAmount(_j), key));}
  }
  public static Offset<Plana.FlatData.ArenaRewardExcel> Pack(FlatBufferBuilder builder, ArenaRewardExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.ArenaRewardExcel>);
    var _RankIconPath = _o.RankIconPath == null ? default(StringOffset) : builder.CreateString(_o.RankIconPath);
    var _RewardParcelType = default(VectorOffset);
    if (_o.RewardParcelType != null) {
      var __RewardParcelType = _o.RewardParcelType.ToArray();
      _RewardParcelType = CreateRewardParcelTypeVector(builder, __RewardParcelType);
    }
    var _RewardParcelUniqueId = default(VectorOffset);
    if (_o.RewardParcelUniqueId != null) {
      var __RewardParcelUniqueId = _o.RewardParcelUniqueId.ToArray();
      _RewardParcelUniqueId = CreateRewardParcelUniqueIdVector(builder, __RewardParcelUniqueId);
    }
    var _RewardParcelUniqueName = default(VectorOffset);
    if (_o.RewardParcelUniqueName != null) {
      var __RewardParcelUniqueName = new StringOffset[_o.RewardParcelUniqueName.Count];
      for (var _j = 0; _j < __RewardParcelUniqueName.Length; ++_j) { __RewardParcelUniqueName[_j] = builder.CreateString(_o.RewardParcelUniqueName[_j]); }
      _RewardParcelUniqueName = CreateRewardParcelUniqueNameVector(builder, __RewardParcelUniqueName);
    }
    var _RewardParcelAmount = default(VectorOffset);
    if (_o.RewardParcelAmount != null) {
      var __RewardParcelAmount = _o.RewardParcelAmount.ToArray();
      _RewardParcelAmount = CreateRewardParcelAmountVector(builder, __RewardParcelAmount);
    }
    return CreateArenaRewardExcel(
      builder,
      _o.UniqueId,
      _o.ArenaRewardType_,
      _o.RankStart,
      _o.RankEnd,
      _RankIconPath,
      _RewardParcelType,
      _RewardParcelUniqueId,
      _RewardParcelUniqueName,
      _RewardParcelAmount);
  }
}

public class ArenaRewardExcelT
{
  public long UniqueId { get; set; }
  public Plana.FlatData.ArenaRewardType ArenaRewardType_ { get; set; }
  public long RankStart { get; set; }
  public long RankEnd { get; set; }
  public string RankIconPath { get; set; }
  public List<Plana.FlatData.ParcelType> RewardParcelType { get; set; }
  public List<long> RewardParcelUniqueId { get; set; }
  public List<string> RewardParcelUniqueName { get; set; }
  public List<long> RewardParcelAmount { get; set; }

  public ArenaRewardExcelT() {
    this.UniqueId = 0;
    this.ArenaRewardType_ = Plana.FlatData.ArenaRewardType.None;
    this.RankStart = 0;
    this.RankEnd = 0;
    this.RankIconPath = null;
    this.RewardParcelType = null;
    this.RewardParcelUniqueId = null;
    this.RewardParcelUniqueName = null;
    this.RewardParcelAmount = null;
  }
}


static public class ArenaRewardExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*UniqueId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*ArenaRewardType_*/, 4 /*Plana.FlatData.ArenaRewardType*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*RankStart*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*RankEnd*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 12 /*RankIconPath*/, false)
      && verifier.VerifyVectorOfData(tablePos, 14 /*RewardParcelType*/, 4 /*Plana.FlatData.ParcelType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 16 /*RewardParcelUniqueId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfStrings(tablePos, 18 /*RewardParcelUniqueName*/, false)
      && verifier.VerifyVectorOfData(tablePos, 20 /*RewardParcelAmount*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
