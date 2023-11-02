using Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

public interface ICentermark
{
    ISheet Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Visible { get; set; }
    CentermarkTypeEnum CentermarkType { get; }
    object ModelWorkFeature { get; }
    bool Attached { get; }
    IPoint2d ExtensionPointOne { get; set; }
    IUnitVector2d ExtensionPointOneDirection { get; }
    IPoint2d ExtensionPointTwo { get; set; }
    IUnitVector2d ExtensionPointTwoDirection { get; }
    IPoint2d ExtensionPointThree { get; set; }
    IUnitVector2d ExtensionPointThreeDirection { get; }
    IPoint2d ExtensionPointFour { get; set; }
    IUnitVector2d ExtensionPointFourDirection { get; }
    IPoint2d Position { get; }
    IObjectsEnumerator Centerlines { get; }
    ILayer Layer { get; set; }
    ICentermarkStyle Style { get; set; }
    object AttachedEntity { get; }
    bool ExtensionLinesVisible { get; set; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
}