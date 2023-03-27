﻿using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void ModelingEventsSink_OnGenerateModelStateMemberEventHandler(IDocument FactoryDocument, string MemberName, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
