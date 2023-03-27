﻿namespace Oblikovati.Domain.Contracts;

public interface IRuledSurfaceEdgeFacePair
{

    void SetData(IEdge Edge, IFace Face);
    void GetData(out IEdge Edge, out IFace Face);
    void Delete();
}
