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

public struct ItemExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ItemExcel GetRootAsItemExcel(ByteBuffer _bb) { return GetRootAsItemExcel(_bb, new ItemExcel()); }
  public static ItemExcel GetRootAsItemExcel(ByteBuffer _bb, ItemExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ItemExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GroupId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.Rarity Rarity_ { get { int o = __p.__offset(8); return o != 0 ? (Plana.FlatData.Rarity)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.Rarity.N; } }
  public Plana.FlatData.ProductionStep ProductionStep_ { get { int o = __p.__offset(10); return o != 0 ? (Plana.FlatData.ProductionStep)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ProductionStep.ToDo; } }
  public uint LocalizeEtcId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public Plana.FlatData.ItemCategory ItemCategory_ { get { int o = __p.__offset(14); return o != 0 ? (Plana.FlatData.ItemCategory)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ItemCategory.Coin; } }
  public long Quality { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string Icon { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetIconBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetIconArray() { return __p.__vector_as_array<byte>(18); }
  public string SpriteName { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSpriteNameBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetSpriteNameBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetSpriteNameArray() { return __p.__vector_as_array<byte>(20); }
  public int StackableMax { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int StackableFunction { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool ImmediateUse { get { int o = __p.__offset(26); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public Plana.FlatData.ParcelType UsingResultParcelType { get { int o = __p.__offset(28); return o != 0 ? (Plana.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ParcelType.None; } }
  public long UsingResultId { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long UsingResultAmount { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.MailType MailType_ { get { int o = __p.__offset(34); return o != 0 ? (Plana.FlatData.MailType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.MailType.System; } }
  public Plana.FlatData.ParcelType ExpiryChangeParcelType { get { int o = __p.__offset(36); return o != 0 ? (Plana.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.ParcelType.None; } }
  public long ExpiryChangeId { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ExpiryChangeAmount { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool CanTierUpgrade { get { int o = __p.__offset(42); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long TierUpgradeRecipeCraftId { get { int o = __p.__offset(44); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.Tag Tags(int j) { int o = __p.__offset(46); return o != 0 ? (Plana.FlatData.Tag)__p.bb.GetInt(__p.__vector(o) + j * 4) : (Plana.FlatData.Tag)0; }
  public int TagsLength { get { int o = __p.__offset(46); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<Plana.FlatData.Tag> GetTagsBytes() { return __p.__vector_as_span<Plana.FlatData.Tag>(46, 4); }
#else
  public ArraySegment<byte>? GetTagsBytes() { return __p.__vector_as_arraysegment(46); }
#endif
  public Plana.FlatData.Tag[] GetTagsArray() { int o = __p.__offset(46); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); Plana.FlatData.Tag[] a = new Plana.FlatData.Tag[l]; for (int i = 0; i < l; i++) { a[i] = (Plana.FlatData.Tag)__p.bb.GetInt(p + i * 4); } return a; }
  public long CraftQualityTier0 { get { int o = __p.__offset(48); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CraftQualityTier1 { get { int o = __p.__offset(50); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CraftQualityTier2 { get { int o = __p.__offset(52); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ShiftingCraftQuality { get { int o = __p.__offset(54); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int MaxGiftTags { get { int o = __p.__offset(56); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public Plana.FlatData.ShopCategoryType ShopCategory(int j) { int o = __p.__offset(58); return o != 0 ? (Plana.FlatData.ShopCategoryType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (Plana.FlatData.ShopCategoryType)0; }
  public int ShopCategoryLength { get { int o = __p.__offset(58); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<Plana.FlatData.ShopCategoryType> GetShopCategoryBytes() { return __p.__vector_as_span<Plana.FlatData.ShopCategoryType>(58, 4); }
#else
  public ArraySegment<byte>? GetShopCategoryBytes() { return __p.__vector_as_arraysegment(58); }
#endif
  public Plana.FlatData.ShopCategoryType[] GetShopCategoryArray() { int o = __p.__offset(58); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); Plana.FlatData.ShopCategoryType[] a = new Plana.FlatData.ShopCategoryType[l]; for (int i = 0; i < l; i++) { a[i] = (Plana.FlatData.ShopCategoryType)__p.bb.GetInt(p + i * 4); } return a; }
  public string ExpirationDateTime { get { int o = __p.__offset(60); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetExpirationDateTimeBytes() { return __p.__vector_as_span<byte>(60, 1); }
#else
  public ArraySegment<byte>? GetExpirationDateTimeBytes() { return __p.__vector_as_arraysegment(60); }
#endif
  public byte[] GetExpirationDateTimeArray() { return __p.__vector_as_array<byte>(60); }
  public int ExpirationNotifyDateIn { get { int o = __p.__offset(62); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long ShortcutTypeId { get { int o = __p.__offset(64); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public Plana.FlatData.GachaTicketType GachaTicket { get { int o = __p.__offset(66); return o != 0 ? (Plana.FlatData.GachaTicketType)__p.bb.GetInt(o + __p.bb_pos) : Plana.FlatData.GachaTicketType.None; } }

  public static Offset<Plana.FlatData.ItemExcel> CreateItemExcel(FlatBufferBuilder builder,
      long Id = 0,
      long GroupId = 0,
      Plana.FlatData.Rarity Rarity_ = Plana.FlatData.Rarity.N,
      Plana.FlatData.ProductionStep ProductionStep_ = Plana.FlatData.ProductionStep.ToDo,
      uint LocalizeEtcId = 0,
      Plana.FlatData.ItemCategory ItemCategory_ = Plana.FlatData.ItemCategory.Coin,
      long Quality = 0,
      StringOffset IconOffset = default(StringOffset),
      StringOffset SpriteNameOffset = default(StringOffset),
      int StackableMax = 0,
      int StackableFunction = 0,
      bool ImmediateUse = false,
      Plana.FlatData.ParcelType UsingResultParcelType = Plana.FlatData.ParcelType.None,
      long UsingResultId = 0,
      long UsingResultAmount = 0,
      Plana.FlatData.MailType MailType_ = Plana.FlatData.MailType.System,
      Plana.FlatData.ParcelType ExpiryChangeParcelType = Plana.FlatData.ParcelType.None,
      long ExpiryChangeId = 0,
      long ExpiryChangeAmount = 0,
      bool CanTierUpgrade = false,
      long TierUpgradeRecipeCraftId = 0,
      VectorOffset TagsOffset = default(VectorOffset),
      long CraftQualityTier0 = 0,
      long CraftQualityTier1 = 0,
      long CraftQualityTier2 = 0,
      long ShiftingCraftQuality = 0,
      int MaxGiftTags = 0,
      VectorOffset ShopCategoryOffset = default(VectorOffset),
      StringOffset ExpirationDateTimeOffset = default(StringOffset),
      int ExpirationNotifyDateIn = 0,
      long ShortcutTypeId = 0,
      Plana.FlatData.GachaTicketType GachaTicket = Plana.FlatData.GachaTicketType.None) {
    builder.StartTable(32);
    ItemExcel.AddShortcutTypeId(builder, ShortcutTypeId);
    ItemExcel.AddShiftingCraftQuality(builder, ShiftingCraftQuality);
    ItemExcel.AddCraftQualityTier2(builder, CraftQualityTier2);
    ItemExcel.AddCraftQualityTier1(builder, CraftQualityTier1);
    ItemExcel.AddCraftQualityTier0(builder, CraftQualityTier0);
    ItemExcel.AddTierUpgradeRecipeCraftId(builder, TierUpgradeRecipeCraftId);
    ItemExcel.AddExpiryChangeAmount(builder, ExpiryChangeAmount);
    ItemExcel.AddExpiryChangeId(builder, ExpiryChangeId);
    ItemExcel.AddUsingResultAmount(builder, UsingResultAmount);
    ItemExcel.AddUsingResultId(builder, UsingResultId);
    ItemExcel.AddQuality(builder, Quality);
    ItemExcel.AddGroupId(builder, GroupId);
    ItemExcel.AddId(builder, Id);
    ItemExcel.AddGachaTicket(builder, GachaTicket);
    ItemExcel.AddExpirationNotifyDateIn(builder, ExpirationNotifyDateIn);
    ItemExcel.AddExpirationDateTime(builder, ExpirationDateTimeOffset);
    ItemExcel.AddShopCategory(builder, ShopCategoryOffset);
    ItemExcel.AddMaxGiftTags(builder, MaxGiftTags);
    ItemExcel.AddTags(builder, TagsOffset);
    ItemExcel.AddExpiryChangeParcelType(builder, ExpiryChangeParcelType);
    ItemExcel.AddMailType_(builder, MailType_);
    ItemExcel.AddUsingResultParcelType(builder, UsingResultParcelType);
    ItemExcel.AddStackableFunction(builder, StackableFunction);
    ItemExcel.AddStackableMax(builder, StackableMax);
    ItemExcel.AddSpriteName(builder, SpriteNameOffset);
    ItemExcel.AddIcon(builder, IconOffset);
    ItemExcel.AddItemCategory_(builder, ItemCategory_);
    ItemExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    ItemExcel.AddProductionStep_(builder, ProductionStep_);
    ItemExcel.AddRarity_(builder, Rarity_);
    ItemExcel.AddCanTierUpgrade(builder, CanTierUpgrade);
    ItemExcel.AddImmediateUse(builder, ImmediateUse);
    return ItemExcel.EndItemExcel(builder);
  }

  public static void StartItemExcel(FlatBufferBuilder builder) { builder.StartTable(32); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddGroupId(FlatBufferBuilder builder, long groupId) { builder.AddLong(1, groupId, 0); }
  public static void AddRarity_(FlatBufferBuilder builder, Plana.FlatData.Rarity rarity_) { builder.AddInt(2, (int)rarity_, 0); }
  public static void AddProductionStep_(FlatBufferBuilder builder, Plana.FlatData.ProductionStep productionStep_) { builder.AddInt(3, (int)productionStep_, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint localizeEtcId) { builder.AddUint(4, localizeEtcId, 0); }
  public static void AddItemCategory_(FlatBufferBuilder builder, Plana.FlatData.ItemCategory itemCategory_) { builder.AddInt(5, (int)itemCategory_, 0); }
  public static void AddQuality(FlatBufferBuilder builder, long quality) { builder.AddLong(6, quality, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset) { builder.AddOffset(7, iconOffset.Value, 0); }
  public static void AddSpriteName(FlatBufferBuilder builder, StringOffset spriteNameOffset) { builder.AddOffset(8, spriteNameOffset.Value, 0); }
  public static void AddStackableMax(FlatBufferBuilder builder, int stackableMax) { builder.AddInt(9, stackableMax, 0); }
  public static void AddStackableFunction(FlatBufferBuilder builder, int stackableFunction) { builder.AddInt(10, stackableFunction, 0); }
  public static void AddImmediateUse(FlatBufferBuilder builder, bool immediateUse) { builder.AddBool(11, immediateUse, false); }
  public static void AddUsingResultParcelType(FlatBufferBuilder builder, Plana.FlatData.ParcelType usingResultParcelType) { builder.AddInt(12, (int)usingResultParcelType, 0); }
  public static void AddUsingResultId(FlatBufferBuilder builder, long usingResultId) { builder.AddLong(13, usingResultId, 0); }
  public static void AddUsingResultAmount(FlatBufferBuilder builder, long usingResultAmount) { builder.AddLong(14, usingResultAmount, 0); }
  public static void AddMailType_(FlatBufferBuilder builder, Plana.FlatData.MailType mailType_) { builder.AddInt(15, (int)mailType_, 0); }
  public static void AddExpiryChangeParcelType(FlatBufferBuilder builder, Plana.FlatData.ParcelType expiryChangeParcelType) { builder.AddInt(16, (int)expiryChangeParcelType, 0); }
  public static void AddExpiryChangeId(FlatBufferBuilder builder, long expiryChangeId) { builder.AddLong(17, expiryChangeId, 0); }
  public static void AddExpiryChangeAmount(FlatBufferBuilder builder, long expiryChangeAmount) { builder.AddLong(18, expiryChangeAmount, 0); }
  public static void AddCanTierUpgrade(FlatBufferBuilder builder, bool canTierUpgrade) { builder.AddBool(19, canTierUpgrade, false); }
  public static void AddTierUpgradeRecipeCraftId(FlatBufferBuilder builder, long tierUpgradeRecipeCraftId) { builder.AddLong(20, tierUpgradeRecipeCraftId, 0); }
  public static void AddTags(FlatBufferBuilder builder, VectorOffset tagsOffset) { builder.AddOffset(21, tagsOffset.Value, 0); }
  public static VectorOffset CreateTagsVector(FlatBufferBuilder builder, Plana.FlatData.Tag[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, Plana.FlatData.Tag[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<Plana.FlatData.Tag> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Plana.FlatData.Tag>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartTagsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCraftQualityTier0(FlatBufferBuilder builder, long craftQualityTier0) { builder.AddLong(22, craftQualityTier0, 0); }
  public static void AddCraftQualityTier1(FlatBufferBuilder builder, long craftQualityTier1) { builder.AddLong(23, craftQualityTier1, 0); }
  public static void AddCraftQualityTier2(FlatBufferBuilder builder, long craftQualityTier2) { builder.AddLong(24, craftQualityTier2, 0); }
  public static void AddShiftingCraftQuality(FlatBufferBuilder builder, long shiftingCraftQuality) { builder.AddLong(25, shiftingCraftQuality, 0); }
  public static void AddMaxGiftTags(FlatBufferBuilder builder, int maxGiftTags) { builder.AddInt(26, maxGiftTags, 0); }
  public static void AddShopCategory(FlatBufferBuilder builder, VectorOffset shopCategoryOffset) { builder.AddOffset(27, shopCategoryOffset.Value, 0); }
  public static VectorOffset CreateShopCategoryVector(FlatBufferBuilder builder, Plana.FlatData.ShopCategoryType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateShopCategoryVectorBlock(FlatBufferBuilder builder, Plana.FlatData.ShopCategoryType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShopCategoryVectorBlock(FlatBufferBuilder builder, ArraySegment<Plana.FlatData.ShopCategoryType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShopCategoryVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Plana.FlatData.ShopCategoryType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartShopCategoryVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddExpirationDateTime(FlatBufferBuilder builder, StringOffset expirationDateTimeOffset) { builder.AddOffset(28, expirationDateTimeOffset.Value, 0); }
  public static void AddExpirationNotifyDateIn(FlatBufferBuilder builder, int expirationNotifyDateIn) { builder.AddInt(29, expirationNotifyDateIn, 0); }
  public static void AddShortcutTypeId(FlatBufferBuilder builder, long shortcutTypeId) { builder.AddLong(30, shortcutTypeId, 0); }
  public static void AddGachaTicket(FlatBufferBuilder builder, Plana.FlatData.GachaTicketType gachaTicket) { builder.AddInt(31, (int)gachaTicket, 0); }
  public static Offset<Plana.FlatData.ItemExcel> EndItemExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.ItemExcel>(o);
  }
  public ItemExcelT UnPack() {
    var _o = new ItemExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ItemExcelT _o) {
        byte[] key = TableEncryptionService.CreateKey("Item");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.GroupId = TableEncryptionService.Convert(this.GroupId, key);
    _o.Rarity_ = TableEncryptionService.Convert(this.Rarity_, key);
    _o.ProductionStep_ = TableEncryptionService.Convert(this.ProductionStep_, key);
    _o.LocalizeEtcId = TableEncryptionService.Convert(this.LocalizeEtcId, key);
    _o.ItemCategory_ = TableEncryptionService.Convert(this.ItemCategory_, key);
    _o.Quality = TableEncryptionService.Convert(this.Quality, key);
    _o.Icon = TableEncryptionService.Convert(this.Icon, key);
    _o.SpriteName = TableEncryptionService.Convert(this.SpriteName, key);
    _o.StackableMax = TableEncryptionService.Convert(this.StackableMax, key);
    _o.StackableFunction = TableEncryptionService.Convert(this.StackableFunction, key);
    _o.ImmediateUse = TableEncryptionService.Convert(this.ImmediateUse, key);
    _o.UsingResultParcelType = TableEncryptionService.Convert(this.UsingResultParcelType, key);
    _o.UsingResultId = TableEncryptionService.Convert(this.UsingResultId, key);
    _o.UsingResultAmount = TableEncryptionService.Convert(this.UsingResultAmount, key);
    _o.MailType_ = TableEncryptionService.Convert(this.MailType_, key);
    _o.ExpiryChangeParcelType = TableEncryptionService.Convert(this.ExpiryChangeParcelType, key);
    _o.ExpiryChangeId = TableEncryptionService.Convert(this.ExpiryChangeId, key);
    _o.ExpiryChangeAmount = TableEncryptionService.Convert(this.ExpiryChangeAmount, key);
    _o.CanTierUpgrade = TableEncryptionService.Convert(this.CanTierUpgrade, key);
    _o.TierUpgradeRecipeCraftId = TableEncryptionService.Convert(this.TierUpgradeRecipeCraftId, key);
    _o.Tags = new List<Plana.FlatData.Tag>();
    for (var _j = 0; _j < this.TagsLength; ++_j) {_o.Tags.Add(TableEncryptionService.Convert(this.Tags(_j), key));}
    _o.CraftQualityTier0 = TableEncryptionService.Convert(this.CraftQualityTier0, key);
    _o.CraftQualityTier1 = TableEncryptionService.Convert(this.CraftQualityTier1, key);
    _o.CraftQualityTier2 = TableEncryptionService.Convert(this.CraftQualityTier2, key);
    _o.ShiftingCraftQuality = TableEncryptionService.Convert(this.ShiftingCraftQuality, key);
    _o.MaxGiftTags = TableEncryptionService.Convert(this.MaxGiftTags, key);
    _o.ShopCategory = new List<Plana.FlatData.ShopCategoryType>();
    for (var _j = 0; _j < this.ShopCategoryLength; ++_j) {_o.ShopCategory.Add(TableEncryptionService.Convert(this.ShopCategory(_j), key));}
    _o.ExpirationDateTime = TableEncryptionService.Convert(this.ExpirationDateTime, key);
    _o.ExpirationNotifyDateIn = TableEncryptionService.Convert(this.ExpirationNotifyDateIn, key);
    _o.ShortcutTypeId = TableEncryptionService.Convert(this.ShortcutTypeId, key);
    _o.GachaTicket = TableEncryptionService.Convert(this.GachaTicket, key);
  }
  public static Offset<Plana.FlatData.ItemExcel> Pack(FlatBufferBuilder builder, ItemExcelT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.ItemExcel>);
    var _Icon = _o.Icon == null ? default(StringOffset) : builder.CreateString(_o.Icon);
    var _SpriteName = _o.SpriteName == null ? default(StringOffset) : builder.CreateString(_o.SpriteName);
    var _Tags = default(VectorOffset);
    if (_o.Tags != null) {
      var __Tags = _o.Tags.ToArray();
      _Tags = CreateTagsVector(builder, __Tags);
    }
    var _ShopCategory = default(VectorOffset);
    if (_o.ShopCategory != null) {
      var __ShopCategory = _o.ShopCategory.ToArray();
      _ShopCategory = CreateShopCategoryVector(builder, __ShopCategory);
    }
    var _ExpirationDateTime = _o.ExpirationDateTime == null ? default(StringOffset) : builder.CreateString(_o.ExpirationDateTime);
    return CreateItemExcel(
      builder,
      _o.Id,
      _o.GroupId,
      _o.Rarity_,
      _o.ProductionStep_,
      _o.LocalizeEtcId,
      _o.ItemCategory_,
      _o.Quality,
      _Icon,
      _SpriteName,
      _o.StackableMax,
      _o.StackableFunction,
      _o.ImmediateUse,
      _o.UsingResultParcelType,
      _o.UsingResultId,
      _o.UsingResultAmount,
      _o.MailType_,
      _o.ExpiryChangeParcelType,
      _o.ExpiryChangeId,
      _o.ExpiryChangeAmount,
      _o.CanTierUpgrade,
      _o.TierUpgradeRecipeCraftId,
      _Tags,
      _o.CraftQualityTier0,
      _o.CraftQualityTier1,
      _o.CraftQualityTier2,
      _o.ShiftingCraftQuality,
      _o.MaxGiftTags,
      _ShopCategory,
      _ExpirationDateTime,
      _o.ExpirationNotifyDateIn,
      _o.ShortcutTypeId,
      _o.GachaTicket);
  }
}

public class ItemExcelT
{
  public long Id { get; set; }
  public long GroupId { get; set; }
  public Plana.FlatData.Rarity Rarity_ { get; set; }
  public Plana.FlatData.ProductionStep ProductionStep_ { get; set; }
  public uint LocalizeEtcId { get; set; }
  public Plana.FlatData.ItemCategory ItemCategory_ { get; set; }
  public long Quality { get; set; }
  public string Icon { get; set; }
  public string SpriteName { get; set; }
  public int StackableMax { get; set; }
  public int StackableFunction { get; set; }
  public bool ImmediateUse { get; set; }
  public Plana.FlatData.ParcelType UsingResultParcelType { get; set; }
  public long UsingResultId { get; set; }
  public long UsingResultAmount { get; set; }
  public Plana.FlatData.MailType MailType_ { get; set; }
  public Plana.FlatData.ParcelType ExpiryChangeParcelType { get; set; }
  public long ExpiryChangeId { get; set; }
  public long ExpiryChangeAmount { get; set; }
  public bool CanTierUpgrade { get; set; }
  public long TierUpgradeRecipeCraftId { get; set; }
  public List<Plana.FlatData.Tag> Tags { get; set; }
  public long CraftQualityTier0 { get; set; }
  public long CraftQualityTier1 { get; set; }
  public long CraftQualityTier2 { get; set; }
  public long ShiftingCraftQuality { get; set; }
  public int MaxGiftTags { get; set; }
  public List<Plana.FlatData.ShopCategoryType> ShopCategory { get; set; }
  public string ExpirationDateTime { get; set; }
  public int ExpirationNotifyDateIn { get; set; }
  public long ShortcutTypeId { get; set; }
  public Plana.FlatData.GachaTicketType GachaTicket { get; set; }

  public ItemExcelT() {
    this.Id = 0;
    this.GroupId = 0;
    this.Rarity_ = Plana.FlatData.Rarity.N;
    this.ProductionStep_ = Plana.FlatData.ProductionStep.ToDo;
    this.LocalizeEtcId = 0;
    this.ItemCategory_ = Plana.FlatData.ItemCategory.Coin;
    this.Quality = 0;
    this.Icon = null;
    this.SpriteName = null;
    this.StackableMax = 0;
    this.StackableFunction = 0;
    this.ImmediateUse = false;
    this.UsingResultParcelType = Plana.FlatData.ParcelType.None;
    this.UsingResultId = 0;
    this.UsingResultAmount = 0;
    this.MailType_ = Plana.FlatData.MailType.System;
    this.ExpiryChangeParcelType = Plana.FlatData.ParcelType.None;
    this.ExpiryChangeId = 0;
    this.ExpiryChangeAmount = 0;
    this.CanTierUpgrade = false;
    this.TierUpgradeRecipeCraftId = 0;
    this.Tags = null;
    this.CraftQualityTier0 = 0;
    this.CraftQualityTier1 = 0;
    this.CraftQualityTier2 = 0;
    this.ShiftingCraftQuality = 0;
    this.MaxGiftTags = 0;
    this.ShopCategory = null;
    this.ExpirationDateTime = null;
    this.ExpirationNotifyDateIn = 0;
    this.ShortcutTypeId = 0;
    this.GachaTicket = Plana.FlatData.GachaTicketType.None;
  }
}


static public class ItemExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*GroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*Rarity_*/, 4 /*Plana.FlatData.Rarity*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*ProductionStep_*/, 4 /*Plana.FlatData.ProductionStep*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*LocalizeEtcId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*ItemCategory_*/, 4 /*Plana.FlatData.ItemCategory*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*Quality*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 18 /*Icon*/, false)
      && verifier.VerifyString(tablePos, 20 /*SpriteName*/, false)
      && verifier.VerifyField(tablePos, 22 /*StackableMax*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 24 /*StackableFunction*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 26 /*ImmediateUse*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 28 /*UsingResultParcelType*/, 4 /*Plana.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 30 /*UsingResultId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 32 /*UsingResultAmount*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 34 /*MailType_*/, 4 /*Plana.FlatData.MailType*/, 4, false)
      && verifier.VerifyField(tablePos, 36 /*ExpiryChangeParcelType*/, 4 /*Plana.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 38 /*ExpiryChangeId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 40 /*ExpiryChangeAmount*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 42 /*CanTierUpgrade*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 44 /*TierUpgradeRecipeCraftId*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 46 /*Tags*/, 4 /*Plana.FlatData.Tag*/, false)
      && verifier.VerifyField(tablePos, 48 /*CraftQualityTier0*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 50 /*CraftQualityTier1*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 52 /*CraftQualityTier2*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 54 /*ShiftingCraftQuality*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 56 /*MaxGiftTags*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 58 /*ShopCategory*/, 4 /*Plana.FlatData.ShopCategoryType*/, false)
      && verifier.VerifyString(tablePos, 60 /*ExpirationDateTime*/, false)
      && verifier.VerifyField(tablePos, 62 /*ExpirationNotifyDateIn*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 64 /*ShortcutTypeId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 66 /*GachaTicket*/, 4 /*Plana.FlatData.GachaTicketType*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
