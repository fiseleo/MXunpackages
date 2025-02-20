// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct LocalizeFieldExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static LocalizeFieldExcel GetRootAsLocalizeFieldExcel(ByteBuffer _bb) { return GetRootAsLocalizeFieldExcel(_bb, new LocalizeFieldExcel()); }
  public static LocalizeFieldExcel GetRootAsLocalizeFieldExcel(ByteBuffer _bb, LocalizeFieldExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LocalizeFieldExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint Key { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string Kr { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetKrBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetKrBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetKrArray() { return __p.__vector_as_array<byte>(6); }
  public string Jp { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetJpBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetJpBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetJpArray() { return __p.__vector_as_array<byte>(8); }

  public static Offset<Plana.FlatData.LocalizeFieldExcel> CreateLocalizeFieldExcel(FlatBufferBuilder builder,
      uint Key = 0,
      StringOffset KrOffset = default(StringOffset),
      StringOffset JpOffset = default(StringOffset)) {
    builder.StartTable(3);
    LocalizeFieldExcel.AddJp(builder, JpOffset);
    LocalizeFieldExcel.AddKr(builder, KrOffset);
    LocalizeFieldExcel.AddKey(builder, Key);
    return LocalizeFieldExcel.EndLocalizeFieldExcel(builder);
  }

  public static void StartLocalizeFieldExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddKey(FlatBufferBuilder builder, uint key) { builder.AddUint(0, key, 0); }
  public static void AddKr(FlatBufferBuilder builder, StringOffset krOffset) { builder.AddOffset(1, krOffset.Value, 0); }
  public static void AddJp(FlatBufferBuilder builder, StringOffset jpOffset) { builder.AddOffset(2, jpOffset.Value, 0); }
  public static Offset<Plana.FlatData.LocalizeFieldExcel> EndLocalizeFieldExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.LocalizeFieldExcel>(o);
  }
  public LocalizeFieldExcelT UnPack() {
    var _o = new LocalizeFieldExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(LocalizeFieldExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("LocalizeField");
    _o.Key = TableEncryptionService.Convert(this.Key, key);
    _o.Kr = TableEncryptionService.Convert(this.Kr, key);
    _o.Jp = TableEncryptionService.Convert(this.Jp, key);
  }
  public static Offset<Plana.FlatData.LocalizeFieldExcel> Pack(FlatBufferBuilder builder, LocalizeFieldExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.LocalizeFieldExcel>);
    var _Kr = _o.Kr == null ? default(StringOffset) : builder.CreateString(_o.Kr);
    var _Jp = _o.Jp == null ? default(StringOffset) : builder.CreateString(_o.Jp);
    return CreateLocalizeFieldExcel(
      builder,
      _o.Key,
      _Kr,
      _Jp);
  }
}

public class LocalizeFieldExcelT
{
  public uint Key { get; set; }
  public string Kr { get; set; }
  public string Jp { get; set; }

  public LocalizeFieldExcelT() {
    this.Key = 0;
    this.Kr = null;
    this.Jp = null;
  }
}


static public class LocalizeFieldExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Key*/, 4 /*uint*/, 4, false)
      && verifier.VerifyString(tablePos, 6 /*Kr*/, false)
      && verifier.VerifyString(tablePos, 8 /*Jp*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
