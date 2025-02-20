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

public struct ConstMiniGameShootingExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ConstMiniGameShootingExcel GetRootAsConstMiniGameShootingExcel(ByteBuffer _bb) { return GetRootAsConstMiniGameShootingExcel(_bb, new ConstMiniGameShootingExcel()); }
  public static ConstMiniGameShootingExcel GetRootAsConstMiniGameShootingExcel(ByteBuffer _bb, ConstMiniGameShootingExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConstMiniGameShootingExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long NormalStageId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int NormalSectionCount { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long HardStageId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int HardSectionCount { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long LeftPlayerCharacterId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RightPlayerCharacterId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long HiddenPlayerCharacterId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public float CameraSmoothTime { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public string SpawnEffectPath { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSpawnEffectPathBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetSpawnEffectPathBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetSpawnEffectPathArray() { return __p.__vector_as_array<byte>(20); }
  public float WaitTimeAfterSpawn { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<Plana.FlatData.ConstMiniGameShootingExcel> CreateConstMiniGameShootingExcel(FlatBufferBuilder builder,
      long NormalStageId = 0,
      int NormalSectionCount = 0,
      long HardStageId = 0,
      int HardSectionCount = 0,
      long LeftPlayerCharacterId = 0,
      long RightPlayerCharacterId = 0,
      long HiddenPlayerCharacterId = 0,
      float CameraSmoothTime = 0.0f,
      StringOffset SpawnEffectPathOffset = default(StringOffset),
      float WaitTimeAfterSpawn = 0.0f) {
    builder.StartTable(10);
    ConstMiniGameShootingExcel.AddHiddenPlayerCharacterId(builder, HiddenPlayerCharacterId);
    ConstMiniGameShootingExcel.AddRightPlayerCharacterId(builder, RightPlayerCharacterId);
    ConstMiniGameShootingExcel.AddLeftPlayerCharacterId(builder, LeftPlayerCharacterId);
    ConstMiniGameShootingExcel.AddHardStageId(builder, HardStageId);
    ConstMiniGameShootingExcel.AddNormalStageId(builder, NormalStageId);
    ConstMiniGameShootingExcel.AddWaitTimeAfterSpawn(builder, WaitTimeAfterSpawn);
    ConstMiniGameShootingExcel.AddSpawnEffectPath(builder, SpawnEffectPathOffset);
    ConstMiniGameShootingExcel.AddCameraSmoothTime(builder, CameraSmoothTime);
    ConstMiniGameShootingExcel.AddHardSectionCount(builder, HardSectionCount);
    ConstMiniGameShootingExcel.AddNormalSectionCount(builder, NormalSectionCount);
    return ConstMiniGameShootingExcel.EndConstMiniGameShootingExcel(builder);
  }

  public static void StartConstMiniGameShootingExcel(FlatBufferBuilder builder) { builder.StartTable(10); }
  public static void AddNormalStageId(FlatBufferBuilder builder, long normalStageId) { builder.AddLong(0, normalStageId, 0); }
  public static void AddNormalSectionCount(FlatBufferBuilder builder, int normalSectionCount) { builder.AddInt(1, normalSectionCount, 0); }
  public static void AddHardStageId(FlatBufferBuilder builder, long hardStageId) { builder.AddLong(2, hardStageId, 0); }
  public static void AddHardSectionCount(FlatBufferBuilder builder, int hardSectionCount) { builder.AddInt(3, hardSectionCount, 0); }
  public static void AddLeftPlayerCharacterId(FlatBufferBuilder builder, long leftPlayerCharacterId) { builder.AddLong(4, leftPlayerCharacterId, 0); }
  public static void AddRightPlayerCharacterId(FlatBufferBuilder builder, long rightPlayerCharacterId) { builder.AddLong(5, rightPlayerCharacterId, 0); }
  public static void AddHiddenPlayerCharacterId(FlatBufferBuilder builder, long hiddenPlayerCharacterId) { builder.AddLong(6, hiddenPlayerCharacterId, 0); }
  public static void AddCameraSmoothTime(FlatBufferBuilder builder, float cameraSmoothTime) { builder.AddFloat(7, cameraSmoothTime, 0.0f); }
  public static void AddSpawnEffectPath(FlatBufferBuilder builder, StringOffset spawnEffectPathOffset) { builder.AddOffset(8, spawnEffectPathOffset.Value, 0); }
  public static void AddWaitTimeAfterSpawn(FlatBufferBuilder builder, float waitTimeAfterSpawn) { builder.AddFloat(9, waitTimeAfterSpawn, 0.0f); }
  public static Offset<Plana.FlatData.ConstMiniGameShootingExcel> EndConstMiniGameShootingExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.ConstMiniGameShootingExcel>(o);
  }
  public ConstMiniGameShootingExcelT UnPack() {
    var _o = new ConstMiniGameShootingExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ConstMiniGameShootingExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("ConstMiniGameShooting");
    _o.NormalStageId = TableEncryptionService.Convert(this.NormalStageId, key);
    _o.NormalSectionCount = TableEncryptionService.Convert(this.NormalSectionCount, key);
    _o.HardStageId = TableEncryptionService.Convert(this.HardStageId, key);
    _o.HardSectionCount = TableEncryptionService.Convert(this.HardSectionCount, key);
    _o.LeftPlayerCharacterId = TableEncryptionService.Convert(this.LeftPlayerCharacterId, key);
    _o.RightPlayerCharacterId = TableEncryptionService.Convert(this.RightPlayerCharacterId, key);
    _o.HiddenPlayerCharacterId = TableEncryptionService.Convert(this.HiddenPlayerCharacterId, key);
    _o.CameraSmoothTime = TableEncryptionService.Convert(this.CameraSmoothTime, key);
    _o.SpawnEffectPath = TableEncryptionService.Convert(this.SpawnEffectPath, key);
    _o.WaitTimeAfterSpawn = TableEncryptionService.Convert(this.WaitTimeAfterSpawn, key);
  }
  public static Offset<Plana.FlatData.ConstMiniGameShootingExcel> Pack(FlatBufferBuilder builder, ConstMiniGameShootingExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.ConstMiniGameShootingExcel>);
    var _SpawnEffectPath = _o.SpawnEffectPath == null ? default(StringOffset) : builder.CreateString(_o.SpawnEffectPath);
    return CreateConstMiniGameShootingExcel(
      builder,
      _o.NormalStageId,
      _o.NormalSectionCount,
      _o.HardStageId,
      _o.HardSectionCount,
      _o.LeftPlayerCharacterId,
      _o.RightPlayerCharacterId,
      _o.HiddenPlayerCharacterId,
      _o.CameraSmoothTime,
      _SpawnEffectPath,
      _o.WaitTimeAfterSpawn);
  }
}

public class ConstMiniGameShootingExcelT
{
  public long NormalStageId { get; set; }
  public int NormalSectionCount { get; set; }
  public long HardStageId { get; set; }
  public int HardSectionCount { get; set; }
  public long LeftPlayerCharacterId { get; set; }
  public long RightPlayerCharacterId { get; set; }
  public long HiddenPlayerCharacterId { get; set; }
  public float CameraSmoothTime { get; set; }
  public string SpawnEffectPath { get; set; }
  public float WaitTimeAfterSpawn { get; set; }

  public ConstMiniGameShootingExcelT() {
    this.NormalStageId = 0;
    this.NormalSectionCount = 0;
    this.HardStageId = 0;
    this.HardSectionCount = 0;
    this.LeftPlayerCharacterId = 0;
    this.RightPlayerCharacterId = 0;
    this.HiddenPlayerCharacterId = 0;
    this.CameraSmoothTime = 0.0f;
    this.SpawnEffectPath = null;
    this.WaitTimeAfterSpawn = 0.0f;
  }
}


static public class ConstMiniGameShootingExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*NormalStageId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*NormalSectionCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*HardStageId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*HardSectionCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*LeftPlayerCharacterId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*RightPlayerCharacterId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*HiddenPlayerCharacterId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*CameraSmoothTime*/, 4 /*float*/, 4, false)
      && verifier.VerifyString(tablePos, 20 /*SpawnEffectPath*/, false)
      && verifier.VerifyField(tablePos, 22 /*WaitTimeAfterSpawn*/, 4 /*float*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
