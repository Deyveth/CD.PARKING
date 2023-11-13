using CD.STORE.Entities.Inv;
using CD.STORE.Entities.Sm;
using CD.STORE.Entities.Usm;
using Microsoft.EntityFrameworkCore;

namespace CD.STORE.Context
{
    public class StoreContext: DbContext 
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenuRole> MenuRole { get; set; }

        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }

        public DbSet<SalesDocumentNumber> SalesDocumentNumber { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<SaleDetail> SaleDetail { get; set; }




    }
}