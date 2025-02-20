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

public struct ConquestMapExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ConquestMapExcel GetRootAsConquestMapExcel(ByteBuffer _bb) { return GetRootAsConquestMapExcel(_bb, new ConquestMapExcel()); }
  public static ConquestMapExcel GetRootAsConquestMapExcel(ByteBuffer _bb, ConquestMapExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConquestMapExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string DevName { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDevNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetDevNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetDevNameArray() { return __p.__vector_as_array<byte>(6); }
  public Plana.FlatData.StageDifficulty MapDifficulty { get { int o = __p.__offset(8); return o != 0 ? (Plana.FlatData.StageDifficulty)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.StageDifficulty.None; } }
  public int StepIndex { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string ConquestMap { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetConquestMapBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetConquestMapBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetConquestMapArray() { return __p.__vector_as_array<byte>(12); }
  public long StepEnterScenarioGroupId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.ConquestConditionType StepOpenConditionType(int j) { int o = __p.__offset(16); return o != 0 ? (Plana.FlatData.ConquestConditionType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (Plana.FlatData.ConquestConditionType)0; }
  public int StepOpenConditionTypeLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<Plana.FlatData.ConquestConditionType> GetStepOpenConditionTypeBytes() { return __p.__vector_as_span<Plana.FlatData.ConquestConditionType>(16, 4); }
#else
  public ArraySegment<byte>? GetStepOpenConditionTypeBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public Plana.FlatData.ConquestConditionType[] GetStepOpenConditionTypeArray() { int o = __p.__offset(16); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); Plana.FlatData.ConquestConditionType[] a = new Plana.FlatData.ConquestConditionType[l]; for (int i = 0; i < l; i++) { a[i] = (Plana.FlatData.ConquestConditionType)__p.bb.GetInt(p + i * 4); } return a; }
  public string StepOpenConditionParameter(int j) { int o = __p.__offset(18); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int StepOpenConditionParameterLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string MapGoalLocalize { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMapGoalLocalizeBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetMapGoalLocalizeBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetMapGoalLocalizeArray() { return __p.__vector_as_array<byte>(20); }
  public string StepGoalLocalize { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStepGoalLocalizeBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetStepGoalLocalizeBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetStepGoalLocalizeArray() { return __p.__vector_as_array<byte>(22); }
  public string StepNameLocalize { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStepNameLocalizeBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetStepNameLocalizeBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetStepNameLocalizeArray() { return __p.__vector_as_array<byte>(24); }
  public string ConquestMapBG { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetConquestMapBGBytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetConquestMapBGBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetConquestMapBGArray() { return __p.__vector_as_array<byte>(26); }
  public long CameraSettingId { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<Plana.FlatData.ConquestMapExcel> CreateConquestMapExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      StringOffset DevNameOffset = default(StringOffset),
      Plana.FlatData.StageDifficulty MapDifficulty = Plana.FlatData.StageDifficulty.None,
      int StepIndex = 0,
      StringOffset ConquestMapOffset = default(StringOffset),
      long StepEnterScenarioGroupId = 0,
      VectorOffset StepOpenConditionTypeOffset = default(VectorOffset),
      VectorOffset StepOpenConditionParameterOffset = default(VectorOffset),
      StringOffset MapGoalLocalizeOffset = default(StringOffset),
      StringOffset StepGoalLocalizeOffset = default(StringOffset),
      StringOffset StepNameLocalizeOffset = default(StringOffset),
      StringOffset ConquestMapBGOffset = default(StringOffset),
      long CameraSettingId = 0) {
    builder.StartTable(13);
    ConquestMapExcel.AddCameraSettingId(builder, CameraSettingId);
    ConquestMapExcel.AddStepEnterScenarioGroupId(builder, StepEnterScenarioGroupId);
    ConquestMapExcel.AddEventContentId(builder, EventContentId);
    ConquestMapExcel.AddConquestMapBG(builder, ConquestMapBGOffset);
    ConquestMapExcel.AddStepNameLocalize(builder, StepNameLocalizeOffset);
    ConquestMapExcel.AddStepGoalLocalize(builder, StepGoalLocalizeOffset);
    ConquestMapExcel.AddMapGoalLocalize(builder, MapGoalLocalizeOffset);
    ConquestMapExcel.AddStepOpenConditionParameter(builder, StepOpenConditionParameterOffset);
    ConquestMapExcel.AddStepOpenConditionType(builder, StepOpenConditionTypeOffset);
    ConquestMapExcel.AddConquestMap(builder, ConquestMapOffset);
    ConquestMapExcel.AddStepIndex(builder, StepIndex);
    ConquestMapExcel.AddMapDifficulty(builder, MapDifficulty);
    ConquestMapExcel.AddDevName(builder, DevNameOffset);
    return ConquestMapExcel.EndConquestMapExcel(builder);
  }

  public static void StartConquestMapExcel(FlatBufferBuilder builder) { builder.StartTable(13); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(0, eventContentId, 0); }
  public static void AddDevName(FlatBufferBuilder builder, StringOffset devNameOffset) { builder.AddOffset(1, devNameOffset.Value, 0); }
  public static void AddMapDifficulty(FlatBufferBuilder builder, Plana.FlatData.StageDifficulty mapDifficulty) { builder.AddInt(2, (int)mapDifficulty, 0); }
  public static void AddStepIndex(FlatBufferBuilder builder, int stepIndex) { builder.AddInt(3, stepIndex, 0); }
  public static void AddConquestMap(FlatBufferBuilder builder, StringOffset conquestMapOffset) { builder.AddOffset(4, conquestMapOffset.Value, 0); }
  public static void AddStepEnterScenarioGroupId(FlatBufferBuilder builder, long stepEnterScenarioGroupId) { builder.AddLong(5, stepEnterScenarioGroupId, 0); }
  public static void AddStepOpenConditionType(FlatBufferBuilder builder, VectorOffset stepOpenConditionTypeOffset) { builder.AddOffset(6, stepOpenConditionTypeOffset.Value, 0); }
  public static VectorOffset CreateStepOpenConditionTypeVector(FlatBufferBuilder builder, Plana.FlatData.ConquestConditionType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStepOpenConditionTypeVectorBlock(FlatBufferBuilder builder, Plana.FlatData.ConquestConditionType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStepOpenConditionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<Plana.FlatData.ConquestConditionType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStepOpenConditionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Plana.FlatData.ConquestConditionType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStepOpenConditionTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddStepOpenConditionParameter(FlatBufferBuilder builder, VectorOffset stepOpenConditionParameterOffset) { builder.AddOffset(7, stepOpenConditionParameterOffset.Value, 0); }
  public static VectorOffset CreateStepOpenConditionParameterVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateStepOpenConditionParameterVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStepOpenConditionParameterVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStepOpenConditionParameterVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStepOpenConditionParameterVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMapGoalLocalize(FlatBufferBuilder builder, StringOffset mapGoalLocalizeOffset) { builder.AddOffset(8, mapGoalLocalizeOffset.Value, 0); }
  public static void AddStepGoalLocalize(FlatBufferBuilder builder, StringOffset stepGoalLocalizeOffset) { builder.AddOffset(9, stepGoalLocalizeOffset.Value, 0); }
  public static void AddStepNameLocalize(FlatBufferBuilder builder, StringOffset stepNameLocalizeOffset) { builder.AddOffset(10, stepNameLocalizeOffset.Value, 0); }
  public static void AddConquestMapBG(FlatBufferBuilder builder, StringOffset conquestMapBGOffset) { builder.AddOffset(11, conquestMapBGOffset.Value, 0); }
  public static void AddCameraSettingId(FlatBufferBuilder builder, long cameraSettingId) { builder.AddLong(12, cameraSettingId, 0); }
  public static Offset<Plana.FlatData.ConquestMapExcel> EndConquestMapExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.ConquestMapExcel>(o);
  }
  public ConquestMapExcelT UnPack() {
    var _o = new ConquestMapExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ConquestMapExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("ConquestMap");
    _o.EventContentId = TableEncryptionService.Convert(this.EventContentId, key);
    _o.DevName = TableEncryptionService.Convert(this.DevName, key);
    _o.MapDifficulty = TableEncryptionService.Convert(this.MapDifficulty, key);
    _o.StepIndex = TableEncryptionService.Convert(this.StepIndex, key);
    _o.ConquestMap = TableEncryptionService.Convert(this.ConquestMap, key);
    _o.StepEnterScenarioGroupId = TableEncryptionService.Convert(this.StepEnterScenarioGroupId, key);
    _o.StepOpenConditionType = new List<Plana.FlatData.ConquestConditionType>();
    for (var _j = 0; _j < this.StepOpenConditionTypeLength; ++_j) {_o.StepOpenConditionType.Add(TableEncryptionService.Convert(this.StepOpenConditionType(_j), key));}
    _o.StepOpenConditionParameter = new List<string>();
    for (var _j = 0; _j < this.StepOpenConditionParameterLength; ++_j) {_o.StepOpenConditionParameter.Add(TableEncryptionService.Convert(this.StepOpenConditionParameter(_j), key));}
    _o.MapGoalLocalize = TableEncryptionService.Convert(this.MapGoalLocalize, key);
    _o.StepGoalLocalize = TableEncryptionService.Convert(this.StepGoalLocalize, key);
    _o.StepNameLocalize = TableEncryptionService.Convert(this.StepNameLocalize, key);
    _o.ConquestMapBG = TableEncryptionService.Convert(this.ConquestMapBG, key);
    _o.CameraSettingId = TableEncryptionService.Convert(this.CameraSettingId, key);
  }
  public static Offset<Plana.FlatData.ConquestMapExcel> Pack(FlatBufferBuilder builder, ConquestMapExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.ConquestMapExcel>);
    var _DevName = _o.DevName == null ? default(StringOffset) : builder.CreateString(_o.DevName);
    var _ConquestMap = _o.ConquestMap == null ? default(StringOffset) : builder.CreateString(_o.ConquestMap);
    var _StepOpenConditionType = default(VectorOffset);
    if (_o.StepOpenConditionType != null) {
      var __StepOpenConditionType = _o.StepOpenConditionType.ToArray();
      _StepOpenConditionType = CreateStepOpenConditionTypeVector(builder, __StepOpenConditionType);
    }
    var _StepOpenConditionParameter = default(VectorOffset);
    if (_o.StepOpenConditionParameter != null) {
      var __StepOpenConditionParameter = new StringOffset[_o.StepOpenConditionParameter.Count];
      for (var _j = 0; _j < __StepOpenConditionParameter.Length; ++_j) { __StepOpenConditionParameter[_j] = builder.CreateString(_o.StepOpenConditionParameter[_j]); }
      _StepOpenConditionParameter = CreateStepOpenConditionParameterVector(builder, __StepOpenConditionParameter);
    }
    var _MapGoalLocalize = _o.MapGoalLocalize == null ? default(StringOffset) : builder.CreateString(_o.MapGoalLocalize);
    var _StepGoalLocalize = _o.StepGoalLocalize == null ? default(StringOffset) : builder.CreateString(_o.StepGoalLocalize);
    var _StepNameLocalize = _o.StepNameLocalize == null ? default(StringOffset) : builder.CreateString(_o.StepNameLocalize);
    var _ConquestMapBG = _o.ConquestMapBG == null ? default(StringOffset) : builder.CreateString(_o.ConquestMapBG);
    return CreateConquestMapExcel(
      builder,
      _o.EventContentId,
      _DevName,
      _o.MapDifficulty,
      _o.StepIndex,
      _ConquestMap,
      _o.StepEnterScenarioGroupId,
      _StepOpenConditionType,
      _StepOpenConditionParameter,
      _MapGoalLocalize,
      _StepGoalLocalize,
      _StepNameLocalize,
      _ConquestMapBG,
      _o.CameraSettingId);
  }
}

public class ConquestMapExcelT
{
  public long EventContentId { get; set; }
  public string DevName { get; set; }
  public Plana.FlatData.StageDifficulty MapDifficulty { get; set; }
  public int StepIndex { get; set; }
  public string ConquestMap { get; set; }
  public long StepEnterScenarioGroupId { get; set; }
  public List<Plana.FlatData.ConquestConditionType> StepOpenConditionType { get; set; }
  public List<string> StepOpenConditionParameter { get; set; }
  public string MapGoalLocalize { get; set; }
  public string StepGoalLocalize { get; set; }
  public string StepNameLocalize { get; set; }
  public string ConquestMapBG { get; set; }
  public long CameraSettingId { get; set; }

  public ConquestMapExcelT() {
    this.EventContentId = 0;
    this.DevName = null;
    this.MapDifficulty = Plana.FlatData.StageDifficulty.None;
    this.StepIndex = 0;
    this.ConquestMap = null;
    this.StepEnterScenarioGroupId = 0;
    this.StepOpenConditionType = null;
    this.StepOpenConditionParameter = null;
    this.MapGoalLocalize = null;
    this.StepGoalLocalize = null;
    this.StepNameLocalize = null;
    this.ConquestMapBG = null;
    this.CameraSettingId = 0;
  }
}


static public class ConquestMapExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 6 /*DevName*/, false)
      && verifier.VerifyField(tablePos, 8 /*MapDifficulty*/, 4 /*Plana.FlatData.StageDifficulty*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*StepIndex*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 12 /*ConquestMap*/, false)
      && verifier.VerifyField(tablePos, 14 /*StepEnterScenarioGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 16 /*StepOpenConditionType*/, 4 /*Plana.FlatData.ConquestConditionType*/, false)
      && verifier.VerifyVectorOfStrings(tablePos, 18 /*StepOpenConditionParameter*/, false)
      && verifier.VerifyString(tablePos, 20 /*MapGoalLocalize*/, false)
      && verifier.VerifyString(tablePos, 22 /*StepGoalLocalize*/, false)
      && verifier.VerifyString(tablePos, 24 /*StepNameLocalize*/, false)
      && verifier.VerifyString(tablePos, 26 /*ConquestMapBG*/, false)
      && verifier.VerifyField(tablePos, 28 /*CameraSettingId*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
