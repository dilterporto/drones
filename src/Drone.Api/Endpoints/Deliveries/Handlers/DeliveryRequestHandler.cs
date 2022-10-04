using AutoMapper;
using DroneApp.Api.Contracts.Requests;
using DroneApp.Api.Contracts.Responses;
using DroneApp.Api.Domain.Entities;
using DroneApp.Api.Domain.Services;
using MediatR;

namespace DroneApp.Api.Endpoints.Deliveries.Handlers;

public class DeliveryRequestHandler : IRequestHandler<DeliveryRequest, DeliverResponse>
{
    private readonly ICalculateDistributionService _calculateDistributionService;
    private readonly IMapper _mapper;

    public DeliveryRequestHandler(ICalculateDistributionService calculateDistributionService, IMapper mapper)
    {
        _calculateDistributionService = calculateDistributionService;
        _mapper = mapper;
    }

    public async Task<DeliverResponse> Handle(DeliveryRequest request, CancellationToken cancellationToken)
    {
        var distributions = new List<Distribution>();
        foreach (var droneRequest in request.DronesAssigned)
        {
            var drone = _mapper.Map<Drone>(droneRequest);
            var scheduledDestinations = request
                .ScheduledDestinations.Select(x => _mapper.Map<ScheduledDestination>(x));

            var distribution = _calculateDistributionService.Apply(drone, scheduledDestinations);
            distributions.Add(distribution);
        }

        return new DeliverResponse();
    }
}