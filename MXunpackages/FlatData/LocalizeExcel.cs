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

public struct LocalizeExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static LocalizeExcel GetRootAsLocalizeExcel(ByteBuffer _bb) { return GetRootAsLocalizeExcel(_bb, new LocalizeExcel()); }
  public static LocalizeExcel GetRootAsLocalizeExcel(ByteBuffer _bb, LocalizeExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LocalizeExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

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
  public string Th { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetThBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetThBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetThArray() { return __p.__vector_as_array<byte>(10); }
  public string Tw { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTwBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetTwBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetTwArray() { return __p.__vector_as_array<byte>(12); }
  public string En { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEnBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetEnBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetEnArray() { return __p.__vector_as_array<byte>(14); }

  public static Offset<Plana.FlatData.LocalizeExcel> CreateLocalizeExcel(FlatBufferBuilder builder,
      uint Key = 0,
      StringOffset KrOffset = default(StringOffset),
      StringOffset JpOffset = default(StringOffset),
      StringOffset ThOffset = default(StringOffset),
      StringOffset TwOffset = default(StringOffset),
      StringOffset EnOffset = default(StringOffset)) {
    builder.StartTable(6);
    LocalizeExcel.AddEn(builder, EnOffset);
    LocalizeExcel.AddTw(builder, TwOffset);
    LocalizeExcel.AddTh(builder, ThOffset);
    LocalizeExcel.AddJp(builder, JpOffset);
    LocalizeExcel.AddKr(builder, KrOffset);
    LocalizeExcel.AddKey(builder, Key);
    return LocalizeExcel.EndLocalizeExcel(builder);
  }

  public static void StartLocalizeExcel(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddKey(FlatBufferBuilder builder, uint key) { builder.AddUint(0, key, 0); }
  public static void AddKr(FlatBufferBuilder builder, StringOffset krOffset) { builder.AddOffset(1, krOffset.Value, 0); }
  public static void AddJp(FlatBufferBuilder builder, StringOffset jpOffset) { builder.AddOffset(2, jpOffset.Value, 0); }
  public static void AddTh(FlatBufferBuilder builder, StringOffset thOffset) { builder.AddOffset(3, thOffset.Value, 0); }
  public static void AddTw(FlatBufferBuilder builder, StringOffset twOffset) { builder.AddOffset(4, twOffset.Value, 0); }
  public static void AddEn(FlatBufferBuilder builder, StringOffset enOffset) { builder.AddOffset(5, enOffset.Value, 0); }
  public static Offset<Plana.FlatData.LocalizeExcel> EndLocalizeExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.LocalizeExcel>(o);
  }
  public LocalizeExcelT UnPack() {
    var _o = new LocalizeExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(LocalizeExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("Localize");
    _o.Key = TableEncryptionService.Convert(this.Key, key);
    _o.Kr = TableEncryptionService.Convert(this.Kr, key);
    _o.Jp = TableEncryptionService.Convert(this.Jp, key);
    _o.Th = TableEncryptionService.Convert(this.Th, key);
    _o.Tw = TableEncryptionService.Convert(this.Tw, key);
    _o.En = TableEncryptionService.Convert(this.En, key);
  }
  public static Offset<Plana.FlatData.LocalizeExcel> Pack(FlatBufferBuilder builder, LocalizeExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.LocalizeExcel>);
    var _Kr = _o.Kr == null ? default(StringOffset) : builder.CreateString(_o.Kr);
    var _Jp = _o.Jp == null ? default(StringOffset) : builder.CreateString(_o.Jp);
    var _Th = _o.Th == null ? default(StringOffset) : builder.CreateString(_o.Th);
    var _Tw = _o.Tw == null ? default(StringOffset) : builder.CreateString(_o.Tw);
    var _En = _o.En == null ? default(StringOffset) : builder.CreateString(_o.En);
    return CreateLocalizeExcel(
      builder,
      _o.Key,
      _Kr,
      _Jp,
      _Th,
      _Tw,
      _En);
  }
}

public class LocalizeExcelT
{
  public uint Key { get; set; }
  public string Kr { get; set; }
  public string Jp { get; set; }
  public string Th { get; set; }
  public string Tw { get; set; }
  public string En { get; set; }

  public LocalizeExcelT() {
    this.Key = 0;
    this.Kr = null;
    this.Jp = null;
    this.Th = null;
    this.Tw = null;
    this.En = null;
  }
}


static public class LocalizeExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Key*/, 4 /*uint*/, 4, false)
      && verifier.VerifyString(tablePos, 6 /*Kr*/, false)
      && verifier.VerifyString(tablePos, 8 /*Jp*/, false)
      && verifier.VerifyString(tablePos, 10 /*Th*/, false)
      && verifier.VerifyString(tablePos, 12 /*Tw*/, false)
      && verifier.VerifyString(tablePos, 14 /*En*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
