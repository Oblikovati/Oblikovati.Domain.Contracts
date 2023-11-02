namespace Oblikovati.Contracts.NotClassified;

public interface ICell
{
    ICustomTable Parent { get; }
    string Value { get; set; }
    bool Static { get; set; }
}