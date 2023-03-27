using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IReferenceKeyEventsSink
{
    void OnBindKeyToObject(ref List<byte> ReferenceKey, object Document, out SolutionNatureEnum MatchType, INameValueMap Context, ref HandlingCodeEnum HandlingCode);
}
