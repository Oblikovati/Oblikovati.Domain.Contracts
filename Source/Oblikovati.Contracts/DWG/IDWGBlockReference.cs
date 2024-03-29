﻿using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.DWG;

public interface IDWGBlockReference
{
    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IDWGBlockDefinition Definition { get; }
    IMatrix Transformation { get; }
    object GetObject(object ObjectInDefinition);
}