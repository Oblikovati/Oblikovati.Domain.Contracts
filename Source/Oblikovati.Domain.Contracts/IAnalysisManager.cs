using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IAnalysisManager
{
    IComponentDefinition Parent { get; }

    IDraftAnalyses DraftAnalyses { get; }
    bool IsAnalysisVisible { get; set; }
    AnalysisTypeEnum ActiveAnalysisType { get; }
    object ActiveAnalysis { get; }
}
