namespace Oblikovati.Domain.Contracts;

public interface IDeleteFaceFeatures : IList<IDeleteFaceFeatures>
{

    IDeleteFaceFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IDeleteFaceFeature Add(object FacesToDelete, bool Heal);
}
