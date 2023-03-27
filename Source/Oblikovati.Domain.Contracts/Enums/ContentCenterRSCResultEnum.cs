﻿namespace Oblikovati.Domain.Contracts.Enums;

public enum ContentCenterRSCResultEnum
{
    kRSCNoError,
    kRSCUnknownFailed,
    kRSCPartIsTPPipe,
    kRSCNoTPAddInLoadedForTPPart,
    kRSCFamilyHealthRequiresReAuthor,
    kRSCFamilyHealthTableUpdateIncomplete,
    kRSCFamilyHealthMissingCatParamMap,
    kRSCFamilyHealthOutOfDateWithTable,
    kRSCFamilyHealthOutOfDateWithCategory,
    kRSCFamilyHealthOutOfDateWithTableAndCategory,
    kRSCFamilyHealthOutOfDateWithAuthorTableAndCategory,
    kRSCInstancingUnknownError,
    kRSCInstancingMissingFileWritePermission,
    kRSCInstancingDifferentFamily,
    kRSCInstancingDifferentMember,
    kRSCInstancingMaterialNotFound,
    kRSCInstancingLongFilename,
    kRSCInstancingFeatureSuppressFail,
    kRSCInstancingThreadFeatureNotFound,
    kRSCInstancingThreadCreateFail,
    kRSCInstancingInvalidMemberValue,
    kRSCReplaceFailed,
}
