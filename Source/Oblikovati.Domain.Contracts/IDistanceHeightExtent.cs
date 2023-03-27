﻿using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDistanceHeightExtent
{

    IPartFeature Parent { get; }
    IParameter Distance { get; }
    PartFeatureExtentDirectionEnum FlangeDirection { get; set; }
    HeightDatumTypeEnum HeightDatumType { get; set; }
}
