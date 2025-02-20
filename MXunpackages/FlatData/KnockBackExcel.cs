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

public struct KnockBackExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static KnockBackExcel GetRootAsKnockBackExcel(ByteBuffer _bb) { return GetRootAsKnockBackExcel(_bb, new KnockBackExcel()); }
  public static KnockBackExcel GetRootAsKnockBackExcel(ByteBuffer _bb, KnockBackExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public KnockBackExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Index { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public float Dist { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Speed { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<Plana.FlatData.KnockBackExcel> CreateKnockBackExcel(FlatBufferBuilder builder,
      long Index = 0,
      float Dist = 0.0f,
      float Speed = 0.0f) {
    builder.StartTable(3);
    KnockBackExcel.AddIndex(builder, Index);
    KnockBackExcel.AddSpeed(builder, Speed);
    KnockBackExcel.AddDist(builder, Dist);
    return KnockBackExcel.EndKnockBackExcel(builder);
  }

  public static void StartKnockBackExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddIndex(FlatBufferBuilder builder, long index) { builder.AddLong(0, index, 0); }
  public static void AddDist(FlatBufferBuilder builder, float dist) { builder.AddFloat(1, dist, 0.0f); }
  public static void AddSpeed(FlatBufferBuilder builder, float speed) { builder.AddFloat(2, speed, 0.0f); }
  public static Offset<Plana.FlatData.KnockBackExcel> EndKnockBackExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.KnockBackExcel>(o);
  }
  public KnockBackExcelT UnPack() {
    var _o = new KnockBackExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(KnockBackExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("KnockBack");
    _o.Index = TableEncryptionService.Convert(this.Index, key);
    _o.Dist = TableEncryptionService.Convert(this.Dist, key);
    _o.Speed = TableEncryptionService.Convert(this.Speed, key);
  }
  public static Offset<Plana.FlatData.KnockBackExcel> Pack(FlatBufferBuilder builder, KnockBackExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.KnockBackExcel>);
    return CreateKnockBackExcel(
      builder,
      _o.Index,
      _o.Dist,
      _o.Speed);
  }
}

public class KnockBackExcelT
{
  public long Index { get; set; }
  public float Dist { get; set; }
  public float Speed { get; set; }

  public KnockBackExcelT() {
    this.Index = 0;
    this.Dist = 0.0f;
    this.Speed = 0.0f;
  }
}


static public class KnockBackExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Index*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*Dist*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*Speed*/, 4 /*float*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
