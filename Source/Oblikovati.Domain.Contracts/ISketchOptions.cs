using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISketchOptions : IInjectableSingletonEntity
{

    IHeadsUpDisplayOptions HeadsUpDisplayOptions { get; }
    bool AutoProjectEdges { get; set; }
    bool AutomaticReferenceEdges { get; set; }
    ConstraintPriorityEnum ConstraintPriority { get; set; }
    bool DisplayAxes { get; set; }
    bool DisplayCoordinateSystemIndicator { get; set; }
    bool DisplayGridLines { get; set; }
    bool DisplayMinorGridLines { get; set; }
    bool EditDimensionWhenCreated { get; set; }
    OverConstrainedDimensionBehaviorEnum OverConstrainedDimensionBehavior { get; set; }
    bool SnapToGrid { get; set; }
    bool ParallelViewOnSketchCreation { get; set; }
    bool _DeferUpdates { get; set; }
    bool AutoProjectPartOrigin { get; set; }
    bool ProjectObjectsAsConstructionGeometry { get; set; }
    bool AutoScaleSketchGeometriesOnInitialDimension { get; set; }
    double ConstraintToolbarScale { get; set; }
    bool DisplayCoincidentConstraintsOnCreation { get; set; }
    bool PointAlignment { get; set; }
    int SplineDefaultTension { get; set; }
    SplineFitMethodEnum SplineFitMethod { get; set; }
    ISketchConstraintSettings SketchConstraintSettings { get; }
    bool ImageInsertionLINKOptionCheckedAsDefault { get; set; }
    bool ParallelViewOnSketchCreationInPart { get; set; }
    bool ParallelViewOnSketchCreationInAssembly { get; set; }
}
