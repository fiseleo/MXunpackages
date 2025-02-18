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

public struct Motion : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static Motion GetRootAsMotion(ByteBuffer _bb) { return GetRootAsMotion(_bb, new Motion()); }
  public static Motion GetRootAsMotion(ByteBuffer _bb, Motion obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Motion __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(4); }
  public Plana.FlatData.Position? Positions(int j) { int o = __p.__offset(6); return o != 0 ? (Plana.FlatData.Position?)(new Plana.FlatData.Position()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int PositionsLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<Plana.FlatData.Motion> CreateMotion(FlatBufferBuilder builder,
      StringOffset NameOffset = default(StringOffset),
      VectorOffset PositionsOffset = default(VectorOffset)) {
    builder.StartTable(2);
    Motion.AddPositions(builder, PositionsOffset);
    Motion.AddName(builder, NameOffset);
    return Motion.EndMotion(builder);
  }

  public static void StartMotion(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(0, nameOffset.Value, 0); }
  public static void AddPositions(FlatBufferBuilder builder, VectorOffset positionsOffset) { builder.AddOffset(1, positionsOffset.Value, 0); }
  public static VectorOffset CreatePositionsVector(FlatBufferBuilder builder, Offset<Plana.FlatData.Position>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreatePositionsVectorBlock(FlatBufferBuilder builder, Offset<Plana.FlatData.Position>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePositionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Plana.FlatData.Position>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePositionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<Plana.FlatData.Position>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPositionsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Plana.FlatData.Motion> EndMotion(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.Motion>(o);
  }
  public MotionT UnPack() {
    var _o = new MotionT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(MotionT _o) {
        byte[] key = TableEncryptionService.CreateKey("MotionT");
    _o.Name = TableEncryptionService.Convert(this.Name, key);
    _o.Positions = new List<Plana.FlatData.PositionT>();
    for (var _j = 0; _j < this.PositionsLength; ++_j) {_o.Positions.Add(this.Positions(_j).HasValue ? this.Positions(_j).Value.UnPack() : null);}
  }
  public static Offset<Plana.FlatData.Motion> Pack(FlatBufferBuilder builder, MotionT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.Motion>);
    var _Name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _Positions = default(VectorOffset);
    if (_o.Positions != null) {
      var __Positions = new Offset<Plana.FlatData.Position>[_o.Positions.Count];
      for (var _j = 0; _j < __Positions.Length; ++_j) { __Positions[_j] = Plana.FlatData.Position.Pack(builder, _o.Positions[_j]); }
      _Positions = CreatePositionsVector(builder, __Positions);
    }
    return CreateMotion(
      builder,
      _Name,
      _Positions);
  }
}

public class MotionT
{
  public string Name { get; set; }
  public List<Plana.FlatData.PositionT> Positions { get; set; }

  public MotionT() {
    this.Name = null;
    this.Positions = null;
  }
}


static public class MotionVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyString(tablePos, 4 /*Name*/, false)
      && verifier.VerifyVectorOfTables(tablePos, 6 /*Positions*/, Plana.FlatData.PositionVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
