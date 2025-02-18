// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct FieldKeywordExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static FieldKeywordExcel GetRootAsFieldKeywordExcel(ByteBuffer _bb) { return GetRootAsFieldKeywordExcel(_bb, new FieldKeywordExcel()); }
  public static FieldKeywordExcel GetRootAsFieldKeywordExcel(ByteBuffer _bb, FieldKeywordExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FieldKeywordExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long UniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long SeasonId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string NameLocalizeKey { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameLocalizeKeyBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetNameLocalizeKeyBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetNameLocalizeKeyArray() { return __p.__vector_as_array<byte>(8); }
  public string DescriptionLocalizeKey { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescriptionLocalizeKeyBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetDescriptionLocalizeKeyBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetDescriptionLocalizeKeyArray() { return __p.__vector_as_array<byte>(10); }
  public string ImagePath { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetImagePathBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetImagePathBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetImagePathArray() { return __p.__vector_as_array<byte>(12); }

  public static Offset<Plana.FlatData.FieldKeywordExcel> CreateFieldKeywordExcel(FlatBufferBuilder builder,
      long UniqueId = 0,
      long SeasonId = 0,
      StringOffset NameLocalizeKeyOffset = default(StringOffset),
      StringOffset DescriptionLocalizeKeyOffset = default(StringOffset),
      StringOffset ImagePathOffset = default(StringOffset)) {
    builder.StartTable(5);
    FieldKeywordExcel.AddSeasonId(builder, SeasonId);
    FieldKeywordExcel.AddUniqueId(builder, UniqueId);
    FieldKeywordExcel.AddImagePath(builder, ImagePathOffset);
    FieldKeywordExcel.AddDescriptionLocalizeKey(builder, DescriptionLocalizeKeyOffset);
    FieldKeywordExcel.AddNameLocalizeKey(builder, NameLocalizeKeyOffset);
    return FieldKeywordExcel.EndFieldKeywordExcel(builder);
  }

  public static void StartFieldKeywordExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddUniqueId(FlatBufferBuilder builder, long uniqueId) { builder.AddLong(0, uniqueId, 0); }
  public static void AddSeasonId(FlatBufferBuilder builder, long seasonId) { builder.AddLong(1, seasonId, 0); }
  public static void AddNameLocalizeKey(FlatBufferBuilder builder, StringOffset nameLocalizeKeyOffset) { builder.AddOffset(2, nameLocalizeKeyOffset.Value, 0); }
  public static void AddDescriptionLocalizeKey(FlatBufferBuilder builder, StringOffset descriptionLocalizeKeyOffset) { builder.AddOffset(3, descriptionLocalizeKeyOffset.Value, 0); }
  public static void AddImagePath(FlatBufferBuilder builder, StringOffset imagePathOffset) { builder.AddOffset(4, imagePathOffset.Value, 0); }
  public static Offset<Plana.FlatData.FieldKeywordExcel> EndFieldKeywordExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.FieldKeywordExcel>(o);
  }
  public FieldKeywordExcelT UnPack() {
    var _o = new FieldKeywordExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FieldKeywordExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("FieldKeyword");
    _o.UniqueId = TableEncryptionService.Convert(this.UniqueId, key);
    _o.SeasonId = TableEncryptionService.Convert(this.SeasonId, key);
    _o.NameLocalizeKey = TableEncryptionService.Convert(this.NameLocalizeKey, key);
    _o.DescriptionLocalizeKey = TableEncryptionService.Convert(this.DescriptionLocalizeKey, key);
    _o.ImagePath = TableEncryptionService.Convert(this.ImagePath, key);
  }
  public static Offset<Plana.FlatData.FieldKeywordExcel> Pack(FlatBufferBuilder builder, FieldKeywordExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.FieldKeywordExcel>);
    var _NameLocalizeKey = _o.NameLocalizeKey == null ? default(StringOffset) : builder.CreateString(_o.NameLocalizeKey);
    var _DescriptionLocalizeKey = _o.DescriptionLocalizeKey == null ? default(StringOffset) : builder.CreateString(_o.DescriptionLocalizeKey);
    var _ImagePath = _o.ImagePath == null ? default(StringOffset) : builder.CreateString(_o.ImagePath);
    return CreateFieldKeywordExcel(
      builder,
      _o.UniqueId,
      _o.SeasonId,
      _NameLocalizeKey,
      _DescriptionLocalizeKey,
      _ImagePath);
  }
}

public class FieldKeywordExcelT
{
  public long UniqueId { get; set; }
  public long SeasonId { get; set; }
  public string NameLocalizeKey { get; set; }
  public string DescriptionLocalizeKey { get; set; }
  public string ImagePath { get; set; }

  public FieldKeywordExcelT() {
    this.UniqueId = 0;
    this.SeasonId = 0;
    this.NameLocalizeKey = null;
    this.DescriptionLocalizeKey = null;
    this.ImagePath = null;
  }
}


static public class FieldKeywordExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*UniqueId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*SeasonId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 8 /*NameLocalizeKey*/, false)
      && verifier.VerifyString(tablePos, 10 /*DescriptionLocalizeKey*/, false)
      && verifier.VerifyString(tablePos, 12 /*ImagePath*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
