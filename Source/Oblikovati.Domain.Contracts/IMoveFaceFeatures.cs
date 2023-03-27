namespace Oblikovati.Domain.Contracts;

public interface IMoveFaceFeatures : IList<IMoveFaceFeatures>
{

    IMoveFaceFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IMoveFaceFeature Add(IMoveFaceDefinition Definition);
    IMoveFaceDefinition CreateDefinition(IFaceCollection Faces);
}
