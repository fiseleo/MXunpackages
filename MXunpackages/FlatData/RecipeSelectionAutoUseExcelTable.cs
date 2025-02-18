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

public struct RecipeSelectionAutoUseExcelTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static RecipeSelectionAutoUseExcelTable GetRootAsRecipeSelectionAutoUseExcelTable(ByteBuffer _bb) { return GetRootAsRecipeSelectionAutoUseExcelTable(_bb, new RecipeSelectionAutoUseExcelTable()); }
  public static RecipeSelectionAutoUseExcelTable GetRootAsRecipeSelectionAutoUseExcelTable(ByteBuffer _bb, RecipeSelectionAutoUseExcelTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RecipeSelectionAutoUseExcelTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Plana.FlatData.RecipeSelectionAutoUseExcel? DataList(int j) { int o = __p.__offset(4); return o != 0 ? (Plana.FlatData.RecipeSelectionAutoUseExcel?)(new Plana.FlatData.RecipeSelectionAutoUseExcel()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<Plana.FlatData.RecipeSelectionAutoUseExcelTable> CreateRecipeSelectionAutoUseExcelTable(FlatBufferBuilder builder,
      VectorOffset DataListOffset = default(VectorOffset)) {
    builder.StartTable(1);
    RecipeSelectionAutoUseExcelTable.AddDataList(builder, DataListOffset);
    return RecipeSelectionAutoUseExcelTable.EndRecipeSelectionAutoUseExcelTable(builder);
  }

  public static void StartRecipeSelectionAutoUseExcelTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset dataListOffset) { builder.AddOffset(0, dataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<Plana.FlatData.RecipeSelectionAutoUseExcel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<Plana.FlatData.RecipeSelectionAutoUseExcel>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Plana.FlatData.RecipeSelectionAutoUseExcel>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<Plana.FlatData.RecipeSelectionAutoUseExcel>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Plana.FlatData.RecipeSelectionAutoUseExcelTable> EndRecipeSelectionAutoUseExcelTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Plana.FlatData.RecipeSelectionAutoUseExcelTable>(o);
  }
  public RecipeSelectionAutoUseExcelTableT UnPack() {
    var _o = new RecipeSelectionAutoUseExcelTableT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(RecipeSelectionAutoUseExcelTableT _o) {
        byte[] key = TableEncryptionService.CreateKey("RecipeSelectionAutoUseExcel");
    _o.DataList = new List<Plana.FlatData.RecipeSelectionAutoUseExcelT>();
    for (var _j = 0; _j < this.DataListLength; ++_j) {_o.DataList.Add(this.DataList(_j).HasValue ? this.DataList(_j).Value.UnPack() : null);}
  }
  public static Offset<Plana.FlatData.RecipeSelectionAutoUseExcelTable> Pack(FlatBufferBuilder builder, RecipeSelectionAutoUseExcelTableT _o) {
    if (_o == null) return default(Offset<Plana.FlatData.RecipeSelectionAutoUseExcelTable>);
    var _DataList = default(VectorOffset);
    if (_o.DataList != null) {
      var __DataList = new Offset<Plana.FlatData.RecipeSelectionAutoUseExcel>[_o.DataList.Count];
      for (var _j = 0; _j < __DataList.Length; ++_j) { __DataList[_j] = Plana.FlatData.RecipeSelectionAutoUseExcel.Pack(builder, _o.DataList[_j]); }
      _DataList = CreateDataListVector(builder, __DataList);
    }
    return CreateRecipeSelectionAutoUseExcelTable(
      builder,
      _DataList);
  }
}

public class RecipeSelectionAutoUseExcelTableT
{
  public List<Plana.FlatData.RecipeSelectionAutoUseExcelT> DataList { get; set; }

  public RecipeSelectionAutoUseExcelTableT() {
    this.DataList = null;
  }
}


static public class RecipeSelectionAutoUseExcelTableVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfTables(tablePos, 4 /*DataList*/, Plana.FlatData.RecipeSelectionAutoUseExcelVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
