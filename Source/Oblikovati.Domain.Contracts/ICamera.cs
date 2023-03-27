using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

/// <summary>
/// The Camera defines the view of the model shown within the window.
/// </summary>
public interface ICamera
{
    /// <summary>
    /// Property that returns the parent object of the camera.
    /// </summary>

    /// <summary>
    /// Gets/Sets the type of orientation of the camera (Top, Iso, etc. or arbitrary).
    /// </summary>
    ViewOrientationTypeEnum ViewOrientationType { get; set; }
    IMatrix WorldToView { get; set; }
    IMatrix ViewToWorld { get; set; }
    /// <summary>
    /// Specifies the position of the observer's 'Eye' (View's center).
    /// </summary>
    IPoint Eye { get; set; }
    /// <summary>
    /// Specifies the position of the Target point the observer's viewing in the scene (View's Z-axis).
    /// </summary>
    IPoint Target { get; set; }
    /// <summary>
    /// Specifies the vector defining what is 'up' for the observer.
    /// </summary>
    IUnitVector UpVector { get; set; }
    /// <summary>
    /// Gets/Sets a boolean flag indicating whether Perpspective viewing is on/off.
    /// </summary>
    bool Perspective { get; set; }
    /// <summary>
    /// Gets/Sets the Perspective Angle.
    /// </summary>
    double PerspectiveAngle { get; set; }
    /// <summary>
    /// Get/Set the contents of the scene for a camera.
    /// This is applicable only when the Camera is created from the ITransientObjects.CreateCamera.
    /// Valid objects that can be set to this property are: IComponentDefinition, ISheet, and IPresentationScene.
    /// </summary>
    object SceneObject { get; set; }
    /// <summary>
    /// Read-only property that returns the transformation matrix from model space to view space.
    /// </summary>
    IMatrix ModelToViewTransformation { get; }
    bool Animating { set; }
    bool DumpingNodeCount { set; }
    /// <summary>
    /// Method that fits all the contents of the Document into the view.
    /// </summary>
    void Fit();
    /// <summary>
    /// Method that causes the changes made to the Camera object to be applied to the actual camera of the view.
    /// This will also cause the view to update.
    /// </summary>
    void Apply();
    /// <summary>
    /// Method that applies the current camera to the View without transition.
    /// </summary>
    void ApplyWithoutTransition();
    /// <summary>
    /// Method that sets the current extents of the camera.
    /// The camera extents define the area within the model that is visible in the view.
    /// Setting the extents results in the camera zooming in or out.
    /// The Apply method of the camera must be called before any changes are shown in the view.
    /// </summary>
    /// <param name="Width"></param>
    /// <param name="Height"></param>
    void SetExtents(double Width, double Height);
    /// <summary>
    /// Method that gets the current extents of the camera.
    /// The camera extents define the area within the model that is visible in the view.
    /// </summary>
    /// <param name="Width"></param>
    /// <param name="Height"></param>
    void GetExtents(out double Width, out double Height);
    /// <summary>
    /// Method that changes the view according mouse movement and view operation.
    /// </summary>
    /// <param name="FromPoint"></param>
    /// <param name="ToPoint"></param>
    /// <param name="WheelDelta"></param>
    /// <param name="ViewOperation"></param>
    void ComputeWithMouseInput(IPoint2d FromPoint, IPoint2d ToPoint, int WheelDelta, ViewOperationTypeEnum ViewOperation);
    /// <summary>
    /// Method that converts a point in model space to the equivalent point on the view.
    /// </summary>
    /// <param name="ModelCoordinate"></param>
    /// <returns></returns>
    IPoint2d ModelToViewSpace(IPoint ModelCoordinate);
    /// <summary>
    /// Method that converts a point in view space to the equivalent point in the model.
    /// </summary>
    /// <param name="ViewCoordinate"></param>
    /// <returns></returns>
    IPoint ViewToModelSpace(IPoint2d ViewCoordinate);
    /// <summary>
    /// Method that saves the current camera view to the specified file.
    /// The width and height arguments define the aspect ratio and the number of pixels in the output image.
    /// The CreateImage method is similar to this but instead of writing the image to a file it creates it in memory,
    /// which is more efficient than writing and reading if from disk if you need to use the image immediately.
    /// </summary>
    /// <param name="FullFileName"></param>
    /// <param name="Width"></param>
    /// <param name="Height"></param>
    /// <param name="topColor"></param>
    /// <param name="bottomColor"></param>
    void SaveAsBitmap(string FullFileName, int Width, int Height, object topColor, object bottomColor);
}
