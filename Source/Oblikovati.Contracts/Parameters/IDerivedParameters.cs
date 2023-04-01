namespace Oblikovati.Contracts.Parameters;

public interface IDerivedParameters : IList<IDerivedParameters>
{
    IDerivedParameter Item { get; }
}