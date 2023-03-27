namespace Oblikovati.Domain.Contracts.Enums;

public enum FileManagementEnum
{
    kNoForceFile,
    kForceFile,
    kOverwriteExistingFile,
    kOverwriteReservedFile,
    kOverwriteReadOnlyFile,
    kCopyFileMask,
    kDeleteFileMask,
    kMoveFileMask,
}
