﻿using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition;
using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application;

public interface IRepresentationEventsSink
{
    void OnDelete(IDocument Document, object Entity, EventTimingEnum BeforeOrAfter, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);

    void OnNewDesignViewRepresentation(IAssemblyDocument Document, IDesignViewRepresentation Representation,
        EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnActivateDesignViewRepresentation(IAssemblyDocument Document, IDesignViewRepresentation Representation,
        EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnNewDesignView(IDocument Document, IDesignViewRepresentation Representation, EventTimingEnum BeforeOrAfter,
        INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnActivateDesignView(IDocument Document, IDesignViewRepresentation Representation,
        EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnNewPositionalRepresentation(IAssemblyDocument Document, IPositionalRepresentation Representation,
        EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnActivatePositionalRepresentation(IAssemblyDocument Document, IPositionalRepresentation Representation,
        EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnNewLevelOfDetailRepresentation(IDocument Document, ILevelOfDetailRepresentation Representation,
        EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnActivateLevelOfDetailRepresentation(IDocument Document, ILevelOfDetailRepresentation Representation,
        EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnNewSectionView(IDocument Document, IDesignViewRepresentation Representation, EventTimingEnum BeforeOrAfter,
        INameValueMap Context, out HandlingCodeEnum HandlingCode);
}