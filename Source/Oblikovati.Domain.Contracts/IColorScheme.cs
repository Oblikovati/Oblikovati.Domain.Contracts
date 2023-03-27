namespace Oblikovati.Domain.Contracts;

public interface IColorScheme
{

    IColor HighlightColor { get; }
    string Name { get; }
    IColor PrimarySelectColor { get; }
    IColor SecondarySelectColor { get; }
    IColor TertiarySelectColor { get; }
    IColor JoinPreviewColor { get; }
    IColor CutPreviewColor { get; }
    IColor IntersectPreviewColor { get; }
    IColor DOFFixedColor { get; }
    IColor DOFFreeColor { get; }
    IColor ScreenColor { get; }
    string ImageFullFileName { get; set; }
    IColor TopScreenColor { get; }
    IColor BottomScreenColor { get; }
    IColor HighlightColor2D { get; }
    IColor PrimarySelectColor2D { get; }
    IColor ScreenColor2D { get; }
    IColor TopScreenColor2D { get; }
    IColor BottomScreenColor2D { get; }
    IColor DimensionColor { get; }
    string ReflectionEnvironmentFileName { get; set; }
    IColor GripHighlightingColor { get; }
    void Activate();
}
