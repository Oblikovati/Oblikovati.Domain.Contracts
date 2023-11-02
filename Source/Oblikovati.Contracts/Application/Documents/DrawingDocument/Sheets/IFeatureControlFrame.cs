using Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Leaders;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.DrawingDocument.Sheets;

public interface IFeatureControlFrame
{
    ISheet Parent { get; }
    IAttributeSets AttributeSets { get; }
    IPoint2d Position { get; set; }
    IFeatureControlFrameRows FeatureControlFrameRows { get; set; }
    IFeatureControlFrameStyle Style { get; set; }
    ILayer Layer { get; set; }
    ILeader Leader { get; }
    double Rotation { get; set; }
    bool AllAroundSymbol { get; set; }
    string DatumIdentifier { get; set; }
    string Notes { get; set; }
    string TopNotes { get; set; }
    bool MergeSymbolOverridden { get; set; }
    bool OverrideMergeSymbol { get; set; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
}