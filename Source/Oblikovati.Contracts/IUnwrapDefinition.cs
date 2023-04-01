using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.UnwrapFeature;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IUnwrapDefinition
{
    IUnwrapFeature Parent { get; }
    bool AutomaticFaceChain { get; set; }
    bool MergeResultBody { get; set; }
    IFaceCollection InputFaces { get; set; }
    IEdgeCollection LinearResult { get; set; }
    IEdgeCollection RigidResult { get; set; }
    UnwrapResultAlignmentEnum ResultAlignment { get; set; }
    IVertex Origin { get; set; }
    IUnwrapDefinition Copy();
}