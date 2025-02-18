// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct EventContentChangeScenarioExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentChangeScenarioExcel GetRootAsEventContentChangeScenarioExcel(ByteBuffer _bb) { return GetRootAsEventContentChangeScenarioExcel(_bb, new EventContentChangeScenarioExcel()); }
  public static EventContentChangeScenarioExcel GetRootAsEventContentChangeScenarioExcel(ByteBuffer _bb, EventContentChangeScenarioExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentChangeScenarioExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.EventChangeType ChangeType { get { int o = __p.__offset(6); return o != 0 ? (Plana.FlatData.EventChangeType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.EventChangeType.MainSub; } }
  public long ChangeCount { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ScenarioGroupId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<Plana.FlatData.EventContentChangeScenarioExcel> CreateEventContentChangeScenarioExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      Plana.FlatData.EventChangeType ChangeType = Plana.FlatData.EventChangeType.MainSub,
      long ChangeCount = 0,
      long ScenarioGroupId = 0) {
    builder.StartTable(4);
    EventContentChangeScenarioExcel.AddScenarioGroupId(builder, ScenarioGroupId);
    EventContentChangeScenarioExcel.AddChangeCount(builder, ChangeCount);
    EventContentChangeScenarioExcel.AddEventContentId(builder, EventContentId);
    EventContentChangeScenarioExcel.AddChangeType(builder, ChangeType);
    return EventContentChangeScenarioExcel.EndEventContentChangeScenarioExcel(builder);
  }

  public static void StartEventContentChangeScenarioExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(0, eventContentId, 0); }
  public static void AddChangeType(FlatBufferBuilder builder, Plana.FlatData.EventChangeType changeType) { builder.AddInt(1, (int)changeType, 0); }
  public static void AddChangeCount(FlatBufferBuilder builder, long changeCount) { builder.AddLong(2, changeCount, 0); }
  public static void AddScenarioGroupId(FlatBufferBuilder builder, long scenarioGroupId) { builder.AddLong(3, scenarioGroupId, 0); }
  public static Offset<Plana.FlatData.EventContentChangeScenarioExcel> EndEventContentChangeScenarioExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.EventContentChangeScenarioExcel>(o);
  }
  public EventContentChangeScenarioExcelT UnPack() {
    var _o = new EventContentChangeScenarioExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EventContentChangeScenarioExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("EventContentChangeScenario");
    _o.EventContentId = TableEncryptionService.Convert(this.EventContentId, key);
    _o.ChangeType = TableEncryptionService.Convert(this.ChangeType, key);
    _o.ChangeCount = TableEncryptionService.Convert(this.ChangeCount, key);
    _o.ScenarioGroupId = TableEncryptionService.Convert(this.ScenarioGroupId, key);
  }
  public static Offset<Plana.FlatData.EventContentChangeScenarioExcel> Pack(FlatBufferBuilder builder, EventContentChangeScenarioExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.EventContentChangeScenarioExcel>);
    return CreateEventContentChangeScenarioExcel(
      builder,
      _o.EventContentId,
      _o.ChangeType,
      _o.ChangeCount,
      _o.ScenarioGroupId);
  }
}

public class EventContentChangeScenarioExcelT
{
  public long EventContentId { get; set; }
  public Plana.FlatData.EventChangeType ChangeType { get; set; }
  public long ChangeCount { get; set; }
  public long ScenarioGroupId { get; set; }

  public EventContentChangeScenarioExcelT() {
    this.EventContentId = 0;
    this.ChangeType = Plana.FlatData.EventChangeType.MainSub;
    this.ChangeCount = 0;
    this.ScenarioGroupId = 0;
  }
}


static public class EventContentChangeScenarioExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*ChangeType*/, 4 /*Plana.FlatData.EventChangeType*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*ChangeCount*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*ScenarioGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
