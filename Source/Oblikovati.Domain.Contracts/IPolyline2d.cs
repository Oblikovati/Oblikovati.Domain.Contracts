﻿namespace Oblikovati.Domain.Contracts;

public interface IPolyline2d
{
    ICurve2dEvaluator Evaluator { get; }
    IPoint2d PointAtIndex { get; set; }
    int PointCount { get; }
    void GetPoints(out List<double> Points);
    void PutPoints(object Points);
    IPolyline2d Copy();
}
