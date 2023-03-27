using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISurfaceTextureSymbols : IList<ISurfaceTextureSymbols>
{

    ISurfaceTextureSymbol Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    ISurfaceTextureSymbol Add(IObjectCollection LeaderPoints, SurfaceTextureTypeEnum SurfaceTextureType, bool ForceTail, bool Majority, bool AllAroundSymbol, string MaximumRoughness, string MinimumRoughness, string ProductionMethod, string AdditionalProductionMethod, string SamplingLength, string AdditionalSamplingLength, LayDirectionTypeEnum LayDirection, string MachiningAllowance, string AdditionalRoughness, string SurfaceWaviness, object SurfaceTextureStyle, object Layer);
    ISurfaceTextureSymbol AddByDefinition(IObjectCollection LeaderPoints, ISurfaceTextureSymbolDefinition SurfaceTextureSymbolDefinition);
    ISurfaceTextureSymbolDefinition CreateDefinition(object SurfaceTextureStyle);
}
