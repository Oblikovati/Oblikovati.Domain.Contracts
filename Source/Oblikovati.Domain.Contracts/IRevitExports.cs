namespace Oblikovati.Domain.Contracts;

public interface IRevitExports : IList<IRevitExports>
{
    int Count { get; }
    IRevitExport Item { get; }
    IRevitExport Add(IRevitExportDefinition Definition);
    IRevitExportDefinition CreateDefinition();
    IEnumerator GetEnumerator();
}
