namespace Oblikovati.Contracts.NotClassified;

public interface IRevitExports : IList<IRevitExports>
{
    IRevitExport Item { get; }
    IRevitExport Add(IRevitExportDefinition Definition);
    IRevitExportDefinition CreateDefinition();
}