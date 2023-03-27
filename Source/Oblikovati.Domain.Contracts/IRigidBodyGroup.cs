using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IRigidBodyGroup
{

    IRigidBodyGroups Parent { get; }
    bool Grounded { get; }
    IComponentOccurrencesEnumerator Occurrences { get; }
    int GroupID { get; }
    void GetOccurrencesAndStates(out IComponentOccurrencesEnumerator Occurrences, out List<OccurrenceDOFStateEnum> States);
}
