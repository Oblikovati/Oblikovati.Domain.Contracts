namespace Oblikovati.Domain.Contracts;

public interface IFaceShellDefinitions : IList<IFaceShellDefinitions>
{

    IFaceShellDefinition Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IFaceShellDefinition Add();
}
