using System.Collections.Generic;

namespace RecipeBox.Models
{
  public class Recipe
  {
    public Recipe()
    {
      this.JoinEntities = new HashSet<RecipeTag>();
    }
    public virtual ApplicationUser User { get; set; }
    public string RecipeName { get; set; }
    public string Ingredient { get; set; }
    public string Instruction { get; set; }
    public int RecipeId { get; set; }
    public virtual ICollection<RecipeTag> JoinEntities { get; }
  }
}


