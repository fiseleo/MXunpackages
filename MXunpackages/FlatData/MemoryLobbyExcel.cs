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

public struct MemoryLobbyExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static MemoryLobbyExcel GetRootAsMemoryLobbyExcel(ByteBuffer _bb) { return GetRootAsMemoryLobbyExcel(_bb, new MemoryLobbyExcel()); }
  public static MemoryLobbyExcel GetRootAsMemoryLobbyExcel(ByteBuffer _bb, MemoryLobbyExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MemoryLobbyExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.ProductionStep ProductionStep_ { get { int o = __p.__offset(6); return o != 0 ? (Plana.FlatData.ProductionStep)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ProductionStep.ToDo; } }
  public uint LocalizeEtcId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public long CharacterId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string PrefabName { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPrefabNameBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetPrefabNameBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetPrefabNameArray() { return __p.__vector_as_array<byte>(12); }
  public Plana.FlatData.MemoryLobbyCategory MemoryLobbyCategory_ { get { int o = __p.__offset(14); return o != 0 ? (Plana.FlatData.MemoryLobbyCategory)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.MemoryLobbyCategory.None; } }
  public string SlotTextureName { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSlotTextureNameBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetSlotTextureNameBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetSlotTextureNameArray() { return __p.__vector_as_array<byte>(16); }
  public string RewardTextureName { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRewardTextureNameBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetRewardTextureNameBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetRewardTextureNameArray() { return __p.__vector_as_array<byte>(18); }
  public long BGMId { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string AudioClipJp { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAudioClipJpBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetAudioClipJpBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetAudioClipJpArray() { return __p.__vector_as_array<byte>(22); }
  public string AudioClipKr { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAudioClipKrBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetAudioClipKrBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetAudioClipKrArray() { return __p.__vector_as_array<byte>(24); }
  public string AudioClipTh { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAudioClipThBytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetAudioClipThBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetAudioClipThArray() { return __p.__vector_as_array<byte>(26); }
  public string AudioClipTw { get { int o = __p.__offset(28); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAudioClipTwBytes() { return __p.__vector_as_span<byte>(28, 1); }
#else
  public ArraySegment<byte>? GetAudioClipTwBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public byte[] GetAudioClipTwArray() { return __p.__vector_as_array<byte>(28); }
  public string AudioClipEn { get { int o = __p.__offset(30); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAudioClipEnBytes() { return __p.__vector_as_span<byte>(30, 1); }
#else
  public ArraySegment<byte>? GetAudioClipEnBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public byte[] GetAudioClipEnArray() { return __p.__vector_as_array<byte>(30); }

  public static Offset<Plana.FlatData.MemoryLobbyExcel> CreateMemoryLobbyExcel(FlatBufferBuilder builder,
      long Id = 0,
      Plana.FlatData.ProductionStep ProductionStep_ = Plana.FlatData.ProductionStep.ToDo,
      uint LocalizeEtcId = 0,
      long CharacterId = 0,
      StringOffset PrefabNameOffset = default(StringOffset),
      Plana.FlatData.MemoryLobbyCategory MemoryLobbyCategory_ = Plana.FlatData.MemoryLobbyCategory.None,
      StringOffset SlotTextureNameOffset = default(StringOffset),
      StringOffset RewardTextureNameOffset = default(StringOffset),
      long BGMId = 0,
      StringOffset AudioClipJpOffset = default(StringOffset),
      StringOffset AudioClipKrOffset = default(StringOffset),
      StringOffset AudioClipThOffset = default(StringOffset),
      StringOffset AudioClipTwOffset = default(StringOffset),
      StringOffset AudioClipEnOffset = default(StringOffset)) {
    builder.StartTable(14);
    MemoryLobbyExcel.AddBGMId(builder, BGMId);
    MemoryLobbyExcel.AddCharacterId(builder, CharacterId);
    MemoryLobbyExcel.AddId(builder, Id);
    MemoryLobbyExcel.AddAudioClipEn(builder, AudioClipEnOffset);
    MemoryLobbyExcel.AddAudioClipTw(builder, AudioClipTwOffset);
    MemoryLobbyExcel.AddAudioClipTh(builder, AudioClipThOffset);
    MemoryLobbyExcel.AddAudioClipKr(builder, AudioClipKrOffset);
    MemoryLobbyExcel.AddAudioClipJp(builder, AudioClipJpOffset);
    MemoryLobbyExcel.AddRewardTextureName(builder, RewardTextureNameOffset);
    MemoryLobbyExcel.AddSlotTextureName(builder, SlotTextureNameOffset);
    MemoryLobbyExcel.AddMemoryLobbyCategory_(builder, MemoryLobbyCategory_);
    MemoryLobbyExcel.AddPrefabName(builder, PrefabNameOffset);
    MemoryLobbyExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    MemoryLobbyExcel.AddProductionStep_(builder, ProductionStep_);
    return MemoryLobbyExcel.EndMemoryLobbyExcel(builder);
  }

  public static void StartMemoryLobbyExcel(FlatBufferBuilder builder) { builder.StartTable(14); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddProductionStep_(FlatBufferBuilder builder, Plana.FlatData.ProductionStep productionStep_) { builder.AddInt(1, (int)productionStep_, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint localizeEtcId) { builder.AddUint(2, localizeEtcId, 0); }
  public static void AddCharacterId(FlatBufferBuilder builder, long characterId) { builder.AddLong(3, characterId, 0); }
  public static void AddPrefabName(FlatBufferBuilder builder, StringOffset prefabNameOffset) { builder.AddOffset(4, prefabNameOffset.Value, 0); }
  public static void AddMemoryLobbyCategory_(FlatBufferBuilder builder, Plana.FlatData.MemoryLobbyCategory memoryLobbyCategory_) { builder.AddInt(5, (int)memoryLobbyCategory_, 0); }
  public static void AddSlotTextureName(FlatBufferBuilder builder, StringOffset slotTextureNameOffset) { builder.AddOffset(6, slotTextureNameOffset.Value, 0); }
  public static void AddRewardTextureName(FlatBufferBuilder builder, StringOffset rewardTextureNameOffset) { builder.AddOffset(7, rewardTextureNameOffset.Value, 0); }
  public static void AddBGMId(FlatBufferBuilder builder, long bGMId) { builder.AddLong(8, bGMId, 0); }
  public static void AddAudioClipJp(FlatBufferBuilder builder, StringOffset audioClipJpOffset) { builder.AddOffset(9, audioClipJpOffset.Value, 0); }
  public static void AddAudioClipKr(FlatBufferBuilder builder, StringOffset audioClipKrOffset) { builder.AddOffset(10, audioClipKrOffset.Value, 0); }
  public static void AddAudioClipTh(FlatBufferBuilder builder, StringOffset audioClipThOffset) { builder.AddOffset(11, audioClipThOffset.Value, 0); }
  public static void AddAudioClipTw(FlatBufferBuilder builder, StringOffset audioClipTwOffset) { builder.AddOffset(12, audioClipTwOffset.Value, 0); }
  public static void AddAudioClipEn(FlatBufferBuilder builder, StringOffset audioClipEnOffset) { builder.AddOffset(13, audioClipEnOffset.Value, 0); }
  public static Offset<Plana.FlatData.MemoryLobbyExcel> EndMemoryLobbyExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.MemoryLobbyExcel>(o);
  }
  public MemoryLobbyExcelT UnPack() {
    var _o = new MemoryLobbyExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(MemoryLobbyExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("MemoryLobby");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.ProductionStep_ = TableEncryptionService.Convert(this.ProductionStep_, key);
    _o.LocalizeEtcId = TableEncryptionService.Convert(this.LocalizeEtcId, key);
    _o.CharacterId = TableEncryptionService.Convert(this.CharacterId, key);
    _o.PrefabName = TableEncryptionService.Convert(this.PrefabName, key);
    _o.MemoryLobbyCategory_ = TableEncryptionService.Convert(this.MemoryLobbyCategory_, key);
    _o.SlotTextureName = TableEncryptionService.Convert(this.SlotTextureName, key);
    _o.RewardTextureName = TableEncryptionService.Convert(this.RewardTextureName, key);
    _o.BGMId = TableEncryptionService.Convert(this.BGMId, key);
    _o.AudioClipJp = TableEncryptionService.Convert(this.AudioClipJp, key);
    _o.AudioClipKr = TableEncryptionService.Convert(this.AudioClipKr, key);
    _o.AudioClipTh = TableEncryptionService.Convert(this.AudioClipTh, key);
    _o.AudioClipTw = TableEncryptionService.Convert(this.AudioClipTw, key);
    _o.AudioClipEn = TableEncryptionService.Convert(this.AudioClipEn, key);
  }
  public static Offset<Plana.FlatData.MemoryLobbyExcel> Pack(FlatBufferBuilder builder, MemoryLobbyExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.MemoryLobbyExcel>);
    var _PrefabName = _o.PrefabName == null ? default(StringOffset) : builder.CreateString(_o.PrefabName);
    var _SlotTextureName = _o.SlotTextureName == null ? default(StringOffset) : builder.CreateString(_o.SlotTextureName);
    var _RewardTextureName = _o.RewardTextureName == null ? default(StringOffset) : builder.CreateString(_o.RewardTextureName);
    var _AudioClipJp = _o.AudioClipJp == null ? default(StringOffset) : builder.CreateString(_o.AudioClipJp);
    var _AudioClipKr = _o.AudioClipKr == null ? default(StringOffset) : builder.CreateString(_o.AudioClipKr);
    var _AudioClipTh = _o.AudioClipTh == null ? default(StringOffset) : builder.CreateString(_o.AudioClipTh);
    var _AudioClipTw = _o.AudioClipTw == null ? default(StringOffset) : builder.CreateString(_o.AudioClipTw);
    var _AudioClipEn = _o.AudioClipEn == null ? default(StringOffset) : builder.CreateString(_o.AudioClipEn);
    return CreateMemoryLobbyExcel(
      builder,
      _o.Id,
      _o.ProductionStep_,
      _o.LocalizeEtcId,
      _o.CharacterId,
      _PrefabName,
      _o.MemoryLobbyCategory_,
      _SlotTextureName,
      _RewardTextureName,
      _o.BGMId,
      _AudioClipJp,
      _AudioClipKr,
      _AudioClipTh,
      _AudioClipTw,
      _AudioClipEn);
  }
}

public class MemoryLobbyExcelT
{
  public long Id { get; set; }
  public Plana.FlatData.ProductionStep ProductionStep_ { get; set; }
  public uint LocalizeEtcId { get; set; }
  public long CharacterId { get; set; }
  public string PrefabName { get; set; }
  public Plana.FlatData.MemoryLobbyCategory MemoryLobbyCategory_ { get; set; }
  public string SlotTextureName { get; set; }
  public string RewardTextureName { get; set; }
  public long BGMId { get; set; }
  public string AudioClipJp { get; set; }
  public string AudioClipKr { get; set; }
  public string AudioClipTh { get; set; }
  public string AudioClipTw { get; set; }
  public string AudioClipEn { get; set; }

  public MemoryLobbyExcelT() {
    this.Id = 0;
    this.ProductionStep_ = Plana.FlatData.ProductionStep.ToDo;
    this.LocalizeEtcId = 0;
    this.CharacterId = 0;
    this.PrefabName = null;
    this.MemoryLobbyCategory_ = Plana.FlatData.MemoryLobbyCategory.None;
    this.SlotTextureName = null;
    this.RewardTextureName = null;
    this.BGMId = 0;
    this.AudioClipJp = null;
    this.AudioClipKr = null;
    this.AudioClipTh = null;
    this.AudioClipTw = null;
    this.AudioClipEn = null;
  }
}


static public class MemoryLobbyExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*ProductionStep_*/, 4 /*Plana.FlatData.ProductionStep*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*LocalizeEtcId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*CharacterId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 12 /*PrefabName*/, false)
      && verifier.VerifyField(tablePos, 14 /*MemoryLobbyCategory_*/, 4 /*Plana.FlatData.MemoryLobbyCategory*/, 4, false)
      && verifier.VerifyString(tablePos, 16 /*SlotTextureName*/, false)
      && verifier.VerifyString(tablePos, 18 /*RewardTextureName*/, false)
      && verifier.VerifyField(tablePos, 20 /*BGMId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 22 /*AudioClipJp*/, false)
      && verifier.VerifyString(tablePos, 24 /*AudioClipKr*/, false)
      && verifier.VerifyString(tablePos, 26 /*AudioClipTh*/, false)
      && verifier.VerifyString(tablePos, 28 /*AudioClipTw*/, false)
      && verifier.VerifyString(tablePos, 30 /*AudioClipEn*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
