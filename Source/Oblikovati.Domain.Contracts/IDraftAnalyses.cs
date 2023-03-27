namespace Oblikovati.Domain.Contracts;

public interface IDraftAnalyses : IList<IDraftAnalyses>
{

    IDraftAnalysis Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IDraftAnalysis Add(double StartAngle, double EndAngle, object PullDirection, bool Reversed, object Faces, bool GradientDisplay, int DisplayQuality, string Name);
}
