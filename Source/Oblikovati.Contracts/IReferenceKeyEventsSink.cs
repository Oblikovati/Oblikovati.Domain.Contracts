using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IReferenceKeyEventsSink
{
    void OnBindKeyToObject(ref List<byte> ReferenceKey, object Document, out SolutionNatureEnum MatchType,
        INameValueMap Context, ref HandlingCodeEnum HandlingCode);
}