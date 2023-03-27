namespace Oblikovati.Domain.Contracts;

public interface ILoftSectionDimension
{

    bool IsDrivingSection { get; set; }
    double Position { get; set; }
    bool PositionAsAbsoluteDistance { get; set; }
    double Size { get; set; }
    bool SizeAsScaleFactor { get; set; }
    void Delete();
}
