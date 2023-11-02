namespace Oblikovati.Contracts.NotClassified;

public interface IMapPointCurves : IList<IMapPointCurves>
{
    IMapPointCurve Item { get; }


    IMapPointCurve AddMapCurve();
}