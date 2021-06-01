using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace RecipeBox.Models
{
  public class RecipeBoxContext : DbContext
  {
  
   public virtual DbSet<Tag> Tags { get; set; }
   public virtual DbSet<Recipe> Recipes { get; set; }
   public DbSet<RecipeTag> RecipeTag { get; set; }
   
    public RecipeBoxContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}