﻿namespace Oblikovati.Contracts.NotClassified;

public interface IFreeDragMoveOperation
{
    IMoveDefinition Parent { get; }
    object XOffset { get; set; }
    object YOffset { get; set; }
    object ZOffset { get; set; }
    void Delete();
}