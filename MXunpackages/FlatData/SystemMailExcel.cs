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

public struct SystemMailExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static SystemMailExcel GetRootAsSystemMailExcel(ByteBuffer _bb) { return GetRootAsSystemMailExcel(_bb, new SystemMailExcel()); }
  public static SystemMailExcel GetRootAsSystemMailExcel(ByteBuffer _bb, SystemMailExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SystemMailExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Plana.FlatData.MailType MailType_ { get { int o = __p.__offset(4); return o != 0 ? (Plana.FlatData.MailType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.MailType.System; } }
  public long ExpiredDay { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string Sender { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSenderBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetSenderBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetSenderArray() { return __p.__vector_as_array<byte>(8); }
  public string Comment { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetCommentBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetCommentBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetCommentArray() { return __p.__vector_as_array<byte>(10); }

  public static Offset<Plana.FlatData.SystemMailExcel> CreateSystemMailExcel(FlatBufferBuilder builder,
      Plana.FlatData.MailType MailType_ = Plana.FlatData.MailType.System,
      long ExpiredDay = 0,
      StringOffset SenderOffset = default(StringOffset),
      StringOffset CommentOffset = default(StringOffset)) {
    builder.StartTable(4);
    SystemMailExcel.AddExpiredDay(builder, ExpiredDay);
    SystemMailExcel.AddComment(builder, CommentOffset);
    SystemMailExcel.AddSender(builder, SenderOffset);
    SystemMailExcel.AddMailType_(builder, MailType_);
    return SystemMailExcel.EndSystemMailExcel(builder);
  }

  public static void StartSystemMailExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddMailType_(FlatBufferBuilder builder, Plana.FlatData.MailType mailType_) { builder.AddInt(0, (int)mailType_, 0); }
  public static void AddExpiredDay(FlatBufferBuilder builder, long expiredDay) { builder.AddLong(1, expiredDay, 0); }
  public static void AddSender(FlatBufferBuilder builder, StringOffset senderOffset) { builder.AddOffset(2, senderOffset.Value, 0); }
  public static void AddComment(FlatBufferBuilder builder, StringOffset commentOffset) { builder.AddOffset(3, commentOffset.Value, 0); }
  public static Offset<Plana.FlatData.SystemMailExcel> EndSystemMailExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.SystemMailExcel>(o);
  }
  public SystemMailExcelT UnPack() {
    var _o = new SystemMailExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(SystemMailExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("SystemMail");
    _o.MailType_ = TableEncryptionService.Convert(this.MailType_, key);
    _o.ExpiredDay = TableEncryptionService.Convert(this.ExpiredDay, key);
    _o.Sender = TableEncryptionService.Convert(this.Sender, key);
    _o.Comment = TableEncryptionService.Convert(this.Comment, key);
  }
  public static Offset<Plana.FlatData.SystemMailExcel> Pack(FlatBufferBuilder builder, SystemMailExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.SystemMailExcel>);
    var _Sender = _o.Sender == null ? default(StringOffset) : builder.CreateString(_o.Sender);
    var _Comment = _o.Comment == null ? default(StringOffset) : builder.CreateString(_o.Comment);
    return CreateSystemMailExcel(
      builder,
      _o.MailType_,
      _o.ExpiredDay,
      _Sender,
      _Comment);
  }
}

public class SystemMailExcelT
{
  public Plana.FlatData.MailType MailType_ { get; set; }
  public long ExpiredDay { get; set; }
  public string Sender { get; set; }
  public string Comment { get; set; }

  public SystemMailExcelT() {
    this.MailType_ = Plana.FlatData.MailType.System;
    this.ExpiredDay = 0;
    this.Sender = null;
    this.Comment = null;
  }
}


static public class SystemMailExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*MailType_*/, 4 /*Plana.FlatData.MailType*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*ExpiredDay*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 8 /*Sender*/, false)
      && verifier.VerifyString(tablePos, 10 /*Comment*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
