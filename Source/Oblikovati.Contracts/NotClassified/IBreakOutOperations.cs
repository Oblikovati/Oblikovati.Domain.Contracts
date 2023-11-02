using Oblikovati.Contracts.Sketch2D.Profiles;

namespace Oblikovati.Contracts.NotClassified;

public interface IBreakOutOperations : IList<IBreakOutOperations>
{
    IBreakOutOperation Item { get; }
    IBreakOutOperation Add(IProfile Profile, object DepthSource, double DepthValue, bool SectionAllParts);
}