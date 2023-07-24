using Dapper;
using Microsoft.EntityFrameworkCore;
using SerempreClientAPI.Domain.Entities;
using SerempreClientAPI.Infrastructure.DataSource;
using SerempreClientAPI.Infrastructure.Interfaces;
using System.Data;

namespace SerempreClientAPI.Infrastructure.Repository.CityRepository;

[Repository]
public class CityQueryRepository : ICityQueryRepository
{
    private readonly IDbConnection connection;

    public CityQueryRepository(DataContext context)
    {
        connection = context.Database.GetDbConnection();
    }

    public async Task<List<City>> GetAllCitiesAsync()
    {
        var response = await connection.QueryAsync<City>(@"select Id, Name FROM City");
        return response.ToList();
    }
}
