using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.DynamicSimulation;

public interface IDSValueGraph
{
    int PointCount { get; }

    void GetSegmentInterpolationType(int SegmentIndex, out DSGraphInterpolationTypeEnum InterpolationType,
        out INameValueMap AdditionalInfo);

    void GetValueArray(out List<double> TimeValueArray);

    void SetSegmentInterpolationType(int SegmentIndex, DSGraphInterpolationTypeEnum InterpolationType,
        INameValueMap AdditionalInfo);

    void SetValueUsingArray(List<double> TimeValueArray, DSGraphInterpolationTypeEnum InterpolationType);
}