using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Entity.Models.Mapping
{
    public class RoleTableMap:EntityTypeConfiguration<RoleTable>
    {
        public RoleTableMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);


            // Table & Column Mappings
            this.ToTable("RoleTable");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.RoleName).HasColumnName("RoleName");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.IsUsed).HasColumnName("IsUsed");
        }
    }
}
