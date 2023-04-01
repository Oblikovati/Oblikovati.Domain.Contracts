using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IRigidBodyGroup
{
    IRigidBodyGroups Parent { get; }
    bool Grounded { get; }
    IComponentOccurrencesEnumerator Occurrences { get; }
    int GroupID { get; }

    void GetOccurrencesAndStates(out IComponentOccurrencesEnumerator Occurrences,
        out List<OccurrenceDOFStateEnum> States);
}