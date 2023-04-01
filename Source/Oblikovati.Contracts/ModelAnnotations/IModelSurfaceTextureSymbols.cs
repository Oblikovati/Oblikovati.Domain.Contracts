using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.ModelAnnotations;

public interface IModelSurfaceTextureSymbols : IList<IModelSurfaceTextureSymbols>
{
    IModelSurfaceTextureSymbol Item { get; }


    IModelSurfaceTextureSymbol Add(IModelSurfaceTextureSymbolDefinition Definition);

    IModelSurfaceTextureSymbolDefinition CreateDefinition(IObjectCollection LeaderPoints,
        IAnnotationPlaneDefinition AnnotationPlaneDefinition);
}