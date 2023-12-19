using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EatItWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private IRecipeService _service;

        public RecipesController(IRecipeService service)
        {
            _service = service;
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
        public IActionResult GetByRecipeName(string name)
        {
            var result = _service.GetRecipeByName(name);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpGet("getallbycuisineid")]
        public IActionResult GetAllRecipesByCuisineId(int id)
        {
            var result = _service.GetAllRecipesByCuisineId(id);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpGet("getallbyuserid")]
        public IActionResult GetAllRecipesByUserId(int id)
        {
            var result = _service.GetAllRecipesByUserId(id);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpGet("getallwithdetail")]
        public IActionResult GetRecipesDetail()
        {
            var result = _service.GetRecipesDetail();
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpGet("getwithdetail")]
        public IActionResult GetRecipeDetail(int id)
        {
            var result = _service.GetRecipeDetail(id);
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
        public IActionResult Update(int id, Recipe recipe)
        {
            var result = _service.Update(id, recipe);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpPost("post")]
        public IActionResult Add(Recipe recipe)
        {
            var result = _service.Add(recipe);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.Message);
        }
    }
}
