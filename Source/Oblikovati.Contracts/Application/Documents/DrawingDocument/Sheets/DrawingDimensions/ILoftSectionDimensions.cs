namespace Oblikovati.Contracts.Application.Documents.DrawingDocument.Sheets.DrawingDimensions;

public interface ILoftSectionDimensions : IList<ILoftSectionDimensions>
{
    ILoftSectionDimension Item { get; }


    ILoftSectionDimension AddDrivenSection(double Position, bool PositionAsAbsoluteDistance);

    ILoftSectionDimension AddDrivingSection(double Position, double Size, bool PositionAsAbsoluteDistance,
        bool SizeAsScaleFactor);
}