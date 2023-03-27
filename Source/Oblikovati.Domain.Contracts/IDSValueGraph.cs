using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDSValueGraph
{

    int PointCount { get; }
    void GetSegmentInterpolationType(int SegmentIndex, out DSGraphInterpolationTypeEnum InterpolationType, out INameValueMap AdditionalInfo);
    void GetValueArray(out List<double> TimeValueArray);
    void SetSegmentInterpolationType(int SegmentIndex, DSGraphInterpolationTypeEnum InterpolationType, INameValueMap AdditionalInfo);
    void SetValueUsingArray(List<double> TimeValueArray, DSGraphInterpolationTypeEnum InterpolationType);
}
