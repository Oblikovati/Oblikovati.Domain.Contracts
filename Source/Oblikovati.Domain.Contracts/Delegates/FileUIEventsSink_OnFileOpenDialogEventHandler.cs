﻿using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void FileUIEventsSink_OnFileOpenDialogEventHandler(List<string> FileTypes, int ParentHWND, out string FileName, INameValueMap Context, out HandlingCodeEnum HandlingCode);