namespace Oblikovati.Domain.Contracts;

public interface IWelds : IList<IWelds>
{

    int Count { get; }
    IWeld Item { get; }
    ICosmeticWelds CosmeticWelds { get; }
    IWeldBeads WeldBeads { get; }
    IEnumerator GetEnumerator();
    void Edit();
    void ExitEdit();
}
