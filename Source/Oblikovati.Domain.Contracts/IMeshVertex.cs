﻿namespace Oblikovati.Domain.Contracts;

public interface IMeshVertex
{

    IPoint Geometry { get; }
    IMeshFeature MeshFeature { get; }
    IMeshFeatureEntity MeshFeatureEntity { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
