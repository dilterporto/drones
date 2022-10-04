using DroneApp.Api.Contracts.Responses;
using MediatR;

namespace DroneApp.Api.Contracts.Requests;

public class DeliveryRequest : IRequest<DeliverResponse>
{
    public IList<DroneRequest> DronesAssigned { get; set; }
    public IList<ScheduledDestinationRequest> ScheduledDestinations { get; set; }
}