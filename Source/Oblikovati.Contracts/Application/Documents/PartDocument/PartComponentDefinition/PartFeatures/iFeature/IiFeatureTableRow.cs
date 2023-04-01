namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.iFeature;

public interface IiFeatureTableRow : IList<IiFeatureTableRow>
{
    IiFeatureTable Parent { get; }

    IiFeatureTableCell Item { get; }

    string MemberName { get; }
    int Index { get; }

    void Delete();
    IiFeatureTableRow Copy();
}