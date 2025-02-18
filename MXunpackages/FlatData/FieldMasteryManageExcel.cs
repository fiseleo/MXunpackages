// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct FieldMasteryManageExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static FieldMasteryManageExcel GetRootAsFieldMasteryManageExcel(ByteBuffer _bb) { return GetRootAsFieldMasteryManageExcel(_bb, new FieldMasteryManageExcel()); }
  public static FieldMasteryManageExcel GetRootAsFieldMasteryManageExcel(ByteBuffer _bb, FieldMasteryManageExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FieldMasteryManageExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long FieldSeason { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public uint LocalizeEtc { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string ImagePath { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetImagePathBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetImagePathBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetImagePathArray() { return __p.__vector_as_array<byte>(8); }
  public long LevelId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<Plana.FlatData.FieldMasteryManageExcel> CreateFieldMasteryManageExcel(FlatBufferBuilder builder,
      long FieldSeason = 0,
      uint LocalizeEtc = 0,
      StringOffset ImagePathOffset = default(StringOffset),
      long LevelId = 0) {
    builder.StartTable(4);
    FieldMasteryManageExcel.AddLevelId(builder, LevelId);
    FieldMasteryManageExcel.AddFieldSeason(builder, FieldSeason);
    FieldMasteryManageExcel.AddImagePath(builder, ImagePathOffset);
    FieldMasteryManageExcel.AddLocalizeEtc(builder, LocalizeEtc);
    return FieldMasteryManageExcel.EndFieldMasteryManageExcel(builder);
  }

  public static void StartFieldMasteryManageExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddFieldSeason(FlatBufferBuilder builder, long fieldSeason) { builder.AddLong(0, fieldSeason, 0); }
  public static void AddLocalizeEtc(FlatBufferBuilder builder, uint localizeEtc) { builder.AddUint(1, localizeEtc, 0); }
  public static void AddImagePath(FlatBufferBuilder builder, StringOffset imagePathOffset) { builder.AddOffset(2, imagePathOffset.Value, 0); }
  public static void AddLevelId(FlatBufferBuilder builder, long levelId) { builder.AddLong(3, levelId, 0); }
  public static Offset<Plana.FlatData.FieldMasteryManageExcel> EndFieldMasteryManageExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.FieldMasteryManageExcel>(o);
  }
  public FieldMasteryManageExcelT UnPack() {
    var _o = new FieldMasteryManageExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FieldMasteryManageExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("FieldMasteryManage");
    _o.FieldSeason = TableEncryptionService.Convert(this.FieldSeason, key);
    _o.LocalizeEtc = TableEncryptionService.Convert(this.LocalizeEtc, key);
    _o.ImagePath = TableEncryptionService.Convert(this.ImagePath, key);
    _o.LevelId = TableEncryptionService.Convert(this.LevelId, key);
  }
  public static Offset<Plana.FlatData.FieldMasteryManageExcel> Pack(FlatBufferBuilder builder, FieldMasteryManageExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.FieldMasteryManageExcel>);
    var _ImagePath = _o.ImagePath == null ? default(StringOffset) : builder.CreateString(_o.ImagePath);
    return CreateFieldMasteryManageExcel(
      builder,
      _o.FieldSeason,
      _o.LocalizeEtc,
      _ImagePath,
      _o.LevelId);
  }
}

public class FieldMasteryManageExcelT
{
  public long FieldSeason { get; set; }
  public uint LocalizeEtc { get; set; }
  public string ImagePath { get; set; }
  public long LevelId { get; set; }

  public FieldMasteryManageExcelT() {
    this.FieldSeason = 0;
    this.LocalizeEtc = 0;
    this.ImagePath = null;
    this.LevelId = 0;
  }
}


static public class FieldMasteryManageExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*FieldSeason*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*LocalizeEtc*/, 4 /*uint*/, 4, false)
      && verifier.VerifyString(tablePos, 8 /*ImagePath*/, false)
      && verifier.VerifyField(tablePos, 10 /*LevelId*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
