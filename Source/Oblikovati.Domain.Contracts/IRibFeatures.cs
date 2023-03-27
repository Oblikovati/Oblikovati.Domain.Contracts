namespace Oblikovati.Domain.Contracts;

public interface IRibFeatures : IList<IRibFeatures>
{

    IRibFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IRibFeature Add(IRibDefinition Definition);
    IRibDefinition CreateDefinition(IObjectCollection ProfileCurves, bool IsRib, bool DirectionReversed, object Thickness);
}
