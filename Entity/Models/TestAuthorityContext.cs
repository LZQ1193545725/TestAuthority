using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Entity.Models.Mapping;

namespace Entity.Models
{
    public class TestAuthorityContext:DbContext
    {
        static TestAuthorityContext()
        {
            Database.SetInitializer<TestAuthorityContext>(null);
        }
        public TestAuthorityContext() : base("TestAuthorityContext") { }

        public DbSet<AuthorityTable> AuthorityTables { get; set; }
        public DbSet<ButtonTable> ButtonTables { get; set; }
        public DbSet<MenuTable> MenuTables { get; set; }
        public DbSet<RoleTable> RoleTables { get; set; }
        public DbSet<UserAndRole> UserAndRoles { get; set; }
        public DbSet<UserTable> UserTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AuthorityTableMap());
            modelBuilder.Configurations.Add(new ButtonTableMap());
            modelBuilder.Configurations.Add(new MenuTableMap());
            modelBuilder.Configurations.Add(new RoleTableMap());
            modelBuilder.Configurations.Add(new UserAndRoleMap());
            modelBuilder.Configurations.Add(new UserTableMap());
        }
    }
}
