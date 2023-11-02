using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

public interface IFamilyManager
{
    string GetFamily(string FamilyId, string LibraryId);
    string PublishFamily(string FamilyXml, string LibraryId);
    void DeleteFamily(string FamilyId, string LibraryId);
    string CopyFamily(string FamilyId, string FromLibraryId, string ToLibraryId, bool Associative);
    void UpdateFamily(string FamilyId, string LibraryId);
    string GetFamilyProperties(string FamilyId, string LibraryId);
    void EditFamilyProperties(string FamilyId, string LibraryId, string FamilyProps);
    string GetFamilyTemplates(string FamilyId, string LibraryId, string TemplateName, bool NoTemplateFile);
    void EditFamilyTemplate(string FamilyId, string LibraryId, string FamilyTemplate);
    void DeleteFamilyTemplate(string FamilyId, string LibraryId, string FamilyTemplate);
    string GetFamilyTable(string FamilyId, string LibraryId, bool FullyPopulated);
    List<string> GetEvaluatedRows(string FamilyId, object RowIds, out List<string> ColumnsIds, string LibraryId);
    List<string> GetEvaluatedColumns(string FamilyId, object ColumnIds, out List<string> RowIds, string LibraryId);
    void EditFamilyTable(string FamilyId, string LibraryId, string FamilyTable);
    string GetFamilyParameterMap(string FamilyId, string LibraryId);
    void EditFamilyParameterMap(string FamilyId, string LibraryId, string FamilyParameterMap);
    string GetFamilyStrings(string FamilyId, string LibraryId, string Language, bool EnumerationOnly);
    void EditFamilyStrings(string FamilyId, string LibraryId, string FamilyStrings);
    List<string> GetFamilyThumbnails(ref List<string> FamilyIds, string LibraryId, bool CachedOnly);
    void EditFamilyThumbnail(string FamilyId, string LibraryId, string ThumbnailFile);
    string GetItem(string FamilyId);
    string GetTableFromExcel(string ExcelFile, string WorkSheet);
    void GetExcelFromTable(string Table, string ExcelFile, string WorkSheet);
    string GetTableFromiPart(string iPartFile);
    void EditFamily(string FamilyId, string LibraryId, string FamilyXml);

    string GetFamilyTable2(string FamilyId, string LibraryId, bool FullyPopulated,
        ContentCenterDecimalMarkerOptionEnum decimalMarker);

    INameValueMap GetEvaluatedRow(string FamilyId, string RowId, string LibraryId, object ColumnIds,
        object ParameterValueOverrides, ContentCenterDecimalMarkerOptionEnum decimalMarker);
}