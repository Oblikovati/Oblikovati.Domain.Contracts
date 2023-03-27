using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IUnwrapFeatures : IList<IUnwrapFeatures>
{

    IUnwrapFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IUnwrapFeature Add(IUnwrapDefinition Definition);
    IUnwrapDefinition CreateDefinition(IFaceCollection Faces, object pOrigin, UnwrapResultAlignmentEnum Align, object LinearResult, object RigidResult, bool AutomaticFaceChain, bool MergeResultBody);
}
