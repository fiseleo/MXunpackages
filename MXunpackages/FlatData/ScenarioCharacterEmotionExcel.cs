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

public struct ScenarioCharacterEmotionExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ScenarioCharacterEmotionExcel GetRootAsScenarioCharacterEmotionExcel(ByteBuffer _bb) { return GetRootAsScenarioCharacterEmotionExcel(_bb, new ScenarioCharacterEmotionExcel()); }
  public static ScenarioCharacterEmotionExcel GetRootAsScenarioCharacterEmotionExcel(ByteBuffer _bb, ScenarioCharacterEmotionExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ScenarioCharacterEmotionExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string EmoticonName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEmoticonNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetEmoticonNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetEmoticonNameArray() { return __p.__vector_as_array<byte>(4); }
  public uint Name { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }

  public static Offset<Plana.FlatData.ScenarioCharacterEmotionExcel> CreateScenarioCharacterEmotionExcel(FlatBufferBuilder builder,
      StringOffset EmoticonNameOffset = default(StringOffset),
      uint Name = 0) {
    builder.StartTable(2);
    ScenarioCharacterEmotionExcel.AddName(builder, Name);
    ScenarioCharacterEmotionExcel.AddEmoticonName(builder, EmoticonNameOffset);
    return ScenarioCharacterEmotionExcel.EndScenarioCharacterEmotionExcel(builder);
  }

  public static void StartScenarioCharacterEmotionExcel(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddEmoticonName(FlatBufferBuilder builder, StringOffset emoticonNameOffset) { builder.AddOffset(0, emoticonNameOffset.Value, 0); }
  public static void AddName(FlatBufferBuilder builder, uint name) { builder.AddUint(1, name, 0); }
  public static Offset<Plana.FlatData.ScenarioCharacterEmotionExcel> EndScenarioCharacterEmotionExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.ScenarioCharacterEmotionExcel>(o);
  }
  public ScenarioCharacterEmotionExcelT UnPack() {
    var _o = new ScenarioCharacterEmotionExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ScenarioCharacterEmotionExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("ScenarioCharacterEmotion");
    _o.EmoticonName = TableEncryptionService.Convert(this.EmoticonName, key);
    _o.Name = TableEncryptionService.Convert(this.Name, key);
  }
  public static Offset<Plana.FlatData.ScenarioCharacterEmotionExcel> Pack(FlatBufferBuilder builder, ScenarioCharacterEmotionExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.ScenarioCharacterEmotionExcel>);
    var _EmoticonName = _o.EmoticonName == null ? default(StringOffset) : builder.CreateString(_o.EmoticonName);
    return CreateScenarioCharacterEmotionExcel(
      builder,
      _EmoticonName,
      _o.Name);
  }
}

public class ScenarioCharacterEmotionExcelT
{
  public string EmoticonName { get; set; }
  public uint Name { get; set; }

  public ScenarioCharacterEmotionExcelT() {
    this.EmoticonName = null;
    this.Name = 0;
  }
}


static public class ScenarioCharacterEmotionExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyString(tablePos, 4 /*EmoticonName*/, false)
      && verifier.VerifyField(tablePos, 6 /*Name*/, 4 /*uint*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
