using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

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
