using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

public interface IFactoryOptions
{
    bool IsPartNumberIndexed { get; set; }
    int MemberNameIndexDigits { get; set; }
    int MemberNameIndexInitialValue { get; set; }
    string MemberNameIndexSeparator { get; set; }
    int MemberNameIndexStepValue { get; set; }
    string MemberNameValue { get; set; }
    FactoryOptionsMemberNameTypeEnum MemberNameType { get; set; }
    int PartNumberIndexDigits { get; set; }
    int PartNumberIndexInitialValue { get; set; }
    string PartNumberIndexSeparator { get; set; }
    int PartNumberIndexStepValue { get; set; }
    string PartNumberValue { get; set; }
    FactoryOptionsPartNumberTypeEnum PartNumberType { get; set; }
    void ApplyToAllMembers();
}