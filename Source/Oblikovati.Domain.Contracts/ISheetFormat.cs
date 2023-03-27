using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISheetFormat
{

    I_DrawingDocument Parent { get; }
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
    ISheetFormat CopyTo(I_DrawingDocument TargetDocument);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
