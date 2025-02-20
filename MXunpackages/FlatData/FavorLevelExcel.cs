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

public struct FavorLevelExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static FavorLevelExcel GetRootAsFavorLevelExcel(ByteBuffer _bb) { return GetRootAsFavorLevelExcel(_bb, new FavorLevelExcel()); }
  public static FavorLevelExcel GetRootAsFavorLevelExcel(ByteBuffer _bb, FavorLevelExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FavorLevelExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Level { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ExpType(int j) { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ExpTypeLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetExpTypeBytes() { return __p.__vector_as_span<long>(6, 8); }
#else
  public ArraySegment<byte>? GetExpTypeBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public long[] GetExpTypeArray() { return __p.__vector_as_array<long>(6); }

  public static Offset<Plana.FlatData.FavorLevelExcel> CreateFavorLevelExcel(FlatBufferBuilder builder,
      long Level = 0,
      VectorOffset ExpTypeOffset = default(VectorOffset)) {
    builder.StartTable(2);
    FavorLevelExcel.AddLevel(builder, Level);
    FavorLevelExcel.AddExpType(builder, ExpTypeOffset);
    return FavorLevelExcel.EndFavorLevelExcel(builder);
  }

  public static void StartFavorLevelExcel(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddLevel(FlatBufferBuilder builder, long level) { builder.AddLong(0, level, 0); }
  public static void AddExpType(FlatBufferBuilder builder, VectorOffset expTypeOffset) { builder.AddOffset(1, expTypeOffset.Value, 0); }
  public static VectorOffset CreateExpTypeVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateExpTypeVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExpTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateExpTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartExpTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<Plana.FlatData.FavorLevelExcel> EndFavorLevelExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.FavorLevelExcel>(o);
  }
  public FavorLevelExcelT UnPack() {
    var _o = new FavorLevelExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FavorLevelExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("FavorLevel");
    _o.Level = TableEncryptionService.Convert(this.Level, key);
    _o.ExpType = new List<long>();
    for (var _j = 0; _j < this.ExpTypeLength; ++_j) {_o.ExpType.Add(TableEncryptionService.Convert(this.ExpType(_j), key));}
  }
  public static Offset<Plana.FlatData.FavorLevelExcel> Pack(FlatBufferBuilder builder, FavorLevelExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.FavorLevelExcel>);
    var _ExpType = default(VectorOffset);
    if (_o.ExpType != null) {
      var __ExpType = _o.ExpType.ToArray();
      _ExpType = CreateExpTypeVector(builder, __ExpType);
    }
    return CreateFavorLevelExcel(
      builder,
      _o.Level,
      _ExpType);
  }
}

public class FavorLevelExcelT
{
  public long Level { get; set; }
  public List<long> ExpType { get; set; }

  public FavorLevelExcelT() {
    this.Level = 0;
    this.ExpType = null;
  }
}


static public class FavorLevelExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Level*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 6 /*ExpType*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
