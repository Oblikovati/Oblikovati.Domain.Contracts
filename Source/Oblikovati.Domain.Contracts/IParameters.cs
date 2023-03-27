using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IParameters : IList<IParameters>
{
    IParameter Item { get; }
    int Count { get; }
    IModelParameters ModelParameters { get; }
    IReferenceParameters ReferenceParameters { get; }
    IUserParameters UserParameters { get; }
    IParameterTables ParameterTables { get; }
    int AngularDimensionPrecision { get; set; }
    string AngularStandardTolerance { get; set; }
    int LinearDimensionPrecision { get; set; }
    string LinearStandardTolerance { get; set; }
    DimensionDisplayTypeEnum DimensionDisplayType { get; set; }
    bool UseStandardTolerances { get; set; }
    ICustomParameterGroups CustomParameterGroups { get; }
    IDerivedParameterTables DerivedParameterTables { get; }
    bool ExportStandardTolerances { get; set; }
    bool DisplayParameterAsExpression { get; set; }
    IEnumerator GetEnumerator();
    double _GetValueFromExpression(string Expression, object UnitsSpecifier);
    object GetValueFromExpression(string Expression, object UnitsSpecifier);
    void SetAllToMax();
    void SetAllToMin();
    void SetAllToNominal();
    void SetAllToMedian();
    bool IsExpressionValid(string Expression, object UnitsSpecifier);
}
