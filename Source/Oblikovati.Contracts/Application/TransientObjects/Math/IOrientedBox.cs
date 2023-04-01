using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.Application.TransientObjects.Math;

public interface IOrientedBox
{
    IPoint CornerPoint { get; set; }
    IVector DirectionOne { get; set; }
    IVector DirectionTwo { get; set; }
    IVector DirectionThree { get; set; }

    void GetOrientedBoxData(out IPoint CornerPoint, out IVector DirectionOne, out IVector DirectionTwo,
        out IVector DirectionThree);

    void PutOrientedBoxData(IPoint CornerPoint, IVector DirectionOne, IVector DirectionTwo, IVector DirectionThree);
    IOrientedBox Copy();
    bool Contains(IPoint Point);
    bool IsDisjoint(IOrientedBox OrientedBox);
}