namespace Oblikovati.Contracts;

public interface IStoryboards : IList<IStoryboards>
{
    IStoryboard Item { get; }
    IStoryboard ItemById { get; }

    IStoryboard Add(object StoryboardId);
}