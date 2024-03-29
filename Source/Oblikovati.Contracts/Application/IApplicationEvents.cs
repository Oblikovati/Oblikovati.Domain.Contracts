﻿using Oblikovati.Contracts.Application.DesignProjectManager;
using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Application.Views;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application;

public interface IApplicationEvents : IInjectableSingletonEntity
{
    struct OnNewDocumentEventArgs
    {
        public IDocument Document;
        public EventTiming BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Handler for Event that is fired whenever a document is activated.
    /// </summary>
    EventHandler<OnNewDocumentEventArgs>? OnNewDocument { get; set; }

    struct OnInitializeDocumentEventArgs
    {
        public IDocument Document;
        public string FullDocumentName;
        public EventTiming BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Handler for Event that is fired whenever a document is initialized.
    /// At the time this event fires, the document is not open yet.
    /// Calling methods or properties on the document will force it to open.
    /// </summary>
    EventHandler<OnInitializeDocumentEventArgs>? OnInitializeDocument { get; set; }

    struct OnOpenDocumentEventArgs
    {
        public IDocument Document;
        public string FullDocumentName;
        public EventTiming BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Handler for The event that notifies a client when a document is opened.
    /// </summary>
    EventHandler<OnOpenDocumentEventArgs>? OnOpenDocument { get; set; }

    struct OnSaveDocumentEventArgs
    {
        public IDocument Document;
        public EventTiming BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Handler for The Event notifies a client whenever a document is saved.
    /// </summary>
    EventHandler<OnSaveDocumentEventArgs>? OnSaveDocument { get; set; }

    struct OnCloseDocumentEventArgs
    {
        public IDocument Document;
        public string FullDocumentName;
        public EventTiming BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Handler for Event that is fired whenever a document is closed.
    /// </summary>
    EventHandler<OnCloseDocumentEventArgs>? OnCloseDocument { get; set; }

    struct OnTerminateDocumentEventArgs
    {
        public IDocument Document;
        public string FullDocumentName;
        public EventTiming BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Handler for The event that notifies a client when a document is being terminated.
    /// Termination of a document is a complete close of the document.
    /// A document terminate corresponds with a document initialize.
    /// </summary>
    EventHandler<OnTerminateDocumentEventArgs>? OnTerminateDocument { get; set; }

    struct OnActivateDocumentEventArgs
    {
        public IDocument Document;
        public EventTiming BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Handler for Event that is fired whenever a document is activated.
    /// </summary>
    EventHandler<OnActivateDocumentEventArgs>? OnActivateDocument { get; set; }

    struct OnDeactivateDocumentEventArgs
    {
        public IDocument Document;
        public EventTiming BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Handler for The event that notifies a client when a document is deactivated.
    /// </summary>
    EventHandler<OnDeactivateDocumentEventArgs>? OnDeactivateDocument { get; set; }

    struct OnNewViewEventArgs
    {
        public IView View;
        public EventTiming BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Handler for The event that notifies a client when a new View object is created.
    /// An API "View" object is equivalent to an Oblikovati graphics window.
    /// </summary>
    EventHandler<OnNewViewEventArgs>? OnNewView { get; set; }

    struct OnDisplayModeChangeEventArgs
    {
        public IView View;
        public EventTiming BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Handler for The event that notifies a client when the display mode of
    /// a view has changed.
    /// </summary>
    EventHandler<OnDisplayModeChangeEventArgs>? OnDisplayModeChange { get; set; }

    struct OnCloseViewEventArgs
    {
        public IView View;
        public EventTiming BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Handler for The event that notifies a client when a view is closed.
    /// An API view is equivalent to an Oblikovati graphics window.
    /// </summary>
    EventHandler<OnCloseViewEventArgs>? OnCloseView { get; set; }

    struct OnActivateViewEventArgs
    {
        public IView View;
        public EventTiming BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Handler for Event that fires just after a view is activated
    /// </summary>
    EventHandler<OnActivateViewEventArgs>? OnActivateView { get; set; }

