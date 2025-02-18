// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Plana.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Plana.Crypto;
using global::Google.FlatBuffers;

public struct CharacterVictoryInteractionExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static CharacterVictoryInteractionExcel GetRootAsCharacterVictoryInteractionExcel(ByteBuffer _bb) { return GetRootAsCharacterVictoryInteractionExcel(_bb, new CharacterVictoryInteractionExcel()); }
  public static CharacterVictoryInteractionExcel GetRootAsCharacterVictoryInteractionExcel(ByteBuffer _bb, CharacterVictoryInteractionExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterVictoryInteractionExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long InteractionId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CostumeId01 { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int PositionIndex01 { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string VictoryStartAnimationPath01 { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryStartAnimationPath01Bytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetVictoryStartAnimationPath01Bytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetVictoryStartAnimationPath01Array() { return __p.__vector_as_array<byte>(10); }
  public string VictoryEndAnimationPath01 { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryEndAnimationPath01Bytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetVictoryEndAnimationPath01Bytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetVictoryEndAnimationPath01Array() { return __p.__vector_as_array<byte>(12); }
  public Plana.FlatData.VoiceEvent VoiceEvent01 { get { int o = __p.__offset(14); return o != 0 ? (Plana.FlatData.VoiceEvent)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.VoiceEvent.OnTSA; } }
  public long CostumeId02 { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int PositionIndex02 { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string VictoryStartAnimationPath02 { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryStartAnimationPath02Bytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetVictoryStartAnimationPath02Bytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetVictoryStartAnimationPath02Array() { return __p.__vector_as_array<byte>(20); }
  public string VictoryEndAnimationPath02 { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryEndAnimationPath02Bytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetVictoryEndAnimationPath02Bytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetVictoryEndAnimationPath02Array() { return __p.__vector_as_array<byte>(22); }
  public Plana.FlatData.VoiceEvent VoiceEvent02 { get { int o = __p.__offset(24); return o != 0 ? (Plana.FlatData.VoiceEvent)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.VoiceEvent.OnTSA; } }
  public long CostumeId03 { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int PositionIndex03 { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string VictoryStartAnimationPath03 { get { int o = __p.__offset(30); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryStartAnimationPath03Bytes() { return __p.__vector_as_span<byte>(30, 1); }
#else
  public ArraySegment<byte>? GetVictoryStartAnimationPath03Bytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public byte[] GetVictoryStartAnimationPath03Array() { return __p.__vector_as_array<byte>(30); }
  public string VictoryEndAnimationPath03 { get { int o = __p.__offset(32); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryEndAnimationPath03Bytes() { return __p.__vector_as_span<byte>(32, 1); }
#else
  public ArraySegment<byte>? GetVictoryEndAnimationPath03Bytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public byte[] GetVictoryEndAnimationPath03Array() { return __p.__vector_as_array<byte>(32); }
  public Plana.FlatData.VoiceEvent VoiceEvent03 { get { int o = __p.__offset(34); return o != 0 ? (Plana.FlatData.VoiceEvent)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.VoiceEvent.OnTSA; } }
  public long CostumeId04 { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int PositionIndex04 { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string VictoryStartAnimationPath04 { get { int o = __p.__offset(40); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryStartAnimationPath04Bytes() { return __p.__vector_as_span<byte>(40, 1); }
#else
  public ArraySegment<byte>? GetVictoryStartAnimationPath04Bytes() { return __p.__vector_as_arraysegment(40); }
#endif
  public byte[] GetVictoryStartAnimationPath04Array() { return __p.__vector_as_array<byte>(40); }
  public string VictoryEndAnimationPath04 { get { int o = __p.__offset(42); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryEndAnimationPath04Bytes() { return __p.__vector_as_span<byte>(42, 1); }
#else
  public ArraySegment<byte>? GetVictoryEndAnimationPath04Bytes() { return __p.__vector_as_arraysegment(42); }
#endif
  public byte[] GetVictoryEndAnimationPath04Array() { return __p.__vector_as_array<byte>(42); }
  public Plana.FlatData.VoiceEvent VoiceEvent04 { get { int o = __p.__offset(44); return o != 0 ? (Plana.FlatData.VoiceEvent)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.VoiceEvent.OnTSA; } }
  public long CostumeId05 { get { int o = __p.__offset(46); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int PositionIndex05 { get { int o = __p.__offset(48); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string VictoryStartAnimationPath05 { get { int o = __p.__offset(50); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryStartAnimationPath05Bytes() { return __p.__vector_as_span<byte>(50, 1); }
#else
  public ArraySegment<byte>? GetVictoryStartAnimationPath05Bytes() { return __p.__vector_as_arraysegment(50); }
#endif
  public byte[] GetVictoryStartAnimationPath05Array() { return __p.__vector_as_array<byte>(50); }
  public string VictoryEndAnimationPath05 { get { int o = __p.__offset(52); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryEndAnimationPath05Bytes() { return __p.__vector_as_span<byte>(52, 1); }
#else
  public ArraySegment<byte>? GetVictoryEndAnimationPath05Bytes() { return __p.__vector_as_arraysegment(52); }
#endif
  public byte[] GetVictoryEndAnimationPath05Array() { return __p.__vector_as_array<byte>(52); }
  public Plana.FlatData.VoiceEvent VoiceEvent05 { get { int o = __p.__offset(54); return o != 0 ? (Plana.FlatData.VoiceEvent)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.VoiceEvent.OnTSA; } }
  public long CostumeId06 { get { int o = __p.__offset(56); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int PositionIndex06 { get { int o = __p.__offset(58); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string VictoryStartAnimationPath06 { get { int o = __p.__offset(60); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryStartAnimationPath06Bytes() { return __p.__vector_as_span<byte>(60, 1); }
#else
  public ArraySegment<byte>? GetVictoryStartAnimationPath06Bytes() { return __p.__vector_as_arraysegment(60); }
#endif
  public byte[] GetVictoryStartAnimationPath06Array() { return __p.__vector_as_array<byte>(60); }
  public string VictoryEndAnimationPath06 { get { int o = __p.__offset(62); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryEndAnimationPath06Bytes() { return __p.__vector_as_span<byte>(62, 1); }
#else
  public ArraySegment<byte>? GetVictoryEndAnimationPath06Bytes() { return __p.__vector_as_arraysegment(62); }
#endif
  public byte[] GetVictoryEndAnimationPath06Array() { return __p.__vector_as_array<byte>(62); }
  public Plana.FlatData.VoiceEvent VoiceEvent06 { get { int o = __p.__offset(64); return o != 0 ? (Plana.FlatData.VoiceEvent)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.VoiceEvent.OnTSA; } }

  public static Offset<Plana.FlatData.CharacterVictoryInteractionExcel> CreateCharacterVictoryInteractionExcel(FlatBufferBuilder builder,
      long InteractionId = 0,
      long CostumeId01 = 0,
      int PositionIndex01 = 0,
      StringOffset VictoryStartAnimationPath01Offset = default(StringOffset),
      StringOffset VictoryEndAnimationPath01Offset = default(StringOffset),
      Plana.FlatData.VoiceEvent VoiceEvent01 = Plana.FlatData.VoiceEvent.OnTSA,
      long CostumeId02 = 0,
      int PositionIndex02 = 0,
      StringOffset VictoryStartAnimationPath02Offset = default(StringOffset),
      StringOffset VictoryEndAnimationPath02Offset = default(StringOffset),
      Plana.FlatData.VoiceEvent VoiceEvent02 = Plana.FlatData.VoiceEvent.OnTSA,
      long CostumeId03 = 0,
      int PositionIndex03 = 0,
      StringOffset VictoryStartAnimationPath03Offset = default(StringOffset),
      StringOffset VictoryEndAnimationPath03Offset = default(StringOffset),
      Plana.FlatData.VoiceEvent VoiceEvent03 = Plana.FlatData.VoiceEvent.OnTSA,
      long CostumeId04 = 0,
      int PositionIndex04 = 0,
      StringOffset VictoryStartAnimationPath04Offset = default(StringOffset),
      StringOffset VictoryEndAnimationPath04Offset = default(StringOffset),
      Plana.FlatData.VoiceEvent VoiceEvent04 = Plana.FlatData.VoiceEvent.OnTSA,
      long CostumeId05 = 0,
      int PositionIndex05 = 0,
      StringOffset VictoryStartAnimationPath05Offset = default(StringOffset),
      StringOffset VictoryEndAnimationPath05Offset = default(StringOffset),
      Plana.FlatData.VoiceEvent VoiceEvent05 = Plana.FlatData.VoiceEvent.OnTSA,
      long CostumeId06 = 0,
      int PositionIndex06 = 0,
      StringOffset VictoryStartAnimationPath06Offset = default(StringOffset),
      StringOffset VictoryEndAnimationPath06Offset = default(StringOffset),
      Plana.FlatData.VoiceEvent VoiceEvent06 = Plana.FlatData.VoiceEvent.OnTSA) {
    builder.StartTable(31);
    CharacterVictoryInteractionExcel.AddCostumeId06(builder, CostumeId06);
    CharacterVictoryInteractionExcel.AddCostumeId05(builder, CostumeId05);
    CharacterVictoryInteractionExcel.AddCostumeId04(builder, CostumeId04);
    CharacterVictoryInteractionExcel.AddCostumeId03(builder, CostumeId03);
    CharacterVictoryInteractionExcel.AddCostumeId02(builder, CostumeId02);
    CharacterVictoryInteractionExcel.AddCostumeId01(builder, CostumeId01);
    CharacterVictoryInteractionExcel.AddInteractionId(builder, InteractionId);
    CharacterVictoryInteractionExcel.AddVoiceEvent06(builder, VoiceEvent06);
    CharacterVictoryInteractionExcel.AddVictoryEndAnimationPath06(builder, VictoryEndAnimationPath06Offset);
    CharacterVictoryInteractionExcel.AddVictoryStartAnimationPath06(builder, VictoryStartAnimationPath06Offset);
    CharacterVictoryInteractionExcel.AddPositionIndex06(builder, PositionIndex06);
    CharacterVictoryInteractionExcel.AddVoiceEvent05(builder, VoiceEvent05);
    CharacterVictoryInteractionExcel.AddVictoryEndAnimationPath05(builder, VictoryEndAnimationPath05Offset);
    CharacterVictoryInteractionExcel.AddVictoryStartAnimationPath05(builder, VictoryStartAnimationPath05Offset);
    CharacterVictoryInteractionExcel.AddPositionIndex05(builder, PositionIndex05);
    CharacterVictoryInteractionExcel.AddVoiceEvent04(builder, VoiceEvent04);
    CharacterVictoryInteractionExcel.AddVictoryEndAnimationPath04(builder, VictoryEndAnimationPath04Offset);
    CharacterVictoryInteractionExcel.AddVictoryStartAnimationPath04(builder, VictoryStartAnimationPath04Offset);
    CharacterVictoryInteractionExcel.AddPositionIndex04(builder, PositionIndex04);
    CharacterVictoryInteractionExcel.AddVoiceEvent03(builder, VoiceEvent03);
    CharacterVictoryInteractionExcel.AddVictoryEndAnimationPath03(builder, VictoryEndAnimationPath03Offset);
    CharacterVictoryInteractionExcel.AddVictoryStartAnimationPath03(builder, VictoryStartAnimationPath03Offset);
    CharacterVictoryInteractionExcel.AddPositionIndex03(builder, PositionIndex03);
    CharacterVictoryInteractionExcel.AddVoiceEvent02(builder, VoiceEvent02);
    CharacterVictoryInteractionExcel.AddVictoryEndAnimationPath02(builder, VictoryEndAnimationPath02Offset);
    CharacterVictoryInteractionExcel.AddVictoryStartAnimationPath02(builder, VictoryStartAnimationPath02Offset);
    CharacterVictoryInteractionExcel.AddPositionIndex02(builder, PositionIndex02);
    CharacterVictoryInteractionExcel.AddVoiceEvent01(builder, VoiceEvent01);
    CharacterVictoryInteractionExcel.AddVictoryEndAnimationPath01(builder, VictoryEndAnimationPath01Offset);
    CharacterVictoryInteractionExcel.AddVictoryStartAnimationPath01(builder, VictoryStartAnimationPath01Offset);
    CharacterVictoryInteractionExcel.AddPositionIndex01(builder, PositionIndex01);
    return CharacterVictoryInteractionExcel.EndCharacterVictoryInteractionExcel(builder);
  }

  public static void StartCharacterVictoryInteractionExcel(FlatBufferBuilder builder) { builder.StartTable(31); }
  public static void AddInteractionId(FlatBufferBuilder builder, long interactionId) { builder.AddLong(0, interactionId, 0); }
  public static void AddCostumeId01(FlatBufferBuilder builder, long costumeId01) { builder.AddLong(1, costumeId01, 0); }
  public static void AddPositionIndex01(FlatBufferBuilder builder, int positionIndex01) { builder.AddInt(2, positionIndex01, 0); }
  public static void AddVictoryStartAnimationPath01(FlatBufferBuilder builder, StringOffset victoryStartAnimationPath01Offset) { builder.AddOffset(3, victoryStartAnimationPath01Offset.Value, 0); }
  public static void AddVictoryEndAnimationPath01(FlatBufferBuilder builder, StringOffset victoryEndAnimationPath01Offset) { builder.AddOffset(4, victoryEndAnimationPath01Offset.Value, 0); }
  public static void AddVoiceEvent01(FlatBufferBuilder builder, Plana.FlatData.VoiceEvent voiceEvent01) { builder.AddInt(5, (int)voiceEvent01, 0); }
  public static void AddCostumeId02(FlatBufferBuilder builder, long costumeId02) { builder.AddLong(6, costumeId02, 0); }
  public static void AddPositionIndex02(FlatBufferBuilder builder, int positionIndex02) { builder.AddInt(7, positionIndex02, 0); }
  public static void AddVictoryStartAnimationPath02(FlatBufferBuilder builder, StringOffset victoryStartAnimationPath02Offset) { builder.AddOffset(8, victoryStartAnimationPath02Offset.Value, 0); }
  public static void AddVictoryEndAnimationPath02(FlatBufferBuilder builder, StringOffset victoryEndAnimationPath02Offset) { builder.AddOffset(9, victoryEndAnimationPath02Offset.Value, 0); }
  public static void AddVoiceEvent02(FlatBufferBuilder builder, Plana.FlatData.VoiceEvent voiceEvent02) { builder.AddInt(10, (int)voiceEvent02, 0); }
  public static void AddCostumeId03(FlatBufferBuilder builder, long costumeId03) { builder.AddLong(11, costumeId03, 0); }
  public static void AddPositionIndex03(FlatBufferBuilder builder, int positionIndex03) { builder.AddInt(12, positionIndex03, 0); }
  public static void AddVictoryStartAnimationPath03(FlatBufferBuilder builder, StringOffset victoryStartAnimationPath03Offset) { builder.AddOffset(13, victoryStartAnimationPath03Offset.Value, 0); }
  public static void AddVictoryEndAnimationPath03(FlatBufferBuilder builder, StringOffset victoryEndAnimationPath03Offset) { builder.AddOffset(14, victoryEndAnimationPath03Offset.Value, 0); }
  public static void AddVoiceEvent03(FlatBufferBuilder builder, Plana.FlatData.VoiceEvent voiceEvent03) { builder.AddInt(15, (int)voiceEvent03, 0); }
  public static void AddCostumeId04(FlatBufferBuilder builder, long costumeId04) { builder.AddLong(16, costumeId04, 0); }
  public static void AddPositionIndex04(FlatBufferBuilder builder, int positionIndex04) { builder.AddInt(17, positionIndex04, 0); }
  public static void AddVictoryStartAnimationPath04(FlatBufferBuilder builder, StringOffset victoryStartAnimationPath04Offset) { builder.AddOffset(18, victoryStartAnimationPath04Offset.Value, 0); }
  public static void AddVictoryEndAnimationPath04(FlatBufferBuilder builder, StringOffset victoryEndAnimationPath04Offset) { builder.AddOffset(19, victoryEndAnimationPath04Offset.Value, 0); }
  public static void AddVoiceEvent04(FlatBufferBuilder builder, Plana.FlatData.VoiceEvent voiceEvent04) { builder.AddInt(20, (int)voiceEvent04, 0); }
  public static void AddCostumeId05(FlatBufferBuilder builder, long costumeId05) { builder.AddLong(21, costumeId05, 0); }
  public static void AddPositionIndex05(FlatBufferBuilder builder, int positionIndex05) { builder.AddInt(22, positionIndex05, 0); }
  public static void AddVictoryStartAnimationPath05(FlatBufferBuilder builder, StringOffset victoryStartAnimationPath05Offset) { builder.AddOffset(23, victoryStartAnimationPath05Offset.Value, 0); }
  public static void AddVictoryEndAnimationPath05(FlatBufferBuilder builder, StringOffset victoryEndAnimationPath05Offset) { builder.AddOffset(24, victoryEndAnimationPath05Offset.Value, 0); }
  public static void AddVoiceEvent05(FlatBufferBuilder builder, Plana.FlatData.VoiceEvent voiceEvent05) { builder.AddInt(25, (int)voiceEvent05, 0); }
  public static void AddCostumeId06(FlatBufferBuilder builder, long costumeId06) { builder.AddLong(26, costumeId06, 0); }
  public static void AddPositionIndex06(FlatBufferBuilder builder, int positionIndex06) { builder.AddInt(27, positionIndex06, 0); }
  public static void AddVictoryStartAnimationPath06(FlatBufferBuilder builder, StringOffset victoryStartAnimationPath06Offset) { builder.AddOffset(28, victoryStartAnimationPath06Offset.Value, 0); }
  public static void AddVictoryEndAnimationPath06(FlatBufferBuilder builder, StringOffset victoryEndAnimationPath06Offset) { builder.AddOffset(29, victoryEndAnimationPath06Offset.Value, 0); }
  public static void AddVoiceEvent06(FlatBufferBuilder builder, Plana.FlatData.VoiceEvent voiceEvent06) { builder.AddInt(30, (int)voiceEvent06, 0); }
  public static Offset<Plana.FlatData.CharacterVictoryInteractionExcel> EndCharacterVictoryInteractionExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.CharacterVictoryInteractionExcel>(o);
  }
  public CharacterVictoryInteractionExcelT UnPack() {
    var _o = new CharacterVictoryInteractionExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CharacterVictoryInteractionExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("CharacterVictoryInteraction");
    _o.InteractionId = TableEncryptionService.Convert(this.InteractionId, key);
    _o.CostumeId01 = TableEncryptionService.Convert(this.CostumeId01, key);
    _o.PositionIndex01 = TableEncryptionService.Convert(this.PositionIndex01, key);
    _o.VictoryStartAnimationPath01 = TableEncryptionService.Convert(this.VictoryStartAnimationPath01, key);
    _o.VictoryEndAnimationPath01 = TableEncryptionService.Convert(this.VictoryEndAnimationPath01, key);
    _o.VoiceEvent01 = TableEncryptionService.Convert(this.VoiceEvent01, key);
    _o.CostumeId02 = TableEncryptionService.Convert(this.CostumeId02, key);
    _o.PositionIndex02 = TableEncryptionService.Convert(this.PositionIndex02, key);
    _o.VictoryStartAnimationPath02 = TableEncryptionService.Convert(this.VictoryStartAnimationPath02, key);
    _o.VictoryEndAnimationPath02 = TableEncryptionService.Convert(this.VictoryEndAnimationPath02, key);
    _o.VoiceEvent02 = TableEncryptionService.Convert(this.VoiceEvent02, key);
    _o.CostumeId03 = TableEncryptionService.Convert(this.CostumeId03, key);
    _o.PositionIndex03 = TableEncryptionService.Convert(this.PositionIndex03, key);
    _o.VictoryStartAnimationPath03 = TableEncryptionService.Convert(this.VictoryStartAnimationPath03, key);
    _o.VictoryEndAnimationPath03 = TableEncryptionService.Convert(this.VictoryEndAnimationPath03, key);
    _o.VoiceEvent03 = TableEncryptionService.Convert(this.VoiceEvent03, key);
    _o.CostumeId04 = TableEncryptionService.Convert(this.CostumeId04, key);
    _o.PositionIndex04 = TableEncryptionService.Convert(this.PositionIndex04, key);
    _o.VictoryStartAnimationPath04 = TableEncryptionService.Convert(this.VictoryStartAnimationPath04, key);
    _o.VictoryEndAnimationPath04 = TableEncryptionService.Convert(this.VictoryEndAnimationPath04, key);
    _o.VoiceEvent04 = TableEncryptionService.Convert(this.VoiceEvent04, key);
    _o.CostumeId05 = TableEncryptionService.Convert(this.CostumeId05, key);
    _o.PositionIndex05 = TableEncryptionService.Convert(this.PositionIndex05, key);
    _o.VictoryStartAnimationPath05 = TableEncryptionService.Convert(this.VictoryStartAnimationPath05, key);
    _o.VictoryEndAnimationPath05 = TableEncryptionService.Convert(this.VictoryEndAnimationPath05, key);
    _o.VoiceEvent05 = TableEncryptionService.Convert(this.VoiceEvent05, key);
    _o.CostumeId06 = TableEncryptionService.Convert(this.CostumeId06, key);
    _o.PositionIndex06 = TableEncryptionService.Convert(this.PositionIndex06, key);
    _o.VictoryStartAnimationPath06 = TableEncryptionService.Convert(this.VictoryStartAnimationPath06, key);
    _o.VictoryEndAnimationPath06 = TableEncryptionService.Convert(this.VictoryEndAnimationPath06, key);
    _o.VoiceEvent06 = TableEncryptionService.Convert(this.VoiceEvent06, key);
  }
  public static Offset<Plana.FlatData.CharacterVictoryInteractionExcel> Pack(FlatBufferBuilder builder, CharacterVictoryInteractionExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.CharacterVictoryInteractionExcel>);
    var _VictoryStartAnimationPath01 = _o.VictoryStartAnimationPath01 == null ? default(StringOffset) : builder.CreateString(_o.VictoryStartAnimationPath01);
    var _VictoryEndAnimationPath01 = _o.VictoryEndAnimationPath01 == null ? default(StringOffset) : builder.CreateString(_o.VictoryEndAnimationPath01);
    var _VictoryStartAnimationPath02 = _o.VictoryStartAnimationPath02 == null ? default(StringOffset) : builder.CreateString(_o.VictoryStartAnimationPath02);
    var _VictoryEndAnimationPath02 = _o.VictoryEndAnimationPath02 == null ? default(StringOffset) : builder.CreateString(_o.VictoryEndAnimationPath02);
    var _VictoryStartAnimationPath03 = _o.VictoryStartAnimationPath03 == null ? default(StringOffset) : builder.CreateString(_o.VictoryStartAnimationPath03);
    var _VictoryEndAnimationPath03 = _o.VictoryEndAnimationPath03 == null ? default(StringOffset) : builder.CreateString(_o.VictoryEndAnimationPath03);
    var _VictoryStartAnimationPath04 = _o.VictoryStartAnimationPath04 == null ? default(StringOffset) : builder.CreateString(_o.VictoryStartAnimationPath04);
    var _VictoryEndAnimationPath04 = _o.VictoryEndAnimationPath04 == null ? default(StringOffset) : builder.CreateString(_o.VictoryEndAnimationPath04);
    var _VictoryStartAnimationPath05 = _o.VictoryStartAnimationPath05 == null ? default(StringOffset) : builder.CreateString(_o.VictoryStartAnimationPath05);
    var _VictoryEndAnimationPath05 = _o.VictoryEndAnimationPath05 == null ? default(StringOffset) : builder.CreateString(_o.VictoryEndAnimationPath05);
    var _VictoryStartAnimationPath06 = _o.VictoryStartAnimationPath06 == null ? default(StringOffset) : builder.CreateString(_o.VictoryStartAnimationPath06);
    var _VictoryEndAnimationPath06 = _o.VictoryEndAnimationPath06 == null ? default(StringOffset) : builder.CreateString(_o.VictoryEndAnimationPath06);
    return CreateCharacterVictoryInteractionExcel(
      builder,
      _o.InteractionId,
      _o.CostumeId01,
      _o.PositionIndex01,
      _VictoryStartAnimationPath01,
      _VictoryEndAnimationPath01,
      _o.VoiceEvent01,
      _o.CostumeId02,
      _o.PositionIndex02,
      _VictoryStartAnimationPath02,
      _VictoryEndAnimationPath02,
      _o.VoiceEvent02,
      _o.CostumeId03,
      _o.PositionIndex03,
      _VictoryStartAnimationPath03,
      _VictoryEndAnimationPath03,
      _o.VoiceEvent03,
      _o.CostumeId04,
      _o.PositionIndex04,
      _VictoryStartAnimationPath04,
      _VictoryEndAnimationPath04,
      _o.VoiceEvent04,
      _o.CostumeId05,
      _o.PositionIndex05,
      _VictoryStartAnimationPath05,
      _VictoryEndAnimationPath05,
      _o.VoiceEvent05,
      _o.CostumeId06,
      _o.PositionIndex06,
      _VictoryStartAnimationPath06,
      _VictoryEndAnimationPath06,
      _o.VoiceEvent06);
  }
}

public class CharacterVictoryInteractionExcelT
{
  public long InteractionId { get; set; }
  public long CostumeId01 { get; set; }
  public int PositionIndex01 { get; set; }
  public string VictoryStartAnimationPath01 { get; set; }
  public string VictoryEndAnimationPath01 { get; set; }
  public Plana.FlatData.VoiceEvent VoiceEvent01 { get; set; }
  public long CostumeId02 { get; set; }
  public int PositionIndex02 { get; set; }
  public string VictoryStartAnimationPath02 { get; set; }
  public string VictoryEndAnimationPath02 { get; set; }
  public Plana.FlatData.VoiceEvent VoiceEvent02 { get; set; }
  public long CostumeId03 { get; set; }
  public int PositionIndex03 { get; set; }
  public string VictoryStartAnimationPath03 { get; set; }
  public string VictoryEndAnimationPath03 { get; set; }
  public Plana.FlatData.VoiceEvent VoiceEvent03 { get; set; }
  public long CostumeId04 { get; set; }
  public int PositionIndex04 { get; set; }
  public string VictoryStartAnimationPath04 { get; set; }
  public string VictoryEndAnimationPath04 { get; set; }
  public Plana.FlatData.VoiceEvent VoiceEvent04 { get; set; }
  public long CostumeId05 { get; set; }
  public int PositionIndex05 { get; set; }
  public string VictoryStartAnimationPath05 { get; set; }
  public string VictoryEndAnimationPath05 { get; set; }
  public Plana.FlatData.VoiceEvent VoiceEvent05 { get; set; }
  public long CostumeId06 { get; set; }
  public int PositionIndex06 { get; set; }
  public string VictoryStartAnimationPath06 { get; set; }
  public string VictoryEndAnimationPath06 { get; set; }
  public Plana.FlatData.VoiceEvent VoiceEvent06 { get; set; }

  public CharacterVictoryInteractionExcelT() {
    this.InteractionId = 0;
    this.CostumeId01 = 0;
    this.PositionIndex01 = 0;
    this.VictoryStartAnimationPath01 = null;
    this.VictoryEndAnimationPath01 = null;
    this.VoiceEvent01 = Plana.FlatData.VoiceEvent.OnTSA;
    this.CostumeId02 = 0;
    this.PositionIndex02 = 0;
    this.VictoryStartAnimationPath02 = null;
    this.VictoryEndAnimationPath02 = null;
    this.VoiceEvent02 = Plana.FlatData.VoiceEvent.OnTSA;
    this.CostumeId03 = 0;
    this.PositionIndex03 = 0;
    this.VictoryStartAnimationPath03 = null;
    this.VictoryEndAnimationPath03 = null;
    this.VoiceEvent03 = Plana.FlatData.VoiceEvent.OnTSA;
    this.CostumeId04 = 0;
    this.PositionIndex04 = 0;
    this.VictoryStartAnimationPath04 = null;
    this.VictoryEndAnimationPath04 = null;
    this.VoiceEvent04 = Plana.FlatData.VoiceEvent.OnTSA;
    this.CostumeId05 = 0;
    this.PositionIndex05 = 0;
    this.VictoryStartAnimationPath05 = null;
    this.VictoryEndAnimationPath05 = null;
    this.VoiceEvent05 = Plana.FlatData.VoiceEvent.OnTSA;
    this.CostumeId06 = 0;
    this.PositionIndex06 = 0;
    this.VictoryStartAnimationPath06 = null;
    this.VictoryEndAnimationPath06 = null;
    this.VoiceEvent06 = Plana.FlatData.VoiceEvent.OnTSA;
  }
}


static public class CharacterVictoryInteractionExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*InteractionId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*CostumeId01*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*PositionIndex01*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 10 /*VictoryStartAnimationPath01*/, false)
      && verifier.VerifyString(tablePos, 12 /*VictoryEndAnimationPath01*/, false)
      && verifier.VerifyField(tablePos, 14 /*VoiceEvent01*/, 4 /*Plana.FlatData.VoiceEvent*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*CostumeId02*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*PositionIndex02*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 20 /*VictoryStartAnimationPath02*/, false)
      && verifier.VerifyString(tablePos, 22 /*VictoryEndAnimationPath02*/, false)
      && verifier.VerifyField(tablePos, 24 /*VoiceEvent02*/, 4 /*Plana.FlatData.VoiceEvent*/, 4, false)
      && verifier.VerifyField(tablePos, 26 /*CostumeId03*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 28 /*PositionIndex03*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 30 /*VictoryStartAnimationPath03*/, false)
      && verifier.VerifyString(tablePos, 32 /*VictoryEndAnimationPath03*/, false)
      && verifier.VerifyField(tablePos, 34 /*VoiceEvent03*/, 4 /*Plana.FlatData.VoiceEvent*/, 4, false)
      && verifier.VerifyField(tablePos, 36 /*CostumeId04*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 38 /*PositionIndex04*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 40 /*VictoryStartAnimationPath04*/, false)
      && verifier.VerifyString(tablePos, 42 /*VictoryEndAnimationPath04*/, false)
      && verifier.VerifyField(tablePos, 44 /*VoiceEvent04*/, 4 /*Plana.FlatData.VoiceEvent*/, 4, false)
      && verifier.VerifyField(tablePos, 46 /*CostumeId05*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 48 /*PositionIndex05*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 50 /*VictoryStartAnimationPath05*/, false)
      && verifier.VerifyString(tablePos, 52 /*VictoryEndAnimationPath05*/, false)
      && verifier.VerifyField(tablePos, 54 /*VoiceEvent05*/, 4 /*Plana.FlatData.VoiceEvent*/, 4, false)
      && verifier.VerifyField(tablePos, 56 /*CostumeId06*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 58 /*PositionIndex06*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 60 /*VictoryStartAnimationPath06*/, false)
      && verifier.VerifyString(tablePos, 62 /*VictoryEndAnimationPath06*/, false)
      && verifier.VerifyField(tablePos, 64 /*VoiceEvent06*/, 4 /*Plana.FlatData.VoiceEvent*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
