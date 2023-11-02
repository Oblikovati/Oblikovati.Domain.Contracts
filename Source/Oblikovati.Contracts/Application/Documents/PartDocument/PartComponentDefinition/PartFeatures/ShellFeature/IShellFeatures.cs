using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ShellFeature;

public interface IShellFeatures : IList<IShellFeatures>
{
    IShellFeature Item { get; }


    IShellFeature Add(IShellDefinition Definition);
    IShellDefinition CreateShellDefinition(object InputFaces, object Thickness, ShellDirectionEnum Direction);
}