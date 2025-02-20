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

public struct VoiceLogicEffectExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static VoiceLogicEffectExcel GetRootAsVoiceLogicEffectExcel(ByteBuffer _bb) { return GetRootAsVoiceLogicEffectExcel(_bb, new VoiceLogicEffectExcel()); }
  public static VoiceLogicEffectExcel GetRootAsVoiceLogicEffectExcel(ByteBuffer _bb, VoiceLogicEffectExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public VoiceLogicEffectExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint LogicEffectNameHash { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public bool Self { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int Priority { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public uint VoiceHash(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetUint(__p.__vector(o) + j * 4) : (uint)0; }
  public int VoiceHashLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<uint> GetVoiceHashBytes() { return __p.__vector_as_span<uint>(10, 4); }
#else
  public ArraySegment<byte>? GetVoiceHashBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public uint[] GetVoiceHashArray() { return __p.__vector_as_array<uint>(10); }
  public uint VoiceId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }

  public static Offset<Plana.FlatData.VoiceLogicEffectExcel> CreateVoiceLogicEffectExcel(FlatBufferBuilder builder,
      uint LogicEffectNameHash = 0,
      bool Self = false,
      int Priority = 0,
      VectorOffset VoiceHashOffset = default(VectorOffset),
      uint VoiceId = 0) {
    builder.StartTable(5);
    VoiceLogicEffectExcel.AddVoiceId(builder, VoiceId);
    VoiceLogicEffectExcel.AddVoiceHash(builder, VoiceHashOffset);
    VoiceLogicEffectExcel.AddPriority(builder, Priority);
    VoiceLogicEffectExcel.AddLogicEffectNameHash(builder, LogicEffectNameHash);
    VoiceLogicEffectExcel.AddSelf(builder, Self);
    return VoiceLogicEffectExcel.EndVoiceLogicEffectExcel(builder);
  }

  public static void StartVoiceLogicEffectExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddLogicEffectNameHash(FlatBufferBuilder builder, uint logicEffectNameHash) { builder.AddUint(0, logicEffectNameHash, 0); }
  public static void AddSelf(FlatBufferBuilder builder, bool self) { builder.AddBool(1, self, false); }
  public static void AddPriority(FlatBufferBuilder builder, int priority) { builder.AddInt(2, priority, 0); }
  public static void AddVoiceHash(FlatBufferBuilder builder, VectorOffset voiceHashOffset) { builder.AddOffset(3, voiceHashOffset.Value, 0); }
  public static VectorOffset CreateVoiceHashVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateVoiceHashVectorBlock(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceHashVectorBlock(FlatBufferBuilder builder, ArraySegment<uint> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceHashVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<uint>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceHashVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddVoiceId(FlatBufferBuilder builder, uint voiceId) { builder.AddUint(4, voiceId, 0); }
  public static Offset<Plana.FlatData.VoiceLogicEffectExcel> EndVoiceLogicEffectExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.VoiceLogicEffectExcel>(o);
  }
  public VoiceLogicEffectExcelT UnPack() {
    var _o = new VoiceLogicEffectExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(VoiceLogicEffectExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("VoiceLogicEffect");
    _o.LogicEffectNameHash = TableEncryptionService.Convert(this.LogicEffectNameHash, key);
    _o.Self = TableEncryptionService.Convert(this.Self, key);
    _o.Priority = TableEncryptionService.Convert(this.Priority, key);
    _o.VoiceHash = new List<uint>();
    for (var _j = 0; _j < this.VoiceHashLength; ++_j) {_o.VoiceHash.Add(TableEncryptionService.Convert(this.VoiceHash(_j), key));}
    _o.VoiceId = TableEncryptionService.Convert(this.VoiceId, key);
  }
  public static Offset<Plana.FlatData.VoiceLogicEffectExcel> Pack(FlatBufferBuilder builder, VoiceLogicEffectExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.VoiceLogicEffectExcel>);
    var _VoiceHash = default(VectorOffset);
    if (_o.VoiceHash != null) {
      var __VoiceHash = _o.VoiceHash.ToArray();
      _VoiceHash = CreateVoiceHashVector(builder, __VoiceHash);
    }
    return CreateVoiceLogicEffectExcel(
      builder,
      _o.LogicEffectNameHash,
      _o.Self,
      _o.Priority,
      _VoiceHash,
      _o.VoiceId);
  }
}

public class VoiceLogicEffectExcelT
{
  public uint LogicEffectNameHash { get; set; }
  public bool Self { get; set; }
  public int Priority { get; set; }
  public List<uint> VoiceHash { get; set; }
  public uint VoiceId { get; set; }

  public VoiceLogicEffectExcelT() {
    this.LogicEffectNameHash = 0;
    this.Self = false;
    this.Priority = 0;
    this.VoiceHash = null;
    this.VoiceId = 0;
  }
}


static public class VoiceLogicEffectExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*LogicEffectNameHash*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*Self*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 8 /*Priority*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*VoiceHash*/, 4 /*uint*/, false)
      && verifier.VerifyField(tablePos, 12 /*VoiceId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
