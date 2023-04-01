using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.BIMExchange;

public interface IBIMElectricalConnectorDefinition
{
    IBIMConnector Parent { get; }
    BIMConnectorShapeEnum ConnectorShape { get; }
    IUnitVector Direction { get; }
    IObjectCollection Geometry { get; }
    IPoint Origin { get; }
    double ApparentLoad { get; set; }
    double ApparentLoadPhase1 { get; set; }
    double ApparentLoadPhase2 { get; set; }
    double ApparentLoadPhase3 { get; set; }
    string Description { get; set; }
    bool HasMotor { get; set; }
    string LoadClassification { get; set; }
    int NumberOfPoles { get; set; }
    double PowerFactor { get; set; }
    BIMElectricalPowerFactorStateEnum PowerFactorState { get; set; }
    BIMElectricalSystemTypeEnum SystemType { get; set; }
    double Voltage { get; set; }
    bool ExposeApparentLoadAsParameter { get; set; }
    object ApparentLoadParameter { get; set; }
    bool ExposeApparentLoadPhase1AsParameter { get; set; }
    object ApparentLoadPhase1Parameter { get; set; }
    bool ExposeApparentLoadPhase2AsParameter { get; set; }
    object ApparentLoadPhase2Parameter { get; set; }
    bool ExposeApparentLoadPhase3AsParameter { get; set; }
    object ApparentLoadPhase3Parameter { get; set; }
    bool ExposeNumberOfPolesAsParameter { get; set; }
    object NumberOfPolesParameter { get; set; }
    bool ExposeVoltageAsParameter { get; set; }
    object VoltageParameter { get; set; }
    bool ExposeLoadClassificationAsParameter { get; set; }
    object LoadClassificationParameter { get; set; }
    bool ExposeHasMotorAsParameter { get; set; }
    object HasMotorParameter { get; set; }
    bool ExposePowerFactorAsParameter { get; set; }
    object PowerFactorParameter { get; set; }
    bool ExposeDescriptionAsParameter { get; set; }
    object DescriptionParameter { get; set; }
    void ReverseDirection();
    void SetShape(IObjectCollection Geometry, BIMConnectorShapeEnum ConnectorShape);
}