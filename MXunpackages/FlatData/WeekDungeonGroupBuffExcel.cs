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

public struct WeekDungeonGroupBuffExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static WeekDungeonGroupBuffExcel GetRootAsWeekDungeonGroupBuffExcel(ByteBuffer _bb) { return GetRootAsWeekDungeonGroupBuffExcel(_bb, new WeekDungeonGroupBuffExcel()); }
  public static WeekDungeonGroupBuffExcel GetRootAsWeekDungeonGroupBuffExcel(ByteBuffer _bb, WeekDungeonGroupBuffExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public WeekDungeonGroupBuffExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long WeekDungeonBuffId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.School School_ { get { int o = __p.__offset(6); return o != 0 ? (Plana.FlatData.School)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.School.None; } }
  public uint RecommandLocalizeEtcId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint FormationLocalizeEtcId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string SkillGroupId { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSkillGroupIdBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetSkillGroupIdBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetSkillGroupIdArray() { return __p.__vector_as_array<byte>(12); }

  public static Offset<Plana.FlatData.WeekDungeonGroupBuffExcel> CreateWeekDungeonGroupBuffExcel(FlatBufferBuilder builder,
      long WeekDungeonBuffId = 0,
      Plana.FlatData.School School_ = Plana.FlatData.School.None,
      uint RecommandLocalizeEtcId = 0,
      uint FormationLocalizeEtcId = 0,
      StringOffset SkillGroupIdOffset = default(StringOffset)) {
    builder.StartTable(5);
    WeekDungeonGroupBuffExcel.AddWeekDungeonBuffId(builder, WeekDungeonBuffId);
    WeekDungeonGroupBuffExcel.AddSkillGroupId(builder, SkillGroupIdOffset);
    WeekDungeonGroupBuffExcel.AddFormationLocalizeEtcId(builder, FormationLocalizeEtcId);
    WeekDungeonGroupBuffExcel.AddRecommandLocalizeEtcId(builder, RecommandLocalizeEtcId);
    WeekDungeonGroupBuffExcel.AddSchool_(builder, School_);
    return WeekDungeonGroupBuffExcel.EndWeekDungeonGroupBuffExcel(builder);
  }

  public static void StartWeekDungeonGroupBuffExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddWeekDungeonBuffId(FlatBufferBuilder builder, long weekDungeonBuffId) { builder.AddLong(0, weekDungeonBuffId, 0); }
  public static void AddSchool_(FlatBufferBuilder builder, Plana.FlatData.School school_) { builder.AddInt(1, (int)school_, 0); }
  public static void AddRecommandLocalizeEtcId(FlatBufferBuilder builder, uint recommandLocalizeEtcId) { builder.AddUint(2, recommandLocalizeEtcId, 0); }
  public static void AddFormationLocalizeEtcId(FlatBufferBuilder builder, uint formationLocalizeEtcId) { builder.AddUint(3, formationLocalizeEtcId, 0); }
  public static void AddSkillGroupId(FlatBufferBuilder builder, StringOffset skillGroupIdOffset) { builder.AddOffset(4, skillGroupIdOffset.Value, 0); }
  public static Offset<Plana.FlatData.WeekDungeonGroupBuffExcel> EndWeekDungeonGroupBuffExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.WeekDungeonGroupBuffExcel>(o);
  }
  public WeekDungeonGroupBuffExcelT UnPack() {
    var _o = new WeekDungeonGroupBuffExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(WeekDungeonGroupBuffExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("WeekDungeonGroupBuff");
    _o.WeekDungeonBuffId = TableEncryptionService.Convert(this.WeekDungeonBuffId, key);
    _o.School_ = TableEncryptionService.Convert(this.School_, key);
    _o.RecommandLocalizeEtcId = TableEncryptionService.Convert(this.RecommandLocalizeEtcId, key);
    _o.FormationLocalizeEtcId = TableEncryptionService.Convert(this.FormationLocalizeEtcId, key);
    _o.SkillGroupId = TableEncryptionService.Convert(this.SkillGroupId, key);
  }
  public static Offset<Plana.FlatData.WeekDungeonGroupBuffExcel> Pack(FlatBufferBuilder builder, WeekDungeonGroupBuffExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.WeekDungeonGroupBuffExcel>);
    var _SkillGroupId = _o.SkillGroupId == null ? default(StringOffset) : builder.CreateString(_o.SkillGroupId);
    return CreateWeekDungeonGroupBuffExcel(
      builder,
      _o.WeekDungeonBuffId,
      _o.School_,
      _o.RecommandLocalizeEtcId,
      _o.FormationLocalizeEtcId,
      _SkillGroupId);
  }
}

public class WeekDungeonGroupBuffExcelT
{
  public long WeekDungeonBuffId { get; set; }
  public Plana.FlatData.School School_ { get; set; }
  public uint RecommandLocalizeEtcId { get; set; }
  public uint FormationLocalizeEtcId { get; set; }
  public string SkillGroupId { get; set; }

  public WeekDungeonGroupBuffExcelT() {
    this.WeekDungeonBuffId = 0;
    this.School_ = Plana.FlatData.School.None;
    this.RecommandLocalizeEtcId = 0;
    this.FormationLocalizeEtcId = 0;
    this.SkillGroupId = null;
  }
}


static public class WeekDungeonGroupBuffExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*WeekDungeonBuffId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*School_*/, 4 /*Plana.FlatData.School*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*RecommandLocalizeEtcId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*FormationLocalizeEtcId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyString(tablePos, 12 /*SkillGroupId*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
