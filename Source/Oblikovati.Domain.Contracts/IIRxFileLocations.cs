using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IIRxFileLocations
{
    string Workspace { get; set; }
    short _WorkspaceActive { get; set; }
    short _LocalsActive { get; set; }
    short _WorkgroupsActive { get; set; }
    string FileLocationsFilesDir { get; set; }
    string FileLocationsFile { get; set; }
    short _CurrentSettingsDirty { get; }
    short _Dirty { get; }
    void Locals(ref int pnPaths, out IntPtr pppNames, out IntPtr ppbstrPaths);
    void RemoveLocal(string bstrName);
    void AddLocal(string bstrName, string bstrPath, int nIndex);
    void Workgroups(ref int pnPaths, out IntPtr ppbstrNames, out IntPtr ppbstrPaths);
    void RemoveWorkgroup(string bstrName);
    void AddWorkgroup(string bstrName, string bstrPath, int nIndex);
    void Libraries(ref int pnPaths, out IntPtr ppbstrNames, out IntPtr ppbstrPaths);
    void RemoveLibrary(string bstrName);
    void AddLibrary(string bstrName, string bstrPath);
    void _ApplyCurrentSettings();
    void _Save();
    void _SaveAs(string bstrFile);
    void FindInLocations(string bstrFullFileName, out string pbstrRepositoryName, out LocationTypeEnum pType);
    void FindLogicalInLocations(string bstrRelativeFileName, string bstrLibraryName, out string pbstrRepositoryName, out LocationTypeEnum pType);
}
