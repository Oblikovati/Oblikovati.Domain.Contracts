using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.TransientObjects.Utility;

public interface IDataMedium
{
    string FileName { get; set; }
    object Stream { get; set; }
    object IDataObject { get; set; }
    string String { get; set; }
    MediumTypeEnum MediumType { get; set; }
}