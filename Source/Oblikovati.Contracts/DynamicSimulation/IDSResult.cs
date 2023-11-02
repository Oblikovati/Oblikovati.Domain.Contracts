using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.DynamicSimulation;

public interface IDSResult
{
    IDSDegreeOfFreedom Parent { get; }
    string Name { get; }
    DSResultTypeEnum ResultType { get; }
    void GetResultValues(List<double> ResultValues);
    double GetCurrentResultValue();
}