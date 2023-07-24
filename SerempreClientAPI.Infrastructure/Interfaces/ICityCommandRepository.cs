using SerempreClientAPI.Domain.Entities;

namespace SerempreClientAPI.Infrastructure.Interfaces;

public interface ICityCommandRepository
{
    Task<City> CreateCityAsync(City city);
    Task UpdateCityAsync(City city);
    Task DeleteCityAsync(int id);
}
