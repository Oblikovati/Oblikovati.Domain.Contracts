using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IiLogicOptions
{
    object ExternalRuleDirectories { get; set; }
    object ExternalRuleFileNames { get; set; }
    string ExternalRuleDefaultExtension { get; set; }
    string CustomAddInDirectory { get; set; }
    iLogicEventTriggersFilterEnum EventTriggersFilter { get; set; }
    bool EnableRuleSecurityInspection { get; set; }
    iLogicExcelEngineTypeEnum ExcelEngineType { get; set; }
}