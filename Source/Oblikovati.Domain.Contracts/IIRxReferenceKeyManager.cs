using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IIRxReferenceKeyManager
{
    void CreateKeyContext(out uint phKeyContext);
    void SaveKeyContext(uint hKeyContext, IIStream pKeyContextStream);
    void LoadKeyContext(out uint phKeyContext, IIStream pKeyContextStream);
    void BindKeyToInterface(uint hKeyContext, Guid ObjectInterfaceIID, uint dwKeySize, byte pKey, out IntPtr ppPrimaryMatch, out SolutionNatureEnum pMatchType, ref IIEnumUnknown ppAllMatches);
    void BindTransientKeyToInterface(Guid ObjectInterfaceIID, int TransientKey, out IntPtr ppMatch);
    void GetTransientKeyFromKey(uint hKeyContext, uint dwKeySize, byte pKey, out int pPrimaryTransientKey, out SolutionNatureEnum pMatchType, ref uint pdwNumMatches, ref IntPtr ppAllMatches);
    IntPtr GetKeyFromTransientKey(int TransientKey, uint hKeyContext, ref uint pdwKeySize);
}
