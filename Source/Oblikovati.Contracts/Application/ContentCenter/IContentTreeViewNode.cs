﻿using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.ContentCenter;

public interface IContentTreeViewNode
{
    IContentTreeViewNodesEnumerator ChildNodes { get; }
    string DisplayName { get; }
    IContentFamiliesEnumerator Families { get; }
    string FullTreeViewPath { get; }
    string InternalName { get; }
    IContentTreeViewNode ParentNode { get; }
}