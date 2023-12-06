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

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _service.GetAll();
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _service.GetById(id);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpGet("getbyname")]
        public IActionResult GetByIngredientName(string name)
        {
            var result = _service.GetByIngredientName(name);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpPost("post")]
        public IActionResult Add(Ingredient ingredient)
        {
            var result = _service.Add(ingredient);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var result = _service.Delete(id);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpPut("update")]
        public IActionResult Update(int id, Ingredient ingredient)
        {
            var result = _service.Update(id, ingredient);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.Message);
        }
    }

}
