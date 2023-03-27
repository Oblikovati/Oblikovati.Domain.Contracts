using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IContentTableColumn
{

    string DisplayHeading { get; set; }
    ValueTypeEnum DataType { get; }
    object Expression { get; set; }
    bool HasPropertyMap { get; }
    bool IsInvProperty { get; }
    string InternalName { get; }
    IContentFamily Parent { get; }
    object Units { get; set; }
    int KeyColumnOrder { get; set; }
    void GetPropertyMap(out string PropertySetId, out string PropertyIdentifier);
    void SetPropertyMap(string PropertySetId, object PropertyIdentifier);
    void ClearPropertyMap();
}
