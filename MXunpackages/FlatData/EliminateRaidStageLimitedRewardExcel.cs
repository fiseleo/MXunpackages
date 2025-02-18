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

public struct EliminateRaidStageLimitedRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EliminateRaidStageLimitedRewardExcel GetRootAsEliminateRaidStageLimitedRewardExcel(ByteBuffer _bb) { return GetRootAsEliminateRaidStageLimitedRewardExcel(_bb, new EliminateRaidStageLimitedRewardExcel()); }
  public static EliminateRaidStageLimitedRewardExcel GetRootAsEliminateRaidStageLimitedRewardExcel(ByteBuffer _bb, EliminateRaidStageLimitedRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EliminateRaidStageLimitedRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long LimitedRewardId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.ParcelType LimitedRewardParcelType(int j) { int o = __p.__offset(6); return o != 0 ? (Plana.FlatData.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (Plana.FlatData.ParcelType)0; }
  public int LimitedRewardParcelTypeLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<Plana.FlatData.ParcelType> GetLimitedRewardParcelTypeBytes() { return __p.__vector_as_span<Plana.FlatData.ParcelType>(6, 4); }
#else
  public ArraySegment<byte>? GetLimitedRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public Plana.FlatData.ParcelType[] GetLimitedRewardParcelTypeArray() { int o = __p.__offset(6); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); Plana.FlatData.ParcelType[] a = new Plana.FlatData.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (Plana.FlatData.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long LimitedRewardParcelUniqueId(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int LimitedRewardParcelUniqueIdLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetLimitedRewardParcelUniqueIdBytes() { return __p.__vector_as_span<long>(8, 8); }
#else
  public ArraySegment<byte>? GetLimitedRewardParcelUniqueIdBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public long[] GetLimitedRewardParcelUniqueIdArray() { return __p.__vector_as_array<long>(8); }
  public long LimitedRewardAmount(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int LimitedRewardAmountLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetLimitedRewardAmountBytes() { return __p.__vector_as_span<long>(10, 8); }
#else
  public ArraySegment<byte>? GetLimitedRewardAmountBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public long[] GetLimitedRewardAmountArray() { return __p.__vector_as_array<long>(10); }

  public static Offset<Plana.FlatData.EliminateRaidStageLimitedRewardExcel> CreateEliminateRaidStageLimitedRewardExcel(FlatBufferBuilder builder,
      long LimitedRewardId = 0,
      VectorOffset LimitedRewardParcelTypeOffset = default(VectorOffset),
      VectorOffset LimitedRewardParcelUniqueIdOffset = default(VectorOffset),
      VectorOffset LimitedRewardAmountOffset = default(VectorOffset)) {
    builder.StartTable(4);
    EliminateRaidStageLimitedRewardExcel.AddLimitedRewardId(builder, LimitedRewardId);
    EliminateRaidStageLimitedRewardExcel.AddLimitedRewardAmount(builder, LimitedRewardAmountOffset);
    EliminateRaidStageLimitedRewardExcel.AddLimitedRewardParcelUniqueId(builder, LimitedRewardParcelUniqueIdOffset);
    EliminateRaidStageLimitedRewardExcel.AddLimitedRewardParcelType(builder, LimitedRewardParcelTypeOffset);
    return EliminateRaidStageLimitedRewardExcel.EndEliminateRaidStageLimitedRewardExcel(builder);
  }

  public static void StartEliminateRaidStageLimitedRewardExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddLimitedRewardId(FlatBufferBuilder builder, long limitedRewardId) { builder.AddLong(0, limitedRewardId, 0); }
  public static void AddLimitedRewardParcelType(FlatBufferBuilder builder, VectorOffset limitedRewardParcelTypeOffset) { builder.AddOffset(1, limitedRewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateLimitedRewardParcelTypeVector(FlatBufferBuilder builder, Plana.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateLimitedRewardParcelTypeVectorBlock(FlatBufferBuilder builder, Plana.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateLimitedRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<Plana.FlatData.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateLimitedRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Plana.FlatData.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartLimitedRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLimitedRewardParcelUniqueId(FlatBufferBuilder builder, VectorOffset limitedRewardParcelUniqueIdOffset) { builder.AddOffset(2, limitedRewardParcelUniqueIdOffset.Value, 0); }
  public static VectorOffset CreateLimitedRewardParcelUniqueIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateLimitedRewardParcelUniqueIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateLimitedRewardParcelUniqueIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateLimitedRewardParcelUniqueIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartLimitedRewardParcelUniqueIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddLimitedRewardAmount(FlatBufferBuilder builder, VectorOffset limitedRewardAmountOffset) { builder.AddOffset(3, limitedRewardAmountOffset.Value, 0); }
  public static VectorOffset CreateLimitedRewardAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateLimitedRewardAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateLimitedRewardAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateLimitedRewardAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartLimitedRewardAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<Plana.FlatData.EliminateRaidStageLimitedRewardExcel> EndEliminateRaidStageLimitedRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.EliminateRaidStageLimitedRewardExcel>(o);
  }
  public EliminateRaidStageLimitedRewardExcelT UnPack() {
    var _o = new EliminateRaidStageLimitedRewardExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EliminateRaidStageLimitedRewardExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("EliminateRaidStageLimitedReward");
    _o.LimitedRewardId = TableEncryptionService.Convert(this.LimitedRewardId, key);
    _o.LimitedRewardParcelType = new List<Plana.FlatData.ParcelType>();
    for (var _j = 0; _j < this.LimitedRewardParcelTypeLength; ++_j) {_o.LimitedRewardParcelType.Add(TableEncryptionService.Convert(this.LimitedRewardParcelType(_j), key));}
    _o.LimitedRewardParcelUniqueId = new List<long>();
    for (var _j = 0; _j < this.LimitedRewardParcelUniqueIdLength; ++_j) {_o.LimitedRewardParcelUniqueId.Add(TableEncryptionService.Convert(this.LimitedRewardParcelUniqueId(_j), key));}
    _o.LimitedRewardAmount = new List<long>();
    for (var _j = 0; _j < this.LimitedRewardAmountLength; ++_j) {_o.LimitedRewardAmount.Add(TableEncryptionService.Convert(this.LimitedRewardAmount(_j), key));}
  }
  public static Offset<Plana.FlatData.EliminateRaidStageLimitedRewardExcel> Pack(FlatBufferBuilder builder, EliminateRaidStageLimitedRewardExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.EliminateRaidStageLimitedRewardExcel>);
    var _LimitedRewardParcelType = default(VectorOffset);
    if (_o.LimitedRewardParcelType != null) {
      var __LimitedRewardParcelType = _o.LimitedRewardParcelType.ToArray();
      _LimitedRewardParcelType = CreateLimitedRewardParcelTypeVector(builder, __LimitedRewardParcelType);
    }
    var _LimitedRewardParcelUniqueId = default(VectorOffset);
    if (_o.LimitedRewardParcelUniqueId != null) {
      var __LimitedRewardParcelUniqueId = _o.LimitedRewardParcelUniqueId.ToArray();
      _LimitedRewardParcelUniqueId = CreateLimitedRewardParcelUniqueIdVector(builder, __LimitedRewardParcelUniqueId);
    }
    var _LimitedRewardAmount = default(VectorOffset);
    if (_o.LimitedRewardAmount != null) {
      var __LimitedRewardAmount = _o.LimitedRewardAmount.ToArray();
      _LimitedRewardAmount = CreateLimitedRewardAmountVector(builder, __LimitedRewardAmount);
    }
    return CreateEliminateRaidStageLimitedRewardExcel(
      builder,
      _o.LimitedRewardId,
      _LimitedRewardParcelType,
      _LimitedRewardParcelUniqueId,
      _LimitedRewardAmount);
  }
}

public class EliminateRaidStageLimitedRewardExcelT
{
  public long LimitedRewardId { get; set; }
  public List<Plana.FlatData.ParcelType> LimitedRewardParcelType { get; set; }
  public List<long> LimitedRewardParcelUniqueId { get; set; }
  public List<long> LimitedRewardAmount { get; set; }

  public EliminateRaidStageLimitedRewardExcelT() {
    this.LimitedRewardId = 0;
    this.LimitedRewardParcelType = null;
    this.LimitedRewardParcelUniqueId = null;
    this.LimitedRewardAmount = null;
  }
}


static public class EliminateRaidStageLimitedRewardExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*LimitedRewardId*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 6 /*LimitedRewardParcelType*/, 4 /*Plana.FlatData.ParcelType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 8 /*LimitedRewardParcelUniqueId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*LimitedRewardAmount*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
