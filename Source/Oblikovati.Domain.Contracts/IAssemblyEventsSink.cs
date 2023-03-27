using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IAssemblyEventsSink
{
    void OnAssemblyChanged(INameValueMap Context, EventTimingEnum BeforeOrAfter, out HandlingCodeEnum HandlingCode);
    void OnAssemblySolve(I_AssemblySolver Solver, EventTimingEnum BeforeOrAfter, INameValueMap Context);
    void OnAssemblyChange(I_AssemblyDocument Document, INameValueMap Context, EventTimingEnum BeforeOrAfter, out HandlingCodeEnum HandlingCode);
    void OnNewOccurrence(I_AssemblyDocument Document, IComponentOccurrence Occurrence, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnOccurrenceChange(I_AssemblyDocument Document, IComponentOccurrence Occurrence, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnNewConstraint(I_AssemblyDocument Document, object Constraint, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnNewRelationship(I_AssemblyDocument Document, object Relationship, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnDelete(IDocument Document, object Entity, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnLoadStateChange(I_AssemblyDocument Document, DocumentLoadStateEnum NewLoadState, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
}
