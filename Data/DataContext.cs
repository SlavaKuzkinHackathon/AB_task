using Microsoft.EntityFrameworkCore;
using AB.Models;

namespace AB.Models {
    public class DataContext : DbContext {
        public DataContext (DbContextOptions<DataContext> opts) : base (opts) { }
        public DbSet<User> Users { get; set; }
    }
}