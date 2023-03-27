using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISketchConstraintSettings
{

    ISketchOptions Parent { get; }
    bool DisplayConstraintsOnCreation { get; set; }
    bool ShowConstraintsForSelectedObjects { get; set; }
    bool DisplayCoincidentConstraintsInSketch { get; set; }
    bool EditDimensionsWhenCreated { get; set; }
    bool CreateDimensionsOnValueInput { get; set; }
    OverConstrainedDimensionBehaviorEnum OverConstrainedDimensionBehavior { get; set; }
    bool EnableInferConstraints { get; set; }
    bool EnablePersistConstraints { get; set; }
    ConstraintInferencePriorityEnum ConstraintInferencePriority { get; set; }
    SketchConstraintInferenceTypeEnum SelectionForGeometricConstraintsInference { get; set; }
    bool KeepDimensionsWithEquationInRelaxMode { get; set; }
    SketchGeometricConstraintTypeEnum GeometricConstraintsToRemoveInRelaxMode { get; set; }
    bool EnableRelaxMode { get; set; }
}
