namespace Oblikovati.Domain.Contracts.Enums;

public enum AddInLoadBehaviorEnum
{
    kLoadImmediately,
    kLoadWithParts,
    kLoadWithAssemblies,
    kLoadWithPresentations,
    kLoadWithDrawings,
    kLoadOnDemand,
    kLoadBehaviorUnknown,
}
