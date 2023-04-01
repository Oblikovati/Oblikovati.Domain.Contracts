using Oblikovati.Contracts.Application.Documents.DrawingDocument;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.DWG;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;

public interface ISheetFormat
{
    IDrawingDocument Parent { get; }
    string Name { get; set; }
    double Height { get; }
    double Width { get; }
    DrawingSheetSizeEnum Size { get; }
    PageOrientationTypeEnum Orientation { get; }
    TitleBlockLocationEnum TitleBlockLocation { get; }
    IAttributeSets AttributeSets { get; }
    ITitleBlockDefinition ReferencedTitleBlockDefinition { get; }
    IBorderDefinition ReferencedBorderDefinition { get; }
    IObjectsEnumerator ReferencedSymbolDefinitions { get; }
    IAutoCADBlockDefinitionsEnumerator ReferencedAutoCADBlockDefinitions { get; }
    bool HasDrawingViews { get; }
    bool FitViewsToSheet { get; }
    void Delete();
    ISheetFormat CopyTo(IDrawingDocument TargetDocument);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}