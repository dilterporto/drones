using DroneApp.Api.Domain.Entities;

namespace DroneApp.Api.Domain.Services;

public interface ICalculateDistributionService
{
    Distribution Apply(Drone drone, IEnumerable<ScheduledDestination> scheduledDestinations);
}

