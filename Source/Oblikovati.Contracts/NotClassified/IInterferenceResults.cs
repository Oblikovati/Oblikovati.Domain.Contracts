namespace Oblikovati.Contracts.NotClassified;

public interface IInterferenceResults : IList<IInterferenceResults>
{
    IInterferenceResult Item { get; }
}