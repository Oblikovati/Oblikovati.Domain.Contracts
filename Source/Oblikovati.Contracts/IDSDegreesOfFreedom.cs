namespace Oblikovati.Contracts;

public interface IDSDegreesOfFreedom : IList<IDSDegreesOfFreedom>
{
    IDSDegreeOfFreedom Item { get; }
}