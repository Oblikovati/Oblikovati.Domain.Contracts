namespace Oblikovati.Domain.Contracts;

public interface IIRxEnumComponentDocuments
{
    void Next(uint nCompDefDocs, out IIRxComponentDocument ppCompDefDocs, out uint pnCompDefDocsFetched);
    void Skip(uint nCompDefs);
    void Reset();
    void Clone(out IIRxEnumComponentDocuments ppResult);
}
