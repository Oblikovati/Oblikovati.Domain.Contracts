namespace Oblikovati.Contracts.NotClassified;

public interface ITestInputOutput
{
    string ValidationText { get; }
    string TraceText { get; }
    string InputText { get; }
    string TestContext { get; set; }
    string GetString(string strPrompt);
    double GetValue(string strPrompt);
    int GetInteger(string strPrompt);
    bool GetChoice(string strPrompt);
    string GetDocument(string strPrompt);
    void ValidateString(string strName, string strValue);
    void ValidateValue(string strName, double dValue, string strTolType);
    void ValidateNumber(string strName, int nValue);
    bool Verify(string strName, object varExpected, object varActual, double dTolerancePercentage);
    void Trace(string strTraceText);
    void Error(string strError);
    void AddLabel(string strLabelName);
    void BeginContext(string strContext);
    void EndContext();
    void NotImplemented(string strMessage);
    void Defect(string strDefectNumMsg);
    void ValidateRawXml(string strName, string strValue);
    bool AssignBadBoolValue(short bVal);
}