using Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.DrawingDocument.Sheets.DrawingDimensions;

public interface IChainDimensionSet
{
    IAttributeSets AttributeSets { get; }
    DimensionTypeEnum DimensionType { get; }
    ILayer Layer { get; set; }
    IGeneralDimensionsEnumerator Members { get; }
    ISheet Parent { get; }
    int Precision { get; set; }
    IDimensionStyle Style { get; set; }
    bool Locked { get; set; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    IGeneralDimensionsEnumerator AddMembers(object DimensionOrGeometry);
    void Delete();
    void MergeMembers(ILinearGeneralDimension MemberOne, ILinearGeneralDimension MemberTwo);
    void Arrange(ILinearGeneralDimension BaseDimension);
}