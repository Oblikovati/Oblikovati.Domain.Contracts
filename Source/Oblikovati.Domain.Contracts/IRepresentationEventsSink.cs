using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IRepresentationEventsSink
{
    void OnDelete(IDocument Document, object Entity, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnNewDesignViewRepresentation(I_AssemblyDocument Document, IDesignViewRepresentation Representation, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnActivateDesignViewRepresentation(I_AssemblyDocument Document, IDesignViewRepresentation Representation, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnNewDesignView(IDocument Document, IDesignViewRepresentation Representation, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnActivateDesignView(IDocument Document, IDesignViewRepresentation Representation, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnNewPositionalRepresentation(I_AssemblyDocument Document, IPositionalRepresentation Representation, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnActivatePositionalRepresentation(I_AssemblyDocument Document, IPositionalRepresentation Representation, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnNewLevelOfDetailRepresentation(IDocument Document, ILevelOfDetailRepresentation Representation, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnActivateLevelOfDetailRepresentation(IDocument Document, ILevelOfDetailRepresentation Representation, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnNewSectionView(IDocument Document, IDesignViewRepresentation Representation, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
}
