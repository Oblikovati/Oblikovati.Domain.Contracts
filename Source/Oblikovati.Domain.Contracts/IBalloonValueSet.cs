namespace Oblikovati.Domain.Contracts;

public interface IBalloonValueSet
{

    string Value { get; set; }
    string OverrideValue { get; set; }
    IBalloon Parent { get; }
    IDrawingBOMRow ReferencedRow { get; }
    bool Static { get; set; }
    string ItemNumber { get; }
    IReferencedFileDescriptors ReferencedFiles { get; }
    void Delete();
}
