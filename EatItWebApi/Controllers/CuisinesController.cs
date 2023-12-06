using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace EatItWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuisinesController : ControllerBase
    {
        private ICuisineService _service;

        public CuisinesController(ICuisineService service)
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
        public IActionResult GetByCuisineName(string name)
        {
            var result = _service.GetByCuisineName(name);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpPost("post")]
        public IActionResult Add(Cuisine cuisine)
        {
            var result = _service.Add(cuisine);
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
        public IActionResult Update(int id,Cuisine cuisine)
        {
            var result = _service.Update(id, cuisine);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.Message);
        }
    }
}
