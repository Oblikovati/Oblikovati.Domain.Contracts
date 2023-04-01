namespace Oblikovati.Contracts;

public interface IInterferenceResults : IList<IInterferenceResults>
{
    IInterferenceResult Item { get; }
}