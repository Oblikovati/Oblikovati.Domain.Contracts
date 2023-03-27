using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ILayer
{
    IDrawingStylesManager _Parent { get; }

    string Name { get; set; }
    string InternalName { get; }
    bool InUse { get; }
    StyleLocationEnum StyleLocation { get; }
    bool UpToDate { get; }
    StyleTypeEnum StyleType { get; }
    string Comments { get; set; }

    bool Visible { get; set; }
    string _Name { get; set; }
    string _InternalName { get; }
    StyleLocationEnum _StyleLocation { get; }
    bool _InUse { get; }
    bool _UpToDate { get; }
    IColor Color { get; set; }
    LineTypeEnum LineType { get; set; }
    double LineWeight { get; set; }
    bool ScaleByLineWeight { get; set; }
    bool AutomaticColor { get; set; }
    bool Plot { get; set; }
    void Delete();
    void SaveToGlobal();
    void UpdateFromGlobal();
    IStyle ConvertToLocal();
    IStyle Copy(string Name);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
    ILayer _Copy(string NewName);
    void _Delete();
    ILayer _ConvertToLocal();
    void _SaveToGlobal();
    void _UpdateFromGlobal();
}
