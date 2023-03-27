using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IFileOpenOptions
{
    LevelOfDetailEnum DefaultLevelOfDetail { get; set; }
    DesignViewTypeEnum DefaultDesignView { get; set; }
    bool DefaultDesignViewIsAssociative { get; set; }
    bool SkipAllUnresolvedFilesInAssembly { get; set; }
    bool SkipAllUnresolvedFilesInPart { get; set; }
    bool SkipAllUnresolvedFilesInDrawing { get; set; }
    bool DefaultDesignViewIsAssociativeInAssembly { get; set; }
    bool DefaultDesignViewIsAssociativeInPart { get; set; }
    DesignViewTypeEnum DefaultDesignViewInAssembly { get; set; }
    DesignViewTypeEnum DefaultDesignViewInPart { get; set; }
    ModelStateTypeEnum DefaultModelStateInAssembly { get; set; }
    ModelStateTypeEnum DefaultModelStateInPart { get; set; }
}
