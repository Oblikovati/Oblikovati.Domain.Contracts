using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.UnwrapFeature;

public interface IUnwrapFeatures : IList<IUnwrapFeatures>
{
    IUnwrapFeature Item { get; }


    IUnwrapFeature Add(IUnwrapDefinition Definition);

    IUnwrapDefinition CreateDefinition(IFaceCollection Faces, object pOrigin, UnwrapResultAlignmentEnum Align,
        object LinearResult, object RigidResult, bool AutomaticFaceChain, bool MergeResultBody);
}