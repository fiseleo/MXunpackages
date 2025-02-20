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

public struct AniStateData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static AniStateData GetRootAsAniStateData(ByteBuffer _bb) { return GetRootAsAniStateData(_bb, new AniStateData()); }
  public static AniStateData GetRootAsAniStateData(ByteBuffer _bb, AniStateData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AniStateData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string StateName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStateNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetStateNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetStateNameArray() { return __p.__vector_as_array<byte>(4); }
  public string StatePrefix { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStatePrefixBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetStatePrefixBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetStatePrefixArray() { return __p.__vector_as_array<byte>(6); }
  public string StateNameWithPrefix { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStateNameWithPrefixBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetStateNameWithPrefixBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetStateNameWithPrefixArray() { return __p.__vector_as_array<byte>(8); }
  public string Tag { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTagBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetTagBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetTagArray() { return __p.__vector_as_array<byte>(10); }
  public string SpeedParameterName { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSpeedParameterNameBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetSpeedParameterNameBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetSpeedParameterNameArray() { return __p.__vector_as_array<byte>(12); }
  public float SpeedParamter { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float StateSpeed { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public string ClipName { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetClipNameBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetClipNameBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetClipNameArray() { return __p.__vector_as_array<byte>(18); }
  public float Length { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float FrameRate { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public bool IsLooping { get { int o = __p.__offset(24); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public Plana.FlatData.AniEventData? Events(int j) { int o = __p.__offset(26); return o != 0 ? (Plana.FlatData.AniEventData?)(new Plana.FlatData.AniEventData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int EventsLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<Plana.FlatData.AniStateData> CreateAniStateData(FlatBufferBuilder builder,
      StringOffset StateNameOffset = default(StringOffset),
      StringOffset StatePrefixOffset = default(StringOffset),
      StringOffset StateNameWithPrefixOffset = default(StringOffset),
      StringOffset TagOffset = default(StringOffset),
      StringOffset SpeedParameterNameOffset = default(StringOffset),
      float SpeedParamter = 0.0f,
      float StateSpeed = 0.0f,
      StringOffset ClipNameOffset = default(StringOffset),
      float Length = 0.0f,
      float FrameRate = 0.0f,
      bool IsLooping = false,
      VectorOffset EventsOffset = default(VectorOffset)) {
    builder.StartTable(12);
    AniStateData.AddEvents(builder, EventsOffset);
    AniStateData.AddFrameRate(builder, FrameRate);
    AniStateData.AddLength(builder, Length);
    AniStateData.AddClipName(builder, ClipNameOffset);
    AniStateData.AddStateSpeed(builder, StateSpeed);
    AniStateData.AddSpeedParamter(builder, SpeedParamter);
    AniStateData.AddSpeedParameterName(builder, SpeedParameterNameOffset);
    AniStateData.AddTag(builder, TagOffset);
    AniStateData.AddStateNameWithPrefix(builder, StateNameWithPrefixOffset);
    AniStateData.AddStatePrefix(builder, StatePrefixOffset);
    AniStateData.AddStateName(builder, StateNameOffset);
    AniStateData.AddIsLooping(builder, IsLooping);
    return AniStateData.EndAniStateData(builder);
  }

  public static void StartAniStateData(FlatBufferBuilder builder) { builder.StartTable(12); }
  public static void AddStateName(FlatBufferBuilder builder, StringOffset stateNameOffset) { builder.AddOffset(0, stateNameOffset.Value, 0); }
  public static void AddStatePrefix(FlatBufferBuilder builder, StringOffset statePrefixOffset) { builder.AddOffset(1, statePrefixOffset.Value, 0); }
  public static void AddStateNameWithPrefix(FlatBufferBuilder builder, StringOffset stateNameWithPrefixOffset) { builder.AddOffset(2, stateNameWithPrefixOffset.Value, 0); }
  public static void AddTag(FlatBufferBuilder builder, StringOffset tagOffset) { builder.AddOffset(3, tagOffset.Value, 0); }
  public static void AddSpeedParameterName(FlatBufferBuilder builder, StringOffset speedParameterNameOffset) { builder.AddOffset(4, speedParameterNameOffset.Value, 0); }
  public static void AddSpeedParamter(FlatBufferBuilder builder, float speedParamter) { builder.AddFloat(5, speedParamter, 0.0f); }
  public static void AddStateSpeed(FlatBufferBuilder builder, float stateSpeed) { builder.AddFloat(6, stateSpeed, 0.0f); }
  public static void AddClipName(FlatBufferBuilder builder, StringOffset clipNameOffset) { builder.AddOffset(7, clipNameOffset.Value, 0); }
  public static void AddLength(FlatBufferBuilder builder, float length) { builder.AddFloat(8, length, 0.0f); }
  public static void AddFrameRate(FlatBufferBuilder builder, float frameRate) { builder.AddFloat(9, frameRate, 0.0f); }
  public static void AddIsLooping(FlatBufferBuilder builder, bool isLooping) { builder.AddBool(10, isLooping, false); }
  public static void AddEvents(FlatBufferBuilder builder, VectorOffset eventsOffset) { builder.AddOffset(11, eventsOffset.Value, 0); }
  public static VectorOffset CreateEventsVector(FlatBufferBuilder builder, Offset<Plana.FlatData.AniEventData>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateEventsVectorBlock(FlatBufferBuilder builder, Offset<Plana.FlatData.AniEventData>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEventsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Plana.FlatData.AniEventData>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEventsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<Plana.FlatData.AniEventData>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartEventsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Plana.FlatData.AniStateData> EndAniStateData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.AniStateData>(o);
  }
  public AniStateDataT UnPack() {
    var _o = new AniStateDataT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(AniStateDataT _o) {
        byte[] key = TableEncryptionService.CreateKey("AniStateDataT");
    _o.StateName = TableEncryptionService.Convert(this.StateName, key);
    _o.StatePrefix = TableEncryptionService.Convert(this.StatePrefix, key);
    _o.StateNameWithPrefix = TableEncryptionService.Convert(this.StateNameWithPrefix, key);
    _o.Tag = TableEncryptionService.Convert(this.Tag, key);
    _o.SpeedParameterName = TableEncryptionService.Convert(this.SpeedParameterName, key);
    _o.SpeedParamter = TableEncryptionService.Convert(this.SpeedParamter, key);
    _o.StateSpeed = TableEncryptionService.Convert(this.StateSpeed, key);
    _o.ClipName = TableEncryptionService.Convert(this.ClipName, key);
    _o.Length = TableEncryptionService.Convert(this.Length, key);
    _o.FrameRate = TableEncryptionService.Convert(this.FrameRate, key);
    _o.IsLooping = TableEncryptionService.Convert(this.IsLooping, key);
    _o.Events = new List<Plana.FlatData.AniEventDataT>();
    for (var _j = 0; _j < this.EventsLength; ++_j) {_o.Events.Add(this.Events(_j).HasValue ? this.Events(_j).Value.UnPack() : null);}
  }
  public static Offset<Plana.FlatData.AniStateData> Pack(FlatBufferBuilder builder, AniStateDataT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.AniStateData>);
    var _StateName = _o.StateName == null ? default(StringOffset) : builder.CreateString(_o.StateName);
    var _StatePrefix = _o.StatePrefix == null ? default(StringOffset) : builder.CreateString(_o.StatePrefix);
    var _StateNameWithPrefix = _o.StateNameWithPrefix == null ? default(StringOffset) : builder.CreateString(_o.StateNameWithPrefix);
    var _Tag = _o.Tag == null ? default(StringOffset) : builder.CreateString(_o.Tag);
    var _SpeedParameterName = _o.SpeedParameterName == null ? default(StringOffset) : builder.CreateString(_o.SpeedParameterName);
    var _ClipName = _o.ClipName == null ? default(StringOffset) : builder.CreateString(_o.ClipName);
    var _Events = default(VectorOffset);
    if (_o.Events != null) {
      var __Events = new Offset<Plana.FlatData.AniEventData>[_o.Events.Count];
      for (var _j = 0; _j < __Events.Length; ++_j) { __Events[_j] = Plana.FlatData.AniEventData.Pack(builder, _o.Events[_j]); }
      _Events = CreateEventsVector(builder, __Events);
    }
    return CreateAniStateData(
      builder,
      _StateName,
      _StatePrefix,
      _StateNameWithPrefix,
      _Tag,
      _SpeedParameterName,
      _o.SpeedParamter,
      _o.StateSpeed,
      _ClipName,
      _o.Length,
      _o.FrameRate,
      _o.IsLooping,
      _Events);
  }
}

public class AniStateDataT
{
  public string StateName { get; set; }
  public string StatePrefix { get; set; }
  public string StateNameWithPrefix { get; set; }
  public string Tag { get; set; }
  public string SpeedParameterName { get; set; }
  public float SpeedParamter { get; set; }
  public float StateSpeed { get; set; }
  public string ClipName { get; set; }
  public float Length { get; set; }
  public float FrameRate { get; set; }
  public bool IsLooping { get; set; }
  public List<Plana.FlatData.AniEventDataT> Events { get; set; }

  public AniStateDataT() {
    this.StateName = null;
    this.StatePrefix = null;
    this.StateNameWithPrefix = null;
    this.Tag = null;
    this.SpeedParameterName = null;
    this.SpeedParamter = 0.0f;
    this.StateSpeed = 0.0f;
    this.ClipName = null;
    this.Length = 0.0f;
    this.FrameRate = 0.0f;
    this.IsLooping = false;
    this.Events = null;
  }
}


static public class AniStateDataVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyString(tablePos, 4 /*StateName*/, false)
      && verifier.VerifyString(tablePos, 6 /*StatePrefix*/, false)
      && verifier.VerifyString(tablePos, 8 /*StateNameWithPrefix*/, false)
      && verifier.VerifyString(tablePos, 10 /*Tag*/, false)
      && verifier.VerifyString(tablePos, 12 /*SpeedParameterName*/, false)
      && verifier.VerifyField(tablePos, 14 /*SpeedParamter*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*StateSpeed*/, 4 /*float*/, 4, false)
      && verifier.VerifyString(tablePos, 18 /*ClipName*/, false)
      && verifier.VerifyField(tablePos, 20 /*Length*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*FrameRate*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 24 /*IsLooping*/, 1 /*bool*/, 1, false)
      && verifier.VerifyVectorOfTables(tablePos, 26 /*Events*/, Plana.FlatData.AniEventDataVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
