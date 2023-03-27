using Oblikovati.Domain.Contracts.Structs;

namespace Oblikovati.Domain.Contracts;

public interface IIRxGeometricLocate
{
    void PointLocate(BoreLineStruct pBoreline, uint dwNumTypes, Guid pTypes, out IIRxEnumReferenceKeys ppEnumReferenceKey);
    void ShapeLocate(SelectPrismStruct pShape, uint dwNumTypes, Guid pTypes, out IIRxEnumReferenceKeys ppEnumReferenceKey);
}
