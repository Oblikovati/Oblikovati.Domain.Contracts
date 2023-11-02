using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.ModelAnnotations;

public interface IModelFeatureControlFrameDefinition
{
    IModelFeatureControlFrame Parent { get; }
    IAnnotationPlane AnnotationPlane { get; set; }
    IAnnotationPlaneDefinition AnnotationPlaneDefinition { get; set; }
    IModelFeatureControlFrameRows FeatureControlFrameRows { get; }
    IGeometryIntent Intent { get; set; }
    IPoint LandingPosition { get; set; }
    IPoint TextPosition { get; set; }
    bool AllAround { get; set; }
    string Notes { get; set; }
    ArrowheadTypeEnum ArrowheadType { get; set; }
    string TopNotes { get; set; }
    bool MergeSymbolOverridden { get; set; }
    bool OverrideMergeSymbol { get; set; }
    double Rotation { get; }
    IModelLeader Leader { get; }
    IModelFeatureControlFrameDefinition Copy();
}