using System.ComponentModel.DataAnnotations;

namespace Shop.Entity.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; internal set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
    }
}
