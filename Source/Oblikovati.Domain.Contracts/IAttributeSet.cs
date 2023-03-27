using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IAttributeSet : IList<IAttributeSet>
{

    string Name { get; set; }
    int Count { get; }
    IAttribute Item { get; }
    bool CopyWithOwner { get; set; }
    bool Copy { get; set; }
    bool NameIsUsed { get; }
    IDataIO DataIO { get; }
    bool Transient { get; }
    IEnumerator GetEnumerator();
    IAttribute Add(string AttributeName, ValueTypeEnum ValueType, object Value);
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    IAttributeSet CopyTo(bool ReplaceExisting);
    IAttributesEnumerator AddAttributes(List<string> AttributeNames, List<ValueTypeEnum> ValueTypes, List<object> Values, bool ReplaceExisting);
}
