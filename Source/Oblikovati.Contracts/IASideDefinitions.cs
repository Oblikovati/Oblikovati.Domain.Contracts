using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;

namespace Oblikovati.Contracts;

public interface IASideDefinitions : IList<IASideDefinitions>
{
    ISheetMetalComponentDefinition Parent { get; }
    IASideDefinition Item { get; }


    IASideDefinition Add(IFace pInput);
}