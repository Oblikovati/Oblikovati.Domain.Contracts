namespace Oblikovati.Contracts.NotClassified;

public interface IDSDegreesOfFreedom : IList<IDSDegreesOfFreedom>
{
    IDSDegreeOfFreedom Item { get; }
}