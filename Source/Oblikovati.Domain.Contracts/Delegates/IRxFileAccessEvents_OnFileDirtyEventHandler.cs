using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void IRxFileAccessEvents_OnFileDirtyEventHandler(string RelativeFileName, string LibraryName, List<byte> CustomLogicalName, string FullFileName, IDocument Documentout, HandlingCodeEnum HandlingCode);
