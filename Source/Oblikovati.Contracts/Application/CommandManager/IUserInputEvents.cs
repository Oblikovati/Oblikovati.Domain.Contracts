using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Application.UserInterfaceManager.Ribbons;
using Oblikovati.Contracts.Application.Views;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.CommandManager;

public interface IUserInputEvents : IInjectableSingletonEntity
{
    public struct OnActivateCommandEventArgs
    {
        /// <summary>
        /// The internal name of the command. This is the same name as the internal name of the ControlDefinition object associated with this command.
        /// </summary>
        public string CommandName;
    }
    /// <summary>
    /// The OnActivateCommand event notifies the client when a command has been invoked.
    /// </summary>
    public EventHandler<OnActivateCommandEventArgs>? OnActivateCommand { get; set; }
    
    public struct OnContextualMiniToolbarEventArgs
    {
        /// <summary>
        /// Input ObjectsEnumerator that contains the selected entities. This is the same set of entities currently
        /// contained in the document’s SelectSet.
        /// </summary>
        public IObjectsEnumerator SelectedEntities;
        /// <summary>
        /// Input NameValueMap object that contains the commands that should be displayed. Name contains the internal
        /// name of the command and Value contains the entity to be highlighted when the user hovers over this command
        /// in the contextual toolbar.
        /// </summary>
        public INameValueMap DisplayedCommands;
        /// <summary>
        /// Input NameValueMap object that contains additional information about why the menu is being displayed.
        /// This is currently empty.
        /// </summary>
        public INameValueMap AdditionalInfo;
    }
    /// <summary>
    /// Fires before contextual commands are displayed to the user in the graphics window when the user selects an object.
    /// </summary>
    public EventHandler<OnContextualMiniToolbarEventArgs>? OnContextualMiniToolbar { get; set; }
    
    public struct OnDeleteKeyUpEventArgs
    {
        public IObjectsEnumerator SelectedEntities;
        public SelectionDeviceEnum SelectionDevice;
        public IView View;
        public INameValueMap AdditionalInfo;
    }
    /// <summary>
    /// Fires when the user performs a delete key click when no command is active.
    /// </summary>
    public EventHandler<OnDeleteKeyUpEventArgs>? OnDeleteKeyUp { get; set; }
    
    public struct OnDoubleClickEventArgs
    {
        /// <summary>
        /// Enumerator of entities selected by double click. Count of SelectedEntities will be 0 if user double-clicks
        /// in space. If any of the selected objects are not supported by the API, no notification is sent.
        /// </summary>
        public IObjectsEnumerator SelectedEntities;
        public SelectionDeviceEnum SelectionDevice;
        /// <summary>
        /// Returns an enumerated constant that identifies the button that was clicked to cause the event.
        /// The constants correspond to the left button (bit 0), right button (bit 1), and middle button (bit 2).
        /// These bits correspond to the values 1, 2, and 4, respectively.
        /// Only one of the bits is set, indicating the button that caused the event.
        /// </summary>
        public MouseButtonEnum Button;
        /// <summary>
        /// Returns an enumerated constant that corresponds to the state of the SHIFT, CTRL, and ALT keys when the
        /// button specified in the button argument is clicked. The constants correspond to one or more of those three
        /// keys being down. Each of these keys corresponds to a bit: SHIFT key (bit 0), the CTRL key (bit 1),
        /// and the ALT key (bit 2). These bits correspond to the values 1, 2, and 4, respectively. Combinations
        /// of these are provided as conveniences in the enumerator. For example, if only the ALT key was down,
        /// the constant kShiftStateAlt would be returned corresponding to the integer 4.
        /// If CTRL and ALT were pressed, the constant kShiftStateCtrlAlt would be returned whose integer value would
        /// be 6.
        /// </summary>
        public ShiftStateEnum ShiftKeys;
        /// <summary>
        /// Returns the coordinates that specify the current location of the mouse pointer in model space and are
        /// returned in centimeters. Model Returns Nothing if user double-clicks in browser.
        /// </summary>
        public IPoint ModelPosition;
        /// <summary>
        /// Returns the coordinates that specify the current location of the mouse pointer in window space and are
        /// returned in pixels. Model Returns Nothing if user double-clicks in browser.
        /// </summary>
        public IPoint2d ViewPosition;
        /// <summary>
        /// Returns the View object where the mouse was pressed.
        /// </summary>
        public IView View;
        public INameValueMap AdditionalInfo;
    }
    /// <summary>
    /// Event that is sent when the user double-clicks in the window.
    /// </summary>
    public EventHandler<OnDoubleClickEventArgs>? OnDoubleClick { get; set; }
    
