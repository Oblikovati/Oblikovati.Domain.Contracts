using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPartsListColumn
{

    IPartsList Parent { get; }
    string Title { get; set; }
    PropertyTypeEnum PropertyType { get; }
    string CustomPropertyName { get; }
    double Width { get; set; }
    HorizontalTextAlignmentEnum TitleHorizontalJustification { get; set; }
    HorizontalTextAlignmentEnum ValueHorizontalJustification { get; set; }
    void Remove();
    void GetFilePropertyId(out string PropertySetId, out int PropId);
    void Reposition(int TargetIndex, bool InsertBefore);
}
