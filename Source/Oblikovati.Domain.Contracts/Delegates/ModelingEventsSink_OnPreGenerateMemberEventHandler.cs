using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void ModelingEventsSink_OnPreGenerateMemberEventHandler(IDocument FactoryDocument, string MemberName, INameValueMap Context, out HandlingCodeEnum HandlingCode);
