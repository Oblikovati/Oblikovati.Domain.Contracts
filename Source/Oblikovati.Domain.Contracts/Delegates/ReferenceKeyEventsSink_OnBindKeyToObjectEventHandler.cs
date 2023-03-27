using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void ReferenceKeyEventsSink_OnBindKeyToObjectEventHandler(ref List<byte> ReferenceKey, object Document, out SolutionNatureEnum MatchType, INameValueMap Context, ref HandlingCodeEnum HandlingCode);
