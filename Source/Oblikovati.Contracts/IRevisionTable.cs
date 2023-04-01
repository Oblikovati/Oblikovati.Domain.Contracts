using Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IRevisionTable
{
    ISheet Parent { get; }
    IAttributeSets AttributeSets { get; }
    string Title { get; set; }
    IPoint2d Position { get; set; }
    IRevisionTableColumns RevisionTableColumns { get; }
    IRevisionTableRows RevisionTableRows { get; }
    ILayer Layer { get; set; }
    IBox2d RangeBox { get; }
    IRevisionTableStyle Style { get; set; }
    bool IsSheetScope { get; }
    ITextStyle ColumnHeaderTextStyle { get; set; }
    ITextStyle DataTextStyle { get; set; }
    double HeadingGap { get; }
    HeadingPlacementEnum HeadingPlacement { get; set; }
    int MaximumRows { get; set; }
    int NumberOfSections { get; set; }
    double Rotation { get; set; }
    double RowGap { get; }
    LineSpacingEnum RowLineSpacing { get; set; }
    bool ShowTitle { get; set; }
    TableDirectionEnum TableDirection { get; set; }
    ITextStyle TitleTextStyle { get; set; }
    bool WrapAutomatically { get; set; }
    bool WrapLeft { get; set; }
    bool UpdatePropertyToRevisionNumber { get; set; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
    void Export(string FileName, FileFormatEnum FileFormat, object Options);

    void Sort(string PrimaryColumnTitle, bool PrimaryColumnAscending, string SecondaryColumnTitle,
        bool SecondaryColumnAscending, string TertiaryColumnTitle, bool TertiaryColumnAscending);
}