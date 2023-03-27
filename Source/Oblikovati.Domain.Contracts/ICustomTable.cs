using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ICustomTable
{


    IAttributeSets AttributeSets { get; }
    IColumns Columns { get; }
    IRows Rows { get; }
    IPoint2d Position { get; set; }
    string Title { get; set; }
    HeadingPlacementEnum HeadingPlacement { get; set; }
    ITableFormat OverrideFormat { get; set; }
    IBox2d RangeBox { get; }
    ILayer Layer { get; set; }
    object ReferencedDocumentDescriptor { get; }
    bool ShowTitle { get; set; }
    TableSourceTypeEnum TableSource { get; }
    double Rotation { get; set; }
    ITextStyle TitleTextStyle { get; set; }
    ITextStyle ColumnHeaderTextStyle { get; set; }
    ITextStyle DataTextStyle { get; set; }
    double RowGap { get; }
    LineSpacingEnum RowLineSpacing { get; set; }
    bool WrapAutomatically { get; set; }
    bool WrapLeft { get; set; }
    int MaximumRows { get; set; }
    int NumberOfSections { get; set; }
    TableDirectionEnum TableDirection { get; set; }
    bool BendDirectionReversed { get; set; }
    ITableStyle Style { get; set; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void AddLink(string FullFileName);
    void Renumber();
    void Sort(string PrimaryColumnTitle, bool PrimaryColumnAscending, string SecondaryColumnTitle, bool SecondaryColumnAscending, string TertiaryColumnTitle, bool TertiaryColumnAscending);
    void Export(string FileName, FileFormatEnum FileFormat, object Options);
    void Update();
    ICustomTable CopyTo(ISheet TargetSheet);
}
