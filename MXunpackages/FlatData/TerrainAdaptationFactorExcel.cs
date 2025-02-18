// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct TerrainAdaptationFactorExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static TerrainAdaptationFactorExcel GetRootAsTerrainAdaptationFactorExcel(ByteBuffer _bb) { return GetRootAsTerrainAdaptationFactorExcel(_bb, new TerrainAdaptationFactorExcel()); }
  public static TerrainAdaptationFactorExcel GetRootAsTerrainAdaptationFactorExcel(ByteBuffer _bb, TerrainAdaptationFactorExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TerrainAdaptationFactorExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Plana.FlatData.StageTopography TerrainAdaptation { get { int o = __p.__offset(4); return o != 0 ? (Plana.FlatData.StageTopography)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.StageTopography.Street; } }
  public Plana.FlatData.TerrainAdaptationStat TerrainAdaptationStat { get { int o = __p.__offset(6); return o != 0 ? (Plana.FlatData.TerrainAdaptationStat)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.TerrainAdaptationStat.D; } }
  public long ShotFactor { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BlockFactor { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AccuracyFactor { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DodgeFactor { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AttackPowerFactor { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<Plana.FlatData.TerrainAdaptationFactorExcel> CreateTerrainAdaptationFactorExcel(FlatBufferBuilder builder,
      Plana.FlatData.StageTopography TerrainAdaptation = Plana.FlatData.StageTopography.Street,
      Plana.FlatData.TerrainAdaptationStat TerrainAdaptationStat = Plana.FlatData.TerrainAdaptationStat.D,
      long ShotFactor = 0,
      long BlockFactor = 0,
      long AccuracyFactor = 0,
      long DodgeFactor = 0,
      long AttackPowerFactor = 0) {
    builder.StartTable(7);
    TerrainAdaptationFactorExcel.AddAttackPowerFactor(builder, AttackPowerFactor);
    TerrainAdaptationFactorExcel.AddDodgeFactor(builder, DodgeFactor);
    TerrainAdaptationFactorExcel.AddAccuracyFactor(builder, AccuracyFactor);
    TerrainAdaptationFactorExcel.AddBlockFactor(builder, BlockFactor);
    TerrainAdaptationFactorExcel.AddShotFactor(builder, ShotFactor);
    TerrainAdaptationFactorExcel.AddTerrainAdaptationStat(builder, TerrainAdaptationStat);
    TerrainAdaptationFactorExcel.AddTerrainAdaptation(builder, TerrainAdaptation);
    return TerrainAdaptationFactorExcel.EndTerrainAdaptationFactorExcel(builder);
  }

  public static void StartTerrainAdaptationFactorExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddTerrainAdaptation(FlatBufferBuilder builder, Plana.FlatData.StageTopography terrainAdaptation) { builder.AddInt(0, (int)terrainAdaptation, 0); }
  public static void AddTerrainAdaptationStat(FlatBufferBuilder builder, Plana.FlatData.TerrainAdaptationStat terrainAdaptationStat) { builder.AddInt(1, (int)terrainAdaptationStat, 0); }
  public static void AddShotFactor(FlatBufferBuilder builder, long shotFactor) { builder.AddLong(2, shotFactor, 0); }
  public static void AddBlockFactor(FlatBufferBuilder builder, long blockFactor) { builder.AddLong(3, blockFactor, 0); }
  public static void AddAccuracyFactor(FlatBufferBuilder builder, long accuracyFactor) { builder.AddLong(4, accuracyFactor, 0); }
  public static void AddDodgeFactor(FlatBufferBuilder builder, long dodgeFactor) { builder.AddLong(5, dodgeFactor, 0); }
  public static void AddAttackPowerFactor(FlatBufferBuilder builder, long attackPowerFactor) { builder.AddLong(6, attackPowerFactor, 0); }
  public static Offset<Plana.FlatData.TerrainAdaptationFactorExcel> EndTerrainAdaptationFactorExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.TerrainAdaptationFactorExcel>(o);
  }
  public TerrainAdaptationFactorExcelT UnPack() {
    var _o = new TerrainAdaptationFactorExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(TerrainAdaptationFactorExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("TerrainAdaptationFactor");
    _o.TerrainAdaptation = TableEncryptionService.Convert(this.TerrainAdaptation, key);
    _o.TerrainAdaptationStat = TableEncryptionService.Convert(this.TerrainAdaptationStat, key);
    _o.ShotFactor = TableEncryptionService.Convert(this.ShotFactor, key);
    _o.BlockFactor = TableEncryptionService.Convert(this.BlockFactor, key);
    _o.AccuracyFactor = TableEncryptionService.Convert(this.AccuracyFactor, key);
    _o.DodgeFactor = TableEncryptionService.Convert(this.DodgeFactor, key);
    _o.AttackPowerFactor = TableEncryptionService.Convert(this.AttackPowerFactor, key);
  }
  public static Offset<Plana.FlatData.TerrainAdaptationFactorExcel> Pack(FlatBufferBuilder builder, TerrainAdaptationFactorExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.TerrainAdaptationFactorExcel>);
    return CreateTerrainAdaptationFactorExcel(
      builder,
      _o.TerrainAdaptation,
      _o.TerrainAdaptationStat,
      _o.ShotFactor,
      _o.BlockFactor,
      _o.AccuracyFactor,
      _o.DodgeFactor,
      _o.AttackPowerFactor);
  }
}

public class TerrainAdaptationFactorExcelT
{
  public Plana.FlatData.StageTopography TerrainAdaptation { get; set; }
  public Plana.FlatData.TerrainAdaptationStat TerrainAdaptationStat { get; set; }
  public long ShotFactor { get; set; }
  public long BlockFactor { get; set; }
  public long AccuracyFactor { get; set; }
  public long DodgeFactor { get; set; }
  public long AttackPowerFactor { get; set; }

  public TerrainAdaptationFactorExcelT() {
    this.TerrainAdaptation = Plana.FlatData.StageTopography.Street;
    this.TerrainAdaptationStat = Plana.FlatData.TerrainAdaptationStat.D;
    this.ShotFactor = 0;
    this.BlockFactor = 0;
    this.AccuracyFactor = 0;
    this.DodgeFactor = 0;
    this.AttackPowerFactor = 0;
  }
}


static public class TerrainAdaptationFactorExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*TerrainAdaptation*/, 4 /*Plana.FlatData.StageTopography*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*TerrainAdaptationStat*/, 4 /*Plana.FlatData.TerrainAdaptationStat*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*ShotFactor*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*BlockFactor*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*AccuracyFactor*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*DodgeFactor*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*AttackPowerFactor*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
