namespace Oblikovati.Contracts;

public interface IRotateAboutLineMoveOperation
{
    IMoveDefinition Parent { get; }
    object Angle { get; set; }
    object AxisEntity { get; set; }
    bool UseEntityNaturalDirection { get; set; }
    void Delete();
}