// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct VoiceTimelineExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static VoiceTimelineExcel GetRootAsVoiceTimelineExcel(ByteBuffer _bb) { return GetRootAsVoiceTimelineExcel(_bb, new VoiceTimelineExcel()); }
  public static VoiceTimelineExcel GetRootAsVoiceTimelineExcel(ByteBuffer _bb, VoiceTimelineExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public VoiceTimelineExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long UniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public uint Id { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public Plana.FlatData.Nation Nation_(int j) { int o = __p.__offset(8); return o != 0 ? (Plana.FlatData.Nation)__p.bb.GetInt(__p.__vector(o) + j * 4) : (Plana.FlatData.Nation)0; }
  public int Nation_Length { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<Plana.FlatData.Nation> GetNation_Bytes() { return __p.__vector_as_span<Plana.FlatData.Nation>(8, 4); }
#else
  public ArraySegment<byte>? GetNation_Bytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public Plana.FlatData.Nation[] GetNation_Array() { int o = __p.__offset(8); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); Plana.FlatData.Nation[] a = new Plana.FlatData.Nation[l]; for (int i = 0; i < l; i++) { a[i] = (Plana.FlatData.Nation)__p.bb.GetInt(p + i * 4); } return a; }
  public string Path(int j) { int o = __p.__offset(10); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int PathLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
  public float SoundVolume(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int SoundVolumeLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetSoundVolumeBytes() { return __p.__vector_as_span<float>(12, 4); }
#else
  public ArraySegment<byte>? GetSoundVolumeBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public float[] GetSoundVolumeArray() { return __p.__vector_as_array<float>(12); }

  public static Offset<Plana.FlatData.VoiceTimelineExcel> CreateVoiceTimelineExcel(FlatBufferBuilder builder,
      long UniqueId = 0,
      uint Id = 0,
      VectorOffset Nation_Offset = default(VectorOffset),
      VectorOffset PathOffset = default(VectorOffset),
      VectorOffset SoundVolumeOffset = default(VectorOffset)) {
    builder.StartTable(5);
    VoiceTimelineExcel.AddUniqueId(builder, UniqueId);
    VoiceTimelineExcel.AddSoundVolume(builder, SoundVolumeOffset);
    VoiceTimelineExcel.AddPath(builder, PathOffset);
    VoiceTimelineExcel.AddNation_(builder, Nation_Offset);
    VoiceTimelineExcel.AddId(builder, Id);
    return VoiceTimelineExcel.EndVoiceTimelineExcel(builder);
  }

  public static void StartVoiceTimelineExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddUniqueId(FlatBufferBuilder builder, long uniqueId) { builder.AddLong(0, uniqueId, 0); }
  public static void AddId(FlatBufferBuilder builder, uint id) { builder.AddUint(1, id, 0); }
  public static void AddNation_(FlatBufferBuilder builder, VectorOffset nation_Offset) { builder.AddOffset(2, nation_Offset.Value, 0); }
  public static VectorOffset CreateNation_Vector(FlatBufferBuilder builder, Plana.FlatData.Nation[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateNation_VectorBlock(FlatBufferBuilder builder, Plana.FlatData.Nation[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateNation_VectorBlock(FlatBufferBuilder builder, ArraySegment<Plana.FlatData.Nation> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateNation_VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Plana.FlatData.Nation>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartNation_Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPath(FlatBufferBuilder builder, VectorOffset pathOffset) { builder.AddOffset(3, pathOffset.Value, 0); }
  public static VectorOffset CreatePathVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreatePathVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePathVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePathVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPathVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSoundVolume(FlatBufferBuilder builder, VectorOffset soundVolumeOffset) { builder.AddOffset(4, soundVolumeOffset.Value, 0); }
  public static VectorOffset CreateSoundVolumeVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateSoundVolumeVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSoundVolumeVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSoundVolumeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSoundVolumeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Plana.FlatData.VoiceTimelineExcel> EndVoiceTimelineExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.VoiceTimelineExcel>(o);
  }
  public VoiceTimelineExcelT UnPack() {
    var _o = new VoiceTimelineExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(VoiceTimelineExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("VoiceTimeline");
    _o.UniqueId = TableEncryptionService.Convert(this.UniqueId, key);
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.Nation_ = new List<Plana.FlatData.Nation>();
    for (var _j = 0; _j < this.Nation_Length; ++_j) {_o.Nation_.Add(TableEncryptionService.Convert(this.Nation_(_j), key));}
    _o.Path = new List<string>();
    for (var _j = 0; _j < this.PathLength; ++_j) {_o.Path.Add(TableEncryptionService.Convert(this.Path(_j), key));}
    _o.SoundVolume = new List<float>();
    for (var _j = 0; _j < this.SoundVolumeLength; ++_j) {_o.SoundVolume.Add(TableEncryptionService.Convert(this.SoundVolume(_j), key));}
  }
  public static Offset<Plana.FlatData.VoiceTimelineExcel> Pack(FlatBufferBuilder builder, VoiceTimelineExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.VoiceTimelineExcel>);
    var _Nation_ = default(VectorOffset);
    if (_o.Nation_ != null) {
      var __Nation_ = _o.Nation_.ToArray();
      _Nation_ = CreateNation_Vector(builder, __Nation_);
    }
    var _Path = default(VectorOffset);
    if (_o.Path != null) {
      var __Path = new StringOffset[_o.Path.Count];
      for (var _j = 0; _j < __Path.Length; ++_j) { __Path[_j] = builder.CreateString(_o.Path[_j]); }
      _Path = CreatePathVector(builder, __Path);
    }
    var _SoundVolume = default(VectorOffset);
    if (_o.SoundVolume != null) {
      var __SoundVolume = _o.SoundVolume.ToArray();
      _SoundVolume = CreateSoundVolumeVector(builder, __SoundVolume);
    }
    return CreateVoiceTimelineExcel(
      builder,
      _o.UniqueId,
      _o.Id,
      _Nation_,
      _Path,
      _SoundVolume);
  }
}

public class VoiceTimelineExcelT
{
  public long UniqueId { get; set; }
  public uint Id { get; set; }
  public List<Plana.FlatData.Nation> Nation_ { get; set; }
  public List<string> Path { get; set; }
  public List<float> SoundVolume { get; set; }

  public VoiceTimelineExcelT() {
    this.UniqueId = 0;
    this.Id = 0;
    this.Nation_ = null;
    this.Path = null;
    this.SoundVolume = null;
  }
}


static public class VoiceTimelineExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*UniqueId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*Id*/, 4 /*uint*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 8 /*Nation_*/, 4 /*Plana.FlatData.Nation*/, false)
      && verifier.VerifyVectorOfStrings(tablePos, 10 /*Path*/, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*SoundVolume*/, 4 /*float*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
