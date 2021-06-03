using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using RecipeBox.Models;
using System.Collections.Generic;
using System.Linq;

namespace RecipeBox.Controllers
{
  public class HomeController : Controller
  {
     private readonly RecipeBoxContext _db;
      public HomeController(RecipeBoxContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      List<Recipe> recipes = _db.Recipes.ToList();
      List<Tag> tags = _db.Tags.ToList();
      model.Add("recipes", recipes);
      model.Add("tags", tags);
      return View(model);
    }
  }
}