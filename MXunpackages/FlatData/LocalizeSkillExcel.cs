// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct LocalizeSkillExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static LocalizeSkillExcel GetRootAsLocalizeSkillExcel(ByteBuffer _bb) { return GetRootAsLocalizeSkillExcel(_bb, new LocalizeSkillExcel()); }
  public static LocalizeSkillExcel GetRootAsLocalizeSkillExcel(ByteBuffer _bb, LocalizeSkillExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LocalizeSkillExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint Key { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string NameKr { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameKrBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameKrBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameKrArray() { return __p.__vector_as_array<byte>(6); }
  public string DescriptionKr { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescriptionKrBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetDescriptionKrBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetDescriptionKrArray() { return __p.__vector_as_array<byte>(8); }
  public string SkillInvokeLocalizeKr { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSkillInvokeLocalizeKrBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetSkillInvokeLocalizeKrBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetSkillInvokeLocalizeKrArray() { return __p.__vector_as_array<byte>(10); }
  public string NameJp { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameJpBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetNameJpBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetNameJpArray() { return __p.__vector_as_array<byte>(12); }
  public string DescriptionJp { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescriptionJpBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetDescriptionJpBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetDescriptionJpArray() { return __p.__vector_as_array<byte>(14); }
  public string SkillInvokeLocalizeJp { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSkillInvokeLocalizeJpBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetSkillInvokeLocalizeJpBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetSkillInvokeLocalizeJpArray() { return __p.__vector_as_array<byte>(16); }

  public static Offset<Plana.FlatData.LocalizeSkillExcel> CreateLocalizeSkillExcel(FlatBufferBuilder builder,
      uint Key = 0,
      StringOffset NameKrOffset = default(StringOffset),
      StringOffset DescriptionKrOffset = default(StringOffset),
      StringOffset SkillInvokeLocalizeKrOffset = default(StringOffset),
      StringOffset NameJpOffset = default(StringOffset),
      StringOffset DescriptionJpOffset = default(StringOffset),
      StringOffset SkillInvokeLocalizeJpOffset = default(StringOffset)) {
    builder.StartTable(7);
    LocalizeSkillExcel.AddSkillInvokeLocalizeJp(builder, SkillInvokeLocalizeJpOffset);
    LocalizeSkillExcel.AddDescriptionJp(builder, DescriptionJpOffset);
    LocalizeSkillExcel.AddNameJp(builder, NameJpOffset);
    LocalizeSkillExcel.AddSkillInvokeLocalizeKr(builder, SkillInvokeLocalizeKrOffset);
    LocalizeSkillExcel.AddDescriptionKr(builder, DescriptionKrOffset);
    LocalizeSkillExcel.AddNameKr(builder, NameKrOffset);
    LocalizeSkillExcel.AddKey(builder, Key);
    return LocalizeSkillExcel.EndLocalizeSkillExcel(builder);
  }

  public static void StartLocalizeSkillExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddKey(FlatBufferBuilder builder, uint key) { builder.AddUint(0, key, 0); }
  public static void AddNameKr(FlatBufferBuilder builder, StringOffset nameKrOffset) { builder.AddOffset(1, nameKrOffset.Value, 0); }
  public static void AddDescriptionKr(FlatBufferBuilder builder, StringOffset descriptionKrOffset) { builder.AddOffset(2, descriptionKrOffset.Value, 0); }
  public static void AddSkillInvokeLocalizeKr(FlatBufferBuilder builder, StringOffset skillInvokeLocalizeKrOffset) { builder.AddOffset(3, skillInvokeLocalizeKrOffset.Value, 0); }
  public static void AddNameJp(FlatBufferBuilder builder, StringOffset nameJpOffset) { builder.AddOffset(4, nameJpOffset.Value, 0); }
  public static void AddDescriptionJp(FlatBufferBuilder builder, StringOffset descriptionJpOffset) { builder.AddOffset(5, descriptionJpOffset.Value, 0); }
  public static void AddSkillInvokeLocalizeJp(FlatBufferBuilder builder, StringOffset skillInvokeLocalizeJpOffset) { builder.AddOffset(6, skillInvokeLocalizeJpOffset.Value, 0); }
  public static Offset<Plana.FlatData.LocalizeSkillExcel> EndLocalizeSkillExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.LocalizeSkillExcel>(o);
  }
  public LocalizeSkillExcelT UnPack() {
    var _o = new LocalizeSkillExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(LocalizeSkillExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("LocalizeSkill");
    _o.Key = TableEncryptionService.Convert(this.Key, key);
    _o.NameKr = TableEncryptionService.Convert(this.NameKr, key);
    _o.DescriptionKr = TableEncryptionService.Convert(this.DescriptionKr, key);
    _o.SkillInvokeLocalizeKr = TableEncryptionService.Convert(this.SkillInvokeLocalizeKr, key);
    _o.NameJp = TableEncryptionService.Convert(this.NameJp, key);
    _o.DescriptionJp = TableEncryptionService.Convert(this.DescriptionJp, key);
    _o.SkillInvokeLocalizeJp = TableEncryptionService.Convert(this.SkillInvokeLocalizeJp, key);
  }
  public static Offset<Plana.FlatData.LocalizeSkillExcel> Pack(FlatBufferBuilder builder, LocalizeSkillExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.LocalizeSkillExcel>);
    var _NameKr = _o.NameKr == null ? default(StringOffset) : builder.CreateString(_o.NameKr);
    var _DescriptionKr = _o.DescriptionKr == null ? default(StringOffset) : builder.CreateString(_o.DescriptionKr);
    var _SkillInvokeLocalizeKr = _o.SkillInvokeLocalizeKr == null ? default(StringOffset) : builder.CreateString(_o.SkillInvokeLocalizeKr);
    var _NameJp = _o.NameJp == null ? default(StringOffset) : builder.CreateString(_o.NameJp);
    var _DescriptionJp = _o.DescriptionJp == null ? default(StringOffset) : builder.CreateString(_o.DescriptionJp);
    var _SkillInvokeLocalizeJp = _o.SkillInvokeLocalizeJp == null ? default(StringOffset) : builder.CreateString(_o.SkillInvokeLocalizeJp);
    return CreateLocalizeSkillExcel(
      builder,
      _o.Key,
      _NameKr,
      _DescriptionKr,
      _SkillInvokeLocalizeKr,
      _NameJp,
      _DescriptionJp,
      _SkillInvokeLocalizeJp);
  }
}

public class LocalizeSkillExcelT
{
  public uint Key { get; set; }
  public string NameKr { get; set; }
  public string DescriptionKr { get; set; }
  public string SkillInvokeLocalizeKr { get; set; }
  public string NameJp { get; set; }
  public string DescriptionJp { get; set; }
  public string SkillInvokeLocalizeJp { get; set; }

  public LocalizeSkillExcelT() {
    this.Key = 0;
    this.NameKr = null;
    this.DescriptionKr = null;
    this.SkillInvokeLocalizeKr = null;
    this.NameJp = null;
    this.DescriptionJp = null;
    this.SkillInvokeLocalizeJp = null;
  }
}


static public class LocalizeSkillExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Key*/, 4 /*uint*/, 4, false)
      && verifier.VerifyString(tablePos, 6 /*NameKr*/, false)
      && verifier.VerifyString(tablePos, 8 /*DescriptionKr*/, false)
      && verifier.VerifyString(tablePos, 10 /*SkillInvokeLocalizeKr*/, false)
      && verifier.VerifyString(tablePos, 12 /*NameJp*/, false)
      && verifier.VerifyString(tablePos, 14 /*DescriptionJp*/, false)
      && verifier.VerifyString(tablePos, 16 /*SkillInvokeLocalizeJp*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
