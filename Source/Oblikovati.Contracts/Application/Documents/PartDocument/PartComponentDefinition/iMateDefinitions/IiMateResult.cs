using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.AssemblyConstraints;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.iMateDefinitions;

public interface IiMateResult
{
    bool IsComposite { get; }
    IAssemblyConstraintsEnumerator Constraints { get; }
    IiMateResult ParentComposite { get; }
    IiMateResultsEnumerator Results { get; }
    string Name { get; set; }
    bool Suppressed { get; set; }
    IAttributeSets AttributeSets { get; }
    void GetInputs(out IiMateDefinition iMateDefinition, out object Entity);
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);

    void SetInputs(IiMateDefinition iMateDefinition, object Entity, object EntityBiasPoint,
        AngleConstraintSolutionTypeEnum SolutionType);
}