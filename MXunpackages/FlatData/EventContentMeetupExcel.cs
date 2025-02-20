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

public struct EventContentMeetupExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentMeetupExcel GetRootAsEventContentMeetupExcel(ByteBuffer _bb) { return GetRootAsEventContentMeetupExcel(_bb, new EventContentMeetupExcel()); }
  public static EventContentMeetupExcel GetRootAsEventContentMeetupExcel(ByteBuffer _bb, EventContentMeetupExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentMeetupExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EventContentId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CharacterId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ConditionScenarioGroupId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.MeetupConditionType ConditionType { get { int o = __p.__offset(12); return o != 0 ? (Plana.FlatData.MeetupConditionType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.MeetupConditionType.None; } }
  public long ConditionParameter(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ConditionParameterLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetConditionParameterBytes() { return __p.__vector_as_span<long>(14, 8); }
#else
  public ArraySegment<byte>? GetConditionParameterBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public long[] GetConditionParameterArray() { return __p.__vector_as_array<long>(14); }
  public Plana.FlatData.MeetupConditionPrintType ConditionPrintType { get { int o = __p.__offset(16); return o != 0 ? (Plana.FlatData.MeetupConditionPrintType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.MeetupConditionPrintType.None; } }

  public static Offset<Plana.FlatData.EventContentMeetupExcel> CreateEventContentMeetupExcel(FlatBufferBuilder builder,
      long Id = 0,
      long EventContentId = 0,
      long CharacterId = 0,
      long ConditionScenarioGroupId = 0,
      Plana.FlatData.MeetupConditionType ConditionType = Plana.FlatData.MeetupConditionType.None,
      VectorOffset ConditionParameterOffset = default(VectorOffset),
      Plana.FlatData.MeetupConditionPrintType ConditionPrintType = Plana.FlatData.MeetupConditionPrintType.None) {
    builder.StartTable(7);
    EventContentMeetupExcel.AddConditionScenarioGroupId(builder, ConditionScenarioGroupId);
    EventContentMeetupExcel.AddCharacterId(builder, CharacterId);
    EventContentMeetupExcel.AddEventContentId(builder, EventContentId);
    EventContentMeetupExcel.AddId(builder, Id);
    EventContentMeetupExcel.AddConditionPrintType(builder, ConditionPrintType);
    EventContentMeetupExcel.AddConditionParameter(builder, ConditionParameterOffset);
    EventContentMeetupExcel.AddConditionType(builder, ConditionType);
    return EventContentMeetupExcel.EndEventContentMeetupExcel(builder);
  }

  public static void StartEventContentMeetupExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(1, eventContentId, 0); }
  public static void AddCharacterId(FlatBufferBuilder builder, long characterId) { builder.AddLong(2, characterId, 0); }
  public static void AddConditionScenarioGroupId(FlatBufferBuilder builder, long conditionScenarioGroupId) { builder.AddLong(3, conditionScenarioGroupId, 0); }
  public static void AddConditionType(FlatBufferBuilder builder, Plana.FlatData.MeetupConditionType conditionType) { builder.AddInt(4, (int)conditionType, 0); }
  public static void AddConditionParameter(FlatBufferBuilder builder, VectorOffset conditionParameterOffset) { builder.AddOffset(5, conditionParameterOffset.Value, 0); }
  public static VectorOffset CreateConditionParameterVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConditionParameterVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionParameterVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionParameterVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConditionParameterVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddConditionPrintType(FlatBufferBuilder builder, Plana.FlatData.MeetupConditionPrintType conditionPrintType) { builder.AddInt(6, (int)conditionPrintType, 0); }
  public static Offset<Plana.FlatData.EventContentMeetupExcel> EndEventContentMeetupExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.EventContentMeetupExcel>(o);
  }
  public EventContentMeetupExcelT UnPack() {
    var _o = new EventContentMeetupExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EventContentMeetupExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("EventContentMeetup");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.EventContentId = TableEncryptionService.Convert(this.EventContentId, key);
    _o.CharacterId = TableEncryptionService.Convert(this.CharacterId, key);
    _o.ConditionScenarioGroupId = TableEncryptionService.Convert(this.ConditionScenarioGroupId, key);
    _o.ConditionType = TableEncryptionService.Convert(this.ConditionType, key);
    _o.ConditionParameter = new List<long>();
    for (var _j = 0; _j < this.ConditionParameterLength; ++_j) {_o.ConditionParameter.Add(TableEncryptionService.Convert(this.ConditionParameter(_j), key));}
    _o.ConditionPrintType = TableEncryptionService.Convert(this.ConditionPrintType, key);
  }
  public static Offset<Plana.FlatData.EventContentMeetupExcel> Pack(FlatBufferBuilder builder, EventContentMeetupExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.EventContentMeetupExcel>);
    var _ConditionParameter = default(VectorOffset);
    if (_o.ConditionParameter != null) {
      var __ConditionParameter = _o.ConditionParameter.ToArray();
      _ConditionParameter = CreateConditionParameterVector(builder, __ConditionParameter);
    }
    return CreateEventContentMeetupExcel(
      builder,
      _o.Id,
      _o.EventContentId,
      _o.CharacterId,
      _o.ConditionScenarioGroupId,
      _o.ConditionType,
      _ConditionParameter,
      _o.ConditionPrintType);
  }
}

public class EventContentMeetupExcelT
{
  public long Id { get; set; }
  public long EventContentId { get; set; }
  public long CharacterId { get; set; }
  public long ConditionScenarioGroupId { get; set; }
  public Plana.FlatData.MeetupConditionType ConditionType { get; set; }
  public List<long> ConditionParameter { get; set; }
  public Plana.FlatData.MeetupConditionPrintType ConditionPrintType { get; set; }

  public EventContentMeetupExcelT() {
    this.Id = 0;
    this.EventContentId = 0;
    this.CharacterId = 0;
    this.ConditionScenarioGroupId = 0;
    this.ConditionType = Plana.FlatData.MeetupConditionType.None;
    this.ConditionParameter = null;
    this.ConditionPrintType = Plana.FlatData.MeetupConditionPrintType.None;
  }
}


static public class EventContentMeetupExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*CharacterId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*ConditionScenarioGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*ConditionType*/, 4 /*Plana.FlatData.MeetupConditionType*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 14 /*ConditionParameter*/, 8 /*long*/, false)
      && verifier.VerifyField(tablePos, 16 /*ConditionPrintType*/, 4 /*Plana.FlatData.MeetupConditionPrintType*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
