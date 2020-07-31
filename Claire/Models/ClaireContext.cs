using Microsoft.EntityFrameworkCore;

namespace Claire.Models
{
  public class ClaireContext : DbContext
  {

    public virtual DbSet<Category> Categories { get; set; }
    public DbSet<Item> Items { get; set; }

    public ToDoListContext(DbContextOptions options) : base(options) { }
  }
}