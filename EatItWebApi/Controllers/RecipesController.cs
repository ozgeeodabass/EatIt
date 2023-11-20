using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EatItWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private IRecipeService _service;

        public RecipesController(IRecipeService service)
        {
            _service = service;
        }

        [HttpGet(Name = "GetAllRecipes")]
        public List<Recipe> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("{id:int}", Name = "GetOneRecipeById")]
        public Recipe GetById([FromRoute] int id)
        {
            return _service.GetById(id);
        }

        [HttpGet("{name}", Name = "GetOneRecipeByName")]
        public Recipe GetByRecipeName([FromRoute] string name)
        {
            return _service.GetRecipeByName(name);
        }

        [HttpGet("{id:int}", Name = "GetRecipesByCuisine")]
        public List<Recipe> GetAllRecipesByCuisineId([FromRoute]int id) { 
            return _service.GetAllRecipesByCuisineId(id);
        }

        [HttpGet("{id:int}", Name = "GetRecipesByIngredient")]
        public List<Recipe> GetAllRecipesByIngredientId([FromRoute]int id)
        {
            return _service.GetAllRecipesByIngredientId(id);
        }

        [HttpGet("{id:int}", Name = "GetRecipesByUser")]
        public List<Recipe> GetAllRecipesByUserId([FromRoute]int id)
        {
            return _service.GetAllRecipesByUserId(id);
        }

        [HttpPost(Name = "CreateRecipe")]
        public void Add([FromBody] Recipe recipe)
        {
            _service.Add(recipe);
        }

        [HttpDelete("{id:int}", Name = "DeleteOneRecipe")]
        public void Delete([FromRoute] int id)
        {
            _service.Delete(id);
        }

        [HttpPut("{id:int}", Name = "UpdateOneRecipe")]
        public void Update([FromRoute] int id, [FromBody] Recipe recipe)
        {
            _service.Update(id, recipe);
        }

    }
}
