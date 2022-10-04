namespace DroneApp.Api.Contracts.Responses;

public class DeliverResponse
{
    public decimal TotalCost { get; set; }
    public IList<DistributionResponse> Distribution { get; set; }
}

public class DistributionResponse
{
    public string DroneAssigned { get; set; }
    public IList<TripResponse> Trips { get; set; }
}

public class TripResponse
{
    public int TripNumber { get; set; }
    public IList<LocationResponse> Locations { get; set; }
    
}

public class LocationResponse
{
    public string Location { get; set; }
    public decimal WeigthToCarry { get; set; }
}