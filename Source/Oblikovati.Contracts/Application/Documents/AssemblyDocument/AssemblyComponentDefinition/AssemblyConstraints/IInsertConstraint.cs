using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.iMateDefinitions;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;
using Oblikovati.Contracts.Parameters;
using Oblikovati.Contracts.Sketch2D.DimensionConstraints;

namespace Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.AssemblyConstraints;

public interface IInsertConstraint
{
    IAssemblyComponentDefinition Parent { get; }
    bool Suppressed { get; set; }
    HealthStatusEnum HealthStatus { get; }
    string Name { get; set; }
    object EntityOne { get; }
    object EntityTwo { get; }
    IComponentOccurrence OccurrenceOne { get; }
    IComponentOccurrence OccurrenceTwo { get; }
    IComponentOccurrence AffectedOccurrenceOne { get; }
    IComponentOccurrence AffectedOccurrenceTwo { get; }
    object GeometryOne { get; }
    object GeometryTwo { get; }
    IAttributeSets AttributeSets { get; }
    bool ResultOfiMate { get; }
    IiMateResult iMateResult { get; }
    bool ResultOfLayoutConstraint { get; }
    ILayoutConstraint LayoutConstraint { get; }
    IDriveConstraintSettings DriveConstraintSettings { get; }
    IDriveSettings DriveSettings { get; }
    bool IsDefaultName { get; }
    bool Visible { get; set; }
    bool AxesOpposed { get; }
    IParameter Distance { get; }
    IConstraintLimits ConstraintLimits { get; }
    bool LockRotation { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);

    IAngleConstraint ConvertToAngleConstraint(object EntityOne, object EntityTwo, object Angle,
        AngleConstraintSolutionTypeEnum SolutionType, object ReferenceVectorEntity, object BiasPointOne,
        object BiasPointTwo);

    ICustomConstraint ConvertToCustomConstraint(object EntityOne, object EntityTwo, string ClientId);

    IFlushConstraint ConvertToFlushConstraint(object EntityOne, object EntityTwo, object Offset, object BiasPointOne,
        object BiasPointTwo);

    IInsertConstraint ConvertToInsertConstraint(object EntityOne, object EntityTwo, bool AxesOpposed, object Distance,
        object BiasPointOne, object BiasPointTwo);

    IMateConstraint ConvertToMateConstraint(object EntityOne, object EntityTwo, object Offset,
        InferredTypeEnum EntityOneInferredType, InferredTypeEnum EntityTwoInferredType, object BiasPointOne,
        object BiasPointTwo);

    IRotateRotateConstraint ConvertToRotateRotateConstraint(object EntityOne, object EntityTwo, object Ratio,
        bool ForwardDirection, object BiasPointOne, object BiasPointTwo);

    IRotateTranslateConstraint ConvertToRotateTranslateConstraint(object EntityOne, object EntityTwo, object Ratio,
        bool ForwardDirection, object BiasPointOne, object BiasPointTwo);

    ITangentConstraint ConvertToTangentConstraint(object EntityOne, object EntityTwo, bool InsideTangency,
        object Offset, object BiasPointOne, object BiasPointTwo);

    ITransitionalConstraint ConvertToTransitionalConstraint(IFace FaceOne, IFace FaceTwo, object BiasPointOne,
        object BiasPointTwo);

    IAssemblySymmetryConstraint _ConvertToSymmetryConstraint(object EntityOne, object EntityTwo, object SymmetryPlane,
        InferredTypeEnum EntityOneInferredType, InferredTypeEnum EntityTwoInferredType);

    IAssemblySymmetryConstraint ConvertToSymmetryConstraint(object EntityOne, object EntityTwo, object SymmetryPlane,
        InferredTypeEnum EntityOneInferredType, InferredTypeEnum EntityTwoInferredType, bool NormalsOpposed);

    IMateConstraint ConvertToMateConstraint2(object EntityOne, object EntityTwo, object Offset,
        InferredTypeEnum EntityOneInferredType, InferredTypeEnum EntityTwoInferredType,
        MateConstraintSolutionTypeEnum SolutionType, object BiasPointOne, object BiasPointTwo);

    IInsertConstraint ConvertToInsertConstraint2(object EntityOne, object EntityTwo, bool AxesOpposed, object Distance,
        object LockRotation, object BiasPointOne, object BiasPointTwo);
}