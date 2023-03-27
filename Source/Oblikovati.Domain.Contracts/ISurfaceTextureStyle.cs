using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISurfaceTextureStyle
{
    IDrawingStylesManager _Parent { get; }

    string Name { get; set; }
    string InternalName { get; }
    bool InUse { get; }
    StyleLocationEnum StyleLocation { get; }
    bool UpToDate { get; }
    StyleTypeEnum StyleType { get; }
    string Comments { get; set; }

    LayDirectionTypeEnum AvailableLaySymbols { get; set; }
    ILeaderStyle LeaderStyle { get; set; }
    ITextStyle TextStyle { get; set; }
    bool MachiningProhibitedSymbolSizeSmall { get; set; }
    DraftingStandardEnum StandardReference { get; set; }
    void Delete();
    void SaveToGlobal();
    void UpdateFromGlobal();
    IStyle ConvertToLocal();
    IStyle Copy(string Name);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
