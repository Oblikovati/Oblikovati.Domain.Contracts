namespace Oblikovati.Domain.Contracts;

public interface IUnfoldMethods : IList<IUnfoldMethods>
{

    IUnfoldMethod Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IUnfoldMethod AddLinearUnfoldMethod(string Name, string Value);
    IUnfoldMethod AddBendTableFromFile(string Name, string FileName);
    IUnfoldMethod AddEquationUnfoldMethod(string Name);
}
