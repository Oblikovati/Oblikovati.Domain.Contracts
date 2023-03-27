﻿namespace Oblikovati.Domain.Contracts;

public interface ITorus
{
    IPoint CenterPoint { get; set; }
    IUnitVector AxisVector { get; set; }
    double MajorRadius { get; set; }
    double MinorRadius { get; set; }
    ISurfaceEvaluator Evaluator { get; }
    void GetTorusData(ref List<double> CenterPoint, ref List<double> AxisVector, out double MajorRadius, out double MinorRadius);
    void PutTorusData(ref List<double> CenterPoint, ref List<double> AxisVector, double MajorRadius, double MinorRadius);
    ITorus Copy();
}
