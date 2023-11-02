namespace Oblikovati.Contracts.NotClassified;

public interface IFaces : IList<IFaces>
{
    IFace Item { get; }
}