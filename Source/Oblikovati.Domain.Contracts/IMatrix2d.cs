namespace Oblikovati.Domain.Contracts;

public interface IMatrix2d
{
    double Cell { get; set; }
    double Determinant { get; }
    IVector2d Translation { get; }
    void GetMatrixData(ref List<double> Cells);
    void PutMatrixData(ref List<double> Cells);
    void Invert();
    void GetCoordinateSystem(out IPoint2d Origin, out IVector2d XAxis, out IVector2d YAxis);
    void SetCoordinateSystem(IPoint2d Origin, IVector2d XAxis, IVector2d YAxis);
    void SetToAlignCoordinateSystems(IPoint2d FromOrigin, IVector2d FromXAxis, IVector2d FromYAxis, IPoint2d ToOrigin, IVector2d ToXAxis, IVector2d ToYAxis);
    void SetToIdentity();
    void SetToRotation(double Angle, IPoint2d Center);
    void SetToRotateTo(IVector2d From, IVector2d To);
    void SetTranslation(IVector2d Translation, bool ResetRotation);
    bool IsEqualTo(IMatrix2d Matrix2d, double Tolerance);
    void TransformBy(IMatrix2d Matrix2d);
    void PreMultiplyBy(IMatrix2d Matrix2d);
    void PostMultiplyBy(IMatrix2d Matrix2d);
    IMatrix2d Copy();
}
