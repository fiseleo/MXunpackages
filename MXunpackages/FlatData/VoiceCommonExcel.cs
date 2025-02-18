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

public struct VoiceCommonExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static VoiceCommonExcel GetRootAsVoiceCommonExcel(ByteBuffer _bb) { return GetRootAsVoiceCommonExcel(_bb, new VoiceCommonExcel()); }
  public static VoiceCommonExcel GetRootAsVoiceCommonExcel(ByteBuffer _bb, VoiceCommonExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public VoiceCommonExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Plana.FlatData.VoiceEvent VoiceEvent_ { get { int o = __p.__offset(4); return o != 0 ? (Plana.FlatData.VoiceEvent)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.VoiceEvent.OnTSA; } }
  public long Rate { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public uint VoiceHash(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.GetUint(__p.__vector(o) + j * 4) : (uint)0; }
  public int VoiceHashLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<uint> GetVoiceHashBytes() { return __p.__vector_as_span<uint>(8, 4); }
#else
  public ArraySegment<byte>? GetVoiceHashBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public uint[] GetVoiceHashArray() { return __p.__vector_as_array<uint>(8); }

  public static Offset<Plana.FlatData.VoiceCommonExcel> CreateVoiceCommonExcel(FlatBufferBuilder builder,
      Plana.FlatData.VoiceEvent VoiceEvent_ = Plana.FlatData.VoiceEvent.OnTSA,
      long Rate = 0,
      VectorOffset VoiceHashOffset = default(VectorOffset)) {
    builder.StartTable(3);
    VoiceCommonExcel.AddRate(builder, Rate);
    VoiceCommonExcel.AddVoiceHash(builder, VoiceHashOffset);
    VoiceCommonExcel.AddVoiceEvent_(builder, VoiceEvent_);
    return VoiceCommonExcel.EndVoiceCommonExcel(builder);
  }

  public static void StartVoiceCommonExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddVoiceEvent_(FlatBufferBuilder builder, Plana.FlatData.VoiceEvent voiceEvent_) { builder.AddInt(0, (int)voiceEvent_, 0); }
  public static void AddRate(FlatBufferBuilder builder, long rate) { builder.AddLong(1, rate, 0); }
  public static void AddVoiceHash(FlatBufferBuilder builder, VectorOffset voiceHashOffset) { builder.AddOffset(2, voiceHashOffset.Value, 0); }
  public static VectorOffset CreateVoiceHashVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateVoiceHashVectorBlock(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceHashVectorBlock(FlatBufferBuilder builder, ArraySegment<uint> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceHashVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<uint>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceHashVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Plana.FlatData.VoiceCommonExcel> EndVoiceCommonExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.VoiceCommonExcel>(o);
  }
  public VoiceCommonExcelT UnPack() {
    var _o = new VoiceCommonExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(VoiceCommonExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("VoiceCommon");
    _o.VoiceEvent_ = TableEncryptionService.Convert(this.VoiceEvent_, key);
    _o.Rate = TableEncryptionService.Convert(this.Rate, key);
    _o.VoiceHash = new List<uint>();
    for (var _j = 0; _j < this.VoiceHashLength; ++_j) {_o.VoiceHash.Add(TableEncryptionService.Convert(this.VoiceHash(_j), key));}
  }
  public static Offset<Plana.FlatData.VoiceCommonExcel> Pack(FlatBufferBuilder builder, VoiceCommonExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.VoiceCommonExcel>);
    var _VoiceHash = default(VectorOffset);
    if (_o.VoiceHash != null) {
      var __VoiceHash = _o.VoiceHash.ToArray();
      _VoiceHash = CreateVoiceHashVector(builder, __VoiceHash);
    }
    return CreateVoiceCommonExcel(
      builder,
      _o.VoiceEvent_,
      _o.Rate,
      _VoiceHash);
  }
}

public class VoiceCommonExcelT
{
  public Plana.FlatData.VoiceEvent VoiceEvent_ { get; set; }
  public long Rate { get; set; }
  public List<uint> VoiceHash { get; set; }

  public VoiceCommonExcelT() {
    this.VoiceEvent_ = Plana.FlatData.VoiceEvent.OnTSA;
    this.Rate = 0;
    this.VoiceHash = null;
  }
}


static public class VoiceCommonExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*VoiceEvent_*/, 4 /*Plana.FlatData.VoiceEvent*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*Rate*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 8 /*VoiceHash*/, 4 /*uint*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
