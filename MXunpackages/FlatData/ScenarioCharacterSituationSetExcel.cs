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

public struct ScenarioCharacterSituationSetExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ScenarioCharacterSituationSetExcel GetRootAsScenarioCharacterSituationSetExcel(ByteBuffer _bb) { return GetRootAsScenarioCharacterSituationSetExcel(_bb, new ScenarioCharacterSituationSetExcel()); }
  public static ScenarioCharacterSituationSetExcel GetRootAsScenarioCharacterSituationSetExcel(ByteBuffer _bb, ScenarioCharacterSituationSetExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ScenarioCharacterSituationSetExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint Name { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string Face { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetFaceBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetFaceBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetFaceArray() { return __p.__vector_as_array<byte>(6); }
  public string Behavior { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBehaviorBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetBehaviorBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetBehaviorArray() { return __p.__vector_as_array<byte>(8); }
  public string Action { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetActionBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetActionBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetActionArray() { return __p.__vector_as_array<byte>(10); }
  public string Shape { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetShapeBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetShapeBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetShapeArray() { return __p.__vector_as_array<byte>(12); }
  public uint Effect { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint Emotion { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }

  public static Offset<Plana.FlatData.ScenarioCharacterSituationSetExcel> CreateScenarioCharacterSituationSetExcel(FlatBufferBuilder builder,
      uint Name = 0,
      StringOffset FaceOffset = default(StringOffset),
      StringOffset BehaviorOffset = default(StringOffset),
      StringOffset ActionOffset = default(StringOffset),
      StringOffset ShapeOffset = default(StringOffset),
      uint Effect = 0,
      uint Emotion = 0) {
    builder.StartTable(7);
    ScenarioCharacterSituationSetExcel.AddEmotion(builder, Emotion);
    ScenarioCharacterSituationSetExcel.AddEffect(builder, Effect);
    ScenarioCharacterSituationSetExcel.AddShape(builder, ShapeOffset);
    ScenarioCharacterSituationSetExcel.AddAction(builder, ActionOffset);
    ScenarioCharacterSituationSetExcel.AddBehavior(builder, BehaviorOffset);
    ScenarioCharacterSituationSetExcel.AddFace(builder, FaceOffset);
    ScenarioCharacterSituationSetExcel.AddName(builder, Name);
    return ScenarioCharacterSituationSetExcel.EndScenarioCharacterSituationSetExcel(builder);
  }

  public static void StartScenarioCharacterSituationSetExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddName(FlatBufferBuilder builder, uint name) { builder.AddUint(0, name, 0); }
  public static void AddFace(FlatBufferBuilder builder, StringOffset faceOffset) { builder.AddOffset(1, faceOffset.Value, 0); }
  public static void AddBehavior(FlatBufferBuilder builder, StringOffset behaviorOffset) { builder.AddOffset(2, behaviorOffset.Value, 0); }
  public static void AddAction(FlatBufferBuilder builder, StringOffset actionOffset) { builder.AddOffset(3, actionOffset.Value, 0); }
  public static void AddShape(FlatBufferBuilder builder, StringOffset shapeOffset) { builder.AddOffset(4, shapeOffset.Value, 0); }
  public static void AddEffect(FlatBufferBuilder builder, uint effect) { builder.AddUint(5, effect, 0); }
  public static void AddEmotion(FlatBufferBuilder builder, uint emotion) { builder.AddUint(6, emotion, 0); }
  public static Offset<Plana.FlatData.ScenarioCharacterSituationSetExcel> EndScenarioCharacterSituationSetExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.ScenarioCharacterSituationSetExcel>(o);
  }
  public ScenarioCharacterSituationSetExcelT UnPack() {
    var _o = new ScenarioCharacterSituationSetExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ScenarioCharacterSituationSetExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("ScenarioCharacterSituationSet");
    _o.Name = TableEncryptionService.Convert(this.Name, key);
    _o.Face = TableEncryptionService.Convert(this.Face, key);
    _o.Behavior = TableEncryptionService.Convert(this.Behavior, key);
    _o.Action = TableEncryptionService.Convert(this.Action, key);
    _o.Shape = TableEncryptionService.Convert(this.Shape, key);
    _o.Effect = TableEncryptionService.Convert(this.Effect, key);
    _o.Emotion = TableEncryptionService.Convert(this.Emotion, key);
  }
  public static Offset<Plana.FlatData.ScenarioCharacterSituationSetExcel> Pack(FlatBufferBuilder builder, ScenarioCharacterSituationSetExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.ScenarioCharacterSituationSetExcel>);
    var _Face = _o.Face == null ? default(StringOffset) : builder.CreateString(_o.Face);
    var _Behavior = _o.Behavior == null ? default(StringOffset) : builder.CreateString(_o.Behavior);
    var _Action = _o.Action == null ? default(StringOffset) : builder.CreateString(_o.Action);
    var _Shape = _o.Shape == null ? default(StringOffset) : builder.CreateString(_o.Shape);
    return CreateScenarioCharacterSituationSetExcel(
      builder,
      _o.Name,
      _Face,
      _Behavior,
      _Action,
      _Shape,
      _o.Effect,
      _o.Emotion);
  }
}

public class ScenarioCharacterSituationSetExcelT
{
  public uint Name { get; set; }
  public string Face { get; set; }
  public string Behavior { get; set; }
  public string Action { get; set; }
  public string Shape { get; set; }
  public uint Effect { get; set; }
  public uint Emotion { get; set; }

  public ScenarioCharacterSituationSetExcelT() {
    this.Name = 0;
    this.Face = null;
    this.Behavior = null;
    this.Action = null;
    this.Shape = null;
    this.Effect = 0;
    this.Emotion = 0;
  }
}


static public class ScenarioCharacterSituationSetExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Name*/, 4 /*uint*/, 4, false)
      && verifier.VerifyString(tablePos, 6 /*Face*/, false)
      && verifier.VerifyString(tablePos, 8 /*Behavior*/, false)
      && verifier.VerifyString(tablePos, 10 /*Action*/, false)
      && verifier.VerifyString(tablePos, 12 /*Shape*/, false)
      && verifier.VerifyField(tablePos, 14 /*Effect*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*Emotion*/, 4 /*uint*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
