using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IShellFeatures : IList<IShellFeatures>
{

    IShellFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IShellFeature Add(IShellDefinition Definition);
    IShellDefinition CreateShellDefinition(object InputFaces, object Thickness, ShellDirectionEnum Direction);
}
