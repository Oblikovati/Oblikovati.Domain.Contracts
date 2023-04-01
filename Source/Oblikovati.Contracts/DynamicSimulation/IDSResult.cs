using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.DynamicSimulation;

public interface IDSResult
{
    IDSDegreeOfFreedom Parent { get; }
    string Name { get; }
    DSResultTypeEnum ResultType { get; }
    void GetResultValues(List<double> ResultValues);
    double GetCurrentResultValue();
}