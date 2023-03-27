﻿namespace Oblikovati.Domain.Contracts;

public interface IPresentationSnapshotView
{

    IPresentationScene Parent { get; }
    string DisplayName { get; set; }
    ICamera SavedCamera { get; }
    bool StoryboardAssociative { get; set; }
    IPresentationTrails Trails { get; }
    void Edit();
    void ExitEdit();
    void SetAppearance(IObjectCollection PresentationComponents, IAsset Appearance);
    void SetOpacity(IObjectCollection PresentationComponents, double Opacity);
    void SetVisibility(IObjectCollection PresentationComponents, bool Visible);
}
