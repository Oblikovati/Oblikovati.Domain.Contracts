namespace Oblikovati.Domain.Contracts;

public interface IIRxEnumComponentDefinitionReferences
{
    void Next(uint nCompDefDescrs, out IIRxComponentDefinitionReference ppCompDefDescrs, out uint pnCompDefDescrsFetched);
    void Skip(uint nDescrs);
    void Reset();
    void Clone(out IIRxEnumComponentDefinitionReferences ppResult);
}
