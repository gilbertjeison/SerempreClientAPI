using MediatR;
using SerempreClientAPI.Application.City.CreateCity;
using SerempreClientAPI.Application.Services;

namespace SerempreClientAPI.Application.City.UpdateCity;

public class UpdateCityCommandHandler : IRequestHandler<UpdateCityRequest, Domain.Entities.City>
{
    private readonly CityService cityService;

    public UpdateCityCommandHandler(CityService cityService)
    {
        this.cityService = cityService;
    }

    public async Task<Domain.Entities.City> Handle(UpdateCityRequest request, CancellationToken cancellationToken)
    {
        await cityService.UpdateCityAsync(
            new Domain.Entities.City { Id = request.Id, Name = request.Name });
        return new Domain.Entities.City();
    }
}
