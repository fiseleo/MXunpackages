// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct ConstAudioExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ConstAudioExcel GetRootAsConstAudioExcel(ByteBuffer _bb) { return GetRootAsConstAudioExcel(_bb, new ConstAudioExcel()); }
  public static ConstAudioExcel GetRootAsConstAudioExcel(ByteBuffer _bb, ConstAudioExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConstAudioExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string DefaultSnapShotName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDefaultSnapShotNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetDefaultSnapShotNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetDefaultSnapShotNameArray() { return __p.__vector_as_array<byte>(4); }
  public string BattleSnapShotName { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBattleSnapShotNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetBattleSnapShotNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetBattleSnapShotNameArray() { return __p.__vector_as_array<byte>(6); }
  public string RaidSnapShotName { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRaidSnapShotNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetRaidSnapShotNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetRaidSnapShotNameArray() { return __p.__vector_as_array<byte>(8); }
  public string ExSkillCutInSnapShotName { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetExSkillCutInSnapShotNameBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetExSkillCutInSnapShotNameBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetExSkillCutInSnapShotNameArray() { return __p.__vector_as_array<byte>(10); }

  public static Offset<Plana.FlatData.ConstAudioExcel> CreateConstAudioExcel(FlatBufferBuilder builder,
      StringOffset DefaultSnapShotNameOffset = default(StringOffset),
      StringOffset BattleSnapShotNameOffset = default(StringOffset),
      StringOffset RaidSnapShotNameOffset = default(StringOffset),
      StringOffset ExSkillCutInSnapShotNameOffset = default(StringOffset)) {
    builder.StartTable(4);
    ConstAudioExcel.AddExSkillCutInSnapShotName(builder, ExSkillCutInSnapShotNameOffset);
    ConstAudioExcel.AddRaidSnapShotName(builder, RaidSnapShotNameOffset);
    ConstAudioExcel.AddBattleSnapShotName(builder, BattleSnapShotNameOffset);
    ConstAudioExcel.AddDefaultSnapShotName(builder, DefaultSnapShotNameOffset);
    return ConstAudioExcel.EndConstAudioExcel(builder);
  }

  public static void StartConstAudioExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddDefaultSnapShotName(FlatBufferBuilder builder, StringOffset defaultSnapShotNameOffset) { builder.AddOffset(0, defaultSnapShotNameOffset.Value, 0); }
  public static void AddBattleSnapShotName(FlatBufferBuilder builder, StringOffset battleSnapShotNameOffset) { builder.AddOffset(1, battleSnapShotNameOffset.Value, 0); }
  public static void AddRaidSnapShotName(FlatBufferBuilder builder, StringOffset raidSnapShotNameOffset) { builder.AddOffset(2, raidSnapShotNameOffset.Value, 0); }
  public static void AddExSkillCutInSnapShotName(FlatBufferBuilder builder, StringOffset exSkillCutInSnapShotNameOffset) { builder.AddOffset(3, exSkillCutInSnapShotNameOffset.Value, 0); }
  public static Offset<Plana.FlatData.ConstAudioExcel> EndConstAudioExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.ConstAudioExcel>(o);
  }
  public ConstAudioExcelT UnPack() {
    var _o = new ConstAudioExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ConstAudioExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("ConstAudio");
    _o.DefaultSnapShotName = TableEncryptionService.Convert(this.DefaultSnapShotName, key);
    _o.BattleSnapShotName = TableEncryptionService.Convert(this.BattleSnapShotName, key);
    _o.RaidSnapShotName = TableEncryptionService.Convert(this.RaidSnapShotName, key);
    _o.ExSkillCutInSnapShotName = TableEncryptionService.Convert(this.ExSkillCutInSnapShotName, key);
  }
  public static Offset<Plana.FlatData.ConstAudioExcel> Pack(FlatBufferBuilder builder, ConstAudioExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.ConstAudioExcel>);
    var _DefaultSnapShotName = _o.DefaultSnapShotName == null ? default(StringOffset) : builder.CreateString(_o.DefaultSnapShotName);
    var _BattleSnapShotName = _o.BattleSnapShotName == null ? default(StringOffset) : builder.CreateString(_o.BattleSnapShotName);
    var _RaidSnapShotName = _o.RaidSnapShotName == null ? default(StringOffset) : builder.CreateString(_o.RaidSnapShotName);
    var _ExSkillCutInSnapShotName = _o.ExSkillCutInSnapShotName == null ? default(StringOffset) : builder.CreateString(_o.ExSkillCutInSnapShotName);
    return CreateConstAudioExcel(
      builder,
      _DefaultSnapShotName,
      _BattleSnapShotName,
      _RaidSnapShotName,
      _ExSkillCutInSnapShotName);
  }
}

public class ConstAudioExcelT
{
  public string DefaultSnapShotName { get; set; }
  public string BattleSnapShotName { get; set; }
  public string RaidSnapShotName { get; set; }
  public string ExSkillCutInSnapShotName { get; set; }

  public ConstAudioExcelT() {
    this.DefaultSnapShotName = null;
    this.BattleSnapShotName = null;
    this.RaidSnapShotName = null;
    this.ExSkillCutInSnapShotName = null;
  }
}


static public class ConstAudioExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyString(tablePos, 4 /*DefaultSnapShotName*/, false)
      && verifier.VerifyString(tablePos, 6 /*BattleSnapShotName*/, false)
      && verifier.VerifyString(tablePos, 8 /*RaidSnapShotName*/, false)
      && verifier.VerifyString(tablePos, 10 /*ExSkillCutInSnapShotName*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
