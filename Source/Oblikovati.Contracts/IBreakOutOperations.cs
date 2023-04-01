using Oblikovati.Contracts.Sketch2D.Profiles;

namespace Oblikovati.Contracts;

public interface IBreakOutOperations : IList<IBreakOutOperations>
{
    IBreakOutOperation Item { get; }
    IBreakOutOperation Add(IProfile Profile, object DepthSource, double DepthValue, bool SectionAllParts);
}