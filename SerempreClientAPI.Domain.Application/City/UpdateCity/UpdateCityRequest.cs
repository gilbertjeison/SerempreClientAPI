using MediatR;

namespace SerempreClientAPI.Application.City.UpdateCity;

public class UpdateCityRequest : IRequest<Domain.Entities.City>
{
    public int Id { get; set; }
    public string? Name { get; set; }
}
