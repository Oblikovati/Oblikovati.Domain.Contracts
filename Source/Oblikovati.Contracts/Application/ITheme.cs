namespace Oblikovati.Contracts.Application;

public interface ITheme
{
    string Name { get; }
    void Activate();
}