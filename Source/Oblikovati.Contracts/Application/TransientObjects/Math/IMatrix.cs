using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.Application.TransientObjects.Math;

public interface IMatrix
{
    double Cell { get; set; }
    double Determinant { get; }
    IVector Translation { get; }
    void GetMatrixData(ref List<double> Cells);
    void PutMatrixData(ref List<double> Cells);
    void Invert();
    void GetCoordinateSystem(out IPoint Origin, out IVector XAxis, out IVector YAxis, out IVector ZAxis);
    void SetCoordinateSystem(IPoint Origin, IVector XAxis, IVector YAxis, IVector ZAxis);

    void SetToAlignCoordinateSystems(IPoint FromOrigin, IVector FromXAxis, IVector FromYAxis, IVector FromZAxis,
        IPoint ToOrigin, IVector ToXAxis, IVector ToYAxis, IVector ToZAxis);

    void SetToIdentity();
    void SetToRotation(double Angle, IVector Axis, IPoint Center);
    void SetToRotateTo(IVector From, IVector To, IVector Axis);
    void SetTranslation(IVector Translation, bool ResetRotation);
    bool IsEqualTo(IMatrix Matrix, double Tolerance);
    void TransformBy(IMatrix Matrix);
    void PreMultiplyBy(IMatrix Matrix);
    void PostMultiplyBy(IMatrix Matrix);
    IMatrix Copy();
    void MultiplyBy(IMatrix Matrix);
}