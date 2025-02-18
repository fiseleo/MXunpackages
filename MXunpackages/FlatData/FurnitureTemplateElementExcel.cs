// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct FurnitureTemplateElementExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static FurnitureTemplateElementExcel GetRootAsFurnitureTemplateElementExcel(ByteBuffer _bb) { return GetRootAsFurnitureTemplateElementExcel(_bb, new FurnitureTemplateElementExcel()); }
  public static FurnitureTemplateElementExcel GetRootAsFurnitureTemplateElementExcel(ByteBuffer _bb, FurnitureTemplateElementExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FurnitureTemplateElementExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long FurnitureTemplateId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long FurnitureId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.FurnitureLocation Location { get { int o = __p.__offset(8); return o != 0 ? (Plana.FlatData.FurnitureLocation)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.FurnitureLocation.None; } }
  public float PositionX { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float PositionY { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Rotation { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public long Order { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<Plana.FlatData.FurnitureTemplateElementExcel> CreateFurnitureTemplateElementExcel(FlatBufferBuilder builder,
      long FurnitureTemplateId = 0,
      long FurnitureId = 0,
      Plana.FlatData.FurnitureLocation Location = Plana.FlatData.FurnitureLocation.None,
      float PositionX = 0.0f,
      float PositionY = 0.0f,
      float Rotation = 0.0f,
      long Order = 0) {
    builder.StartTable(7);
    FurnitureTemplateElementExcel.AddOrder(builder, Order);
    FurnitureTemplateElementExcel.AddFurnitureId(builder, FurnitureId);
    FurnitureTemplateElementExcel.AddFurnitureTemplateId(builder, FurnitureTemplateId);
    FurnitureTemplateElementExcel.AddRotation(builder, Rotation);
    FurnitureTemplateElementExcel.AddPositionY(builder, PositionY);
    FurnitureTemplateElementExcel.AddPositionX(builder, PositionX);
    FurnitureTemplateElementExcel.AddLocation(builder, Location);
    return FurnitureTemplateElementExcel.EndFurnitureTemplateElementExcel(builder);
  }

  public static void StartFurnitureTemplateElementExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddFurnitureTemplateId(FlatBufferBuilder builder, long furnitureTemplateId) { builder.AddLong(0, furnitureTemplateId, 0); }
  public static void AddFurnitureId(FlatBufferBuilder builder, long furnitureId) { builder.AddLong(1, furnitureId, 0); }
  public static void AddLocation(FlatBufferBuilder builder, Plana.FlatData.FurnitureLocation location) { builder.AddInt(2, (int)location, 0); }
  public static void AddPositionX(FlatBufferBuilder builder, float positionX) { builder.AddFloat(3, positionX, 0.0f); }
  public static void AddPositionY(FlatBufferBuilder builder, float positionY) { builder.AddFloat(4, positionY, 0.0f); }
  public static void AddRotation(FlatBufferBuilder builder, float rotation) { builder.AddFloat(5, rotation, 0.0f); }
  public static void AddOrder(FlatBufferBuilder builder, long order) { builder.AddLong(6, order, 0); }
  public static Offset<Plana.FlatData.FurnitureTemplateElementExcel> EndFurnitureTemplateElementExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.FurnitureTemplateElementExcel>(o);
  }
  public FurnitureTemplateElementExcelT UnPack() {
    var _o = new FurnitureTemplateElementExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FurnitureTemplateElementExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("FurnitureTemplateElement");
    _o.FurnitureTemplateId = TableEncryptionService.Convert(this.FurnitureTemplateId, key);
    _o.FurnitureId = TableEncryptionService.Convert(this.FurnitureId, key);
    _o.Location = TableEncryptionService.Convert(this.Location, key);
    _o.PositionX = TableEncryptionService.Convert(this.PositionX, key);
    _o.PositionY = TableEncryptionService.Convert(this.PositionY, key);
    _o.Rotation = TableEncryptionService.Convert(this.Rotation, key);
    _o.Order = TableEncryptionService.Convert(this.Order, key);
  }
  public static Offset<Plana.FlatData.FurnitureTemplateElementExcel> Pack(FlatBufferBuilder builder, FurnitureTemplateElementExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.FurnitureTemplateElementExcel>);
    return CreateFurnitureTemplateElementExcel(
      builder,
      _o.FurnitureTemplateId,
      _o.FurnitureId,
      _o.Location,
      _o.PositionX,
      _o.PositionY,
      _o.Rotation,
      _o.Order);
  }
}

public class FurnitureTemplateElementExcelT
{
  public long FurnitureTemplateId { get; set; }
  public long FurnitureId { get; set; }
  public Plana.FlatData.FurnitureLocation Location { get; set; }
  public float PositionX { get; set; }
  public float PositionY { get; set; }
  public float Rotation { get; set; }
  public long Order { get; set; }

  public FurnitureTemplateElementExcelT() {
    this.FurnitureTemplateId = 0;
    this.FurnitureId = 0;
    this.Location = Plana.FlatData.FurnitureLocation.None;
    this.PositionX = 0.0f;
    this.PositionY = 0.0f;
    this.Rotation = 0.0f;
    this.Order = 0;
  }
}


static public class FurnitureTemplateElementExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*FurnitureTemplateId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*FurnitureId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*Location*/, 4 /*Plana.FlatData.FurnitureLocation*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*PositionX*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*PositionY*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*Rotation*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*Order*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
