namespace Oblikovati.Domain.Contracts;

public interface IGraphicsImageSet
{
    int Count { get; }
    int Id { get; }
    void Remove(int Index);
    void Delete();
}
