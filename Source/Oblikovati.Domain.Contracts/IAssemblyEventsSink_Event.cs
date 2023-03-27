using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IAssemblyEventsSink_Event
{
    void add_OnAssemblyChanged(AssemblyEventsSink_OnAssemblyChangedEventHandler handler);
    void remove_OnAssemblyChanged(AssemblyEventsSink_OnAssemblyChangedEventHandler handler);
    void add_OnAssemblySolve(AssemblyEventsSink_OnAssemblySolveEventHandler handler);
    void remove_OnAssemblySolve(AssemblyEventsSink_OnAssemblySolveEventHandler handler);
    void add_OnAssemblyChange(AssemblyEventsSink_OnAssemblyChangeEventHandler handler);
    void remove_OnAssemblyChange(AssemblyEventsSink_OnAssemblyChangeEventHandler handler);
    void add_OnNewOccurrence(AssemblyEventsSink_OnNewOccurrenceEventHandler handler);
    void remove_OnNewOccurrence(AssemblyEventsSink_OnNewOccurrenceEventHandler handler);
    void add_OnOccurrenceChange(AssemblyEventsSink_OnOccurrenceChangeEventHandler handler);
    void remove_OnOccurrenceChange(AssemblyEventsSink_OnOccurrenceChangeEventHandler handler);
    void add_OnNewConstraint(AssemblyEventsSink_OnNewConstraintEventHandler handler);
    void remove_OnNewConstraint(AssemblyEventsSink_OnNewConstraintEventHandler handler);
    void add_OnNewRelationship(AssemblyEventsSink_OnNewRelationshipEventHandler handler);
    void remove_OnNewRelationship(AssemblyEventsSink_OnNewRelationshipEventHandler handler);
    void add_OnDelete(AssemblyEventsSink_OnDeleteEventHandler handler);
    void remove_OnDelete(AssemblyEventsSink_OnDeleteEventHandler handler);
    void add_OnLoadStateChange(AssemblyEventsSink_OnLoadStateChangeEventHandler handler);
    void remove_OnLoadStateChange(AssemblyEventsSink_OnLoadStateChangeEventHandler handler);
}
