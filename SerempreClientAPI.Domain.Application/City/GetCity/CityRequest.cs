using MediatR;

namespace SerempreClientAPI.Application.City.GetCity;

public class CityRequest : IRequest<List<CityResponse>>
{
}
