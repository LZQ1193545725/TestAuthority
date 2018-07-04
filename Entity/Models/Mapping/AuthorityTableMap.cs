using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Entity.Models.Mapping
{
    public class AuthorityTableMap:EntityTypeConfiguration<AuthorityTable>
    {
        public AuthorityTableMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);


            // Table & Column Mappings
            this.ToTable("AuthorityTable");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.MenuId).HasColumnName("MenuId");
            this.Property(t => t.ButtonId).HasColumnName("ButtonId");
            this.Property(t => t.RoleId).HasColumnName("RoleId");
        }
    }
}
