using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.MoveFaceFeature;

public interface IMoveFaceFeatures : IList<IMoveFaceFeatures>
{
    IMoveFaceFeature Item { get; }


    IMoveFaceFeature Add(IMoveFaceDefinition Definition);
    IMoveFaceDefinition CreateDefinition(IFaceCollection Faces);
}