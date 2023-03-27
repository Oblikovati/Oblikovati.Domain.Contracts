namespace Oblikovati.Domain.Contracts;

public interface IDSLoadDefinition
{

    IDSLoad Parent { get; }
    object DirectionEntity { get; set; }
    IColor GlyphColor { get; set; }
    double GlyphScale { get; set; }
    bool IsAssociativeLoadDirection { get; set; }
    bool IsDefinedByVectorComponents { get; set; }
    bool IsDirectionEntityNaturalDirection { get; set; }
    bool IsDisplayed { get; set; }
    IPoint Location { get; }
    object LocationEntity { get; set; }
    IDSValue Magnitude { get; }
    IVector Vector { get; }
    IDSValue VectorXComponent { get; }
    IDSValue VectorYComponent { get; }
    IDSValue VectorZComponent { get; }
    bool IsSuppressed { get; set; }
    IDSLoadDefinition Copy();
    void SetByMagnitudeAndDirection(object Magnitude, object DirectionEntity, bool NaturalEntityDirection);
    void SetByVector(object XComponent, object YComponent, object ZComponent);
}
