﻿using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IRepresentationEventsSink_Event
{
    void add_OnDelete(RepresentationEventsSink_OnDeleteEventHandler handler);
    void remove_OnDelete(RepresentationEventsSink_OnDeleteEventHandler handler);
    void add_OnNewDesignViewRepresentation(RepresentationEventsSink_OnNewDesignViewRepresentationEventHandler handler);
    void remove_OnNewDesignViewRepresentation(RepresentationEventsSink_OnNewDesignViewRepresentationEventHandler handler);
    void add_OnActivateDesignViewRepresentation(RepresentationEventsSink_OnActivateDesignViewRepresentationEventHandler handler);
    void remove_OnActivateDesignViewRepresentation(RepresentationEventsSink_OnActivateDesignViewRepresentationEventHandler handler);
    void add_OnNewDesignView(RepresentationEventsSink_OnNewDesignViewEventHandler handler);
    void remove_OnNewDesignView(RepresentationEventsSink_OnNewDesignViewEventHandler handler);
    void add_OnActivateDesignView(RepresentationEventsSink_OnActivateDesignViewEventHandler handler);
    void remove_OnActivateDesignView(RepresentationEventsSink_OnActivateDesignViewEventHandler handler);
    void add_OnNewPositionalRepresentation(RepresentationEventsSink_OnNewPositionalRepresentationEventHandler handler);
    void remove_OnNewPositionalRepresentation(RepresentationEventsSink_OnNewPositionalRepresentationEventHandler handler);
    void add_OnActivatePositionalRepresentation(RepresentationEventsSink_OnActivatePositionalRepresentationEventHandler handler);
    void remove_OnActivatePositionalRepresentation(RepresentationEventsSink_OnActivatePositionalRepresentationEventHandler handler);
    void add_OnNewLevelOfDetailRepresentation(RepresentationEventsSink_OnNewLevelOfDetailRepresentationEventHandler handler);
    void remove_OnNewLevelOfDetailRepresentation(RepresentationEventsSink_OnNewLevelOfDetailRepresentationEventHandler handler);
    void add_OnActivateLevelOfDetailRepresentation(RepresentationEventsSink_OnActivateLevelOfDetailRepresentationEventHandler handler);
    void remove_OnActivateLevelOfDetailRepresentation(RepresentationEventsSink_OnActivateLevelOfDetailRepresentationEventHandler handler);
    void add_OnNewSectionView(RepresentationEventsSink_OnNewSectionViewEventHandler handler);
    void remove_OnNewSectionView(RepresentationEventsSink_OnNewSectionViewEventHandler handler);
}