    public struct OnDragEventArgs
    {
        /// <summary>
        /// indicating the current state of the drag operation. When the drag is initially started this value is
        /// kDragStateDragHandlerSelection, indicating the selection of an entity to be dragged.
        /// During the drag, this value is kDragStateOnDrag.
        /// When the mouse button is released to stop the drag operation this value is kDragStateEndDrag.
        /// </summary>
        public DragStateEnum DragState;
        /// <summary>
        /// A value indicating what combinations of the Shift, Control, and Alt keys are currently pressed.
        /// This allows you to use combinations of these keys to control options for the command implementing the drag.
        /// For example, a Control drag might result in copying the entity.
        /// </summary>
        public ShiftStateEnum ShiftKeys;
        /// <summary>
        /// The current position of the mouse in model space.
        /// </summary>
        public IPoint ModelPosition;
        /// <summary>
        /// The current position of the mouse in view space.
        /// The coordinates are pixels where the upper-left corner of the view is (0,0).
        /// </summary>
        public IPoint2d ViewPosition;
        /// <summary>
        /// The View object the drag is taking place within.
        /// </summary>
        public IView View;
        /// <summary>
        /// Input object that contains additional information about why the context menu is being displayed.
        /// No additional information is provided for this event.
        /// </summary>
        public INameValueMap AdditionalInfo;
    }
    /// <summary>
    /// The OnDrag event notifies the client whenever the end-user performs a drag operation in the graphics window.
    /// Using this event, the client can override Oblikovati's standard drag behavior.
    /// Remarks:
    /// The following discusses the principles a client needs to understand in order to take advantage of the full
    /// capabilities of this event. The OnDrag event notification is sent whenever the end-user begins to perform a drag
    /// operation in the graphics window. When the drag is initiated the DragState argument is equal to
    /// kDragStateDragHandlerSelection. The client can determine what object is being dragged by checking the contents
    /// of the SelectSet object of the active document. If the client wants to override Oblikovati's standard drag
    /// behavior for the object, they need to set the HandlingCode argument to kEventHandled indicating they will
    /// handle the drag. If the HandlingCode is set to kEventNotHandled then Oblikovati will handle the drag.
    /// A handling code of kEventCanceled is not supported and will result in the same thing as kEventNotHandled.
    /// If the HandlingCode has been set to kEventHandled then the OnDrag event notification will continue to be sent
    /// as the end-user continues the drag operation. The DrageState argument will be equal to kDragStateOnDrag while
    /// the end-user continues to drag. When the end-user releases the mouse button to stop the drag operation,
    /// the DragState argument will be equal to kDragStateEndDrag. By handling the drag, Oblikovati expects the client to
    /// handle all aspects of the drag. The only thing that Oblikovati does is change the icon to a drag icon and continues
    /// to fire the OnDrag event notification. It is up to the client to provide any dynamic feedback during the drag
    /// and to perform whatever the final action of the drag is expected to produce, (typically the repositioning of an
    /// entity). Using the ModelPosition and ViewPosition arguments Oblikovati notifies the client of the current position
    /// of the mouse to allow them to create any preview graphics.
    /// </summary>
    public EventHandler<OnDragEventArgs>? OnDrag { get; set; }
    
    public struct OnLinearMarkingMenuEventArgs
    {
        /// <summary>
        /// Input ObjectsEnumerator that contains the selected entities.
        /// This is the same set of entities currently contained in the document’s SelectSet.
        /// </summary>
        public IObjectsEnumerator SelectedEntities;
        /// <summary>
        /// Input constant denoting whether the menu was invoked via a click in a graphics window
        /// (kGraphicsWindowSelection) or by a click in the browser (kBrowserSelection).
        /// </summary>
        public SelectionDeviceEnum SelectionDevice;
        /// <summary>
        /// Input/Output CommandControls object.
        /// This object represents the contents of the linear menu that will be displayed to the user.
        /// Using the functionality of the CommandControls object you can iterate over the current contents and add
        /// and remove items from the menu.
        /// </summary>
        public ICommandControls LinearMenu;
        /// <summary>
        /// Input NameValueMap object that contains additional information about why the menu is being displayed.
        /// This is currently empty.
        /// </summary>
        public INameValueMap AdditionalInfo;
    }
    /// <summary>
    /// Fires before the overflow context menu is displayed to the user.
    /// </summary>
    public EventHandler<OnLinearMarkingMenuEventArgs>? OnLinearMarkingMenu { get; set; }
    
