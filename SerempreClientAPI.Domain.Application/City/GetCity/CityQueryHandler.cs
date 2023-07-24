using MediatR;
using SerempreClientAPI.Application.Services;

namespace SerempreClientAPI.Application.City.GetCity;

public class CityQueryHandler : IRequestHandler<CityRequest, List<CityResponse>>
{
    private readonly CityService cityService;

    public CityQueryHandler(CityService _cityService)
    {
        this.cityService = _cityService;
    }

    public Task<List<CityResponse>> Handle(CityRequest request, CancellationToken cancellationToken)
    {
        return cityService.GetAllCitiesAsync();
    }
}
