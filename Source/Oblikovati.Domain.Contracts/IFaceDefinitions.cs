namespace Oblikovati.Domain.Contracts;

public interface IFaceDefinitions : IList<IFaceDefinitions>
{

    IFaceDefinition Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IFaceDefinition Add(object SurfaceGeometry, bool IsParamReversed);
}
