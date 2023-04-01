using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.Document;

public interface ISketchSettings
{
    IDocument Parent { get; }
    int MinorLinesPerMajorGridLine { get; set; }
    int SnapsPerMinorGrid { get; set; }
    string XSnapSpacing { get; set; }
    string YSnapSpacing { get; set; }
    bool DisplayLineWeights { get; set; }
    LineWeightTypeEnum LineWeightType { get; set; }
    double UpperLimitForFirstRangeOfLineWeights { get; set; }
    double UpperLimitForSecondRangeOfLineWeights { get; set; }
    double UpperLimitForThirdRangeOfLineWeights { get; set; }
}