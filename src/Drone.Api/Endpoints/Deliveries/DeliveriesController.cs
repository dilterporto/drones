using DroneApp.Api.Contracts.Requests;
using DroneApp.Api.Contracts.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DroneApp.Api.Endpoints.Deliveries;

[ApiController]
[Route("v1/deliveries")]
public class DeliveriesController : ControllerBase
{
    private readonly ILogger<DeliveriesController> _logger;
    private readonly IMediator _mediator;

    public DeliveriesController(ILogger<DeliveriesController> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    /// <summary>
    /// Receives the delivery request
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<ActionResult<DeliverResponse>> Post([FromBody] DeliveryRequest request)
    {
        var response = await _mediator.Send(request);
        return Ok(response);
    }
}