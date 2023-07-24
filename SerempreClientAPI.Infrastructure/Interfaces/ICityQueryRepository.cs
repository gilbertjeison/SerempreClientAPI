using SerempreClientAPI.Domain.Entities;

namespace SerempreClientAPI.Infrastructure.Interfaces;

public interface ICityQueryRepository
{
    Task<List<City>> GetAllCitiesAsync();
}
