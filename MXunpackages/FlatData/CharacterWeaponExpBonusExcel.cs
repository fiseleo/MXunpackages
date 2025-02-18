// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct CharacterWeaponExpBonusExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static CharacterWeaponExpBonusExcel GetRootAsCharacterWeaponExpBonusExcel(ByteBuffer _bb) { return GetRootAsCharacterWeaponExpBonusExcel(_bb, new CharacterWeaponExpBonusExcel()); }
  public static CharacterWeaponExpBonusExcel GetRootAsCharacterWeaponExpBonusExcel(ByteBuffer _bb, CharacterWeaponExpBonusExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterWeaponExpBonusExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Plana.FlatData.WeaponType WeaponType { get { int o = __p.__offset(4); return o != 0 ? (Plana.FlatData.WeaponType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.WeaponType.None; } }
  public int WeaponExpGrowthA { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int WeaponExpGrowthB { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int WeaponExpGrowthC { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int WeaponExpGrowthZ { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<Plana.FlatData.CharacterWeaponExpBonusExcel> CreateCharacterWeaponExpBonusExcel(FlatBufferBuilder builder,
      Plana.FlatData.WeaponType WeaponType = Plana.FlatData.WeaponType.None,
      int WeaponExpGrowthA = 0,
      int WeaponExpGrowthB = 0,
      int WeaponExpGrowthC = 0,
      int WeaponExpGrowthZ = 0) {
    builder.StartTable(5);
    CharacterWeaponExpBonusExcel.AddWeaponExpGrowthZ(builder, WeaponExpGrowthZ);
    CharacterWeaponExpBonusExcel.AddWeaponExpGrowthC(builder, WeaponExpGrowthC);
    CharacterWeaponExpBonusExcel.AddWeaponExpGrowthB(builder, WeaponExpGrowthB);
    CharacterWeaponExpBonusExcel.AddWeaponExpGrowthA(builder, WeaponExpGrowthA);
    CharacterWeaponExpBonusExcel.AddWeaponType(builder, WeaponType);
    return CharacterWeaponExpBonusExcel.EndCharacterWeaponExpBonusExcel(builder);
  }

  public static void StartCharacterWeaponExpBonusExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddWeaponType(FlatBufferBuilder builder, Plana.FlatData.WeaponType weaponType) { builder.AddInt(0, (int)weaponType, 0); }
  public static void AddWeaponExpGrowthA(FlatBufferBuilder builder, int weaponExpGrowthA) { builder.AddInt(1, weaponExpGrowthA, 0); }
  public static void AddWeaponExpGrowthB(FlatBufferBuilder builder, int weaponExpGrowthB) { builder.AddInt(2, weaponExpGrowthB, 0); }
  public static void AddWeaponExpGrowthC(FlatBufferBuilder builder, int weaponExpGrowthC) { builder.AddInt(3, weaponExpGrowthC, 0); }
  public static void AddWeaponExpGrowthZ(FlatBufferBuilder builder, int weaponExpGrowthZ) { builder.AddInt(4, weaponExpGrowthZ, 0); }
  public static Offset<Plana.FlatData.CharacterWeaponExpBonusExcel> EndCharacterWeaponExpBonusExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.CharacterWeaponExpBonusExcel>(o);
  }
  public CharacterWeaponExpBonusExcelT UnPack() {
    var _o = new CharacterWeaponExpBonusExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CharacterWeaponExpBonusExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("CharacterWeaponExpBonus");
    _o.WeaponType = TableEncryptionService.Convert(this.WeaponType, key);
    _o.WeaponExpGrowthA = TableEncryptionService.Convert(this.WeaponExpGrowthA, key);
    _o.WeaponExpGrowthB = TableEncryptionService.Convert(this.WeaponExpGrowthB, key);
    _o.WeaponExpGrowthC = TableEncryptionService.Convert(this.WeaponExpGrowthC, key);
    _o.WeaponExpGrowthZ = TableEncryptionService.Convert(this.WeaponExpGrowthZ, key);
  }
  public static Offset<Plana.FlatData.CharacterWeaponExpBonusExcel> Pack(FlatBufferBuilder builder, CharacterWeaponExpBonusExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.CharacterWeaponExpBonusExcel>);
    return CreateCharacterWeaponExpBonusExcel(
      builder,
      _o.WeaponType,
      _o.WeaponExpGrowthA,
      _o.WeaponExpGrowthB,
      _o.WeaponExpGrowthC,
      _o.WeaponExpGrowthZ);
  }
}

public class CharacterWeaponExpBonusExcelT
{
  public Plana.FlatData.WeaponType WeaponType { get; set; }
  public int WeaponExpGrowthA { get; set; }
  public int WeaponExpGrowthB { get; set; }
  public int WeaponExpGrowthC { get; set; }
  public int WeaponExpGrowthZ { get; set; }

  public CharacterWeaponExpBonusExcelT() {
    this.WeaponType = Plana.FlatData.WeaponType.None;
    this.WeaponExpGrowthA = 0;
    this.WeaponExpGrowthB = 0;
    this.WeaponExpGrowthC = 0;
    this.WeaponExpGrowthZ = 0;
  }
}


static public class CharacterWeaponExpBonusExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*WeaponType*/, 4 /*Plana.FlatData.WeaponType*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*WeaponExpGrowthA*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*WeaponExpGrowthB*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*WeaponExpGrowthC*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*WeaponExpGrowthZ*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
