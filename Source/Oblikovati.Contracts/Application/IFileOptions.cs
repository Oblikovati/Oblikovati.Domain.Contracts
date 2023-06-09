﻿using Oblikovati.Contracts.Application.FileManager;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application;

public interface IFileOptions : IInjectableSingletonEntity
{
    string ProjectsPath { get; set; }
    string TeamWebFullFilename { get; set; }
    string TemplatesPath { get; set; }
    string UndoPath { get; set; }
    string DesignDataPath { get; set; }
    string ContentCenterPath { get; set; }
    IFileOpenOptions FileOpenOptions { get; }
    bool QuickFileOpenEnabled { get; set; }
    bool QuickFileOpenCacheLastAssembly { get; set; }
    string QuickFileOpenCachedAssembly { get; set; }
    bool DefaultTemplateUnitsAreInches { get; set; }
    DraftingStandardEnum DefaultTemplateDrawingStandard { get; set; }
    string SymbolLibraryPath { get; set; }
    string TexturePath { get; set; }
    string PresetsPath { get; set; }
}