using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void FileUIEventsSink_OnPopulateFileMetadataEventHandler(IObjectsEnumerator FileMetadataObjects, string Formulae, INameValueMap Context, out HandlingCodeEnum HandlingCode);
