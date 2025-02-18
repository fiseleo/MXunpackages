// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct MiniGamePlayGuideExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static MiniGamePlayGuideExcel GetRootAsMiniGamePlayGuideExcel(ByteBuffer _bb) { return GetRootAsMiniGamePlayGuideExcel(_bb, new MiniGamePlayGuideExcel()); }
  public static MiniGamePlayGuideExcel GetRootAsMiniGamePlayGuideExcel(ByteBuffer _bb, MiniGamePlayGuideExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MiniGamePlayGuideExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EventContentId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int DisplayOrder { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string GuideTitle { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetGuideTitleBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetGuideTitleBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetGuideTitleArray() { return __p.__vector_as_array<byte>(10); }
  public string GuideImagePath { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetGuideImagePathBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetGuideImagePathBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetGuideImagePathArray() { return __p.__vector_as_array<byte>(12); }
  public string GuideText { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetGuideTextBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetGuideTextBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetGuideTextArray() { return __p.__vector_as_array<byte>(14); }

  public static Offset<Plana.FlatData.MiniGamePlayGuideExcel> CreateMiniGamePlayGuideExcel(FlatBufferBuilder builder,
      long Id = 0,
      long EventContentId = 0,
      int DisplayOrder = 0,
      StringOffset GuideTitleOffset = default(StringOffset),
      StringOffset GuideImagePathOffset = default(StringOffset),
      StringOffset GuideTextOffset = default(StringOffset)) {
    builder.StartTable(6);
    MiniGamePlayGuideExcel.AddEventContentId(builder, EventContentId);
    MiniGamePlayGuideExcel.AddId(builder, Id);
    MiniGamePlayGuideExcel.AddGuideText(builder, GuideTextOffset);
    MiniGamePlayGuideExcel.AddGuideImagePath(builder, GuideImagePathOffset);
    MiniGamePlayGuideExcel.AddGuideTitle(builder, GuideTitleOffset);
    MiniGamePlayGuideExcel.AddDisplayOrder(builder, DisplayOrder);
    return MiniGamePlayGuideExcel.EndMiniGamePlayGuideExcel(builder);
  }

  public static void StartMiniGamePlayGuideExcel(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(1, eventContentId, 0); }
  public static void AddDisplayOrder(FlatBufferBuilder builder, int displayOrder) { builder.AddInt(2, displayOrder, 0); }
  public static void AddGuideTitle(FlatBufferBuilder builder, StringOffset guideTitleOffset) { builder.AddOffset(3, guideTitleOffset.Value, 0); }
  public static void AddGuideImagePath(FlatBufferBuilder builder, StringOffset guideImagePathOffset) { builder.AddOffset(4, guideImagePathOffset.Value, 0); }
  public static void AddGuideText(FlatBufferBuilder builder, StringOffset guideTextOffset) { builder.AddOffset(5, guideTextOffset.Value, 0); }
  public static Offset<Plana.FlatData.MiniGamePlayGuideExcel> EndMiniGamePlayGuideExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.MiniGamePlayGuideExcel>(o);
  }
  public MiniGamePlayGuideExcelT UnPack() {
    var _o = new MiniGamePlayGuideExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(MiniGamePlayGuideExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("MiniGamePlayGuide");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.EventContentId = TableEncryptionService.Convert(this.EventContentId, key);
    _o.DisplayOrder = TableEncryptionService.Convert(this.DisplayOrder, key);
    _o.GuideTitle = TableEncryptionService.Convert(this.GuideTitle, key);
    _o.GuideImagePath = TableEncryptionService.Convert(this.GuideImagePath, key);
    _o.GuideText = TableEncryptionService.Convert(this.GuideText, key);
  }
  public static Offset<Plana.FlatData.MiniGamePlayGuideExcel> Pack(FlatBufferBuilder builder, MiniGamePlayGuideExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.MiniGamePlayGuideExcel>);
    var _GuideTitle = _o.GuideTitle == null ? default(StringOffset) : builder.CreateString(_o.GuideTitle);
    var _GuideImagePath = _o.GuideImagePath == null ? default(StringOffset) : builder.CreateString(_o.GuideImagePath);
    var _GuideText = _o.GuideText == null ? default(StringOffset) : builder.CreateString(_o.GuideText);
    return CreateMiniGamePlayGuideExcel(
      builder,
      _o.Id,
      _o.EventContentId,
      _o.DisplayOrder,
      _GuideTitle,
      _GuideImagePath,
      _GuideText);
  }
}

public class MiniGamePlayGuideExcelT
{
  public long Id { get; set; }
  public long EventContentId { get; set; }
  public int DisplayOrder { get; set; }
  public string GuideTitle { get; set; }
  public string GuideImagePath { get; set; }
  public string GuideText { get; set; }

  public MiniGamePlayGuideExcelT() {
    this.Id = 0;
    this.EventContentId = 0;
    this.DisplayOrder = 0;
    this.GuideTitle = null;
    this.GuideImagePath = null;
    this.GuideText = null;
  }
}


static public class MiniGamePlayGuideExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*DisplayOrder*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 10 /*GuideTitle*/, false)
      && verifier.VerifyString(tablePos, 12 /*GuideImagePath*/, false)
      && verifier.VerifyString(tablePos, 14 /*GuideText*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
