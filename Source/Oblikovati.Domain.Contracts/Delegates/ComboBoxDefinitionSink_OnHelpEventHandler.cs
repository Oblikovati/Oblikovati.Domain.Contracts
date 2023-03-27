using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void ComboBoxDefinitionSink_OnHelpEventHandler(INameValueMap Context, out HandlingCodeEnum HandlingCode);
