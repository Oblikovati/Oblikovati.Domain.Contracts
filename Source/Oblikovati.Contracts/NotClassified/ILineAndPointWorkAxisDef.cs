﻿namespace Oblikovati.Contracts.NotClassified;

public interface ILineAndPointWorkAxisDef
{
    IWorkAxis Parent { get; }
    object Line { get; }
    object Point { get; }
    void GetData(out object Line, out object Point);
}