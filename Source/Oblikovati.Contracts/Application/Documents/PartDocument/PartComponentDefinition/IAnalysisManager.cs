using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;

public interface IAnalysisManager
{
    IComponentDefinition Parent { get; }

    IDraftAnalyses DraftAnalyses { get; }
    bool IsAnalysisVisible { get; set; }
    AnalysisTypeEnum ActiveAnalysisType { get; }
    object ActiveAnalysis { get; }
}