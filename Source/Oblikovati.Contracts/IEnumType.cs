namespace Oblikovati.Contracts;

public interface IEnumType
{
    string Name { get; }
    int Value { get; set; }
    int CurrentIndex { get; set; }

    string ValueName { get; }
    void Reset();
    void MoveNext();
}