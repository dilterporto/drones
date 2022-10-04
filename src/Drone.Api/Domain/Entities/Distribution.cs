namespace DroneApp.Api.Domain.Entities;

public class Distribution
{
    public Drone DroneAssigned { get; set; }
    public IList<Trip> Trips { get; set; }
}