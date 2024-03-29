﻿using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.NotClassified;

public interface IPunchNotes : IList<IPunchNotes>
{
    IPunchNote Item { get; }
    IPunchNote Add(IPoint2d Position, IGeometryIntent PunchEdge, object DimensionStyle);
}