﻿namespace Oblikovati.Domain.Contracts;

public interface IAngleiMateDefinition
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
    IParameter Angle { get; }
    bool DirectionOneReversed { get; }
    object Entity { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
