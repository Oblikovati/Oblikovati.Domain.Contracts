using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IMemberManager
{
    LinkStatusEnum InstanceStatus { get; }
    string GetMemberValues(string Moniker, string LibraryId);

    object EvaluateTableExpression(string Expression, GeneralDataTypeEnum ValueType, string DefaultUnitType,
        bool AsValue, string Moniker, string LibraryId, object CustomParameters);

    string GetInstance(string Moniker, out ContentCenterInstanceStatusEnum InstanceStatus, string LibraryId,
        object CustomParameters, string FullFileName);

    string GetRefreshedInstance(string Moniker, string LibraryId, object CustomParameters, string FullFileName);
    string GetLastError(out MemberManagerErrorsEnum Error);
    IDocument GetNewInstance(string Moniker, string LibraryId, object CustomParameters);
    string GetBatchEditParameters(string Moniker, string LibraryId, object CustomParameters);
    string GetItem(string Moniker);
    string GetMoniker(string RowId, string Family);
    string GetFamilyFromMoniker(string Moniker);
    string GetRowIdFromMoniker(string Moniker);

    string GetMemberCategorization(ref List<string> Categories, string FamilyParamMap, string Table,
        string TemplateParams);

    void GetDefaultTableWithMap(string MemberCategorization, string TemplateFile, ref List<string> Categories,
        out string DefaultTable, out string FamilyParamMap, out string TemplateParams);

    INameValueMap GetUserParametersFromInstance(object Instance);
}