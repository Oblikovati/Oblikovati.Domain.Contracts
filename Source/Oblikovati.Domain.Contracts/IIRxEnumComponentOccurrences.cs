namespace Oblikovati.Domain.Contracts;

public interface IIRxEnumComponentOccurrences
{
    void Next(uint nCompOccs, out IIRxComponentOccurrence ppCompOccs, out uint pnCompOccsFetched);
    void Skip(uint nCompOccs);
    void Reset();
    void Clone(out IIRxEnumComponentOccurrences ppResult);
}
