﻿namespace Oblikovati.Contracts;

public interface IRows : IList<IRows>
{
    IRow Item { get; }


    IRow Add(int TargetIndex, bool InsertBefore, object Contents, object Height);
}