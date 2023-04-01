namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;

public interface IDraftAnalyses : IList<IDraftAnalyses>
{
    IDraftAnalysis Item { get; }


    IDraftAnalysis Add(double StartAngle, double EndAngle, object PullDirection, bool Reversed, object Faces,
        bool GradientDisplay, int DisplayQuality, string Name);
}