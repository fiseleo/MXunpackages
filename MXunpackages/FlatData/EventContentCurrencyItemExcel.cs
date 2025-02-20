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

public struct EventContentCurrencyItemExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentCurrencyItemExcel GetRootAsEventContentCurrencyItemExcel(ByteBuffer _bb) { return GetRootAsEventContentCurrencyItemExcel(_bb, new EventContentCurrencyItemExcel()); }
  public static EventContentCurrencyItemExcel GetRootAsEventContentCurrencyItemExcel(ByteBuffer _bb, EventContentCurrencyItemExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentCurrencyItemExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.EventContentItemType EventContentItemType_ { get { int o = __p.__offset(6); return o != 0 ? (Plana.FlatData.EventContentItemType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.EventContentItemType.EventPoint; } }
  public long ItemUniqueId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<Plana.FlatData.EventContentCurrencyItemExcel> CreateEventContentCurrencyItemExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      Plana.FlatData.EventContentItemType EventContentItemType_ = Plana.FlatData.EventContentItemType.EventPoint,
      long ItemUniqueId = 0) {
    builder.StartTable(3);
    EventContentCurrencyItemExcel.AddItemUniqueId(builder, ItemUniqueId);
    EventContentCurrencyItemExcel.AddEventContentId(builder, EventContentId);
    EventContentCurrencyItemExcel.AddEventContentItemType_(builder, EventContentItemType_);
    return EventContentCurrencyItemExcel.EndEventContentCurrencyItemExcel(builder);
  }

  public static void StartEventContentCurrencyItemExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(0, eventContentId, 0); }
  public static void AddEventContentItemType_(FlatBufferBuilder builder, Plana.FlatData.EventContentItemType eventContentItemType_) { builder.AddInt(1, (int)eventContentItemType_, 0); }
  public static void AddItemUniqueId(FlatBufferBuilder builder, long itemUniqueId) { builder.AddLong(2, itemUniqueId, 0); }
  public static Offset<Plana.FlatData.EventContentCurrencyItemExcel> EndEventContentCurrencyItemExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.EventContentCurrencyItemExcel>(o);
  }
  public EventContentCurrencyItemExcelT UnPack() {
    var _o = new EventContentCurrencyItemExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EventContentCurrencyItemExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("EventContentCurrencyItem");
    _o.EventContentId = TableEncryptionService.Convert(this.EventContentId, key);
    _o.EventContentItemType_ = TableEncryptionService.Convert(this.EventContentItemType_, key);
    _o.ItemUniqueId = TableEncryptionService.Convert(this.ItemUniqueId, key);
  }
  public static Offset<Plana.FlatData.EventContentCurrencyItemExcel> Pack(FlatBufferBuilder builder, EventContentCurrencyItemExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.EventContentCurrencyItemExcel>);
    return CreateEventContentCurrencyItemExcel(
      builder,
      _o.EventContentId,
      _o.EventContentItemType_,
      _o.ItemUniqueId);
  }
}

public class EventContentCurrencyItemExcelT
{
  public long EventContentId { get; set; }
  public Plana.FlatData.EventContentItemType EventContentItemType_ { get; set; }
  public long ItemUniqueId { get; set; }

  public EventContentCurrencyItemExcelT() {
    this.EventContentId = 0;
    this.EventContentItemType_ = Plana.FlatData.EventContentItemType.EventPoint;
    this.ItemUniqueId = 0;
  }
}


static public class EventContentCurrencyItemExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*EventContentItemType_*/, 4 /*Plana.FlatData.EventContentItemType*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*ItemUniqueId*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
