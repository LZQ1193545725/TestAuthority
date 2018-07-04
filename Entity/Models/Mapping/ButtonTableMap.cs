using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Entity.Models.Mapping
{
    public class ButtonTableMap:EntityTypeConfiguration<ButtonTable>
    {
        public ButtonTableMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);


            // Table & Column Mappings
            this.ToTable("ButtonTable");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ButtonName).HasColumnName("ButtonName");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.IsUsed).HasColumnName("IsUsed");
        }
    }
}
