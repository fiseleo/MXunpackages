// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct GroundNodeLayerFlat : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static GroundNodeLayerFlat GetRootAsGroundNodeLayerFlat(ByteBuffer _bb) { return GetRootAsGroundNodeLayerFlat(_bb, new GroundNodeLayerFlat()); }
  public static GroundNodeLayerFlat GetRootAsGroundNodeLayerFlat(ByteBuffer _bb, GroundNodeLayerFlat obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GroundNodeLayerFlat __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }


  public static void StartGroundNodeLayerFlat(FlatBufferBuilder builder) { builder.StartTable(0); }
  public static Offset<Plana.FlatData.GroundNodeLayerFlat> EndGroundNodeLayerFlat(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.GroundNodeLayerFlat>(o);
  }
  public GroundNodeLayerFlatT UnPack() {
    var _o = new GroundNodeLayerFlatT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(GroundNodeLayerFlatT _o) {
		byte[] key = { 0 };
  }
  public static Offset<Plana.FlatData.GroundNodeLayerFlat> Pack(FlatBufferBuilder builder, GroundNodeLayerFlatT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.GroundNodeLayerFlat>);
    StartGroundNodeLayerFlat(builder);
    return EndGroundNodeLayerFlat(builder);
  }
}

public class GroundNodeLayerFlatT
{

  public GroundNodeLayerFlatT() {
  }
}


static public class GroundNodeLayerFlatVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
