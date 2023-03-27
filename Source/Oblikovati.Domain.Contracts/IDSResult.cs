using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDSResult
{

    IDSDegreeOfFreedom Parent { get; }
    string Name { get; }
    DSResultTypeEnum ResultType { get; }
    void GetResultValues(List<double> ResultValues);
    double GetCurrentResultValue();
}