    struct OnDeactivateViewEventAgrs
    {
        public IView View;
        public EventTiming BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Handler for The event that Fires just after a view is deactivated.
    /// </summary>
    EventHandler<OnDeactivateViewEventAgrs> OnDeactivateView { get; set; }

    struct OnQuitEventArgs
    {
        public EventTiming BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Handler for The event that notifies a client when Oblikovati is being shut down.
    /// </summary>
    EventHandler<OnQuitEventArgs>? OnQuit { get; set; }

    struct OnNewEditObjectEventArgs
    {
        public object Edit;
        public EventTiming BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Adds a handler for The event that notifies a client when the edit object is changing.
    /// </summary>
    EventHandler<OnNewEditObjectEventArgs>? OnNewEditObject { get; set; }

    struct OnTranslateDocumentEventArgs
    {
        public bool TranslatingIn;
        public IDocument Document;
        public string FullFileName;
        public EventTiming BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Handler for The event notifies a client whenever a file is translated into Oblikovati
    /// or an Oblikovati document is translated out to a non-Oblikovati file.
    /// </summary>
    EventHandler<OnTranslateDocumentEventArgs>? OnTranslateDocument { get; set; }

    struct OnActiveProjectChangedEventArgs
    {
        public IDesignProject Project;
        public EventTiming BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Handler for the event that Fires just before and soon after the active 
    /// project is changed, supplying the context in which this action is being taken.
    /// </summary>
    EventHandler<OnActiveProjectChangedEventArgs>? OnActiveProjectChanged { get; set; }

    struct OnDocumentChangeEventArgs
    {
        public IDocument Document;
        public EventTiming BeforeOrAfter;
        public CommandTypesEnum ReasonsForChange;
        public INameValueMap Context;
    }

    /// <summary>
    /// Handler for the event that Fires just before the document is changed,
    /// supplying the reasons for change and the context in which this action is being taken.
    /// </summary>
    EventHandler<OnDocumentChangeEventArgs>? OnDocumentChange { get; set; }

    struct OnReadyEventArgs
    {
        public EventTiming BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Handler for The event that notifies a client when Oblikovati has completely
    /// initialized and is ready for interactive use.
    /// </summary>
    EventHandler<OnReadyEventArgs>? OnReady { get; set; }

    struct OnMigrateDocumentEventArgs
    {
        public IDocument Document;
        public EventTiming BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Handler for the Event that is fired whenever a document is being 
    /// explicitly migrated.
    /// </summary>
    EventHandler<OnMigrateDocumentEventArgs>? OnMigrateDocument { get; set; }

    struct OnApplicationOptionChangeEventArgs
    {
        public EventTiming BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Handler for the event that Fires just before and soon after 
    /// application options are modified.
    /// </summary>
    EventHandler<OnApplicationOptionChangeEventArgs>? OnApplicationOptionChange { get;  set;}

    struct OnMoveApplicationWindowEventArgs
    {
        public EventTiming BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Handler for the event that Fires after application main window is moved.
    /// </summary>
    EventHandler<OnMoveApplicationWindowEventArgs>? OnMoveApplicationWindow { get; set; }

    struct OnResizeApplicationWindowEventArgs
    {
        public EventTiming BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Handler for the event that Fires after application main window is resized, 
    /// or layout is recalculated.
    /// </summary>
    EventHandler<OnResizeApplicationWindowEventArgs>? OnResizeApplicationWindow { get; set; }

    struct OnMoveViewEventArgs
    {
        public IView View;
        public EventTiming BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Handler for the event that Fires after view window is moved.
    /// </summary>
    EventHandler<OnMoveViewEventArgs>? OnMoveView { get; set; }

    struct OnResizeViewEventArgs
    {
        public IView View;
        public EventTiming BeforeOrAfter;
        public INameValueMap Context;
    }

    /// <summary>
    /// Handler for the event that Fires after view window is resized, 
    /// or window state is changed.
    /// </summary>
    EventHandler<OnResizeViewEventArgs>? OnResizeView { get; set; }
}