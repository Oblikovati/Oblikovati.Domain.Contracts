namespace Oblikovati.Domain.Contracts;

public interface IInterferenceResults : IList<IInterferenceResults>
{
    IInterferenceResult Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
