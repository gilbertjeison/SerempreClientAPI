using SerempreClientAPI.Application.City.GetCity;
using SerempreClientAPI.Domain;
using SerempreClientAPI.Domain.Entities;
using SerempreClientAPI.Infrastructure.Interfaces;

namespace SerempreClientAPI.Application.Services;

[DomainService]
public class CityService
{
    private readonly ICityQueryRepository cityQueryRepository;
    private readonly ICityCommandRepository cityCommandRepository;
    private readonly IUnitOfWork unitOfWork;

    public CityService(ICityQueryRepository _cityQueryRepository,
                       ICityCommandRepository _cityCommandRepository,
                       IUnitOfWork unitOfWork)
    {
        cityQueryRepository = _cityQueryRepository;
        this.cityCommandRepository = _cityCommandRepository;
        this.unitOfWork = unitOfWork;
    }

    public async Task<List<CityResponse>> GetAllCitiesAsync()
    {
        var response = await cityQueryRepository.GetAllCitiesAsync();
        return response.Select(
            city =>  new CityResponse 
            { 
                    Id = city.Id, 
                    Name = city.Name 
            }).ToList();
    }

    public async Task<Domain.Entities.City> CreateCityAsync(Domain.Entities.City city)
    {
        city.Name = city?.Name?.ToUpper();
        var response = await cityCommandRepository.CreateCityAsync(city);
        await unitOfWork.SaveAsync();
        return response;
    }

    public async Task UpdateCityAsync(Domain.Entities.City city)
    {
        await cityCommandRepository.UpdateCityAsync(city);
    }

    public async Task<bool> DeleteCityAsync(int id)
    {
        await cityCommandRepository.DeleteCityAsync(id);
        return true;
    }
}
