namespace Oblikovati.Contracts;

public interface IFaces : IList<IFaces>
{
    IFace Item { get; }
}