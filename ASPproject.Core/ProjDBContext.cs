using ASPproject.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPproject.Core;
public class ProjDBContext : DbContext {
    public DbSet<User> Users { get; set; }
    public ProjDBContext(DbContextOptions<ProjDBContext> options) : base(options) {

    }
}
