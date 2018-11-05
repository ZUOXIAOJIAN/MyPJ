using System.Data.Entity;
using MyPJ.Models;

namespace MyPJ.DAL
{
    /// <summary>
    /// 根据上下文
    /// </summary>
    public class MyPJDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRoleRelation> UserRoleRelations { get; set; }
        public DbSet<UserConfig> UserConfig { get; set; }
        public MyPJDbContext()
            : base("DefaultConnection")
        {
            Database.CreateIfNotExists();
        }
    }
}
