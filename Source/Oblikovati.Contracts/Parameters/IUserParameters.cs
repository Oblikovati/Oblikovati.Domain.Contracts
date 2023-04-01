namespace Oblikovati.Contracts.Parameters;

public interface IUserParameters : IList<IUserParameters>
{
    IUserParameter Item { get; }


    IUserParameter AddByExpression(string Name, string Expression, object UnitsSpecifier);
    IUserParameter _AddByValue(string Name, double Value, object UnitsSpecifier);
    IUserParameter AddByValue(string Name, object Value, object UnitsSpecifier);
}