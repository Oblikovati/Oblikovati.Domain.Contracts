using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IASideDefinition
{

    ISheetMetalComponentDefinition Parent { get; }
    ASideFaceStatusEnum Status { get; }
    IFaces Faces { get; }
    IFace ASideFace { get; }
    void Delete();
}
