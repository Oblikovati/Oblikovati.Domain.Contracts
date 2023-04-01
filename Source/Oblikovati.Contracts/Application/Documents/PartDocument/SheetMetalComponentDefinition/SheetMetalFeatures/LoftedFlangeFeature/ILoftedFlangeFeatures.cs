using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    PunchToolFeature;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    LoftedFlangeFeature;

public interface ILoftedFlangeFeatures : IList<ILoftedFlangeFeatures>
{
    ILoftedFlangeFeature Item { get; }


    ILoftedFlangeFeature Add(ILoftedFlangeDefinition LoftedFlangeDefinition);
    ILoftedFlangeDefinition CreateLoftedFlangeDefinition(IPath ProfileOne, IPath ProfileTwo);
}