using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;

public interface IUserCoordinateSystemDefinition
{
    UCSDefinitionTypeEnum DefinitionType { get; }
    IUserCoordinateSystem Parent { get; }
    IMatrix Transformation { get; set; }
    void GetByThreePoints(out object Origin, out object XDirectionPoint, out object YDirectionPoint);
    void SetByThreePoints(object Origin, object XDirectionPoint, object YDirectionPoint);
}