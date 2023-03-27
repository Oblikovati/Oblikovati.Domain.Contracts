namespace Oblikovati.Domain.Contracts;

public interface IStoryboards : IList<IStoryboards>
{

    int Count { get; }
    IStoryboard Item { get; }
    IStoryboard ItemById { get; }
    IEnumerator GetEnumerator();
    IStoryboard Add(object StoryboardId);
}
