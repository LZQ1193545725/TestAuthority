using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Entity.Models.Mapping
{
    public class UserTableMap:EntityTypeConfiguration<UserTable>
    {
        public UserTableMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);


            // Table & Column Mappings
            this.ToTable("UserTable");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.IsUsed).HasColumnName("IsUsed");
        }
    }
}
