﻿namespace Oblikovati.Contracts.Application.FileManager;

public interface IFileSaveAs
{
    void _WhereUsed(object Document, ref List<object> OwningDocuments);
    void AddFileToSave(object Document, string TargetFileName);
    void ExecuteSaveAs();
    void ExecuteSaveCopyAs();
    void ExecuteSave();
}