namespace Oblikovati.Domain.Contracts;

public interface IIRxPropertySet
{
    string DisplayName { get; set; }
    Guid InternalName { get; }
    int Count { get; }
    short Dirty { get; }
    IIRxProperty Create(int PropId, object PropValue, string Name);
    IIRxProperty CreateByName(object PropValue, string Name);
    void Delete();
    IIRxProperty GetByName(string Name);
    IIRxProperty GetByPropId(int PropId);
    IIRxProperty GetByIndex(int Index);
}