    public struct OnPreSelectEventArgs
    {
        /// <summary>
        /// When called, Oblikovati returns the entity the mouse is currently over.
        /// The client though has a chance to change this entity to some other, if so desired.
        /// The entity passed back from the call is the one Oblikovati will highlight for the pre-select.
        /// </summary>
        public object PreSelectEntity;
        /// <summary>
        /// Input value that specifies whether the entity should be available for selection or not.
        /// If True, this signifies a successful pre-selection and the entity is highlighted by Oblikovati.
        /// </summary>
        public bool DoHighlight;
        /// <summary>
        /// Input argument through which you can supply a group of objects that are logically pre-selected along with
        /// the one that Oblikovati found on its own. This argument is ignored if DoHighLight is False.
        /// Oblikovati passes in an empty collection that you can add additional entities to.
        /// </summary>
        public IObjectCollection MorePreSelectEntities;
        /// <summary>
        /// Returns a constant denoting whether the selection was made via a pick in a graphics window or was it by a
        /// pick in the browser or by some other means. An object can also be selected programmatically by calling the
        /// selection simulation methods on the CommandManager. A value of kGraphicsWindowSelection indicates it was
        /// selected in a graphic window. For all other values the View,
        /// ModelPosition, and ViewPosition arguments are meaningless.
        /// </summary>
        public SelectionDeviceEnum SelectionDevice;
        /// <summary>
        /// Returns the coordinates that result from projecting the click point onto the selected entity.
        /// This is returned in centimeters relative to model space.
        /// Applicable only when the SelectionDevice argument is kGraphicsWindowSelection.
        /// </summary>
        public IPoint ModelPosition;
        /// <summary>
        /// Returns the coordinates that specify the current location of the mouse pointer in window space and are
        /// returned in pixels. Applicable only when the SelectionDevice argument is kGraphicsWindowSelection.
        /// </summary>
        public IPoint2d ViewPosition;
        /// <summary>
        /// Returns the View object where the selection took place.
        /// Applicable only when the SelectionDevice argument is kGraphicsWindowSelection.
        /// </summary>
        public IView View;
    }
    /// <summary>
    /// Fires when the user hovers over an Oblikovati object, and it is a potential candidate for selection.
    /// </summary>
    public EventHandler<OnPreSelectEventArgs>? OnPreSelect { get; set; }
    
    public struct OnRadialMarkingMenuEventArgs
    {
        /// <summary>
        /// Input ObjectsEnumerator that contains the selected entities.
        /// This is the same set of entities currently contained in the document’s SelectSet.
        /// </summary>
        public IObjectsEnumerator SelectedEntities;
        /// <summary>
        /// Input constant denoting whether the menu was invoked via a click in a graphics window
        /// (kGraphicsWindowSelection) or by a click in the browser (kBrowserSelection).
        /// </summary>
        public SelectionDeviceEnum SelectionDevice;
        /// <summary>
        /// Input/Output RadialMarkingMenu object.
        /// This object represents the contents of the radial menu that will be displayed to the user.
        /// The radial marking menu that Oblikovati would usually show in the current context is passed through this argument.
        /// You can then choose to modify the contents of that marking menu.
        /// Any changes you make are transient and will only be used for that display of the marking menu.
        /// Instead of modifying the marking menu you can instead return a different marking menu.
        /// For example, you can create a custom radial marking menu, and then in certain contexts, provide that marking menu.
        /// </summary>
        public IRadialMarkingMenu RadialMenu;
        /// <summary>
        /// Input NameValueMap object that contains additional information about why the menu is being displayed.
        /// This is currently empty.
        /// </summary>
        public INameValueMap AdditionalInfo;
    }
    /// <summary>
    /// Fires before the marking menu is displayed to the user or before the user gestures using the right mouse button.
    /// </summary>
    public EventHandler<OnRadialMarkingMenuEventArgs>? OnRadialMarkingMenu { get; set; }
    
