using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Sketch2D;

namespace Oblikovati.Contracts.Attributes;

public interface IAttributeSet : IList<IAttributeSet>
{
    string Name { get; set; }

    IAttribute Item { get; }
    bool CopyWithOwner { get; set; }
    bool Copy { get; set; }
    bool NameIsUsed { get; }
    IDataIO DataIO { get; }
    bool Transient { get; }

    IAttribute Add(string AttributeName, ValueTypeEnum ValueType, object Value);
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    IAttributeSet CopyTo(bool ReplaceExisting);

    IAttributesEnumerator AddAttributes(List<string> AttributeNames, List<ValueTypeEnum> ValueTypes,
        List<object> Values, bool ReplaceExisting);
}