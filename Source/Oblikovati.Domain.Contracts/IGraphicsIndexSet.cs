namespace Oblikovati.Domain.Contracts;

public interface IGraphicsIndexSet
{
    int Count { get; }
    int Id { get; }
    int IndexValue { get; set; }
    void Remove(int Index);
    void Delete();
    void Add(int Index, int IndexValue);
    void GetIndices(ref List<int> IndexValues);
    void PutIndices(ref List<int> IndexValues);
}
