﻿namespace Oblikovati.Domain.Contracts.Enums;

public enum MemberManagerErrorsEnum
{
    kMemberManagerNoError,
    kMemberManagerUnknown,
    kMemberManagerVaultFileStatusFail,
    kMemberManagerVaultCheckoutFail,
    kMemberManagerVaultGetLatestVersionFail,
    kMemberManagerMissingFileWritePermission,
    kMemberManagerDifferentFamily,
    kMemberManagerDifferentMember,
    kMemberManagerMaterialNotFound,
    kMemberManagerLongFilename,
    kMemberManagerFeatureSuppressFail,
    kMemberManagerThreadFeatureNotFound,
    kMemberManagerThreadCreateFail,
    kMemberManagerInvalidMemberValue,
    kMemberManagerInvalidTemplateModelParameters,
    kMemberManagerInvalidTemplateUserParameters,
}
