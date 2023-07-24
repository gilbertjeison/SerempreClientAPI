using System.ComponentModel.DataAnnotations.Schema;

namespace SerempreClientAPI.Domain.Entities
{
    public class DomainEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}
