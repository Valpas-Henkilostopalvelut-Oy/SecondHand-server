using System.ComponentModel.DataAnnotations;

namespace SecondHand.Domain.Entities
{
    public class CustomerRoles : BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        public string Description { get; set; }
        public ICollection<CustomerRoleMappings> CustomerRoleMappings { get; set; }
    }

    public class CustomerRoleMappings : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public Customers Customer { get; set; }
        public Guid CustomerRoleId { get; set; }
        public CustomerRoles CustomerRole { get; set; }
    }
    public class CustomerPermissions : BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        public string Description { get; set; }
        public ICollection<RolePermissionMappings> RolePermissionMappings { get; set; }
    }

    public class RolePermissionMappings : BaseEntity
    {
        public Guid RoleId { get; set; }
        public Guid PermissionId { get; set; }
        public CustomerRoles CustomerRoles { get; set; }
        public CustomerPermissions CustomerPermissions { get; set; }
    }
}