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

public struct ProtocolSettingExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ProtocolSettingExcel GetRootAsProtocolSettingExcel(ByteBuffer _bb) { return GetRootAsProtocolSettingExcel(_bb, new ProtocolSettingExcel()); }
  public static ProtocolSettingExcel GetRootAsProtocolSettingExcel(ByteBuffer _bb, ProtocolSettingExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ProtocolSettingExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Protocol { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetProtocolBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetProtocolBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetProtocolArray() { return __p.__vector_as_array<byte>(4); }
  public Plana.FlatData.OpenConditionContent OpenConditionContent_ { get { int o = __p.__offset(6); return o != 0 ? (Plana.FlatData.OpenConditionContent)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.OpenConditionContent.Shop; } }
  public bool Currency { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool Inventory { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool Mail { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<Plana.FlatData.ProtocolSettingExcel> CreateProtocolSettingExcel(FlatBufferBuilder builder,
      StringOffset ProtocolOffset = default(StringOffset),
      Plana.FlatData.OpenConditionContent OpenConditionContent_ = Plana.FlatData.OpenConditionContent.Shop,
      bool Currency = false,
      bool Inventory = false,
      bool Mail = false) {
    builder.StartTable(5);
    ProtocolSettingExcel.AddOpenConditionContent_(builder, OpenConditionContent_);
    ProtocolSettingExcel.AddProtocol(builder, ProtocolOffset);
    ProtocolSettingExcel.AddMail(builder, Mail);
    ProtocolSettingExcel.AddInventory(builder, Inventory);
    ProtocolSettingExcel.AddCurrency(builder, Currency);
    return ProtocolSettingExcel.EndProtocolSettingExcel(builder);
  }

  public static void StartProtocolSettingExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddProtocol(FlatBufferBuilder builder, StringOffset protocolOffset) { builder.AddOffset(0, protocolOffset.Value, 0); }
  public static void AddOpenConditionContent_(FlatBufferBuilder builder, Plana.FlatData.OpenConditionContent openConditionContent_) { builder.AddInt(1, (int)openConditionContent_, 0); }
  public static void AddCurrency(FlatBufferBuilder builder, bool currency) { builder.AddBool(2, currency, false); }
  public static void AddInventory(FlatBufferBuilder builder, bool inventory) { builder.AddBool(3, inventory, false); }
  public static void AddMail(FlatBufferBuilder builder, bool mail) { builder.AddBool(4, mail, false); }
  public static Offset<Plana.FlatData.ProtocolSettingExcel> EndProtocolSettingExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.ProtocolSettingExcel>(o);
  }
  public ProtocolSettingExcelT UnPack() {
    var _o = new ProtocolSettingExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ProtocolSettingExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("ProtocolSetting");
    _o.Protocol = TableEncryptionService.Convert(this.Protocol, key);
    _o.OpenConditionContent_ = TableEncryptionService.Convert(this.OpenConditionContent_, key);
    _o.Currency = TableEncryptionService.Convert(this.Currency, key);
    _o.Inventory = TableEncryptionService.Convert(this.Inventory, key);
    _o.Mail = TableEncryptionService.Convert(this.Mail, key);
  }
  public static Offset<Plana.FlatData.ProtocolSettingExcel> Pack(FlatBufferBuilder builder, ProtocolSettingExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.ProtocolSettingExcel>);
    var _Protocol = _o.Protocol == null ? default(StringOffset) : builder.CreateString(_o.Protocol);
    return CreateProtocolSettingExcel(
      builder,
      _Protocol,
      _o.OpenConditionContent_,
      _o.Currency,
      _o.Inventory,
      _o.Mail);
  }
}

public class ProtocolSettingExcelT
{
  public string Protocol { get; set; }
  public Plana.FlatData.OpenConditionContent OpenConditionContent_ { get; set; }
  public bool Currency { get; set; }
  public bool Inventory { get; set; }
  public bool Mail { get; set; }

  public ProtocolSettingExcelT() {
    this.Protocol = null;
    this.OpenConditionContent_ = Plana.FlatData.OpenConditionContent.Shop;
    this.Currency = false;
    this.Inventory = false;
    this.Mail = false;
  }
}


static public class ProtocolSettingExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyString(tablePos, 4 /*Protocol*/, false)
      && verifier.VerifyField(tablePos, 6 /*OpenConditionContent_*/, 4 /*Plana.FlatData.OpenConditionContent*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*Currency*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 10 /*Inventory*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 12 /*Mail*/, 1 /*bool*/, 1, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
