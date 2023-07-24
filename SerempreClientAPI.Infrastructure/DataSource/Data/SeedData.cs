using SerempreClientAPI.Domain.Entities;

namespace SerempreClientAPI.Infrastructure.DataSource.Data
{
    public static class SeedData
    {
        public static List<City> Cities { get; } = new List<City>()
        {
            new City(1, "Bogotá"),
            new City(2, "Medellín"),
            new City(3, "Cali"),
            new City(4, "Barranquilla"),
            new City(5, "Cartagena"),
        };

        public static List<Client> Clients { get; } = new List<Client>
        {
            new Client { Id = 1, Name = "Antonio Garcia", CityId = 1 },
            new Client { Id = 2, Name = "Sonia Flores", CityId = 2 },
            new Client { Id = 3, Name = "Ana Gomez", CityId = 3 },
            new Client { Id = 4, Name = "Jose Gonzalez", CityId = 4 },
            new Client { Id = 5, Name = "Servelina Montaño", CityId = 5 },
        };

        public static List<User> Users { get; } = new List<User>
        {
            new User { Id = 1, Name = "Administrador", Email = "admin@admin.com", Password = "admin123", Photo = "photo1.jpg" },
        };
    }
}
