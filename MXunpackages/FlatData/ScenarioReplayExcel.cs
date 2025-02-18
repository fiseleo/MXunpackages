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

public struct ScenarioReplayExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ScenarioReplayExcel GetRootAsScenarioReplayExcel(ByteBuffer _bb) { return GetRootAsScenarioReplayExcel(_bb, new ScenarioReplayExcel()); }
  public static ScenarioReplayExcel GetRootAsScenarioReplayExcel(ByteBuffer _bb, ScenarioReplayExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ScenarioReplayExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long ModeId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long VolumeId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.ScenarioModeReplayTypes ReplayType { get { int o = __p.__offset(8); return o != 0 ? (Plana.FlatData.ScenarioModeReplayTypes)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ScenarioModeReplayTypes.None; } }
  public long ChapterId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EpisodeId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long FrontScenarioGroupId(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int FrontScenarioGroupIdLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetFrontScenarioGroupIdBytes() { return __p.__vector_as_span<long>(14, 8); }
#else
  public ArraySegment<byte>? GetFrontScenarioGroupIdBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public long[] GetFrontScenarioGroupIdArray() { return __p.__vector_as_array<long>(14); }
  public long GroundId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BattleDuration { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BackScenarioGroupId(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int BackScenarioGroupIdLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetBackScenarioGroupIdBytes() { return __p.__vector_as_span<long>(20, 8); }
#else
  public ArraySegment<byte>? GetBackScenarioGroupIdBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public long[] GetBackScenarioGroupIdArray() { return __p.__vector_as_array<long>(20); }

  public static Offset<Plana.FlatData.ScenarioReplayExcel> CreateScenarioReplayExcel(FlatBufferBuilder builder,
      long ModeId = 0,
      long VolumeId = 0,
      Plana.FlatData.ScenarioModeReplayTypes ReplayType = Plana.FlatData.ScenarioModeReplayTypes.None,
      long ChapterId = 0,
      long EpisodeId = 0,
      VectorOffset FrontScenarioGroupIdOffset = default(VectorOffset),
      long GroundId = 0,
      long BattleDuration = 0,
      VectorOffset BackScenarioGroupIdOffset = default(VectorOffset)) {
    builder.StartTable(9);
    ScenarioReplayExcel.AddBattleDuration(builder, BattleDuration);
    ScenarioReplayExcel.AddGroundId(builder, GroundId);
    ScenarioReplayExcel.AddEpisodeId(builder, EpisodeId);
    ScenarioReplayExcel.AddChapterId(builder, ChapterId);
    ScenarioReplayExcel.AddVolumeId(builder, VolumeId);
    ScenarioReplayExcel.AddModeId(builder, ModeId);
    ScenarioReplayExcel.AddBackScenarioGroupId(builder, BackScenarioGroupIdOffset);
    ScenarioReplayExcel.AddFrontScenarioGroupId(builder, FrontScenarioGroupIdOffset);
    ScenarioReplayExcel.AddReplayType(builder, ReplayType);
    return ScenarioReplayExcel.EndScenarioReplayExcel(builder);
  }

  public static void StartScenarioReplayExcel(FlatBufferBuilder builder) { builder.StartTable(9); }
  public static void AddModeId(FlatBufferBuilder builder, long modeId) { builder.AddLong(0, modeId, 0); }
  public static void AddVolumeId(FlatBufferBuilder builder, long volumeId) { builder.AddLong(1, volumeId, 0); }
  public static void AddReplayType(FlatBufferBuilder builder, Plana.FlatData.ScenarioModeReplayTypes replayType) { builder.AddInt(2, (int)replayType, 0); }
  public static void AddChapterId(FlatBufferBuilder builder, long chapterId) { builder.AddLong(3, chapterId, 0); }
  public static void AddEpisodeId(FlatBufferBuilder builder, long episodeId) { builder.AddLong(4, episodeId, 0); }
  public static void AddFrontScenarioGroupId(FlatBufferBuilder builder, VectorOffset frontScenarioGroupIdOffset) { builder.AddOffset(5, frontScenarioGroupIdOffset.Value, 0); }
  public static VectorOffset CreateFrontScenarioGroupIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateFrontScenarioGroupIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateFrontScenarioGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateFrontScenarioGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartFrontScenarioGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddGroundId(FlatBufferBuilder builder, long groundId) { builder.AddLong(6, groundId, 0); }
  public static void AddBattleDuration(FlatBufferBuilder builder, long battleDuration) { builder.AddLong(7, battleDuration, 0); }
  public static void AddBackScenarioGroupId(FlatBufferBuilder builder, VectorOffset backScenarioGroupIdOffset) { builder.AddOffset(8, backScenarioGroupIdOffset.Value, 0); }
  public static VectorOffset CreateBackScenarioGroupIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBackScenarioGroupIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBackScenarioGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBackScenarioGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBackScenarioGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<Plana.FlatData.ScenarioReplayExcel> EndScenarioReplayExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.ScenarioReplayExcel>(o);
  }
  public ScenarioReplayExcelT UnPack() {
    var _o = new ScenarioReplayExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ScenarioReplayExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("ScenarioReplay");
    _o.ModeId = TableEncryptionService.Convert(this.ModeId, key);
    _o.VolumeId = TableEncryptionService.Convert(this.VolumeId, key);
    _o.ReplayType = TableEncryptionService.Convert(this.ReplayType, key);
    _o.ChapterId = TableEncryptionService.Convert(this.ChapterId, key);
    _o.EpisodeId = TableEncryptionService.Convert(this.EpisodeId, key);
    _o.FrontScenarioGroupId = new List<long>();
    for (var _j = 0; _j < this.FrontScenarioGroupIdLength; ++_j) {_o.FrontScenarioGroupId.Add(TableEncryptionService.Convert(this.FrontScenarioGroupId(_j), key));}
    _o.GroundId = TableEncryptionService.Convert(this.GroundId, key);
    _o.BattleDuration = TableEncryptionService.Convert(this.BattleDuration, key);
    _o.BackScenarioGroupId = new List<long>();
    for (var _j = 0; _j < this.BackScenarioGroupIdLength; ++_j) {_o.BackScenarioGroupId.Add(TableEncryptionService.Convert(this.BackScenarioGroupId(_j), key));}
  }
  public static Offset<Plana.FlatData.ScenarioReplayExcel> Pack(FlatBufferBuilder builder, ScenarioReplayExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.ScenarioReplayExcel>);
    var _FrontScenarioGroupId = default(VectorOffset);
    if (_o.FrontScenarioGroupId != null) {
      var __FrontScenarioGroupId = _o.FrontScenarioGroupId.ToArray();
      _FrontScenarioGroupId = CreateFrontScenarioGroupIdVector(builder, __FrontScenarioGroupId);
    }
    var _BackScenarioGroupId = default(VectorOffset);
    if (_o.BackScenarioGroupId != null) {
      var __BackScenarioGroupId = _o.BackScenarioGroupId.ToArray();
      _BackScenarioGroupId = CreateBackScenarioGroupIdVector(builder, __BackScenarioGroupId);
    }
    return CreateScenarioReplayExcel(
      builder,
      _o.ModeId,
      _o.VolumeId,
      _o.ReplayType,
      _o.ChapterId,
      _o.EpisodeId,
      _FrontScenarioGroupId,
      _o.GroundId,
      _o.BattleDuration,
      _BackScenarioGroupId);
  }
}

public class ScenarioReplayExcelT
{
  public long ModeId { get; set; }
  public long VolumeId { get; set; }
  public Plana.FlatData.ScenarioModeReplayTypes ReplayType { get; set; }
  public long ChapterId { get; set; }
  public long EpisodeId { get; set; }
  public List<long> FrontScenarioGroupId { get; set; }
  public long GroundId { get; set; }
  public long BattleDuration { get; set; }
  public List<long> BackScenarioGroupId { get; set; }

  public ScenarioReplayExcelT() {
    this.ModeId = 0;
    this.VolumeId = 0;
    this.ReplayType = Plana.FlatData.ScenarioModeReplayTypes.None;
    this.ChapterId = 0;
    this.EpisodeId = 0;
    this.FrontScenarioGroupId = null;
    this.GroundId = 0;
    this.BattleDuration = 0;
    this.BackScenarioGroupId = null;
  }
}


static public class ScenarioReplayExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*ModeId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*VolumeId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*ReplayType*/, 4 /*Plana.FlatData.ScenarioModeReplayTypes*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*ChapterId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*EpisodeId*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 14 /*FrontScenarioGroupId*/, 8 /*long*/, false)
      && verifier.VerifyField(tablePos, 16 /*GroundId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*BattleDuration*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 20 /*BackScenarioGroupId*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
