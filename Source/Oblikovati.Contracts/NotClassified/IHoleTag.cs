using Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Leaders;

namespace Oblikovati.Contracts.NotClassified;

public interface IHoleTag
{
    IHoleTableRow Parent { get; }
    string Text { get; set; }
    string FormattedText { get; set; }
    bool Visible { get; set; }
    bool ShowLeader { get; set; }
    IPoint2d Position { get; set; }
    IDimensionStyle DimensionStyle { get; set; }
    ILayer Layer { get; set; }
    ILeader Leader { get; }
    VerticalTextAlignmentEnum StackedTextPosition { get; set; }
    IBox2d RangeBox { get; }
}