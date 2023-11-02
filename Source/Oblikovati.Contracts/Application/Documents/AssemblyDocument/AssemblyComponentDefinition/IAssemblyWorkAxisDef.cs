using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.AssemblyConstraints;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition;

public interface IAssemblyWorkAxisDef
{
    IWorkAxis Parent { get; }
    IAssemblyConstraintsEnumerator Constraints { get; }
    IPoint OriginPoint { get; }
    IUnitVector Axis { get; }
    void GetData(out IPoint OriginPoint, out IUnitVector Axis);
    void PutData(IPoint OriginPoint, IUnitVector Axis);
}