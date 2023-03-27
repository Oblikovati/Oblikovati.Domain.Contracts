namespace Oblikovati.Domain.Contracts;

public interface IIRxEnumComponentDefinitions
{
    void Next(uint nCompDefs, out IIRxComponentDefinition ppCompDefs, out uint pnCompDefsFetched);
    void Skip(uint nCompDefs);
    void Reset();
    void Clone(out IIRxEnumComponentDefinitions ppResult);
}
