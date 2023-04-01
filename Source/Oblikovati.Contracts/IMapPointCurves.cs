namespace Oblikovati.Contracts;

public interface IMapPointCurves : IList<IMapPointCurves>
{
    IMapPointCurve Item { get; }


    IMapPointCurve AddMapCurve();
}