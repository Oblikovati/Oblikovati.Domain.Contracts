using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.AssemblyConstraints;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;

namespace Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition;

public interface IAssemblyWorkPlaneDef
{
    IWorkPlane Parent { get; }
    IAssemblyConstraintsEnumerator Constraints { get; }
    IPoint OriginPoint { get; }
    IUnitVector XAxis { get; }
    IUnitVector YAxis { get; }
    void GetData(out IPoint OriginPoint, out IUnitVector XAxis, out IUnitVector YAxis);
    void PutData(IPoint OriginPoint, IUnitVector XAxis, IUnitVector YAxis);
}