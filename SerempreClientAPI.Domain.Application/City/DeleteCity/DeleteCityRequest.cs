using MediatR;

namespace SerempreClientAPI.Application.City.DeleteCity;

public class DeleteCityRequest : IRequest<bool>
{
    public int Id { get; set; }
}
