namespace Oblikovati.Contracts.Parameters;

public interface IModelParameters : IList<IModelParameters>
{
    IModelParameter Item { get; }


    IModelParameter AddByExpression(string Expression, object UnitsSpecifier, string Name);
    IModelParameter _AddByValue(double Value, object UnitsSpecifier, string Name);
    IModelParameter AddByValue(object Value, object UnitsSpecifier, string Name);
}