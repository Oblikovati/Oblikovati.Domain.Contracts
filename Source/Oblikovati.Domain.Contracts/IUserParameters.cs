namespace Oblikovati.Domain.Contracts;

public interface IUserParameters : IList<IUserParameters>
{
    IUserParameter Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IUserParameter AddByExpression(string Name, string Expression, object UnitsSpecifier);
    IUserParameter _AddByValue(string Name, double Value, object UnitsSpecifier);
    IUserParameter AddByValue(string Name, object Value, object UnitsSpecifier);
}
