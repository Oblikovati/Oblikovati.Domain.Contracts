namespace Oblikovati.Contracts;

public interface IClientViews : IList<IClientView>
{
    IClientView Item { get; }
    IClientView Add(int HWND);
    IClientView AddBySubset(int HWND, int Left, int Top, int Width, int Height);
}