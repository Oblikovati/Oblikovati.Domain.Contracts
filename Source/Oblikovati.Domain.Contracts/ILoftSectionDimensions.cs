namespace Oblikovati.Domain.Contracts;

public interface ILoftSectionDimensions : IList<ILoftSectionDimensions>
{

    ILoftSectionDimension Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    ILoftSectionDimension AddDrivenSection(double Position, bool PositionAsAbsoluteDistance);
    ILoftSectionDimension AddDrivingSection(double Position, double Size, bool PositionAsAbsoluteDistance, bool SizeAsScaleFactor);
}
