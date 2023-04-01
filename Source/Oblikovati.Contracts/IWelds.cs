namespace Oblikovati.Contracts;

public interface IWelds : IList<IWelds>
{
    IWeld Item { get; }
    ICosmeticWelds CosmeticWelds { get; }
    IWeldBeads WeldBeads { get; }

    void Edit();
    void ExitEdit();
}