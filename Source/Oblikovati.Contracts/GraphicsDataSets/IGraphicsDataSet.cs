namespace Oblikovati.Contracts.GraphicsDataSets;

public interface IGraphicsDataSet
{
    int Id { get; }
    void Remove(int Index);
    void Delete();
}