using SerempreClientAPI.Domain.Entities;
using SerempreClientAPI.Infrastructure.Interfaces;

namespace SerempreClientAPI.Infrastructure.Repository.CityRepository;

[Repository]
public class CityCommandRepository: ICityCommandRepository
{
    private readonly IRepository<City> dataSource;

    public CityCommandRepository(IRepository<City> dataSource)
    {
        this.dataSource = dataSource;
    }

    public async Task<City> CreateCityAsync(City city) => await dataSource.AddAsync(city);

    public async Task UpdateCityAsync(City city)
    {
        var dbCity = await dataSource.GetOneAsync(city.Id);

        if (dbCity != null)
        {
            dbCity.Name = city.Name;
            dataSource.UpdateAsync(dbCity);
        }        
    }

    public async Task DeleteCityAsync(int id)
    {
        var dbCity = await dataSource.GetOneAsync(id);

        if (dbCity != null)
        {            
            dataSource.DeleteAsync(dbCity);
        }
    }
}
