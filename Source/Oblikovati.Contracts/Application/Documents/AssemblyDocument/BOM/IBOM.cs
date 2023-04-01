using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.AssemblyDocument.BOM;

public interface IBOM
{
    string RevisionId { get; }
    IBOMViews BOMViews { get; }
    bool PartsOnlyViewEnabled { get; set; }
    bool RequiresUpdate { get; }
    bool StructuredViewEnabled { get; set; }
    bool StructuredViewFirstLevelOnly { get; set; }
    string StructuredViewDelimiter { get; set; }
    int StructuredViewMinimumDigits { get; set; }
    NumberingSchemeEnum PartsOnlyViewNumberingScheme { get; set; }
    int PartsOnlyViewMinimumDigits { get; set; }
    void GetPartNumberMergeSettings(out bool MergeEnabled, out List<string> MergeExcludeList);
    void SetPartNumberMergeSettings(bool MergeEnabled, object MergeKeys);
    void ImportBOMCustomization(string FileName);
    void ExportBOMCustomization(string FileName);

    void GetPartNumberMergeSettings2(out bool MergeEnabled, out List<string> MergeExcludeList,
        out bool MergeInstanceRows);

    void SetPartNumberMergeSettings2(bool MergeEnabled, object MergeKeys, object MergeInstanceRows);
}