using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.ModelAnnotations;

public interface IModelCompositeAnnotation
{
    IAttributeSets AttributeSets { get; }
    IComponentDefinition Parent { get; }
    HealthStatusEnum HealthStatus { get; }
    bool Visible { get; set; }
    string Name { get; set; }
    bool IsMemberOfCompositeAnnotation { get; }
    IModelCompositeAnnotation CompositeAnnotation { get; }
    bool IsOwnedByToleranceFeature { get; }
    IModelToleranceFeature OwnedByToleranceFeature { get; }
    IModelToleranceFeature TopToleranceFeature { get; }
    string InternalName { get; }
    IModelCompositeAnnotationDefinition Definition { get; set; }
    string ClientId { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();

    void GetDisplayGeometry(ICamera Camera, out int GroupCount, out List<int> PolylinesPerGroup,
        out List<bool> FilledGroups, out int PolylineCount, out List<int> PolylineLengths, out int VertexCount,
        out List<double> VertexCoordinates);

    void GetFilledAreaFacetsInfo(ICamera Camera, out int TextVertexCount, out int TextFacetCount,
        out List<double> TextVertexCoordinates, out List<int> TextVertexIndices, out int SymbolVertexCount,
        out int SymbolFacetCount, out List<double> SymbolVertexCoordinates, out List<int> SymbolVertexIndices);

    void GenerateInternalName(object Context, object InternalName);
}