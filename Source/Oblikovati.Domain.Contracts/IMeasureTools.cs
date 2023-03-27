using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IMeasureTools
{


    double GetMinimumDistance(object EntityOne, object EntityTwo, InferredTypeEnum EntityOneInferredType, InferredTypeEnum EntityTwoInferredType, ref object Context);
    double GetAngle(object EntityOne, object EntityTwo, object EntityThree);
    double GetLoopLength(object Curves);
    int GetAnglePrecision(IDocument Document);
    int SetAnglePrecision(IDocument Document, int Precision);
    int GetLengthPrecision(IDocument Document);
    int SetLengthPrecision(IDocument Document, int Precision);
}
