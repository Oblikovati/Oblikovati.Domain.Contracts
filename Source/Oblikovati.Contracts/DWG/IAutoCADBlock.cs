using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.DWG;

public interface IAutoCADBlock
{
    ISheet Parent { get; }
    IAutoCADBlockDefinition Definition { get; set; }
    IPoint2d Position { get; set; }
    IMatrix2d Transformation { get; }
    IAttributeSets AttributeSets { get; }
    ILayer Layer { get; set; }
    double Scale { get; set; }
    double Rotation { get; set; }
    string Name { get; }
    IColor Color { get; set; }
    double LineWeight { get; set; }
    LineTypeEnum LineType { get; set; }
    bool Static { get; set; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
    void GetPromptTextValues(out object PromptTags, out object Values);
    void SetPromptTextValues(object PromptTags, object Values);
}