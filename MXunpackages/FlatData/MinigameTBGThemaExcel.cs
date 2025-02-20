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

public struct MinigameTBGThemaExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static MinigameTBGThemaExcel GetRootAsMinigameTBGThemaExcel(ByteBuffer _bb) { return GetRootAsMinigameTBGThemaExcel(_bb, new MinigameTBGThemaExcel()); }
  public static MinigameTBGThemaExcel GetRootAsMinigameTBGThemaExcel(ByteBuffer _bb, MinigameTBGThemaExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MinigameTBGThemaExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long UniqueId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int ThemaIndex { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public Plana.FlatData.TBGThemaType ThemaType { get { int o = __p.__offset(10); return o != 0 ? (Plana.FlatData.TBGThemaType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.TBGThemaType.None; } }
  public string ThemaMap { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetThemaMapBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetThemaMapBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetThemaMapArray() { return __p.__vector_as_array<byte>(12); }
  public string ThemaMapBG { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetThemaMapBGBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetThemaMapBGBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetThemaMapBGArray() { return __p.__vector_as_array<byte>(14); }
  public Plana.FlatData.TBGPortalCondition PortalCondition(int j) { int o = __p.__offset(16); return o != 0 ? (Plana.FlatData.TBGPortalCondition)__p.bb.GetInt(__p.__vector(o) + j * 4) : (Plana.FlatData.TBGPortalCondition)0; }
  public int PortalConditionLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<Plana.FlatData.TBGPortalCondition> GetPortalConditionBytes() { return __p.__vector_as_span<Plana.FlatData.TBGPortalCondition>(16, 4); }
#else
  public ArraySegment<byte>? GetPortalConditionBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public Plana.FlatData.TBGPortalCondition[] GetPortalConditionArray() { int o = __p.__offset(16); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); Plana.FlatData.TBGPortalCondition[] a = new Plana.FlatData.TBGPortalCondition[l]; for (int i = 0; i < l; i++) { a[i] = (Plana.FlatData.TBGPortalCondition)__p.bb.GetInt(p + i * 4); } return a; }
  public string PortalConditionParameter(int j) { int o = __p.__offset(18); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int PortalConditionParameterLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string ThemaNameLocalize { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetThemaNameLocalizeBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetThemaNameLocalizeBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetThemaNameLocalizeArray() { return __p.__vector_as_array<byte>(20); }
  public string ThemaLoadingImage { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetThemaLoadingImageBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetThemaLoadingImageBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetThemaLoadingImageArray() { return __p.__vector_as_array<byte>(22); }
  public string ThemaPlayerPrefab { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetThemaPlayerPrefabBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetThemaPlayerPrefabBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetThemaPlayerPrefabArray() { return __p.__vector_as_array<byte>(24); }
  public long ThemaLeaderId { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string ThemaGoalLocalize { get { int o = __p.__offset(28); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetThemaGoalLocalizeBytes() { return __p.__vector_as_span<byte>(28, 1); }
#else
  public ArraySegment<byte>? GetThemaGoalLocalizeBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public byte[] GetThemaGoalLocalizeArray() { return __p.__vector_as_array<byte>(28); }
  public long InstantClearCostAmount { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<Plana.FlatData.MinigameTBGThemaExcel> CreateMinigameTBGThemaExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      long UniqueId = 0,
      int ThemaIndex = 0,
      Plana.FlatData.TBGThemaType ThemaType = Plana.FlatData.TBGThemaType.None,
      StringOffset ThemaMapOffset = default(StringOffset),
      StringOffset ThemaMapBGOffset = default(StringOffset),
      VectorOffset PortalConditionOffset = default(VectorOffset),
      VectorOffset PortalConditionParameterOffset = default(VectorOffset),
      StringOffset ThemaNameLocalizeOffset = default(StringOffset),
      StringOffset ThemaLoadingImageOffset = default(StringOffset),
      StringOffset ThemaPlayerPrefabOffset = default(StringOffset),
      long ThemaLeaderId = 0,
      StringOffset ThemaGoalLocalizeOffset = default(StringOffset),
      long InstantClearCostAmount = 0) {
    builder.StartTable(14);
    MinigameTBGThemaExcel.AddInstantClearCostAmount(builder, InstantClearCostAmount);
    MinigameTBGThemaExcel.AddThemaLeaderId(builder, ThemaLeaderId);
    MinigameTBGThemaExcel.AddUniqueId(builder, UniqueId);
    MinigameTBGThemaExcel.AddEventContentId(builder, EventContentId);
    MinigameTBGThemaExcel.AddThemaGoalLocalize(builder, ThemaGoalLocalizeOffset);
    MinigameTBGThemaExcel.AddThemaPlayerPrefab(builder, ThemaPlayerPrefabOffset);
    MinigameTBGThemaExcel.AddThemaLoadingImage(builder, ThemaLoadingImageOffset);
    MinigameTBGThemaExcel.AddThemaNameLocalize(builder, ThemaNameLocalizeOffset);
    MinigameTBGThemaExcel.AddPortalConditionParameter(builder, PortalConditionParameterOffset);
    MinigameTBGThemaExcel.AddPortalCondition(builder, PortalConditionOffset);
    MinigameTBGThemaExcel.AddThemaMapBG(builder, ThemaMapBGOffset);
    MinigameTBGThemaExcel.AddThemaMap(builder, ThemaMapOffset);
    MinigameTBGThemaExcel.AddThemaType(builder, ThemaType);
    MinigameTBGThemaExcel.AddThemaIndex(builder, ThemaIndex);
    return MinigameTBGThemaExcel.EndMinigameTBGThemaExcel(builder);
  }

  public static void StartMinigameTBGThemaExcel(FlatBufferBuilder builder) { builder.StartTable(14); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(0, eventContentId, 0); }
  public static void AddUniqueId(FlatBufferBuilder builder, long uniqueId) { builder.AddLong(1, uniqueId, 0); }
  public static void AddThemaIndex(FlatBufferBuilder builder, int themaIndex) { builder.AddInt(2, themaIndex, 0); }
  public static void AddThemaType(FlatBufferBuilder builder, Plana.FlatData.TBGThemaType themaType) { builder.AddInt(3, (int)themaType, 0); }
  public static void AddThemaMap(FlatBufferBuilder builder, StringOffset themaMapOffset) { builder.AddOffset(4, themaMapOffset.Value, 0); }
  public static void AddThemaMapBG(FlatBufferBuilder builder, StringOffset themaMapBGOffset) { builder.AddOffset(5, themaMapBGOffset.Value, 0); }
  public static void AddPortalCondition(FlatBufferBuilder builder, VectorOffset portalConditionOffset) { builder.AddOffset(6, portalConditionOffset.Value, 0); }
  public static VectorOffset CreatePortalConditionVector(FlatBufferBuilder builder, Plana.FlatData.TBGPortalCondition[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreatePortalConditionVectorBlock(FlatBufferBuilder builder, Plana.FlatData.TBGPortalCondition[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePortalConditionVectorBlock(FlatBufferBuilder builder, ArraySegment<Plana.FlatData.TBGPortalCondition> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePortalConditionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Plana.FlatData.TBGPortalCondition>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPortalConditionVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPortalConditionParameter(FlatBufferBuilder builder, VectorOffset portalConditionParameterOffset) { builder.AddOffset(7, portalConditionParameterOffset.Value, 0); }
  public static VectorOffset CreatePortalConditionParameterVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreatePortalConditionParameterVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePortalConditionParameterVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePortalConditionParameterVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPortalConditionParameterVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddThemaNameLocalize(FlatBufferBuilder builder, StringOffset themaNameLocalizeOffset) { builder.AddOffset(8, themaNameLocalizeOffset.Value, 0); }
  public static void AddThemaLoadingImage(FlatBufferBuilder builder, StringOffset themaLoadingImageOffset) { builder.AddOffset(9, themaLoadingImageOffset.Value, 0); }
  public static void AddThemaPlayerPrefab(FlatBufferBuilder builder, StringOffset themaPlayerPrefabOffset) { builder.AddOffset(10, themaPlayerPrefabOffset.Value, 0); }
  public static void AddThemaLeaderId(FlatBufferBuilder builder, long themaLeaderId) { builder.AddLong(11, themaLeaderId, 0); }
  public static void AddThemaGoalLocalize(FlatBufferBuilder builder, StringOffset themaGoalLocalizeOffset) { builder.AddOffset(12, themaGoalLocalizeOffset.Value, 0); }
  public static void AddInstantClearCostAmount(FlatBufferBuilder builder, long instantClearCostAmount) { builder.AddLong(13, instantClearCostAmount, 0); }
  public static Offset<Plana.FlatData.MinigameTBGThemaExcel> EndMinigameTBGThemaExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.MinigameTBGThemaExcel>(o);
  }
  public MinigameTBGThemaExcelT UnPack() {
    var _o = new MinigameTBGThemaExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(MinigameTBGThemaExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("MinigameTBGThema");
    _o.EventContentId = TableEncryptionService.Convert(this.EventContentId, key);
    _o.UniqueId = TableEncryptionService.Convert(this.UniqueId, key);
    _o.ThemaIndex = TableEncryptionService.Convert(this.ThemaIndex, key);
    _o.ThemaType = TableEncryptionService.Convert(this.ThemaType, key);
    _o.ThemaMap = TableEncryptionService.Convert(this.ThemaMap, key);
    _o.ThemaMapBG = TableEncryptionService.Convert(this.ThemaMapBG, key);
    _o.PortalCondition = new List<Plana.FlatData.TBGPortalCondition>();
    for (var _j = 0; _j < this.PortalConditionLength; ++_j) {_o.PortalCondition.Add(TableEncryptionService.Convert(this.PortalCondition(_j), key));}
    _o.PortalConditionParameter = new List<string>();
    for (var _j = 0; _j < this.PortalConditionParameterLength; ++_j) {_o.PortalConditionParameter.Add(TableEncryptionService.Convert(this.PortalConditionParameter(_j), key));}
    _o.ThemaNameLocalize = TableEncryptionService.Convert(this.ThemaNameLocalize, key);
    _o.ThemaLoadingImage = TableEncryptionService.Convert(this.ThemaLoadingImage, key);
    _o.ThemaPlayerPrefab = TableEncryptionService.Convert(this.ThemaPlayerPrefab, key);
    _o.ThemaLeaderId = TableEncryptionService.Convert(this.ThemaLeaderId, key);
    _o.ThemaGoalLocalize = TableEncryptionService.Convert(this.ThemaGoalLocalize, key);
    _o.InstantClearCostAmount = TableEncryptionService.Convert(this.InstantClearCostAmount, key);
  }
  public static Offset<Plana.FlatData.MinigameTBGThemaExcel> Pack(FlatBufferBuilder builder, MinigameTBGThemaExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.MinigameTBGThemaExcel>);
    var _ThemaMap = _o.ThemaMap == null ? default(StringOffset) : builder.CreateString(_o.ThemaMap);
    var _ThemaMapBG = _o.ThemaMapBG == null ? default(StringOffset) : builder.CreateString(_o.ThemaMapBG);
    var _PortalCondition = default(VectorOffset);
    if (_o.PortalCondition != null) {
      var __PortalCondition = _o.PortalCondition.ToArray();
      _PortalCondition = CreatePortalConditionVector(builder, __PortalCondition);
    }
    var _PortalConditionParameter = default(VectorOffset);
    if (_o.PortalConditionParameter != null) {
      var __PortalConditionParameter = new StringOffset[_o.PortalConditionParameter.Count];
      for (var _j = 0; _j < __PortalConditionParameter.Length; ++_j) { __PortalConditionParameter[_j] = builder.CreateString(_o.PortalConditionParameter[_j]); }
      _PortalConditionParameter = CreatePortalConditionParameterVector(builder, __PortalConditionParameter);
    }
    var _ThemaNameLocalize = _o.ThemaNameLocalize == null ? default(StringOffset) : builder.CreateString(_o.ThemaNameLocalize);
    var _ThemaLoadingImage = _o.ThemaLoadingImage == null ? default(StringOffset) : builder.CreateString(_o.ThemaLoadingImage);
    var _ThemaPlayerPrefab = _o.ThemaPlayerPrefab == null ? default(StringOffset) : builder.CreateString(_o.ThemaPlayerPrefab);
    var _ThemaGoalLocalize = _o.ThemaGoalLocalize == null ? default(StringOffset) : builder.CreateString(_o.ThemaGoalLocalize);
    return CreateMinigameTBGThemaExcel(
      builder,
      _o.EventContentId,
      _o.UniqueId,
      _o.ThemaIndex,
      _o.ThemaType,
      _ThemaMap,
      _ThemaMapBG,
      _PortalCondition,
      _PortalConditionParameter,
      _ThemaNameLocalize,
      _ThemaLoadingImage,
      _ThemaPlayerPrefab,
      _o.ThemaLeaderId,
      _ThemaGoalLocalize,
      _o.InstantClearCostAmount);
  }
}

public class MinigameTBGThemaExcelT
{
  public long EventContentId { get; set; }
  public long UniqueId { get; set; }
  public int ThemaIndex { get; set; }
  public Plana.FlatData.TBGThemaType ThemaType { get; set; }
  public string ThemaMap { get; set; }
  public string ThemaMapBG { get; set; }
  public List<Plana.FlatData.TBGPortalCondition> PortalCondition { get; set; }
  public List<string> PortalConditionParameter { get; set; }
  public string ThemaNameLocalize { get; set; }
  public string ThemaLoadingImage { get; set; }
  public string ThemaPlayerPrefab { get; set; }
  public long ThemaLeaderId { get; set; }
  public string ThemaGoalLocalize { get; set; }
  public long InstantClearCostAmount { get; set; }

  public MinigameTBGThemaExcelT() {
    this.EventContentId = 0;
    this.UniqueId = 0;
    this.ThemaIndex = 0;
    this.ThemaType = Plana.FlatData.TBGThemaType.None;
    this.ThemaMap = null;
    this.ThemaMapBG = null;
    this.PortalCondition = null;
    this.PortalConditionParameter = null;
    this.ThemaNameLocalize = null;
    this.ThemaLoadingImage = null;
    this.ThemaPlayerPrefab = null;
    this.ThemaLeaderId = 0;
    this.ThemaGoalLocalize = null;
    this.InstantClearCostAmount = 0;
  }
}


static public class MinigameTBGThemaExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*UniqueId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*ThemaIndex*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*ThemaType*/, 4 /*Plana.FlatData.TBGThemaType*/, 4, false)
      && verifier.VerifyString(tablePos, 12 /*ThemaMap*/, false)
      && verifier.VerifyString(tablePos, 14 /*ThemaMapBG*/, false)
      && verifier.VerifyVectorOfData(tablePos, 16 /*PortalCondition*/, 4 /*Plana.FlatData.TBGPortalCondition*/, false)
      && verifier.VerifyVectorOfStrings(tablePos, 18 /*PortalConditionParameter*/, false)
      && verifier.VerifyString(tablePos, 20 /*ThemaNameLocalize*/, false)
      && verifier.VerifyString(tablePos, 22 /*ThemaLoadingImage*/, false)
      && verifier.VerifyString(tablePos, 24 /*ThemaPlayerPrefab*/, false)
      && verifier.VerifyField(tablePos, 26 /*ThemaLeaderId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 28 /*ThemaGoalLocalize*/, false)
      && verifier.VerifyField(tablePos, 30 /*InstantClearCostAmount*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
