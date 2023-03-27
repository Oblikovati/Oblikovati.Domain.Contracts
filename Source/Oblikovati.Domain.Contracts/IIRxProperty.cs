namespace Oblikovati.Domain.Contracts;

public interface IIRxProperty
{
    int PropId { get; }
    string Name { get; set; }
    object Value { get; set; }
    short Dirty { get; }
    void Delete();
}
