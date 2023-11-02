using Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;
using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.NotClassified;

public interface ITableFormat
{
    IColor InsideLineColor { get; set; }
    double InsideLineWeight { get; set; }
    IColor OutsideLineColor { get; set; }
    double OutsideLineWeight { get; set; }
    ITextStyle TextStyle { get; set; }
}