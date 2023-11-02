namespace Oblikovati.Contracts.NotClassified;

public interface IIEnumUnknown
{
    void RemoteNext(uint celt, out object rgelt, out uint pceltFetched);
    void Skip(uint celt);
    void Reset();
    void Clone(out IIEnumUnknown ppEnum);
}