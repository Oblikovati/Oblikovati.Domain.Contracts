namespace Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition;

public interface IAssemblyComponentDefinitions : IList<IAssemblyComponentDefinitions>
{
    IAssemblyDocument Parent { get; }
    IAssemblyComponentDefinition Item { get; }
}