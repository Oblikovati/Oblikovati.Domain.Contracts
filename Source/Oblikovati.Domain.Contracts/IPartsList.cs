using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPartsList
{

    IAttributeSets AttributeSets { get; }
    ISheet Parent { get; }
    IPartsListColumns PartsListColumns { get; }
    IPartsListRows PartsListRows { get; }
    string Title { get; set; }
    bool ShowTitle { get; set; }
    IDrawingView ParentView { get; }
    IPoint2d Position { get; set; }
    bool WrapLeft { get; set; }
    LineSpacingEnum RowLineSpacing { get; set; }
    TableDirectionEnum TableDirection { get; set; }
    HeadingPlacementEnum HeadingPlacement { get; set; }
    PartsListLevelEnum Level { get; }
    int NumberOfSections { get; set; }
    bool WrapAutomatically { get; set; }
    double RowGap { get; }
    ILayer Layer { get; set; }
    bool Converted { get; set; }
    IDocumentDescriptor ReferencedDocumentDescriptor { get; }
    int MaximumRows { get; set; }
    NumberingSchemeEnum NumberingScheme { get; }
    List<string> MembersToInclude { get; set; }
    bool HideZeroQuantityRows { get; set; }
    ITextStyle TitleTextStyle { get; set; }
    ITextStyle ColumnHeaderTextStyle { get; set; }
    ITextStyle DataTextStyle { get; set; }
    double Rotation { get; set; }
    IBox2d RangeBox { get; }
    IPartsListStyle Style { get; set; }
    IReferencedFileDescriptor ReferencedFile { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
    void Export(string FileName, PartsListFileFormatEnum FileFormat, object Options);
    void Update();
    void Renumber();
    void Sort(string PrimaryColumnTitle, bool PrimaryColumnAscending, string SecondaryColumnTitle, bool SecondaryColumnAscending, string TertiaryColumnTitle, bool TertiaryColumnAscending);
    void SaveItemOverridesToBOM();
    IPartsList CopyTo(ISheet TargetSheet);
    void Sort2(string PrimaryColumnTitle, bool PrimaryColumnAscending, string SecondaryColumnTitle, bool SecondaryColumnAscending, string TertiaryColumnTitle, bool TertiaryColumnAscending, bool SortByString, bool AutoSortOnUpdate);
}
