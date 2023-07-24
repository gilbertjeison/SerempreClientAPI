using MediatR;
using SerempreClientAPI.Application.Services;

namespace SerempreClientAPI.Application.City.CreateCity;

public class CreateCityCommandHandler : IRequestHandler<CreateCityRequest, Domain.Entities.City>
{
    private readonly CityService cityService;

    public CreateCityCommandHandler(CityService _cityService)
    {
        this.cityService = _cityService;
    }

    public async Task<Domain.Entities.City> Handle(CreateCityRequest request, CancellationToken cancellationToken)
    {
        return await cityService.CreateCityAsync(new Domain.Entities.City { Name = request.Name });
    }
}
