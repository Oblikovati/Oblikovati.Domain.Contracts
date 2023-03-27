﻿namespace Oblikovati.Domain.Contracts;

public interface IInsertiMateDefinition
{

    string Identifier { get; }
    string Name { get; set; }
    int SequenceIndex { get; set; }
    bool Suppressed { get; set; }
    IAttributeSets AttributeSets { get; }
    object MatchList { get; set; }
    IiMateDefinition ReferencedEntity { get; }
    bool HasReferenceComponent { get; }
    IReferenceComponent ReferenceComponent { get; }
    bool Exported { get; set; }
    IParameter Distance { get; }
    bool AxesOpposed { get; }
    object Entity { get; }
    IConstraintLimits ConstraintLimits { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
