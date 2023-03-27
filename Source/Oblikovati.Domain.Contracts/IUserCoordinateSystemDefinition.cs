using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IUserCoordinateSystemDefinition
{

    UCSDefinitionTypeEnum DefinitionType { get; }
    IUserCoordinateSystem Parent { get; }
    IMatrix Transformation { get; set; }
    void GetByThreePoints(out object Origin, out object XDirectionPoint, out object YDirectionPoint);
    void SetByThreePoints(object Origin, object XDirectionPoint, object YDirectionPoint);
}
