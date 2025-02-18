// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct AcademyRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static AcademyRewardExcel GetRootAsAcademyRewardExcel(ByteBuffer _bb) { return GetRootAsAcademyRewardExcel(_bb, new AcademyRewardExcel()); }
  public static AcademyRewardExcel GetRootAsAcademyRewardExcel(ByteBuffer _bb, AcademyRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AcademyRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Location { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocationBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetLocationBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetLocationArray() { return __p.__vector_as_array<byte>(4); }
  public long ScheduleGroupId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long OrderInGroup { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Id { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string ProgressTexture { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetProgressTextureBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetProgressTextureBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetProgressTextureArray() { return __p.__vector_as_array<byte>(12); }
  public uint LocalizeEtcId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public long LocationRank { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long FavorExp { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long SecretStoneAmount { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long SecretStoneProb { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ExtraFavorExp { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ExtraFavorExpProb { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.ParcelType ExtraRewardParcelType(int j) { int o = __p.__offset(28); return o != 0 ? (Plana.FlatData.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (Plana.FlatData.ParcelType)0; }
  public int ExtraRewardParcelTypeLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<Plana.FlatData.ParcelType> GetExtraRewardParcelTypeBytes() { return __p.__vector_as_span<Plana.FlatData.ParcelType>(28, 4); }
#else
  public ArraySegment<byte>? GetExtraRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public Plana.FlatData.ParcelType[] GetExtraRewardParcelTypeArray() { int o = __p.__offset(28); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); Plana.FlatData.ParcelType[] a = new Plana.FlatData.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (Plana.FlatData.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long ExtraRewardParcelId(int j) { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ExtraRewardParcelIdLength { get { int o = __p.__offset(30); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetExtraRewardParcelIdBytes() { return __p.__vector_as_span<long>(30, 8); }
#else
  public ArraySegment<byte>? GetExtraRewardParcelIdBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public long[] GetExtraRewardParcelIdArray() { return __p.__vector_as_array<long>(30); }
  public long ExtraRewardAmount(int j) { int o = __p.__offset(32); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ExtraRewardAmountLength { get { int o = __p.__offset(32); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetExtraRewardAmountBytes() { return __p.__vector_as_span<long>(32, 8); }
#else
  public ArraySegment<byte>? GetExtraRewardAmountBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public long[] GetExtraRewardAmountArray() { return __p.__vector_as_array<long>(32); }
  public long ExtraRewardProb(int j) { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ExtraRewardProbLength { get { int o = __p.__offset(34); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetExtraRewardProbBytes() { return __p.__vector_as_span<long>(34, 8); }
#else
  public ArraySegment<byte>? GetExtraRewardProbBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public long[] GetExtraRewardProbArray() { return __p.__vector_as_array<long>(34); }
  public bool IsExtraRewardDisplayed(int j) { int o = __p.__offset(36); return o != 0 ? 0!=__p.bb.Get(__p.__vector(o) + j * 1) : false; }
  public int IsExtraRewardDisplayedLength { get { int o = __p.__offset(36); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<bool> GetIsExtraRewardDisplayedBytes() { return __p.__vector_as_span<bool>(36, 1); }
#else
  public ArraySegment<byte>? GetIsExtraRewardDisplayedBytes() { return __p.__vector_as_arraysegment(36); }
#endif
  public bool[] GetIsExtraRewardDisplayedArray() { return __p.__vector_as_array<bool>(36); }
  public Plana.FlatData.ParcelType RewardParcelType(int j) { int o = __p.__offset(38); return o != 0 ? (Plana.FlatData.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (Plana.FlatData.ParcelType)0; }
  public int RewardParcelTypeLength { get { int o = __p.__offset(38); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<Plana.FlatData.ParcelType> GetRewardParcelTypeBytes() { return __p.__vector_as_span<Plana.FlatData.ParcelType>(38, 4); }
#else
  public ArraySegment<byte>? GetRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public Plana.FlatData.ParcelType[] GetRewardParcelTypeArray() { int o = __p.__offset(38); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); Plana.FlatData.ParcelType[] a = new Plana.FlatData.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (Plana.FlatData.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long RewardParcelId(int j) { int o = __p.__offset(40); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelIdLength { get { int o = __p.__offset(40); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelIdBytes() { return __p.__vector_as_span<long>(40, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelIdBytes() { return __p.__vector_as_arraysegment(40); }
#endif
  public long[] GetRewardParcelIdArray() { return __p.__vector_as_array<long>(40); }
  public long RewardAmount(int j) { int o = __p.__offset(42); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardAmountLength { get { int o = __p.__offset(42); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardAmountBytes() { return __p.__vector_as_span<long>(42, 8); }
#else
  public ArraySegment<byte>? GetRewardAmountBytes() { return __p.__vector_as_arraysegment(42); }
#endif
  public long[] GetRewardAmountArray() { return __p.__vector_as_array<long>(42); }

  public static Offset<Plana.FlatData.AcademyRewardExcel> CreateAcademyRewardExcel(FlatBufferBuilder builder,
      StringOffset LocationOffset = default(StringOffset),
      long ScheduleGroupId = 0,
      long OrderInGroup = 0,
      long Id = 0,
      StringOffset ProgressTextureOffset = default(StringOffset),
      uint LocalizeEtcId = 0,
      long LocationRank = 0,
      long FavorExp = 0,
      long SecretStoneAmount = 0,
      long SecretStoneProb = 0,
      long ExtraFavorExp = 0,
      long ExtraFavorExpProb = 0,
      VectorOffset ExtraRewardParcelTypeOffset = default(VectorOffset),
      VectorOffset ExtraRewardParcelIdOffset = default(VectorOffset),
      VectorOffset ExtraRewardAmountOffset = default(VectorOffset),
      VectorOffset ExtraRewardProbOffset = default(VectorOffset),
      VectorOffset IsExtraRewardDisplayedOffset = default(VectorOffset),
      VectorOffset RewardParcelTypeOffset = default(VectorOffset),
      VectorOffset RewardParcelIdOffset = default(VectorOffset),
      VectorOffset RewardAmountOffset = default(VectorOffset)) {
    builder.StartTable(20);
    AcademyRewardExcel.AddExtraFavorExpProb(builder, ExtraFavorExpProb);
    AcademyRewardExcel.AddExtraFavorExp(builder, ExtraFavorExp);
    AcademyRewardExcel.AddSecretStoneProb(builder, SecretStoneProb);
    AcademyRewardExcel.AddSecretStoneAmount(builder, SecretStoneAmount);
    AcademyRewardExcel.AddFavorExp(builder, FavorExp);
    AcademyRewardExcel.AddLocationRank(builder, LocationRank);
    AcademyRewardExcel.AddId(builder, Id);
    AcademyRewardExcel.AddOrderInGroup(builder, OrderInGroup);
    AcademyRewardExcel.AddScheduleGroupId(builder, ScheduleGroupId);
    AcademyRewardExcel.AddRewardAmount(builder, RewardAmountOffset);
    AcademyRewardExcel.AddRewardParcelId(builder, RewardParcelIdOffset);
    AcademyRewardExcel.AddRewardParcelType(builder, RewardParcelTypeOffset);
    AcademyRewardExcel.AddIsExtraRewardDisplayed(builder, IsExtraRewardDisplayedOffset);
    AcademyRewardExcel.AddExtraRewardProb(builder, ExtraRewardProbOffset);
    AcademyRewardExcel.AddExtraRewardAmount(builder, ExtraRewardAmountOffset);
    AcademyRewardExcel.AddExtraRewardParcelId(builder, ExtraRewardParcelIdOffset);
    AcademyRewardExcel.AddExtraRewardParcelType(builder, ExtraRewardParcelTypeOffset);
    AcademyRewardExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    AcademyRewardExcel.AddProgressTexture(builder, ProgressTextureOffset);
    AcademyRewardExcel.AddLocation(builder, LocationOffset);
    return AcademyRewardExcel.EndAcademyRewardExcel(builder);
  }

  public static void StartAcademyRewardExcel(FlatBufferBuilder builder) { builder.StartTable(20); }
  public static void AddLocation(FlatBufferBuilder builder, StringOffset locationOffset) { builder.AddOffset(0, locationOffset.Value, 0); }
  public static void AddScheduleGroupId(FlatBufferBuilder builder, long scheduleGroupId) { builder.AddLong(1, scheduleGroupId, 0); }
  public static void AddOrderInGroup(FlatBufferBuilder builder, long orderInGroup) { builder.AddLong(2, orderInGroup, 0); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(3, id, 0); }
  public static void AddProgressTexture(FlatBufferBuilder builder, StringOffset progressTextureOffset) { builder.AddOffset(4, progressTextureOffset.Value, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint localizeEtcId) { builder.AddUint(5, localizeEtcId, 0); }
  public static void AddLocationRank(FlatBufferBuilder builder, long locationRank) { builder.AddLong(6, locationRank, 0); }
  public static void AddFavorExp(FlatBufferBuilder builder, long favorExp) { builder.AddLong(7, favorExp, 0); }
  public static void AddSecretStoneAmount(FlatBufferBuilder builder, long secretStoneAmount) { builder.AddLong(8, secretStoneAmount, 0); }
  public static void AddSecretStoneProb(FlatBufferBuilder builder, long secretStoneProb) { builder.AddLong(9, secretStoneProb, 0); }
  public static void AddExtraFavorExp(FlatBufferBuilder builder, long extraFavorExp) { builder.AddLong(10, extraFavorExp, 0); }
  public static void AddExtraFavorExpProb(FlatBufferBuilder builder, long extraFavorExpProb) { builder.AddLong(11, extraFavorExpProb, 0); }
  public static void AddExtraRewardParcelType(FlatBufferBuilder builder, VectorOffset extraRewardParcelTypeOffset) { builder.AddOffset(12, extraRewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateExtraRewardParcelTypeVector(FlatBufferBuilder builder, Plana.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateExtraRewardParcelTypeVectorBlock(FlatBufferBuilder builder, Plana.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExtraRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<Plana.FlatData.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExtraRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Plana.FlatData.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartExtraRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddExtraRewardParcelId(FlatBufferBuilder builder, VectorOffset extraRewardParcelIdOffset) { builder.AddOffset(13, extraRewardParcelIdOffset.Value, 0); }
  public static VectorOffset CreateExtraRewardParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateExtraRewardParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExtraRewardParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExtraRewardParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartExtraRewardParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddExtraRewardAmount(FlatBufferBuilder builder, VectorOffset extraRewardAmountOffset) { builder.AddOffset(14, extraRewardAmountOffset.Value, 0); }
  public static VectorOffset CreateExtraRewardAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateExtraRewardAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExtraRewardAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExtraRewardAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartExtraRewardAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddExtraRewardProb(FlatBufferBuilder builder, VectorOffset extraRewardProbOffset) { builder.AddOffset(15, extraRewardProbOffset.Value, 0); }
  public static VectorOffset CreateExtraRewardProbVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateExtraRewardProbVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExtraRewardProbVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExtraRewardProbVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartExtraRewardProbVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddIsExtraRewardDisplayed(FlatBufferBuilder builder, VectorOffset isExtraRewardDisplayedOffset) { builder.AddOffset(16, isExtraRewardDisplayedOffset.Value, 0); }
  public static VectorOffset CreateIsExtraRewardDisplayedVector(FlatBufferBuilder builder, bool[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddBool(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateIsExtraRewardDisplayedVectorBlock(FlatBufferBuilder builder, bool[] data) { builder.StartVector(1, data.Length, 1); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateIsExtraRewardDisplayedVectorBlock(FlatBufferBuilder builder, ArraySegment<bool> data) { builder.StartVector(1, data.Count, 1); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateIsExtraRewardDisplayedVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<bool>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartIsExtraRewardDisplayedVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, VectorOffset rewardParcelTypeOffset) { builder.AddOffset(17, rewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelTypeVector(FlatBufferBuilder builder, Plana.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, Plana.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<Plana.FlatData.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Plana.FlatData.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardParcelId(FlatBufferBuilder builder, VectorOffset rewardParcelIdOffset) { builder.AddOffset(18, rewardParcelIdOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddRewardAmount(FlatBufferBuilder builder, VectorOffset rewardAmountOffset) { builder.AddOffset(19, rewardAmountOffset.Value, 0); }
  public static VectorOffset CreateRewardAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<Plana.FlatData.AcademyRewardExcel> EndAcademyRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.AcademyRewardExcel>(o);
  }
  public AcademyRewardExcelT UnPack() {
    var _o = new AcademyRewardExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(AcademyRewardExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("AcademyReward");
    _o.Location = TableEncryptionService.Convert(this.Location, key);
    _o.ScheduleGroupId = TableEncryptionService.Convert(this.ScheduleGroupId, key);
    _o.OrderInGroup = TableEncryptionService.Convert(this.OrderInGroup, key);
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.ProgressTexture = TableEncryptionService.Convert(this.ProgressTexture, key);
    _o.LocalizeEtcId = TableEncryptionService.Convert(this.LocalizeEtcId, key);
    _o.LocationRank = TableEncryptionService.Convert(this.LocationRank, key);
    _o.FavorExp = TableEncryptionService.Convert(this.FavorExp, key);
    _o.SecretStoneAmount = TableEncryptionService.Convert(this.SecretStoneAmount, key);
    _o.SecretStoneProb = TableEncryptionService.Convert(this.SecretStoneProb, key);
    _o.ExtraFavorExp = TableEncryptionService.Convert(this.ExtraFavorExp, key);
    _o.ExtraFavorExpProb = TableEncryptionService.Convert(this.ExtraFavorExpProb, key);
    _o.ExtraRewardParcelType = new List<Plana.FlatData.ParcelType>();
    for (var _j = 0; _j < this.ExtraRewardParcelTypeLength; ++_j) {_o.ExtraRewardParcelType.Add(TableEncryptionService.Convert(this.ExtraRewardParcelType(_j), key));}
    _o.ExtraRewardParcelId = new List<long>();
    for (var _j = 0; _j < this.ExtraRewardParcelIdLength; ++_j) {_o.ExtraRewardParcelId.Add(TableEncryptionService.Convert(this.ExtraRewardParcelId(_j), key));}
    _o.ExtraRewardAmount = new List<long>();
    for (var _j = 0; _j < this.ExtraRewardAmountLength; ++_j) {_o.ExtraRewardAmount.Add(TableEncryptionService.Convert(this.ExtraRewardAmount(_j), key));}
    _o.ExtraRewardProb = new List<long>();
    for (var _j = 0; _j < this.ExtraRewardProbLength; ++_j) {_o.ExtraRewardProb.Add(TableEncryptionService.Convert(this.ExtraRewardProb(_j), key));}
    _o.IsExtraRewardDisplayed = new List<bool>();
    for (var _j = 0; _j < this.IsExtraRewardDisplayedLength; ++_j) {_o.IsExtraRewardDisplayed.Add(TableEncryptionService.Convert(this.IsExtraRewardDisplayed(_j), key));}
    _o.RewardParcelType = new List<Plana.FlatData.ParcelType>();
    for (var _j = 0; _j < this.RewardParcelTypeLength; ++_j) {_o.RewardParcelType.Add(TableEncryptionService.Convert(this.RewardParcelType(_j), key));}
    _o.RewardParcelId = new List<long>();
    for (var _j = 0; _j < this.RewardParcelIdLength; ++_j) {_o.RewardParcelId.Add(TableEncryptionService.Convert(this.RewardParcelId(_j), key));}
    _o.RewardAmount = new List<long>();
    for (var _j = 0; _j < this.RewardAmountLength; ++_j) {_o.RewardAmount.Add(TableEncryptionService.Convert(this.RewardAmount(_j), key));}
  }
  public static Offset<Plana.FlatData.AcademyRewardExcel> Pack(FlatBufferBuilder builder, AcademyRewardExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.AcademyRewardExcel>);
    var _Location = _o.Location == null ? default(StringOffset) : builder.CreateString(_o.Location);
    var _ProgressTexture = _o.ProgressTexture == null ? default(StringOffset) : builder.CreateString(_o.ProgressTexture);
    var _ExtraRewardParcelType = default(VectorOffset);
    if (_o.ExtraRewardParcelType != null) {
      var __ExtraRewardParcelType = _o.ExtraRewardParcelType.ToArray();
      _ExtraRewardParcelType = CreateExtraRewardParcelTypeVector(builder, __ExtraRewardParcelType);
    }
    var _ExtraRewardParcelId = default(VectorOffset);
    if (_o.ExtraRewardParcelId != null) {
      var __ExtraRewardParcelId = _o.ExtraRewardParcelId.ToArray();
      _ExtraRewardParcelId = CreateExtraRewardParcelIdVector(builder, __ExtraRewardParcelId);
    }
    var _ExtraRewardAmount = default(VectorOffset);
    if (_o.ExtraRewardAmount != null) {
      var __ExtraRewardAmount = _o.ExtraRewardAmount.ToArray();
      _ExtraRewardAmount = CreateExtraRewardAmountVector(builder, __ExtraRewardAmount);
    }
    var _ExtraRewardProb = default(VectorOffset);
    if (_o.ExtraRewardProb != null) {
      var __ExtraRewardProb = _o.ExtraRewardProb.ToArray();
      _ExtraRewardProb = CreateExtraRewardProbVector(builder, __ExtraRewardProb);
    }
    var _IsExtraRewardDisplayed = default(VectorOffset);
    if (_o.IsExtraRewardDisplayed != null) {
      var __IsExtraRewardDisplayed = _o.IsExtraRewardDisplayed.ToArray();
      _IsExtraRewardDisplayed = CreateIsExtraRewardDisplayedVector(builder, __IsExtraRewardDisplayed);
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
    return CreateAcademyRewardExcel(
      builder,
      _Location,
      _o.ScheduleGroupId,
      _o.OrderInGroup,
      _o.Id,
      _ProgressTexture,
      _o.LocalizeEtcId,
      _o.LocationRank,
      _o.FavorExp,
      _o.SecretStoneAmount,
      _o.SecretStoneProb,
      _o.ExtraFavorExp,
      _o.ExtraFavorExpProb,
      _ExtraRewardParcelType,
      _ExtraRewardParcelId,
      _ExtraRewardAmount,
      _ExtraRewardProb,
      _IsExtraRewardDisplayed,
      _RewardParcelType,
      _RewardParcelId,
      _RewardAmount);
  }
}

public class AcademyRewardExcelT
{
  public string Location { get; set; }
  public long ScheduleGroupId { get; set; }
  public long OrderInGroup { get; set; }
  public long Id { get; set; }
  public string ProgressTexture { get; set; }
  public uint LocalizeEtcId { get; set; }
  public long LocationRank { get; set; }
  public long FavorExp { get; set; }
  public long SecretStoneAmount { get; set; }
  public long SecretStoneProb { get; set; }
  public long ExtraFavorExp { get; set; }
  public long ExtraFavorExpProb { get; set; }
  public List<Plana.FlatData.ParcelType> ExtraRewardParcelType { get; set; }
  public List<long> ExtraRewardParcelId { get; set; }
  public List<long> ExtraRewardAmount { get; set; }
  public List<long> ExtraRewardProb { get; set; }
  public List<bool> IsExtraRewardDisplayed { get; set; }
  public List<Plana.FlatData.ParcelType> RewardParcelType { get; set; }
  public List<long> RewardParcelId { get; set; }
  public List<long> RewardAmount { get; set; }

  public AcademyRewardExcelT() {
    this.Location = null;
    this.ScheduleGroupId = 0;
    this.OrderInGroup = 0;
    this.Id = 0;
    this.ProgressTexture = null;
    this.LocalizeEtcId = 0;
    this.LocationRank = 0;
    this.FavorExp = 0;
    this.SecretStoneAmount = 0;
    this.SecretStoneProb = 0;
    this.ExtraFavorExp = 0;
    this.ExtraFavorExpProb = 0;
    this.ExtraRewardParcelType = null;
    this.ExtraRewardParcelId = null;
    this.ExtraRewardAmount = null;
    this.ExtraRewardProb = null;
    this.IsExtraRewardDisplayed = null;
    this.RewardParcelType = null;
    this.RewardParcelId = null;
    this.RewardAmount = null;
  }
}


static public class AcademyRewardExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyString(tablePos, 4 /*Location*/, false)
      && verifier.VerifyField(tablePos, 6 /*ScheduleGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*OrderInGroup*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 12 /*ProgressTexture*/, false)
      && verifier.VerifyField(tablePos, 14 /*LocalizeEtcId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*LocationRank*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*FavorExp*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 20 /*SecretStoneAmount*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 22 /*SecretStoneProb*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 24 /*ExtraFavorExp*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 26 /*ExtraFavorExpProb*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 28 /*ExtraRewardParcelType*/, 4 /*Plana.FlatData.ParcelType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 30 /*ExtraRewardParcelId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 32 /*ExtraRewardAmount*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 34 /*ExtraRewardProb*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 36 /*IsExtraRewardDisplayed*/, 1 /*bool*/, false)
      && verifier.VerifyVectorOfData(tablePos, 38 /*RewardParcelType*/, 4 /*Plana.FlatData.ParcelType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 40 /*RewardParcelId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 42 /*RewardAmount*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
