using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application;

public interface ISoftwareVersion
{
    int Major { get; }
    int Minor { get; }
    int ServicePack { get; }
    int BetaVersion { get; }
    bool NotProduction { get; }
    int BuildIdentifier { get; }
    int _InternalBuildIdentifier { get; }
    int _DebugBuildIdentifier { get; }
    int _PatchBuildIdentifier { get; }
    string DisplayName { get; }
    bool Is64BitVersion { get; }
    ProductEditionEnum ProductEdition { get; }
    string DisplayVersion { get; }
    bool IsEducationVersion { get; }
    string ProductName { get; }
}