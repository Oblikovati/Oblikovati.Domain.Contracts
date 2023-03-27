namespace Oblikovati.Domain.Contracts;

public interface IBIMComponentProperty
{

    IBIMComponentPropertySet Parent { get; }
    string InternalName { get; }
    string Name { get; }
    string Value { get; set; }
}
