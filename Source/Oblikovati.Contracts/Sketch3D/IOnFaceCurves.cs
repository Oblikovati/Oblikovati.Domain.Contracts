using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Sketch3D;

public interface IOnFaceCurves : IList<IOnFaceCurves>
{
    IOnFaceCurve Item { get; }

    IOnFaceCurve Add(INameValueMap Faces, INameValueMap FitPoints);
}