using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;

public interface ISketchBlocks : IList<ISketchBlocks>
{
    ISketchBlock Item { get; }


    ISketchBlock Add(IObjectCollection SketchObjects, string Name, object InsertionPoint);
    ISketchBlock AddByDefinition(ISketchBlockDefinition Definition, IPoint2d Position);
}