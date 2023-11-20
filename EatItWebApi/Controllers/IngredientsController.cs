using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EatItWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {

        private IIngredientService _service;

        public IngredientsController(IIngredientService ingredientService)
        {
                _service = ingredientService;
        }

        [HttpGet(Name = "GetAllIngredients")]
        public List<Ingredient> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("{id:int}", Name = "GetOneIngredientById")]
        public Ingredient GetById([FromRoute] int id)
        {
            return _service.GetById(id);
        }

        [HttpGet("{name}", Name = "GetOneIngredientByName")]
        public Ingredient GetByIngredientName([FromRoute] string name)
        {
            return _service.GetByIngredientName(name);
        }

        [HttpPost(Name = "CreateIngredient")]
        public void Add([FromBody] Ingredient ingredient)
        {
            _service.Add(ingredient);
        }

        [HttpDelete("{id:int}", Name = "DeleteOneIngredient")]
        public void Delete([FromRoute] int id)
        {
            _service.Delete(id);
        }

        [HttpPut("{id:int}", Name = "UpdateOneIngredient")]
        public void Update([FromRoute] int id, [FromBody] Ingredient ingredient)
        {
            _service.Update(id, ingredient);
        }
    }

}
