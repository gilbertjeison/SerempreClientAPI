using MediatR;

namespace SerempreClientAPI.Application.City.CreateCity;

public class CreateCityRequest : IRequest<Domain.Entities.City>
{
    public int Id { get; set; }
    public string? Name { get; set; }
}
