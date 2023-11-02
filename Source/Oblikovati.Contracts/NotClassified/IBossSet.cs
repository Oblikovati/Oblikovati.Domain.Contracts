using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.NotClassified;

public interface IBossSet
{
    IRibDefinition Parent { get; }
    IObjectCollection Centers { get; set; }
    object Diameter { get; set; }
    object Offset { get; set; }
    object TaperAngle { get; set; }
    void Delete();
}