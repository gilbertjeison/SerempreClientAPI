using MediatR;
using SerempreClientAPI.Application.Services;

namespace SerempreClientAPI.Application.City.DeleteCity;

public class DeleteCityCommandHandler : IRequestHandler<DeleteCityRequest, bool>
{
    private readonly CityService cityService;

    public DeleteCityCommandHandler(CityService _cityService)
    {
        this.cityService = _cityService;
    }

    public async Task<bool> Handle(DeleteCityRequest request, CancellationToken cancellationToken)
    {
        return await cityService.DeleteCityAsync(request.Id);
    }
}
