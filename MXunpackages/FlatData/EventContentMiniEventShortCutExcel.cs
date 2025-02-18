// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct EventContentMiniEventShortCutExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentMiniEventShortCutExcel GetRootAsEventContentMiniEventShortCutExcel(ByteBuffer _bb) { return GetRootAsEventContentMiniEventShortCutExcel(_bb, new EventContentMiniEventShortCutExcel()); }
  public static EventContentMiniEventShortCutExcel GetRootAsEventContentMiniEventShortCutExcel(ByteBuffer _bb, EventContentMiniEventShortCutExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentMiniEventShortCutExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public uint LocalizeEtcId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public Plana.FlatData.EventTargetType ShorcutContentType { get { int o = __p.__offset(8); return o != 0 ? (Plana.FlatData.EventTargetType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.EventTargetType.WeekDungeon; } }

  public static Offset<Plana.FlatData.EventContentMiniEventShortCutExcel> CreateEventContentMiniEventShortCutExcel(FlatBufferBuilder builder,
      int Id = 0,
      uint LocalizeEtcId = 0,
      Plana.FlatData.EventTargetType ShorcutContentType = Plana.FlatData.EventTargetType.WeekDungeon) {
    builder.StartTable(3);
    EventContentMiniEventShortCutExcel.AddShorcutContentType(builder, ShorcutContentType);
    EventContentMiniEventShortCutExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    EventContentMiniEventShortCutExcel.AddId(builder, Id);
    return EventContentMiniEventShortCutExcel.EndEventContentMiniEventShortCutExcel(builder);
  }

  public static void StartEventContentMiniEventShortCutExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint localizeEtcId) { builder.AddUint(1, localizeEtcId, 0); }
  public static void AddShorcutContentType(FlatBufferBuilder builder, Plana.FlatData.EventTargetType shorcutContentType) { builder.AddInt(2, (int)shorcutContentType, 0); }
  public static Offset<Plana.FlatData.EventContentMiniEventShortCutExcel> EndEventContentMiniEventShortCutExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.EventContentMiniEventShortCutExcel>(o);
  }
  public EventContentMiniEventShortCutExcelT UnPack() {
    var _o = new EventContentMiniEventShortCutExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EventContentMiniEventShortCutExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("EventContentMiniEventShortCut");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.LocalizeEtcId = TableEncryptionService.Convert(this.LocalizeEtcId, key);
    _o.ShorcutContentType = TableEncryptionService.Convert(this.ShorcutContentType, key);
  }
  public static Offset<Plana.FlatData.EventContentMiniEventShortCutExcel> Pack(FlatBufferBuilder builder, EventContentMiniEventShortCutExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.EventContentMiniEventShortCutExcel>);
    return CreateEventContentMiniEventShortCutExcel(
      builder,
      _o.Id,
      _o.LocalizeEtcId,
      _o.ShorcutContentType);
  }
}

public class EventContentMiniEventShortCutExcelT
{
  public int Id { get; set; }
  public uint LocalizeEtcId { get; set; }
  public Plana.FlatData.EventTargetType ShorcutContentType { get; set; }

  public EventContentMiniEventShortCutExcelT() {
    this.Id = 0;
    this.LocalizeEtcId = 0;
    this.ShorcutContentType = Plana.FlatData.EventTargetType.WeekDungeon;
  }
}


static public class EventContentMiniEventShortCutExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*LocalizeEtcId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*ShorcutContentType*/, 4 /*Plana.FlatData.EventTargetType*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
