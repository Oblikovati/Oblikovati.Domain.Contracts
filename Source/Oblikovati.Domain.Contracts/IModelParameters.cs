namespace Oblikovati.Domain.Contracts;

public interface IModelParameters : IList<IModelParameters>
{
    IModelParameter Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IModelParameter AddByExpression(string Expression, object UnitsSpecifier, string Name);
    IModelParameter _AddByValue(double Value, object UnitsSpecifier, string Name);
    IModelParameter AddByValue(object Value, object UnitsSpecifier, string Name);
}
