using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;
using Oblikovati.Contracts.Sketch2D.DimensionConstraints;

namespace Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.AssemblyConstraints;

public interface IAssemblyConstraints : IList<IAssemblyConstraints>
{
    IAssemblyComponentDefinition Parent { get; }
    IAssemblyConstraint Item { get; }


    IAngleConstraint _AddAngleConstraint(object EntityOne, bool DirectionOneReversed, object EntityTwo,
        bool DirectionTwoReversed, object Angle, object BiasPointOne, object BiasPointTwo);

    IAngleConstraint _AddAngleConstraint2(object EntityOne, bool DirectionOneReversed, object EntityTwo,
        bool DirectionTwoReversed, object Angle, object BiasPointOne, object BiasPointTwo, bool Directed);

    IAngleConstraint AddAngleConstraint(object EntityOne, object EntityTwo, object Angle,
        AngleConstraintSolutionTypeEnum SolutionType, object ReferenceVectorEntity, object BiasPointOne,
        object BiasPointTwo);

    IInsertConstraint AddInsertConstraint(object EntityOne, object EntityTwo, bool AxesOpposed, object Distance,
        object BiasPointOne, object BiasPointTwo);

    ITangentConstraint AddTangentConstraint(object EntityOne, object EntityTwo, bool InsideTangency, object Offset,
        object BiasPointOne, object BiasPointTwo);

    IMateConstraint AddMateConstraint(object EntityOne, object EntityTwo, object Offset,
        InferredTypeEnum EntityOneInferredType, InferredTypeEnum EntityTwoInferredType, object BiasPointOne,
        object BiasPointTwo);

    IFlushConstraint AddFlushConstraint(object EntityOne, object EntityTwo, object Offset, object BiasPointOne,
        object BiasPointTwo);

    ITransitionalConstraint AddTransitionalConstraint(IFace FaceOne, IFace FaceTwo, object BiasPointOne,
        object BiasPointTwo);

    IRotateRotateConstraint AddRotateRotateConstraint(object EntityOne, object EntityTwo, object Ratio,
        bool ForwardDirection, object BiasPointOne, object BiasPointTwo);

    IRotateTranslateConstraint AddRotateTranslateConstraint(object EntityOne, object EntityTwo, object Ratio,
        bool ForwardDirection, object BiasPointOne, object BiasPointTwo);

    ICustomConstraint AddCustomConstraint(object EntityOne, object EntityTwo, string ClientId);

    IAssemblySymmetryConstraint _AddSymmetryConstraint(object EntityOne, object EntityTwo, object SymmetryPlane,
        InferredTypeEnum EntityOneInferredType, InferredTypeEnum EntityTwoInferredType);

    IAssemblySymmetryConstraint AddSymmetryConstraint(object EntityOne, object EntityTwo, object SymmetryPlane,
        InferredTypeEnum EntityOneInferredType, InferredTypeEnum EntityTwoInferredType, bool NormalsOpposed);

    IMateConstraint AddMateConstraint2(object EntityOne, object EntityTwo, object Offset,
        InferredTypeEnum EntityOneInferredType, InferredTypeEnum EntityTwoInferredType,
        MateConstraintSolutionTypeEnum SolutionType, object BiasPointOne, object BiasPointTwo);

    IInsertConstraint AddInsertConstraint2(object EntityOne, object EntityTwo, bool AxesOpposed, object Distance,
        object LockRotation, object BiasPointOne, object BiasPointTwo);
}