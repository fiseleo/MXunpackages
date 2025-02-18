// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct MiniGameDefenseInfoExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static MiniGameDefenseInfoExcel GetRootAsMiniGameDefenseInfoExcel(ByteBuffer _bb) { return GetRootAsMiniGameDefenseInfoExcel(_bb, new MiniGameDefenseInfoExcel()); }
  public static MiniGameDefenseInfoExcel GetRootAsMiniGameDefenseInfoExcel(ByteBuffer _bb, MiniGameDefenseInfoExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MiniGameDefenseInfoExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.ParcelType DefenseBattleParcelType { get { int o = __p.__offset(6); return o != 0 ? (Plana.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ParcelType.None; } }
  public long DefenseBattleParcelId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DefenseBattleMultiplierMax { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool DisableRootMotion { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<Plana.FlatData.MiniGameDefenseInfoExcel> CreateMiniGameDefenseInfoExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      Plana.FlatData.ParcelType DefenseBattleParcelType = Plana.FlatData.ParcelType.None,
      long DefenseBattleParcelId = 0,
      long DefenseBattleMultiplierMax = 0,
      bool DisableRootMotion = false) {
    builder.StartTable(5);
    MiniGameDefenseInfoExcel.AddDefenseBattleMultiplierMax(builder, DefenseBattleMultiplierMax);
    MiniGameDefenseInfoExcel.AddDefenseBattleParcelId(builder, DefenseBattleParcelId);
    MiniGameDefenseInfoExcel.AddEventContentId(builder, EventContentId);
    MiniGameDefenseInfoExcel.AddDefenseBattleParcelType(builder, DefenseBattleParcelType);
    MiniGameDefenseInfoExcel.AddDisableRootMotion(builder, DisableRootMotion);
    return MiniGameDefenseInfoExcel.EndMiniGameDefenseInfoExcel(builder);
  }

  public static void StartMiniGameDefenseInfoExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(0, eventContentId, 0); }
  public static void AddDefenseBattleParcelType(FlatBufferBuilder builder, Plana.FlatData.ParcelType defenseBattleParcelType) { builder.AddInt(1, (int)defenseBattleParcelType, 0); }
  public static void AddDefenseBattleParcelId(FlatBufferBuilder builder, long defenseBattleParcelId) { builder.AddLong(2, defenseBattleParcelId, 0); }
  public static void AddDefenseBattleMultiplierMax(FlatBufferBuilder builder, long defenseBattleMultiplierMax) { builder.AddLong(3, defenseBattleMultiplierMax, 0); }
  public static void AddDisableRootMotion(FlatBufferBuilder builder, bool disableRootMotion) { builder.AddBool(4, disableRootMotion, false); }
  public static Offset<Plana.FlatData.MiniGameDefenseInfoExcel> EndMiniGameDefenseInfoExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.MiniGameDefenseInfoExcel>(o);
  }
  public MiniGameDefenseInfoExcelT UnPack() {
    var _o = new MiniGameDefenseInfoExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(MiniGameDefenseInfoExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("MiniGameDefenseInfo");
    _o.EventContentId = TableEncryptionService.Convert(this.EventContentId, key);
    _o.DefenseBattleParcelType = TableEncryptionService.Convert(this.DefenseBattleParcelType, key);
    _o.DefenseBattleParcelId = TableEncryptionService.Convert(this.DefenseBattleParcelId, key);
    _o.DefenseBattleMultiplierMax = TableEncryptionService.Convert(this.DefenseBattleMultiplierMax, key);
    _o.DisableRootMotion = TableEncryptionService.Convert(this.DisableRootMotion, key);
  }
  public static Offset<Plana.FlatData.MiniGameDefenseInfoExcel> Pack(FlatBufferBuilder builder, MiniGameDefenseInfoExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.MiniGameDefenseInfoExcel>);
    return CreateMiniGameDefenseInfoExcel(
      builder,
      _o.EventContentId,
      _o.DefenseBattleParcelType,
      _o.DefenseBattleParcelId,
      _o.DefenseBattleMultiplierMax,
      _o.DisableRootMotion);
  }
}

public class MiniGameDefenseInfoExcelT
{
  public long EventContentId { get; set; }
  public Plana.FlatData.ParcelType DefenseBattleParcelType { get; set; }
  public long DefenseBattleParcelId { get; set; }
  public long DefenseBattleMultiplierMax { get; set; }
  public bool DisableRootMotion { get; set; }

  public MiniGameDefenseInfoExcelT() {
    this.EventContentId = 0;
    this.DefenseBattleParcelType = Plana.FlatData.ParcelType.None;
    this.DefenseBattleParcelId = 0;
    this.DefenseBattleMultiplierMax = 0;
    this.DisableRootMotion = false;
  }
}


static public class MiniGameDefenseInfoExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*DefenseBattleParcelType*/, 4 /*Plana.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*DefenseBattleParcelId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*DefenseBattleMultiplierMax*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*DisableRootMotion*/, 1 /*bool*/, 1, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
