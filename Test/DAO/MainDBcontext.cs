using Microsoft.EntityFrameworkCore;
using Test.Entities;


namespace Test.DAO {
    public class MainDBcontext : DbContext {
        public MainDBcontext(DbContextOptions options) : base(options) {
        }

        public DbSet<Mard> M { get; set; }
    }
}
