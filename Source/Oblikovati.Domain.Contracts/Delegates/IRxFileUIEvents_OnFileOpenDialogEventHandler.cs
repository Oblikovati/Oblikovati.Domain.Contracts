﻿using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void IRxFileUIEvents_OnFileOpenDialogEventHandler(List<string> FileTypes, int ParentHWND, out string FileName, out HandlingCodeEnum HandlingCode);