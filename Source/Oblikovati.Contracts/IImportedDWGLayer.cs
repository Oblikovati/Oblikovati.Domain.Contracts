﻿namespace Oblikovati.Contracts;

public interface IImportedDWGLayer
{
    string Name { get; }
    bool Visible { get; set; }
}