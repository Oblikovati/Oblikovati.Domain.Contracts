﻿using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void IRxUserInputEvents_OnStartCommandEventHandler(CommandIDEnum CommandID);