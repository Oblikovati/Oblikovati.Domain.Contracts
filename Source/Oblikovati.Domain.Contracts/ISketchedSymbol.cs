using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISketchedSymbol
{

    ISheet Parent { get; }
    ISketchedSymbolDefinition Definition { get; }
    IPoint2d Position { get; set; }
    IMatrix2d Transformation { get; }
    IAttributeSets AttributeSets { get; }
    ILayer Layer { get; set; }
    double Scale { get; set; }
    double Rotation { get; set; }
    bool Callout { get; }
    ILeader Leader { get; }
    bool LeaderVisible { get; set; }
    bool Static { get; set; }
    bool SymbolClipping { get; set; }
    string Name { get; set; }
    bool LeaderClipping { get; set; }
    IGeometryIntent _AttachedEntity { get; set; }
    IColor Color { get; set; }
    double LineWeight { get; set; }
    LineTypeEnum LineType { get; set; }
    ILeaderStyle LeaderStyle { get; set; }
    void Delete();
    string GetResultText(ITextBox DefinitionText);
    void SetPromptResultText(ITextBox DefinitionText, string NewValue);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
}
