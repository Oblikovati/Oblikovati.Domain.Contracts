namespace Oblikovati.Domain.Contracts;

public interface IWireDefinitions : IList<IWireDefinitions>
{

    IWireDefinition Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IWireDefinition Add();
}
