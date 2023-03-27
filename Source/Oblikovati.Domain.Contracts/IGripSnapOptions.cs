﻿namespace Oblikovati.Domain.Contracts;

public interface IGripSnapOptions
{

    bool DisplayObjectInOriginalLocation { get; set; }
    bool SelectGroundedComponentsAndWorkGeometry { get; set; }
    bool ShowDegreesOfFreedom { get; set; }
    bool UseFreeDrag { get; set; }
    bool UseTemporaryConstraints { get; set; }
}
