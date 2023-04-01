namespace Oblikovati.Contracts;

public interface ICell
{
    ICustomTable Parent { get; }
    string Value { get; set; }
    bool Static { get; set; }
}