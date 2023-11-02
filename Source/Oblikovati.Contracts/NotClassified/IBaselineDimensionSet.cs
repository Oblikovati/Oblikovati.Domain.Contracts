using Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;
using Oblikovati.Contracts.Application.Documents.DrawingDocument.Sheets.DrawingDimensions;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

public interface IBaselineDimensionSet
{
    ISheet Parent { get; }
    IAttributeSets AttributeSets { get; }
    DimensionTypeEnum DimensionType { get; }
    ILayer Layer { get; set; }
    IGeneralDimensionsEnumerator Members { get; }
    IGeometryIntent Origin { get; set; }
    int Precision { get; set; }
    IDimensionStyle Style { get; set; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    ILinearGeneralDimension AddMember(object DimensionOrGeometry);
    void ArrangeText();
    void Delete();
    void DetachMember(ILinearGeneralDimension Member);
}