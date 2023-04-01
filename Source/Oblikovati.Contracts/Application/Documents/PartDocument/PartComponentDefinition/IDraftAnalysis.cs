using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;

public interface IDraftAnalysis
{
    IAnalysisManager Parent { get; }

    IAttributeSets AttributeSets { get; }
    int DisplayQuality { get; set; }
    double EndAngle { get; set; }
    double StartAngle { get; set; }
    bool PullDirectionReversed { get; set; }
    object PullDirection { get; set; }
    bool GradientDisplay { get; set; }
    IObjectCollection Faces { get; set; }
    string Name { get; set; }
    IDraftAnalysis Copy();
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Activate();
}