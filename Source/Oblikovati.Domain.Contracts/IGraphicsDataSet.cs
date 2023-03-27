namespace Oblikovati.Domain.Contracts;

public interface IGraphicsDataSet
{
    int Count { get; }
    int Id { get; }
    void Remove(int Index);
    void Delete();
}
