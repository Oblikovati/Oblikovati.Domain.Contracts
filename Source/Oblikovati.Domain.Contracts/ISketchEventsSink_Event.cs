using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface ISketchEventsSink_Event
{
    void add_OnNewSketch(SketchEventsSink_OnNewSketchEventHandler handler);
    void remove_OnNewSketch(SketchEventsSink_OnNewSketchEventHandler handler);
    void add_OnSketchChange(SketchEventsSink_OnSketchChangeEventHandler handler);
    void remove_OnSketchChange(SketchEventsSink_OnSketchChangeEventHandler handler);
    void add_OnNewSketch3D(SketchEventsSink_OnNewSketch3DEventHandler handler);
    void remove_OnNewSketch3D(SketchEventsSink_OnNewSketch3DEventHandler handler);
    void add_OnSketch3DChange(SketchEventsSink_OnSketch3DChangeEventHandler handler);
    void remove_OnSketch3DChange(SketchEventsSink_OnSketch3DChangeEventHandler handler);
    void add_OnSketch3DSolve(SketchEventsSink_OnSketch3DSolveEventHandler handler);
    void remove_OnSketch3DSolve(SketchEventsSink_OnSketch3DSolveEventHandler handler);
    void add_OnDelete(SketchEventsSink_OnDeleteEventHandler handler);
    void remove_OnDelete(SketchEventsSink_OnDeleteEventHandler handler);
}
