using System.Numerics;

namespace Oblikovati.Domain.Contracts.Windowing;

public interface IWindowEvents
{
    struct WindowResizedEventArgs
    {
        public int Width;
        public int Height;
        public WindowResizedEventArgs(int width, int height)
        {
            Width= width;
            Height= height;
        }
    }
    EventHandler<WindowResizedEventArgs> WindowResized { get; }
}
