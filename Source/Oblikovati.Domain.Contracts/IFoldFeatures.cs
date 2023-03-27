namespace Oblikovati.Domain.Contracts;

public interface IFoldFeatures : IList<IFoldFeatures>
{

    IFoldFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IFoldFeature Add(IFoldDefinition FoldDefinition);
    IFoldDefinition CreateFoldDefinition(ISketchLine BendLine, object BendAngle);
}
