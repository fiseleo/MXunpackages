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

public struct CharacterStatsDetailExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static CharacterStatsDetailExcel GetRootAsCharacterStatsDetailExcel(ByteBuffer _bb) { return GetRootAsCharacterStatsDetailExcel(_bb, new CharacterStatsDetailExcel()); }
  public static CharacterStatsDetailExcel GetRootAsCharacterStatsDetailExcel(ByteBuffer _bb, CharacterStatsDetailExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterStatsDetailExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.StatType DetailShowStats(int j) { int o = __p.__offset(6); return o != 0 ? (Plana.FlatData.StatType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (Plana.FlatData.StatType)0; }
  public int DetailShowStatsLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<Plana.FlatData.StatType> GetDetailShowStatsBytes() { return __p.__vector_as_span<Plana.FlatData.StatType>(6, 4); }
#else
  public ArraySegment<byte>? GetDetailShowStatsBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public Plana.FlatData.StatType[] GetDetailShowStatsArray() { int o = __p.__offset(6); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); Plana.FlatData.StatType[] a = new Plana.FlatData.StatType[l]; for (int i = 0; i < l; i++) { a[i] = (Plana.FlatData.StatType)__p.bb.GetInt(p + i * 4); } return a; }
  public bool IsStatsPercent(int j) { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(__p.__vector(o) + j * 1) : false; }
  public int IsStatsPercentLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<bool> GetIsStatsPercentBytes() { return __p.__vector_as_span<bool>(8, 1); }
#else
  public ArraySegment<byte>? GetIsStatsPercentBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public bool[] GetIsStatsPercentArray() { return __p.__vector_as_array<bool>(8); }

  public static Offset<Plana.FlatData.CharacterStatsDetailExcel> CreateCharacterStatsDetailExcel(FlatBufferBuilder builder,
      long Id = 0,
      VectorOffset DetailShowStatsOffset = default(VectorOffset),
      VectorOffset IsStatsPercentOffset = default(VectorOffset)) {
    builder.StartTable(3);
    CharacterStatsDetailExcel.AddId(builder, Id);
    CharacterStatsDetailExcel.AddIsStatsPercent(builder, IsStatsPercentOffset);
    CharacterStatsDetailExcel.AddDetailShowStats(builder, DetailShowStatsOffset);
    return CharacterStatsDetailExcel.EndCharacterStatsDetailExcel(builder);
  }

  public static void StartCharacterStatsDetailExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddDetailShowStats(FlatBufferBuilder builder, VectorOffset detailShowStatsOffset) { builder.AddOffset(1, detailShowStatsOffset.Value, 0); }
  public static VectorOffset CreateDetailShowStatsVector(FlatBufferBuilder builder, Plana.FlatData.StatType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateDetailShowStatsVectorBlock(FlatBufferBuilder builder, Plana.FlatData.StatType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDetailShowStatsVectorBlock(FlatBufferBuilder builder, ArraySegment<Plana.FlatData.StatType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDetailShowStatsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Plana.FlatData.StatType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDetailShowStatsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIsStatsPercent(FlatBufferBuilder builder, VectorOffset isStatsPercentOffset) { builder.AddOffset(2, isStatsPercentOffset.Value, 0); }
  public static VectorOffset CreateIsStatsPercentVector(FlatBufferBuilder builder, bool[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddBool(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateIsStatsPercentVectorBlock(FlatBufferBuilder builder, bool[] data) { builder.StartVector(1, data.Length, 1); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateIsStatsPercentVectorBlock(FlatBufferBuilder builder, ArraySegment<bool> data) { builder.StartVector(1, data.Count, 1); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateIsStatsPercentVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<bool>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartIsStatsPercentVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static Offset<Plana.FlatData.CharacterStatsDetailExcel> EndCharacterStatsDetailExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.CharacterStatsDetailExcel>(o);
  }
  public CharacterStatsDetailExcelT UnPack() {
    var _o = new CharacterStatsDetailExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CharacterStatsDetailExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("CharacterStatsDetail");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.DetailShowStats = new List<Plana.FlatData.StatType>();
    for (var _j = 0; _j < this.DetailShowStatsLength; ++_j) {_o.DetailShowStats.Add(TableEncryptionService.Convert(this.DetailShowStats(_j), key));}
    _o.IsStatsPercent = new List<bool>();
    for (var _j = 0; _j < this.IsStatsPercentLength; ++_j) {_o.IsStatsPercent.Add(TableEncryptionService.Convert(this.IsStatsPercent(_j), key));}
  }
  public static Offset<Plana.FlatData.CharacterStatsDetailExcel> Pack(FlatBufferBuilder builder, CharacterStatsDetailExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.CharacterStatsDetailExcel>);
    var _DetailShowStats = default(VectorOffset);
    if (_o.DetailShowStats != null) {
      var __DetailShowStats = _o.DetailShowStats.ToArray();
      _DetailShowStats = CreateDetailShowStatsVector(builder, __DetailShowStats);
    }
    var _IsStatsPercent = default(VectorOffset);
    if (_o.IsStatsPercent != null) {
      var __IsStatsPercent = _o.IsStatsPercent.ToArray();
      _IsStatsPercent = CreateIsStatsPercentVector(builder, __IsStatsPercent);
    }
    return CreateCharacterStatsDetailExcel(
      builder,
      _o.Id,
      _DetailShowStats,
      _IsStatsPercent);
  }
}

public class CharacterStatsDetailExcelT
{
  public long Id { get; set; }
  public List<Plana.FlatData.StatType> DetailShowStats { get; set; }
  public List<bool> IsStatsPercent { get; set; }

  public CharacterStatsDetailExcelT() {
    this.Id = 0;
    this.DetailShowStats = null;
    this.IsStatsPercent = null;
  }
}


static public class CharacterStatsDetailExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 6 /*DetailShowStats*/, 4 /*Plana.FlatData.StatType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 8 /*IsStatsPercent*/, 1 /*bool*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
