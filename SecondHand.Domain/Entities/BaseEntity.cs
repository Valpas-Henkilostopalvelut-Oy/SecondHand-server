using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecondHand.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        public Guid? CreatedBy { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public Guid? DeletedBy { get; set; }

        [Timestamp]
        public required byte[] RowVersion { get; set; }

        public int Version { get; set; }
    }

}