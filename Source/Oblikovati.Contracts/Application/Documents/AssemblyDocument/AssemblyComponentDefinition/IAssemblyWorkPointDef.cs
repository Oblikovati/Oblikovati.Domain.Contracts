using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.AssemblyConstraints;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition;

public interface IAssemblyWorkPointDef
{
    IWorkPoint Parent { get; }
    IAssemblyConstraintsEnumerator Constraints { get; }
    IPoint Point { get; set; }
}