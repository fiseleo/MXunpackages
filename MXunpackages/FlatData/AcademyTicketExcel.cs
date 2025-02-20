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

public struct AcademyTicketExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static AcademyTicketExcel GetRootAsAcademyTicketExcel(ByteBuffer _bb) { return GetRootAsAcademyTicketExcel(_bb, new AcademyTicketExcel()); }
  public static AcademyTicketExcel GetRootAsAcademyTicketExcel(ByteBuffer _bb, AcademyTicketExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AcademyTicketExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long LocationRankSum { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ScheduleTicktetMax { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<Plana.FlatData.AcademyTicketExcel> CreateAcademyTicketExcel(FlatBufferBuilder builder,
      long LocationRankSum = 0,
      long ScheduleTicktetMax = 0) {
    builder.StartTable(2);
    AcademyTicketExcel.AddScheduleTicktetMax(builder, ScheduleTicktetMax);
    AcademyTicketExcel.AddLocationRankSum(builder, LocationRankSum);
    return AcademyTicketExcel.EndAcademyTicketExcel(builder);
  }

  public static void StartAcademyTicketExcel(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddLocationRankSum(FlatBufferBuilder builder, long locationRankSum) { builder.AddLong(0, locationRankSum, 0); }
  public static void AddScheduleTicktetMax(FlatBufferBuilder builder, long scheduleTicktetMax) { builder.AddLong(1, scheduleTicktetMax, 0); }
  public static Offset<Plana.FlatData.AcademyTicketExcel> EndAcademyTicketExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.AcademyTicketExcel>(o);
  }
  public AcademyTicketExcelT UnPack() {
    var _o = new AcademyTicketExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(AcademyTicketExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("AcademyTicket");
    _o.LocationRankSum = TableEncryptionService.Convert(this.LocationRankSum, key);
    _o.ScheduleTicktetMax = TableEncryptionService.Convert(this.ScheduleTicktetMax, key);
  }
  public static Offset<Plana.FlatData.AcademyTicketExcel> Pack(FlatBufferBuilder builder, AcademyTicketExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.AcademyTicketExcel>);
    return CreateAcademyTicketExcel(
      builder,
      _o.LocationRankSum,
      _o.ScheduleTicktetMax);
  }
}

public class AcademyTicketExcelT
{
  public long LocationRankSum { get; set; }
  public long ScheduleTicktetMax { get; set; }

  public AcademyTicketExcelT() {
    this.LocationRankSum = 0;
    this.ScheduleTicktetMax = 0;
  }
}


static public class AcademyTicketExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*LocationRankSum*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*ScheduleTicktetMax*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
