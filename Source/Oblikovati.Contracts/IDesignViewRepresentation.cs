using Oblikovati.Contracts.Application.Documents;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IDesignViewRepresentation
{
    IRepresentationsManager Parent { get; }
    string Name { get; set; }
    IAttributeSets AttributeSets { get; }
    DesignViewTypeEnum DesignViewType { get; }
    bool Locked { get; set; }
    string DesignViewInfo { get; }
    bool AutoSaveCamera { get; set; }
    double ModelAnnotationScale { get; set; }
    ICamera Camera { get; set; }
    bool ModelAnnotationAutoScale { get; set; }
    bool Publish { get; set; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Activate();
    IDesignViewRepresentation Copy(string NewName);
    void Delete();
    void HideAll();
    void ShowAll();
    void RemoveColorOverrides();
    ILevelOfDetailRepresentation CopyToLevelOfDetail(string NewName);
    void SetVisibilityOfOccurrences(IObjectCollection Occurrences, bool Visible);
    void RemoveAppearanceOverrides();
    void SaveCurrentCamera();
    void RestoreCamera();
    void SetSectionView(SectionViewTypeEnum SectionViewType, object FirstSectionPlane, object SecondSectionPlane);

    void GetSectionViewInfo(out SectionViewTypeEnum SectionViewType, out IPlane FirstSectionPlane,
        out IPlane SecondSectionPlane);

    IModelState CopyComponentVisibilityToSuppression(string NewName);
}