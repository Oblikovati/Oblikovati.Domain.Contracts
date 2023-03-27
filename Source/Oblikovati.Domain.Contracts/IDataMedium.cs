using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDataMedium
{
    string FileName { get; set; }
    object Stream { get; set; }
    object IDataObject { get; set; }
    string String { get; set; }
    MediumTypeEnum MediumType { get; set; }
}
