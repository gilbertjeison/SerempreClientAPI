namespace SerempreClientAPI.Domain.Entities
{
    public class Client : DomainEntity
    {
        public string? Name { get; set; }
        public int CityId { get; set; }
        public City? City { get; set; }
    }
}
