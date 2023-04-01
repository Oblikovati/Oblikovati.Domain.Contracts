namespace Oblikovati.Contracts.Parameters;

public interface IReferenceParameters : IList<IReferenceParameters>
{
    IReferenceParameter Item { get; }


    IReferenceParameter AddByExpression(string Expression, object UnitsSpecifier, string Name);
    IReferenceParameter _AddByValue(double Value, object UnitsSpecifier, string Name);
    IReferenceParameter AddByValue(object Value, object UnitsSpecifier, string Name);
}