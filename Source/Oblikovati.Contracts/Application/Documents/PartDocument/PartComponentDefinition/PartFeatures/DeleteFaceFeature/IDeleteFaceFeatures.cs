namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    DeleteFaceFeature;

public interface IDeleteFaceFeatures : IList<IDeleteFaceFeatures>
{
    IDeleteFaceFeature Item { get; }


    IDeleteFaceFeature Add(object FacesToDelete, bool Heal);
}