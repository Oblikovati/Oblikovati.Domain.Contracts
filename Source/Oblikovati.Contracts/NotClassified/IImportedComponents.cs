using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;

namespace Oblikovati.Contracts.NotClassified;

public interface IImportedComponents : IList<IImportedComponents>
{
    IComponentDefinition Parent { get; }
    IImportedComponent Item { get; }
    IImportedComponent Add(IImportedComponentDefinition Definition);
    IImportedComponentDefinition CreateDefinition(string FullFileName);
}