using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IRevisionTableColumn
{

    IRevisionTable Parent { get; }
    string Title { get; set; }
    double Width { get; set; }
    HorizontalTextAlignmentEnum TitleHorizontalJustification { get; set; }
    HorizontalTextAlignmentEnum ValueHorizontalJustification { get; set; }
    string CustomPropertyName { get; }
    RevisionTablePropertyEnum PropertyType { get; }
    void Delete();
    void GetFilePropertyId(out string PropertySetId, out int PropId);
    void Reposition(int TargetIndex, bool InsertBefore);
}
