// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct AnimatorData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static AnimatorData GetRootAsAnimatorData(ByteBuffer _bb) { return GetRootAsAnimatorData(_bb, new AnimatorData()); }
  public static AnimatorData GetRootAsAnimatorData(ByteBuffer _bb, AnimatorData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AnimatorData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string DefaultStateName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDefaultStateNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetDefaultStateNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetDefaultStateNameArray() { return __p.__vector_as_array<byte>(4); }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }
  public Plana.FlatData.AniStateData? DataList(int j) { int o = __p.__offset(8); return o != 0 ? (Plana.FlatData.AniStateData?)(new Plana.FlatData.AniStateData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<Plana.FlatData.AnimatorData> CreateAnimatorData(FlatBufferBuilder builder,
      StringOffset DefaultStateNameOffset = default(StringOffset),
      StringOffset NameOffset = default(StringOffset),
      VectorOffset DataListOffset = default(VectorOffset)) {
    builder.StartTable(3);
    AnimatorData.AddDataList(builder, DataListOffset);
    AnimatorData.AddName(builder, NameOffset);
    AnimatorData.AddDefaultStateName(builder, DefaultStateNameOffset);
    return AnimatorData.EndAnimatorData(builder);
  }

  public static void StartAnimatorData(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddDefaultStateName(FlatBufferBuilder builder, StringOffset defaultStateNameOffset) { builder.AddOffset(0, defaultStateNameOffset.Value, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset dataListOffset) { builder.AddOffset(2, dataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<Plana.FlatData.AniStateData>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<Plana.FlatData.AniStateData>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Plana.FlatData.AniStateData>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<Plana.FlatData.AniStateData>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Plana.FlatData.AnimatorData> EndAnimatorData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.AnimatorData>(o);
  }
  public AnimatorDataT UnPack() {
    var _o = new AnimatorDataT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(AnimatorDataT _o) {
		byte[] key = { 0 };
    _o.DefaultStateName = TableEncryptionService.Convert(this.DefaultStateName, key);
    _o.Name = TableEncryptionService.Convert(this.Name, key);
    _o.DataList = new List<Plana.FlatData.AniStateDataT>();
    for (var _j = 0; _j < this.DataListLength; ++_j) {_o.DataList.Add(this.DataList(_j).HasValue ? this.DataList(_j).Value.UnPack() : null);}
  }
  public static Offset<Plana.FlatData.AnimatorData> Pack(FlatBufferBuilder builder, AnimatorDataT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.AnimatorData>);
    var _DefaultStateName = _o.DefaultStateName == null ? default(StringOffset) : builder.CreateString(_o.DefaultStateName);
    var _Name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _DataList = default(VectorOffset);
    if (_o.DataList != null) {
      var __DataList = new Offset<Plana.FlatData.AniStateData>[_o.DataList.Count];
      for (var _j = 0; _j < __DataList.Length; ++_j) { __DataList[_j] = Plana.FlatData.AniStateData.Pack(builder, _o.DataList[_j]); }
      _DataList = CreateDataListVector(builder, __DataList);
    }
    return CreateAnimatorData(
      builder,
      _DefaultStateName,
      _Name,
      _DataList);
  }
}

public class AnimatorDataT
{
  public string DefaultStateName { get; set; }
  public string Name { get; set; }
  public List<Plana.FlatData.AniStateDataT> DataList { get; set; }

  public AnimatorDataT() {
    this.DefaultStateName = null;
    this.Name = null;
    this.DataList = null;
  }
}


static public class AnimatorDataVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyString(tablePos, 4 /*DefaultStateName*/, false)
      && verifier.VerifyString(tablePos, 6 /*Name*/, false)
      && verifier.VerifyVectorOfTables(tablePos, 8 /*DataList*/, Plana.FlatData.AniStateDataVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
