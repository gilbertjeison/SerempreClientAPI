namespace SerempreClientAPI.Domain.Entities
{
    public class User : DomainEntity
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Photo { get; set; }
    }
}
