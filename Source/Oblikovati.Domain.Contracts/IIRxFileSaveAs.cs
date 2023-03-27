namespace Oblikovati.Domain.Contracts;

public interface IIRxFileSaveAs
{
    void _WhereUsed(object pDocument, ref int pnOwningDocuments, out IntPtr pppOwningDocuments);
    void AddFileToSave(object pDocument, string pTargetFileName);
    void ExecuteSaveAs();
    void ExecuteSaveCopyAs();
    void ExecuteSave();
}
