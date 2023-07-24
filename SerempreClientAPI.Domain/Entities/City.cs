namespace SerempreClientAPI.Domain.Entities
{
    public class City : DomainEntity
    {
        public City(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public City()
        {
        }

        public string? Name { get; set; }
        public ICollection<Client>? Clients { get; set; }
    }
}

