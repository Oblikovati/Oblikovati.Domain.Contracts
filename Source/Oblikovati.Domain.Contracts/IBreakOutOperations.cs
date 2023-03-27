namespace Oblikovati.Domain.Contracts;

public interface IBreakOutOperations : IList<IBreakOutOperations>
{

    int Count { get; }
    IBreakOutOperation Item { get; }
    IBreakOutOperation Add(IProfile Profile, object DepthSource, double DepthValue, bool SectionAllParts);
    IEnumerator GetEnumerator();
}
