using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

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
