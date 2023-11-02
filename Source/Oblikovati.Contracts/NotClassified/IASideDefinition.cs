using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

public interface IASideDefinition
{
    ISheetMetalComponentDefinition Parent { get; }
    ASideFaceStatusEnum Status { get; }
    IFaces Faces { get; }
    IFace ASideFace { get; }
    void Delete();
}