using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IColumn
{

    ICustomTable Parent { get; }
    string Title { get; set; }
    double Width { get; set; }
    HorizontalTextAlignmentEnum TitleHorizontalJustification { get; set; }
    HorizontalTextAlignmentEnum ValueHorizontalJustification { get; set; }
    string InternalTitle { get; }
    void Delete();
    void Reposition(int TargetIndex, bool InsertBefore);
}
