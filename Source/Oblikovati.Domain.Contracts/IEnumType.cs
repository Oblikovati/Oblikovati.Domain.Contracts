namespace Oblikovati.Domain.Contracts;

public interface IEnumType
{
    string Name { get; }
    int Value { get; set; }
    int CurrentIndex { get; set; }
    int Count { get; }
    string ValueName { get; }
    void Reset();
    void MoveNext();
}
