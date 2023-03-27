namespace Oblikovati.Domain.Contracts;

public interface IAssemblyComponentDefinitions : IList<IAssemblyComponentDefinitions>
{

    I_AssemblyDocument Parent { get; }
    IAssemblyComponentDefinition Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
