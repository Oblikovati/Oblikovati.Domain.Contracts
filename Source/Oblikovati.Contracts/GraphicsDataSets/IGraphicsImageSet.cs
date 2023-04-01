namespace Oblikovati.Contracts.GraphicsDataSets;

public interface IGraphicsImageSet
{
    int Id { get; }
    void Remove(int Index);
    void Delete();
}