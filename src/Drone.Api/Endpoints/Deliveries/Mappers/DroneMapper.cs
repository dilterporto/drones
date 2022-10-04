using AutoMapper;
using DroneApp.Api.Contracts.Requests;
using DroneApp.Api.Domain.Entities;

namespace DroneApp.Api.Endpoints.Deliveries.Mappers;

public class DroneMapper : Profile
{
    public DroneMapper()
    {
        CreateMap<DroneRequest, Drone>();
    }    
}