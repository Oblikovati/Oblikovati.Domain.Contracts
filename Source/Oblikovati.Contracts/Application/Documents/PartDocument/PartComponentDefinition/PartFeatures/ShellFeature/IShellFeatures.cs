using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ShellFeature;

public interface IShellFeatures : IList<IShellFeatures>
{
    IShellFeature Item { get; }


    IShellFeature Add(IShellDefinition Definition);
    IShellDefinition CreateShellDefinition(object InputFaces, object Thickness, ShellDirectionEnum Direction);
}