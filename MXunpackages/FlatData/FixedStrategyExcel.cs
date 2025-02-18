// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct FixedStrategyExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static FixedStrategyExcel GetRootAsFixedStrategyExcel(ByteBuffer _bb) { return GetRootAsFixedStrategyExcel(_bb, new FixedStrategyExcel()); }
  public static FixedStrategyExcel GetRootAsFixedStrategyExcel(ByteBuffer _bb, FixedStrategyExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FixedStrategyExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StageEnterEchelon01FixedEchelonId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StageEnterEchelon01Starttile { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StageEnterEchelon02FixedEchelonId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StageEnterEchelon02Starttile { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StageEnterEchelon03FixedEchelonId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StageEnterEchelon03Starttile { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StageEnterEchelon04FixedEchelonId { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StageEnterEchelon04Starttile { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<Plana.FlatData.FixedStrategyExcel> CreateFixedStrategyExcel(FlatBufferBuilder builder,
      long Id = 0,
      long StageEnterEchelon01FixedEchelonId = 0,
      long StageEnterEchelon01Starttile = 0,
      long StageEnterEchelon02FixedEchelonId = 0,
      long StageEnterEchelon02Starttile = 0,
      long StageEnterEchelon03FixedEchelonId = 0,
      long StageEnterEchelon03Starttile = 0,
      long StageEnterEchelon04FixedEchelonId = 0,
      long StageEnterEchelon04Starttile = 0) {
    builder.StartTable(9);
    FixedStrategyExcel.AddStageEnterEchelon04Starttile(builder, StageEnterEchelon04Starttile);
    FixedStrategyExcel.AddStageEnterEchelon04FixedEchelonId(builder, StageEnterEchelon04FixedEchelonId);
    FixedStrategyExcel.AddStageEnterEchelon03Starttile(builder, StageEnterEchelon03Starttile);
    FixedStrategyExcel.AddStageEnterEchelon03FixedEchelonId(builder, StageEnterEchelon03FixedEchelonId);
    FixedStrategyExcel.AddStageEnterEchelon02Starttile(builder, StageEnterEchelon02Starttile);
    FixedStrategyExcel.AddStageEnterEchelon02FixedEchelonId(builder, StageEnterEchelon02FixedEchelonId);
    FixedStrategyExcel.AddStageEnterEchelon01Starttile(builder, StageEnterEchelon01Starttile);
    FixedStrategyExcel.AddStageEnterEchelon01FixedEchelonId(builder, StageEnterEchelon01FixedEchelonId);
    FixedStrategyExcel.AddId(builder, Id);
    return FixedStrategyExcel.EndFixedStrategyExcel(builder);
  }

  public static void StartFixedStrategyExcel(FlatBufferBuilder builder) { builder.StartTable(9); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddStageEnterEchelon01FixedEchelonId(FlatBufferBuilder builder, long stageEnterEchelon01FixedEchelonId) { builder.AddLong(1, stageEnterEchelon01FixedEchelonId, 0); }
  public static void AddStageEnterEchelon01Starttile(FlatBufferBuilder builder, long stageEnterEchelon01Starttile) { builder.AddLong(2, stageEnterEchelon01Starttile, 0); }
  public static void AddStageEnterEchelon02FixedEchelonId(FlatBufferBuilder builder, long stageEnterEchelon02FixedEchelonId) { builder.AddLong(3, stageEnterEchelon02FixedEchelonId, 0); }
  public static void AddStageEnterEchelon02Starttile(FlatBufferBuilder builder, long stageEnterEchelon02Starttile) { builder.AddLong(4, stageEnterEchelon02Starttile, 0); }
  public static void AddStageEnterEchelon03FixedEchelonId(FlatBufferBuilder builder, long stageEnterEchelon03FixedEchelonId) { builder.AddLong(5, stageEnterEchelon03FixedEchelonId, 0); }
  public static void AddStageEnterEchelon03Starttile(FlatBufferBuilder builder, long stageEnterEchelon03Starttile) { builder.AddLong(6, stageEnterEchelon03Starttile, 0); }
  public static void AddStageEnterEchelon04FixedEchelonId(FlatBufferBuilder builder, long stageEnterEchelon04FixedEchelonId) { builder.AddLong(7, stageEnterEchelon04FixedEchelonId, 0); }
  public static void AddStageEnterEchelon04Starttile(FlatBufferBuilder builder, long stageEnterEchelon04Starttile) { builder.AddLong(8, stageEnterEchelon04Starttile, 0); }
  public static Offset<Plana.FlatData.FixedStrategyExcel> EndFixedStrategyExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.FixedStrategyExcel>(o);
  }
  public FixedStrategyExcelT UnPack() {
    var _o = new FixedStrategyExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FixedStrategyExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("FixedStrategy");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.StageEnterEchelon01FixedEchelonId = TableEncryptionService.Convert(this.StageEnterEchelon01FixedEchelonId, key);
    _o.StageEnterEchelon01Starttile = TableEncryptionService.Convert(this.StageEnterEchelon01Starttile, key);
    _o.StageEnterEchelon02FixedEchelonId = TableEncryptionService.Convert(this.StageEnterEchelon02FixedEchelonId, key);
    _o.StageEnterEchelon02Starttile = TableEncryptionService.Convert(this.StageEnterEchelon02Starttile, key);
    _o.StageEnterEchelon03FixedEchelonId = TableEncryptionService.Convert(this.StageEnterEchelon03FixedEchelonId, key);
    _o.StageEnterEchelon03Starttile = TableEncryptionService.Convert(this.StageEnterEchelon03Starttile, key);
    _o.StageEnterEchelon04FixedEchelonId = TableEncryptionService.Convert(this.StageEnterEchelon04FixedEchelonId, key);
    _o.StageEnterEchelon04Starttile = TableEncryptionService.Convert(this.StageEnterEchelon04Starttile, key);
  }
  public static Offset<Plana.FlatData.FixedStrategyExcel> Pack(FlatBufferBuilder builder, FixedStrategyExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.FixedStrategyExcel>);
    return CreateFixedStrategyExcel(
      builder,
      _o.Id,
      _o.StageEnterEchelon01FixedEchelonId,
      _o.StageEnterEchelon01Starttile,
      _o.StageEnterEchelon02FixedEchelonId,
      _o.StageEnterEchelon02Starttile,
      _o.StageEnterEchelon03FixedEchelonId,
      _o.StageEnterEchelon03Starttile,
      _o.StageEnterEchelon04FixedEchelonId,
      _o.StageEnterEchelon04Starttile);
  }
}

public class FixedStrategyExcelT
{
  public long Id { get; set; }
  public long StageEnterEchelon01FixedEchelonId { get; set; }
  public long StageEnterEchelon01Starttile { get; set; }
  public long StageEnterEchelon02FixedEchelonId { get; set; }
  public long StageEnterEchelon02Starttile { get; set; }
  public long StageEnterEchelon03FixedEchelonId { get; set; }
  public long StageEnterEchelon03Starttile { get; set; }
  public long StageEnterEchelon04FixedEchelonId { get; set; }
  public long StageEnterEchelon04Starttile { get; set; }

  public FixedStrategyExcelT() {
    this.Id = 0;
    this.StageEnterEchelon01FixedEchelonId = 0;
    this.StageEnterEchelon01Starttile = 0;
    this.StageEnterEchelon02FixedEchelonId = 0;
    this.StageEnterEchelon02Starttile = 0;
    this.StageEnterEchelon03FixedEchelonId = 0;
    this.StageEnterEchelon03Starttile = 0;
    this.StageEnterEchelon04FixedEchelonId = 0;
    this.StageEnterEchelon04Starttile = 0;
  }
}


static public class FixedStrategyExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*StageEnterEchelon01FixedEchelonId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*StageEnterEchelon01Starttile*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*StageEnterEchelon02FixedEchelonId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*StageEnterEchelon02Starttile*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*StageEnterEchelon03FixedEchelonId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*StageEnterEchelon03Starttile*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*StageEnterEchelon04FixedEchelonId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 20 /*StageEnterEchelon04Starttile*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
