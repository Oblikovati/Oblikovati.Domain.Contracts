﻿using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.DWG;

public interface IDWGEllipticalArc
{
    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IPoint Center { get; }
    IUnitVector Normal { get; }
}