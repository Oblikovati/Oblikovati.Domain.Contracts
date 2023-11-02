using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.NotClassified;

public interface IThreadInfo
{
    string ThreadType { get; set; }
    string ThreadTypeIdentifier { get; }
    bool Metric { get; set; }
    bool Internal { get; set; }
    bool RightHanded { get; set; }
    string _NominalSizeDescription { get; set; }
    string ThreadDesignation { get; }
    string CustomThreadDesignation { get; }
    IObjectsEnumerator ThreadBasePoints { get; }
    IUnitVector _ThreadDirection { get; }
    IVector ThreadDirection { get; }
    bool FullThreadDepth { get; set; }
}