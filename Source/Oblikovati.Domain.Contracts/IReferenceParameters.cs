namespace Oblikovati.Domain.Contracts;

public interface IReferenceParameters : IList<IReferenceParameters>
{
    IReferenceParameter Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IReferenceParameter AddByExpression(string Expression, object UnitsSpecifier, string Name);
    IReferenceParameter _AddByValue(double Value, object UnitsSpecifier, string Name);
    IReferenceParameter AddByValue(object Value, object UnitsSpecifier, string Name);
}
