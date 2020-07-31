using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class HairSalonContext : DbContext
  {

    public virtual DbSet<Category> Categories { get; set; }
    public DbSet<Item> Items { get; set; }

    public ToDoListContext(DbContextOptions options) : base(options) { }
  }
}