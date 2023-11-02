using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.DynamicSimulation;

public interface IDynamicSimulation
{
    ISimulationManager Parent { get; }
    int CurrentTimeStep { get; set; }
    IDSJoints DSJoints { get; }
    IDSLoads DSLoads { get; }
    IDSSettings DSSettings { get; }
    bool IsInSimulationMode { get; set; }
    int NumberOfTimeSteps { get; set; }
    int PlaybackSpeed { get; set; }
    double SimulationLength { get; set; }
    int LastComputedTimeStep { get; }
    void PlaySimulation(int StartStep, int EndStep);
    void ComputeSimulation(int EndStep);
}