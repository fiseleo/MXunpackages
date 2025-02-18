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

public struct CharacterLevelStatFactorExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static CharacterLevelStatFactorExcel GetRootAsCharacterLevelStatFactorExcel(ByteBuffer _bb) { return GetRootAsCharacterLevelStatFactorExcel(_bb, new CharacterLevelStatFactorExcel()); }
  public static CharacterLevelStatFactorExcel GetRootAsCharacterLevelStatFactorExcel(ByteBuffer _bb, CharacterLevelStatFactorExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterLevelStatFactorExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Level { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CriticalFactor { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StabilityFactor { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DefenceFactor { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AccuracyFactor { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<Plana.FlatData.CharacterLevelStatFactorExcel> CreateCharacterLevelStatFactorExcel(FlatBufferBuilder builder,
      long Level = 0,
      long CriticalFactor = 0,
      long StabilityFactor = 0,
      long DefenceFactor = 0,
      long AccuracyFactor = 0) {
    builder.StartTable(5);
    CharacterLevelStatFactorExcel.AddAccuracyFactor(builder, AccuracyFactor);
    CharacterLevelStatFactorExcel.AddDefenceFactor(builder, DefenceFactor);
    CharacterLevelStatFactorExcel.AddStabilityFactor(builder, StabilityFactor);
    CharacterLevelStatFactorExcel.AddCriticalFactor(builder, CriticalFactor);
    CharacterLevelStatFactorExcel.AddLevel(builder, Level);
    return CharacterLevelStatFactorExcel.EndCharacterLevelStatFactorExcel(builder);
  }

  public static void StartCharacterLevelStatFactorExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddLevel(FlatBufferBuilder builder, long level) { builder.AddLong(0, level, 0); }
  public static void AddCriticalFactor(FlatBufferBuilder builder, long criticalFactor) { builder.AddLong(1, criticalFactor, 0); }
  public static void AddStabilityFactor(FlatBufferBuilder builder, long stabilityFactor) { builder.AddLong(2, stabilityFactor, 0); }
  public static void AddDefenceFactor(FlatBufferBuilder builder, long defenceFactor) { builder.AddLong(3, defenceFactor, 0); }
  public static void AddAccuracyFactor(FlatBufferBuilder builder, long accuracyFactor) { builder.AddLong(4, accuracyFactor, 0); }
  public static Offset<Plana.FlatData.CharacterLevelStatFactorExcel> EndCharacterLevelStatFactorExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.CharacterLevelStatFactorExcel>(o);
  }
  public CharacterLevelStatFactorExcelT UnPack() {
    var _o = new CharacterLevelStatFactorExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CharacterLevelStatFactorExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("CharacterLevelStatFactor");
    _o.Level = TableEncryptionService.Convert(this.Level, key);
    _o.CriticalFactor = TableEncryptionService.Convert(this.CriticalFactor, key);
    _o.StabilityFactor = TableEncryptionService.Convert(this.StabilityFactor, key);
    _o.DefenceFactor = TableEncryptionService.Convert(this.DefenceFactor, key);
    _o.AccuracyFactor = TableEncryptionService.Convert(this.AccuracyFactor, key);
  }
  public static Offset<Plana.FlatData.CharacterLevelStatFactorExcel> Pack(FlatBufferBuilder builder, CharacterLevelStatFactorExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.CharacterLevelStatFactorExcel>);
    return CreateCharacterLevelStatFactorExcel(
      builder,
      _o.Level,
      _o.CriticalFactor,
      _o.StabilityFactor,
      _o.DefenceFactor,
      _o.AccuracyFactor);
  }
}

public class CharacterLevelStatFactorExcelT
{
  public long Level { get; set; }
  public long CriticalFactor { get; set; }
  public long StabilityFactor { get; set; }
  public long DefenceFactor { get; set; }
  public long AccuracyFactor { get; set; }

  public CharacterLevelStatFactorExcelT() {
    this.Level = 0;
    this.CriticalFactor = 0;
    this.StabilityFactor = 0;
    this.DefenceFactor = 0;
    this.AccuracyFactor = 0;
  }
}


static public class CharacterLevelStatFactorExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Level*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*CriticalFactor*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*StabilityFactor*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*DefenceFactor*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*AccuracyFactor*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
