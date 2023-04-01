using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition;
using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Unsorted;

namespace Oblikovati.Contracts.Application;

public interface IAssemblyEvents : IInjectableSingletonEntity
{
    /// <summary>
    /// Event that is fired after any change occurs that impacts the assembly structure.
    /// </summary>
    EventHandler<OnAssemblyChangedEventArgs> OnAssemblyChanged { get; }

    public struct OnAssemblyChangedEventArgs
    {
        public INameValueMap Context;
        public EventTimingEnum BeforeOrAfter;
    }

    /// <summary>
    /// 
    /// </summary>
    EventHandler<OnAssemblySolveEventArgs> OnAssemblySolve { get; }

    public struct OnAssemblySolveEventArgs
    {
        public I_AssemblySolver Solver;
        public EventTimingEnum BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// 
    /// </summary>
    EventHandler<OnAssemblyChangeEventArgs> OnAssemblyChange { get; }

    public struct OnAssemblyChangeEventArgs
    {
        public IAssemblyDocument Document;
        public INameValueMap Context;
        public EventTimingEnum BeforeOrAfter;
    }

    /// <summary>
    /// Event that is fired whenever an occurrence is created.
    /// </summary>
    EventHandler<OnNewOccurrenceEventArgs> OnNewOccurrence { get; }

    public struct OnNewOccurrenceEventArgs
    {
        public IAssemblyDocument Document;
        public IComponentOccurrence Occurrence;
        public EventTimingEnum BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Event that is fired whenever an occurrence changes.
    /// </summary>
    EventHandler<OnOccurrenceChangeEventArgs> OnOccurrenceChange { get; }

    public struct OnOccurrenceChangeEventArgs
    {
        public IAssemblyDocument Document;
        public IComponentOccurrence Occurrence;
        public EventTimingEnum BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// 
    /// </summary>
    EventHandler<OnOccurrenceChangeEventArgs> OnNewConstraint { get; }

    public struct OnNewConstraintEventArgs
    {
        public IAssemblyDocument Document;
        public object Constraint;
        public EventTimingEnum BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// The OnNewRelationship event notifies a client when a new constraint or connection is added to an assembly.
    /// </summary>
    EventHandler<OnNewRelationshipEventArgs> OnNewRelationship { get; }

    public struct OnNewRelationshipEventArgs
    {
        public IAssemblyDocument Document;
        public object Relationship;
        public EventTimingEnum BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Event that is fired whenever an object within this events set is deleted in a document.
    /// </summary>
    EventHandler<OnDeleteEventArgs> OnDelete { get; }

    public struct OnDeleteEventArgs
    {
        public IDocument Document;
        public object Entity;
        public EventTimingEnum BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Fires when an assembly document goes from lite to full or full to lite loading.
    /// </summary>
    EventHandler<OnLoadStateChangeEventArgs> OnLoadStateChange { get; }

    public struct OnLoadStateChangeEventArgs
    {
        public IAssemblyDocument Document;
        public DocumentLoadStateEnum NewLoadState;
        public EventTimingEnum BeforeOrAfter;
        public INameValueMap Context;
    }
}