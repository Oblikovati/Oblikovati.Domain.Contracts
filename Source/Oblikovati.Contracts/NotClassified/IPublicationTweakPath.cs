﻿namespace Oblikovati.Contracts.NotClassified;

public interface IPublicationTweakPath
{
    IPublicationTweak Parent { get; }
    bool Visible { get; set; }
    IPublicationTrailSegmentsEnumerator TrailSegments { get; }
    IPublicationComponent PublicationComponent { get; }
    void Delete();
    void SetTimeRange(double StartTime, double EndTime);
    void GetTimeRange(out double StartTime, out double EndTime);
}