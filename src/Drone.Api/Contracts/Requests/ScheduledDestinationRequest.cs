namespace DroneApp.Api.Contracts.Requests;

public class ScheduledDestinationRequest
{
    public int Id { get; set; }
    public int LocationCode { get; set; }
    public string Location { get; set; }
    public decimal TotalWeigthToDeliver { get; set; }
}