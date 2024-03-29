﻿using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.TransientBRep;

public interface ISurfaceBodyDefinition
{
    IEdgeDefinitions EdgeDefinitions { get; }
    ILumpDefinitions LumpDefinitions { get; }
    IVertexDefinitions VertexDefinitions { get; }
    ISurfaceBody CreateTransientSurfaceBody(out INameValueMap Errors, object Options);
}