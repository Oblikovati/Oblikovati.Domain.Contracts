using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts;

public interface IFlatPatternOrientation
{
    IFlatPattern Parent { get; }
    IParameter AlignmentRotation { get; }
    object AlignmentAxis { get; set; }
    AlignmentTypeEnum AlignmentType { get; set; }
    bool FlipAlignmentAxis { get; set; }
    bool FlipBaseFace { get; set; }
    string Name { get; set; }
    void Activate();
    IFlatPatternOrientation Copy(string Name);
    void Delete();
}