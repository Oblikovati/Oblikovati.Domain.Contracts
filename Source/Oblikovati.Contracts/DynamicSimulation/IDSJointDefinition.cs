﻿using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.DynamicSimulation;

public interface IDSJointDefinition
{
    IDSJoint Parent { get; }
    IDSDegreesOfFreedom DegreesOfFreedom { get; }
    IColor ForceGlyphColor { get; set; }
    double ForceGlyphScale { get; set; }
    bool IsDOFsLocked { get; set; }
    bool IsForceDisplayed { get; set; }
    bool IsSuppressed { get; set; }
    bool IsLoadDisplayed { get; set; }
    IColor LoadGlyphColor { get; set; }
    double LoadGlyphScale { get; set; }
    IDSJointDefinition Copy();
}