using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISurfaceTextureSymbol
{

    ISheet Parent { get; }
    IAttributeSets AttributeSets { get; }
    IPoint2d Position { get; set; }
    ISurfaceTextureStyle Style { get; set; }
    ILayer Layer { get; set; }
    ILeader Leader { get; }
    ISurfaceTextureSymbolDefinition Definition { get; set; }
    SurfaceTextureTypeEnum SurfaceTextureType { get; set; }
    bool ForceTail { get; set; }
    bool Majority { get; set; }
    bool AllAroundSymbol { get; set; }
    string MaximumRoughness { get; set; }
    string MinimumRoughness { get; set; }
    string ProductionMethod { get; set; }
    string AdditionalProductionMethod { get; set; }
    string SamplingLength { get; set; }
    string AdditionalSamplingLength { get; set; }
    LayDirectionTypeEnum LayDirection { get; set; }
    string MachiningAllowance { get; set; }
    string AdditionalRoughness { get; set; }
    string SurfaceWaviness { get; set; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
}
