﻿using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.FilletFeature;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

public interface IFilletDefinition
{
    IFilletFeature Parent { get; }
    FilletTypeEnum FilletType { get; }
    IFilletRadiusEdgeSet EdgeSetItem { get; }
    int EdgeSetCount { get; }
    IFilletSetbackVertex SetbackVertexItem { get; }
    int SetbackVertexCount { get; }
    IFilletConstantRadiusFaceSet FaceSet { get; }
    IFilletFullRoundSet FullRoundSet { get; }
    IFilletConstantRadiusEdgeSet AddConstantRadiusEdgeSet(IEdgeCollection Edges, object ConstantRadius);
    IFilletVariableRadiusEdgeSet AddVariableRadiusEdgeSet(IEdgeCollection Edges, object StartRadius, object EndRadius);

    IFilletConstantRadiusFaceSet AddFaceSet(IFaceCollection FacesOne, IFaceCollection FacesTwo, object Radius,
        bool IncludeTangentFaces, object BiasPoint, bool FacesOneReverseDirection, bool FacesTwoReverseDirection);

    IFilletFullRoundSet AddFullRoundSet(IFaceCollection SideFacesOne, IFaceCollection CenterFaces,
        IFaceCollection SideFacesTwo, bool IncludeTangentFaces);
}