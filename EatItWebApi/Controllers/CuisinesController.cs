using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
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

        [HttpGet(Name = "GetAllCuisines")]
        public List<Cuisine> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("{id:int}", Name = "GetOneCuisineById")]
        public Cuisine GetById([FromRoute] int id)
        {
            return _service.GetById(id);
        }

        [HttpGet("{name}", Name = "GetOneCuisineByUserName")]
        public Cuisine GetByCuisineName([FromRoute] string name)
        {
            return _service.GetByCuisineName(name);
        }

        [HttpPost(Name = "CreateCuisine")]
        public void Add([FromBody] Cuisine cuisine)
        {
            _service.Add(cuisine);
        }

        [HttpDelete("{id:int}", Name = "DeleteOneCuisine")]
        public void Delete([FromRoute] int id)
        {
            _service.Delete(id);
        }

        [HttpPut("{id:int}", Name = "UpdateOneCuisine")]
        public void Update([FromRoute] int id, [FromBody] Cuisine cuisine)
        {
            _service.Update(id, cuisine);
        }
    }
}
