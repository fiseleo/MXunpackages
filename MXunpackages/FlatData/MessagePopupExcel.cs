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

public struct MessagePopupExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static MessagePopupExcel GetRootAsMessagePopupExcel(ByteBuffer _bb) { return GetRootAsMessagePopupExcel(_bb, new MessagePopupExcel()); }
  public static MessagePopupExcel GetRootAsMessagePopupExcel(ByteBuffer _bb, MessagePopupExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MessagePopupExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint StringId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public Plana.FlatData.MessagePopupLayout MessagePopupLayout_ { get { int o = __p.__offset(6); return o != 0 ? (Plana.FlatData.MessagePopupLayout)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.MessagePopupLayout.TextOnly; } }
  public Plana.FlatData.MessagePopupImagePositionType OrderType { get { int o = __p.__offset(8); return o != 0 ? (Plana.FlatData.MessagePopupImagePositionType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.MessagePopupImagePositionType.ImageFirst; } }
  public string Image { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetImageBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetImageBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetImageArray() { return __p.__vector_as_array<byte>(10); }
  public uint TitleText { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint SubTitleText { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint MessageText { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint ConditionText(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetUint(__p.__vector(o) + j * 4) : (uint)0; }
  public int ConditionTextLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<uint> GetConditionTextBytes() { return __p.__vector_as_span<uint>(18, 4); }
#else
  public ArraySegment<byte>? GetConditionTextBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public uint[] GetConditionTextArray() { return __p.__vector_as_array<uint>(18); }
  public bool DisplayXButton { get { int o = __p.__offset(20); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public Plana.FlatData.MessagePopupButtonType Button(int j) { int o = __p.__offset(22); return o != 0 ? (Plana.FlatData.MessagePopupButtonType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (Plana.FlatData.MessagePopupButtonType)0; }
  public int ButtonLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<Plana.FlatData.MessagePopupButtonType> GetButtonBytes() { return __p.__vector_as_span<Plana.FlatData.MessagePopupButtonType>(22, 4); }
#else
  public ArraySegment<byte>? GetButtonBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public Plana.FlatData.MessagePopupButtonType[] GetButtonArray() { int o = __p.__offset(22); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); Plana.FlatData.MessagePopupButtonType[] a = new Plana.FlatData.MessagePopupButtonType[l]; for (int i = 0; i < l; i++) { a[i] = (Plana.FlatData.MessagePopupButtonType)__p.bb.GetInt(p + i * 4); } return a; }
  public uint ButtonText(int j) { int o = __p.__offset(24); return o != 0 ? __p.bb.GetUint(__p.__vector(o) + j * 4) : (uint)0; }
  public int ButtonTextLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<uint> GetButtonTextBytes() { return __p.__vector_as_span<uint>(24, 4); }
#else
  public ArraySegment<byte>? GetButtonTextBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public uint[] GetButtonTextArray() { return __p.__vector_as_array<uint>(24); }
  public string ButtonCommand(int j) { int o = __p.__offset(26); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int ButtonCommandLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string ButtonParameter(int j) { int o = __p.__offset(28); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int ButtonParameterLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<Plana.FlatData.MessagePopupExcel> CreateMessagePopupExcel(FlatBufferBuilder builder,
      uint StringId = 0,
      Plana.FlatData.MessagePopupLayout MessagePopupLayout_ = Plana.FlatData.MessagePopupLayout.TextOnly,
      Plana.FlatData.MessagePopupImagePositionType OrderType = Plana.FlatData.MessagePopupImagePositionType.ImageFirst,
      StringOffset ImageOffset = default(StringOffset),
      uint TitleText = 0,
      uint SubTitleText = 0,
      uint MessageText = 0,
      VectorOffset ConditionTextOffset = default(VectorOffset),
      bool DisplayXButton = false,
      VectorOffset ButtonOffset = default(VectorOffset),
      VectorOffset ButtonTextOffset = default(VectorOffset),
      VectorOffset ButtonCommandOffset = default(VectorOffset),
      VectorOffset ButtonParameterOffset = default(VectorOffset)) {
    builder.StartTable(13);
    MessagePopupExcel.AddButtonParameter(builder, ButtonParameterOffset);
    MessagePopupExcel.AddButtonCommand(builder, ButtonCommandOffset);
    MessagePopupExcel.AddButtonText(builder, ButtonTextOffset);
    MessagePopupExcel.AddButton(builder, ButtonOffset);
    MessagePopupExcel.AddConditionText(builder, ConditionTextOffset);
    MessagePopupExcel.AddMessageText(builder, MessageText);
    MessagePopupExcel.AddSubTitleText(builder, SubTitleText);
    MessagePopupExcel.AddTitleText(builder, TitleText);
    MessagePopupExcel.AddImage(builder, ImageOffset);
    MessagePopupExcel.AddOrderType(builder, OrderType);
    MessagePopupExcel.AddMessagePopupLayout_(builder, MessagePopupLayout_);
    MessagePopupExcel.AddStringId(builder, StringId);
    MessagePopupExcel.AddDisplayXButton(builder, DisplayXButton);
    return MessagePopupExcel.EndMessagePopupExcel(builder);
  }

  public static void StartMessagePopupExcel(FlatBufferBuilder builder) { builder.StartTable(13); }
  public static void AddStringId(FlatBufferBuilder builder, uint stringId) { builder.AddUint(0, stringId, 0); }
  public static void AddMessagePopupLayout_(FlatBufferBuilder builder, Plana.FlatData.MessagePopupLayout messagePopupLayout_) { builder.AddInt(1, (int)messagePopupLayout_, 0); }
  public static void AddOrderType(FlatBufferBuilder builder, Plana.FlatData.MessagePopupImagePositionType orderType) { builder.AddInt(2, (int)orderType, 0); }
  public static void AddImage(FlatBufferBuilder builder, StringOffset imageOffset) { builder.AddOffset(3, imageOffset.Value, 0); }
  public static void AddTitleText(FlatBufferBuilder builder, uint titleText) { builder.AddUint(4, titleText, 0); }
  public static void AddSubTitleText(FlatBufferBuilder builder, uint subTitleText) { builder.AddUint(5, subTitleText, 0); }
  public static void AddMessageText(FlatBufferBuilder builder, uint messageText) { builder.AddUint(6, messageText, 0); }
  public static void AddConditionText(FlatBufferBuilder builder, VectorOffset conditionTextOffset) { builder.AddOffset(7, conditionTextOffset.Value, 0); }
  public static VectorOffset CreateConditionTextVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConditionTextVectorBlock(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionTextVectorBlock(FlatBufferBuilder builder, ArraySegment<uint> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionTextVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<uint>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConditionTextVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDisplayXButton(FlatBufferBuilder builder, bool displayXButton) { builder.AddBool(8, displayXButton, false); }
  public static void AddButton(FlatBufferBuilder builder, VectorOffset buttonOffset) { builder.AddOffset(9, buttonOffset.Value, 0); }
  public static VectorOffset CreateButtonVector(FlatBufferBuilder builder, Plana.FlatData.MessagePopupButtonType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateButtonVectorBlock(FlatBufferBuilder builder, Plana.FlatData.MessagePopupButtonType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateButtonVectorBlock(FlatBufferBuilder builder, ArraySegment<Plana.FlatData.MessagePopupButtonType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateButtonVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Plana.FlatData.MessagePopupButtonType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartButtonVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddButtonText(FlatBufferBuilder builder, VectorOffset buttonTextOffset) { builder.AddOffset(10, buttonTextOffset.Value, 0); }
  public static VectorOffset CreateButtonTextVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateButtonTextVectorBlock(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateButtonTextVectorBlock(FlatBufferBuilder builder, ArraySegment<uint> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateButtonTextVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<uint>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartButtonTextVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddButtonCommand(FlatBufferBuilder builder, VectorOffset buttonCommandOffset) { builder.AddOffset(11, buttonCommandOffset.Value, 0); }
  public static VectorOffset CreateButtonCommandVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateButtonCommandVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateButtonCommandVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateButtonCommandVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartButtonCommandVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddButtonParameter(FlatBufferBuilder builder, VectorOffset buttonParameterOffset) { builder.AddOffset(12, buttonParameterOffset.Value, 0); }
  public static VectorOffset CreateButtonParameterVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateButtonParameterVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateButtonParameterVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateButtonParameterVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartButtonParameterVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Plana.FlatData.MessagePopupExcel> EndMessagePopupExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.MessagePopupExcel>(o);
  }
  public MessagePopupExcelT UnPack() {
    var _o = new MessagePopupExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(MessagePopupExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("MessagePopup");
    _o.StringId = TableEncryptionService.Convert(this.StringId, key);
    _o.MessagePopupLayout_ = TableEncryptionService.Convert(this.MessagePopupLayout_, key);
    _o.OrderType = TableEncryptionService.Convert(this.OrderType, key);
    _o.Image = TableEncryptionService.Convert(this.Image, key);
    _o.TitleText = TableEncryptionService.Convert(this.TitleText, key);
    _o.SubTitleText = TableEncryptionService.Convert(this.SubTitleText, key);
    _o.MessageText = TableEncryptionService.Convert(this.MessageText, key);
    _o.ConditionText = new List<uint>();
    for (var _j = 0; _j < this.ConditionTextLength; ++_j) {_o.ConditionText.Add(TableEncryptionService.Convert(this.ConditionText(_j), key));}
    _o.DisplayXButton = TableEncryptionService.Convert(this.DisplayXButton, key);
    _o.Button = new List<Plana.FlatData.MessagePopupButtonType>();
    for (var _j = 0; _j < this.ButtonLength; ++_j) {_o.Button.Add(TableEncryptionService.Convert(this.Button(_j), key));}
    _o.ButtonText = new List<uint>();
    for (var _j = 0; _j < this.ButtonTextLength; ++_j) {_o.ButtonText.Add(TableEncryptionService.Convert(this.ButtonText(_j), key));}
    _o.ButtonCommand = new List<string>();
    for (var _j = 0; _j < this.ButtonCommandLength; ++_j) {_o.ButtonCommand.Add(TableEncryptionService.Convert(this.ButtonCommand(_j), key));}
    _o.ButtonParameter = new List<string>();
    for (var _j = 0; _j < this.ButtonParameterLength; ++_j) {_o.ButtonParameter.Add(TableEncryptionService.Convert(this.ButtonParameter(_j), key));}
  }
  public static Offset<Plana.FlatData.MessagePopupExcel> Pack(FlatBufferBuilder builder, MessagePopupExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.MessagePopupExcel>);
    var _Image = _o.Image == null ? default(StringOffset) : builder.CreateString(_o.Image);
    var _ConditionText = default(VectorOffset);
    if (_o.ConditionText != null) {
      var __ConditionText = _o.ConditionText.ToArray();
      _ConditionText = CreateConditionTextVector(builder, __ConditionText);
    }
    var _Button = default(VectorOffset);
    if (_o.Button != null) {
      var __Button = _o.Button.ToArray();
      _Button = CreateButtonVector(builder, __Button);
    }
    var _ButtonText = default(VectorOffset);
    if (_o.ButtonText != null) {
      var __ButtonText = _o.ButtonText.ToArray();
      _ButtonText = CreateButtonTextVector(builder, __ButtonText);
    }
    var _ButtonCommand = default(VectorOffset);
    if (_o.ButtonCommand != null) {
      var __ButtonCommand = new StringOffset[_o.ButtonCommand.Count];
      for (var _j = 0; _j < __ButtonCommand.Length; ++_j) { __ButtonCommand[_j] = builder.CreateString(_o.ButtonCommand[_j]); }
      _ButtonCommand = CreateButtonCommandVector(builder, __ButtonCommand);
    }
    var _ButtonParameter = default(VectorOffset);
    if (_o.ButtonParameter != null) {
      var __ButtonParameter = new StringOffset[_o.ButtonParameter.Count];
      for (var _j = 0; _j < __ButtonParameter.Length; ++_j) { __ButtonParameter[_j] = builder.CreateString(_o.ButtonParameter[_j]); }
      _ButtonParameter = CreateButtonParameterVector(builder, __ButtonParameter);
    }
    return CreateMessagePopupExcel(
      builder,
      _o.StringId,
      _o.MessagePopupLayout_,
      _o.OrderType,
      _Image,
      _o.TitleText,
      _o.SubTitleText,
      _o.MessageText,
      _ConditionText,
      _o.DisplayXButton,
      _Button,
      _ButtonText,
      _ButtonCommand,
      _ButtonParameter);
  }
}

public class MessagePopupExcelT
{
  public uint StringId { get; set; }
  public Plana.FlatData.MessagePopupLayout MessagePopupLayout_ { get; set; }
  public Plana.FlatData.MessagePopupImagePositionType OrderType { get; set; }
  public string Image { get; set; }
  public uint TitleText { get; set; }
  public uint SubTitleText { get; set; }
  public uint MessageText { get; set; }
  public List<uint> ConditionText { get; set; }
  public bool DisplayXButton { get; set; }
  public List<Plana.FlatData.MessagePopupButtonType> Button { get; set; }
  public List<uint> ButtonText { get; set; }
  public List<string> ButtonCommand { get; set; }
  public List<string> ButtonParameter { get; set; }

  public MessagePopupExcelT() {
    this.StringId = 0;
    this.MessagePopupLayout_ = Plana.FlatData.MessagePopupLayout.TextOnly;
    this.OrderType = Plana.FlatData.MessagePopupImagePositionType.ImageFirst;
    this.Image = null;
    this.TitleText = 0;
    this.SubTitleText = 0;
    this.MessageText = 0;
    this.ConditionText = null;
    this.DisplayXButton = false;
    this.Button = null;
    this.ButtonText = null;
    this.ButtonCommand = null;
    this.ButtonParameter = null;
  }
}


static public class MessagePopupExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*StringId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*MessagePopupLayout_*/, 4 /*Plana.FlatData.MessagePopupLayout*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*OrderType*/, 4 /*Plana.FlatData.MessagePopupImagePositionType*/, 4, false)
      && verifier.VerifyString(tablePos, 10 /*Image*/, false)
      && verifier.VerifyField(tablePos, 12 /*TitleText*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*SubTitleText*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*MessageText*/, 4 /*uint*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 18 /*ConditionText*/, 4 /*uint*/, false)
      && verifier.VerifyField(tablePos, 20 /*DisplayXButton*/, 1 /*bool*/, 1, false)
      && verifier.VerifyVectorOfData(tablePos, 22 /*Button*/, 4 /*Plana.FlatData.MessagePopupButtonType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 24 /*ButtonText*/, 4 /*uint*/, false)
      && verifier.VerifyVectorOfStrings(tablePos, 26 /*ButtonCommand*/, false)
      && verifier.VerifyVectorOfStrings(tablePos, 28 /*ButtonParameter*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
