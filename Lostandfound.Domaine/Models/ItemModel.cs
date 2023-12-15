using Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lostandfound.Domaine.Models
{
    [Table("item")]
    public class ItemModel
    {
        [Key]
        public Guid ItemId { get; set; } = Guid.NewGuid();

        [Required]
        public string ItemName { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Location { get; set; }
        public DateTimeOffset LostOrFoundDate { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public ItemStatus ItemStatus { get; set; }

        [ForeignKey("PersonId")]
        public Guid PersonId { get; set; }
        public virtual PersonModel Person { get; set; }

        [ForeignKey("CategoryId")]
        public Guid CategoryId { get; set; }
        public virtual CategoryModel Category { get; set; }

        public string Picture { get; set; }
    }
}
