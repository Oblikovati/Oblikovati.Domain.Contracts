using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.Application.Documents.Document;

public interface IUnitsOfMeasure
{
    UnitsTypeEnum LengthUnits { get; set; }
    UnitsTypeEnum AngleUnits { get; set; }
    UnitsTypeEnum MassUnits { get; set; }
    UnitsTypeEnum TimeUnits { get; set; }
    int LengthDisplayPrecision { get; set; }
    int AngleDisplayPrecision { get; set; }
    double _GetValueFromExpression(string Expression, object UnitsSpecifier);
    object GetValueFromExpression(string Expression, object UnitsSpecifier);
    string GetStringFromValue(double Value, object UnitsSpecifier);
    string GetStringFromType(UnitsTypeEnum UnitsType);
    bool CompatibleUnits(string Expression1, object UnitsSpecifier1, string Expression2, object UnitsSpecifier2);
    double ConvertUnits(double Value, object InputUnitsSpecifier, object OutputUnitsSpecifier);
    string GetLocaleCorrectedExpression(string Expression, object UnitsSpecifier);
    IParametersEnumerator GetDrivingParameters(string Expression);
    string GetDatabaseUnitsFromExpression(string Expression, object UnitsSpecifier);
    string GetPreciseStringFromValue(double Value, object UnitsSpecifier);
    bool IsExpressionValid(string Expression, object UnitsSpecifier);
}