    public struct OnSelectEventArgs
    {
        /// <summary>
        /// Returns the object(s) that were just selected by the user.
        /// This may be the only one selected so far or the latest one in a series during this selection process.
        /// Multiple objects may be returned if the user does a window (area) select.
        /// </summary>
        public IObjectsEnumerator JustSelectedEntities;
        /// <summary>
        /// Subsequently selected entities.
        /// </summary>
        public IObjectCollection MoreSelectedEntities;
        /// <summary>
        /// Returns a constant denoting whether the selection was made via a pick in a graphics window or was it by a
        /// pick in the browser or by some other means. An object can also be selected programmatically by calling the
        /// selection simulation methods on the CommandManager. A value of kGraphicsWindowSelection indicates it was
        /// selected in a graphic window. For all other values the View, ModelPosition, and ViewPosition arguments are
        /// meaningless.
        /// </summary>
        public SelectionDeviceEnum SelectionDevice;
        /// <summary>
        /// Returns the coordinates that result from projecting the click point onto the selected entity.
        /// This is returned in centimeters relative to model space. Applicable only when the SelectionDevice argument
        /// is kGraphicsWindowSelection.
        /// </summary>
        public IPoint ModelPosition;
        /// <summary>
        /// Returns the coordinates that specify the current location of the mouse pointer in window space and are
        /// returned in pixels. Applicable only when the SelectionDevice argument is kGraphicsWindowSelection.
        /// </summary>
        public IPoint2d ViewPosition;
        /// <summary>
        /// Returns the View object where the selection took place.
        /// Applicable only when the SelectionDevice argument is kGraphicsWindowSelection.
        /// </summary>
        public IView View;
    }
    /// <summary>
    /// Fires when the user selects an object by clicking.
    /// </summary>
    public EventHandler<OnSelectEventArgs> OnSelect { get; set; }
    
    public struct OnStopPreSelectEventArgs
    {
        /// <summary>
        /// Returns the coordinates that result from projecting the click point onto the selected entity.
        /// This is returned in centimeters relative to model space. Applicable only when the SelectionDevice argument
        /// is kGraphicsWindowSelection.
        /// </summary>
        public IPoint ModelPosition;
        /// <summary>
        /// Returns the coordinates that specify the current location of the mouse pointer in window space and are
        /// returned in pixels. Applicable only when the SelectionDevice argument is kGraphicsWindowSelection.
        /// </summary>
        public IPoint2d ViewPosition;
        /// <summary>
        /// Returns the View object where the selection took place.
        /// Applicable only when the SelectionDevice argument is kGraphicsWindowSelection.
        /// </summary>
        public IView View;
    }
    /// <summary>
    /// Fires when the user hovers away from an Oblikovati object and it is no longer highlighted.
    /// </summary>
    public EventHandler<OnStopPreSelectEventArgs>? OnStopPreSelect { get; set; }
    
    public struct OnTerminateCommandEventArgs
    {
        /// <summary>
        /// The internal name of the command.
        /// This is the same name as the internal name of the ControlDefinition object associated with this command.
        /// </summary>
        public string CommandName;
    }
    /// <summary>
    /// The OnTerminateCommand event notifies the client when a command has been terminated.
    /// Remarks:
    /// There are several things that cause a command to be terminated. When a command finishes it will terminate.
    /// For example when you execute the Extrude command, after the extrusion has finished the command terminates.
    /// Starting another command while one command is active will cause the active command to terminate.
    /// An exception to this is the viewing commands. They just temporarily suspend the active command rather
    /// than terminate it. Pressing the escape key will terminate the current command.
    /// </summary>
    public EventHandler<OnTerminateCommandEventArgs>? OnTerminateCommand { get; set; }
    
    public struct OnUnSelectEventArgs
    {
        /// <summary>
        /// Returns the object(s) (un)selected by the user to be taken out of the selection set being built.
        /// </summary>
        private IObjectsEnumerator UnSelectedEntities;
        /// <summary>
        /// Returns a constant denoting whether the (un)selection was made via a pick in a graphics window or was it by
        /// a pick in the browser or by some other means. An object can also be selected programmatically by calling
        /// the selection simulation methods on the CommandManager.
        /// A value of kGraphicsWindowSelection indicates it was (un)selected in a graphic window.
        /// For all other values the View, ModelPosition, and ViewPosition arguments are meaningless.
        /// </summary>
        private SelectionDeviceEnum SelectionDevice;
        /// <summary>
        /// Returns the coordinates that result from projecting the click point onto the (un)selected entity.
        /// This is returned in centimeters relative to model space.
        /// Applicable only when the SelectionDevice argument is kGraphicsWindowSelection.
        /// </summary>
        private IPoint ModelPosition;
        /// <summary>
        /// Returns the coordinates that specify the current location of the mouse pointer in window space and are
        /// returned in pixels. Applicable only when the SelectionDevice argument is kGraphicsWindowSelection.
        /// </summary>
        private IPoint2d ViewPosition;
        /// <summary>
        /// Returns the View object where the selection took place.
        /// Applicable only when the SelectionDevice argument is kGraphicsWindowSelection.
        /// </summary>
        private IView View;
    }
    /// <summary>
    /// Event that occurs when the user unselects an entity.
    /// This is done in the user interface by pressing the Shift button and selecting a previously selected entity.
    /// </summary>
    public EventHandler<OnUnSelectEventArgs>? OnUnSelect { get; set; }
}