using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.ModelAnnotations;

public interface IModelSurfaceTextureSymbolDefinition
{
    IModelSurfaceTextureSymbol Parent { get; }
    IAnnotationPlane AnnotationPlane { get; set; }
    IAnnotationPlaneDefinition AnnotationPlaneDefinition { get; set; }
    IPoint Position { get; set; }
    IModelLeader Leader { get; }
    IModelLeaderNodesEnumerator AllLeafNodes { get; }
    IModelLeaderNodesEnumerator AllNodes { get; }
    bool HasRootNode { get; }
    IModelLeaderNode RootNode { get; }
    IGeometryIntent Intent { get; set; }
    SurfaceTextureTypeEnum SurfaceTextureType { get; set; }
    bool IsForceTailShown { get; set; }
    bool IsMajority { get; set; }
    bool AllAroundSymbol { get; set; }
    string MaximumRoughness { get; set; }
    string MinimumRoughness { get; set; }
    string ProductionMethod { get; set; }
    string AdditionalProductionMethod { get; set; }
    string SamplingLength { get; set; }
    string AdditionalSamplingLength { get; set; }
    LayDirectionTypeEnum LayDirection { get; set; }
    string MachiningAllowance { get; set; }
    string AdditionalRoughness { get; set; }
    string SurfaceWaviness { get; set; }
    void AddLeader(IObjectCollection Points);
    IModelSurfaceTextureSymbolDefinition Copy();
}