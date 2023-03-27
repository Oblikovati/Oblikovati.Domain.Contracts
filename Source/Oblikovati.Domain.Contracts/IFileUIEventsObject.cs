using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IFileUIEventsObject
{
    void PopulateFileMetadata(IObjectCollection FileMetadataObjects, string Formulae, INameValueMap Context, out HandlingCodeEnum HandlingCode);
}
