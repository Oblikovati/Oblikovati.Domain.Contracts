using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IUnfoldMethod
{
    IDrawingStylesManager _Parent { get; }

    string Name { get; set; }
    string InternalName { get; }
    bool InUse { get; }
    StyleLocationEnum StyleLocation { get; }
    bool UpToDate { get; }
    StyleTypeEnum StyleType { get; }
    string Comments { get; set; }

    UnfoldMethodTypeEnum UnfoldMethodType { get; }
    string kFactor { get; set; }
    BendAngleTypeEnum BendAngleType { get; set; }
    int EquationCount { get; }
    UnfoldMethodEquationTypeEnum EquationType { get; }
    string SplineFactor { get; set; }
    void Delete();
    void SaveToGlobal();
    void UpdateFromGlobal();
    IStyle ConvertToLocal();
    IStyle Copy(string Name);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void WriteBendTableToFile(string FileName);
    void DeleteEquation(int Index);
    void GetEquation(int Index, out string Equation, out string MinimumValue, out ComparisonTypeEnum MinimumCompareCondition, out string BoundedVariable, out string MaximumValue, out ComparisonTypeEnum MaximumCompareCondition);
    void SetEquation(int Index, UnfoldMethodEquationTypeEnum EquationType, string Equation, string MinimumValue, ComparisonTypeEnum MinimumCompareCondition, string BoundedVariable, string MaximumValue, ComparisonTypeEnum MaximumCompareCondition);
}
