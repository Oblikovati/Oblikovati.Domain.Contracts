using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

public interface ISurfaceTextureSymbols : IList<ISurfaceTextureSymbols>
{
    ISurfaceTextureSymbol Item { get; }


    ISurfaceTextureSymbol Add(IObjectCollection LeaderPoints, SurfaceTextureTypeEnum SurfaceTextureType, bool ForceTail,
        bool Majority, bool AllAroundSymbol, string MaximumRoughness, string MinimumRoughness, string ProductionMethod,
        string AdditionalProductionMethod, string SamplingLength, string AdditionalSamplingLength,
        LayDirectionTypeEnum LayDirection, string MachiningAllowance, string AdditionalRoughness,
        string SurfaceWaviness, object SurfaceTextureStyle, object Layer);

    ISurfaceTextureSymbol AddByDefinition(IObjectCollection LeaderPoints,
        ISurfaceTextureSymbolDefinition SurfaceTextureSymbolDefinition);

    ISurfaceTextureSymbolDefinition CreateDefinition(object SurfaceTextureStyle);
}