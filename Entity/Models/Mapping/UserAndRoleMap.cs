using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Entity.Models.Mapping
{
    public class UserAndRoleMap:EntityTypeConfiguration<UserAndRole>
    {
        public UserAndRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);


            // Table & Column Mappings
            this.ToTable("UserAndRole");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.RoleId).HasColumnName("RoleId");
            this.Property(t => t.UserId).HasColumnName("UserId");
        }
    }
}
