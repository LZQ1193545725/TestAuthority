using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Entity.Models.Mapping
{
    public class MenuTableMap:EntityTypeConfiguration<MenuTable>
    {
        public MenuTableMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);


            // Table & Column Mappings
            this.ToTable("MenuTable");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.MenuName).HasColumnName("MenuName");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.IsUsed).HasColumnName("IsUsed");
        }
    }
}
