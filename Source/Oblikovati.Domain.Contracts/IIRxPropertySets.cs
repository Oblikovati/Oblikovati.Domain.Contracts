namespace Oblikovati.Domain.Contracts;

public interface IIRxPropertySets
{
    int Count { get; }
    short Dirty { get; }
    IIRxPropertySet Create(string DisplayName, Guid InternalName);
    IIRxPropertySet GetByName(string DisplayName);
    IIRxPropertySet GetByFMTID(Guid InternalName);
    IIRxPropertySet GetByIndex(int Index);
    void RefreshFromFile();
    void FlushToFile();
}
