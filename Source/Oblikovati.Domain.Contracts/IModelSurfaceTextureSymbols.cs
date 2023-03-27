namespace Oblikovati.Domain.Contracts;

public interface IModelSurfaceTextureSymbols : IList<IModelSurfaceTextureSymbols>
{
    IModelSurfaceTextureSymbol Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IModelSurfaceTextureSymbol Add(IModelSurfaceTextureSymbolDefinition Definition);
    IModelSurfaceTextureSymbolDefinition CreateDefinition(IObjectCollection LeaderPoints, IAnnotationPlaneDefinition AnnotationPlaneDefinition);
}
