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

        [HttpGet(Name = "GetAllCuisines")]
        public IDataResult<List<Cuisine>> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("{id:int}", Name = "GetOneCuisineById")]
        public IDataResult<Cuisine> GetById([FromRoute] int id)
        {
            return _service.GetById(id);
        }

        [HttpGet("{name}", Name = "GetOneCuisineByUserName")]
        public IDataResult<Cuisine> GetByCuisineName([FromRoute] string name)
        {
            return _service.GetByCuisineName(name);
        }

        [HttpPost(Name = "CreateCuisine")]
        public Core.Utilities.Results.IResult Add([FromBody] Cuisine cuisine)
        {
            return _service.Add(cuisine);
        }

        [HttpDelete("{id:int}", Name = "DeleteOneCuisine")]
        public Core.Utilities.Results.IResult Delete([FromRoute] int id)
        {
            return _service.Delete(id);
        }

        [HttpPut("{id:int}", Name = "UpdateOneCuisine")]
        public Core.Utilities.Results.IResult Update([FromRoute] int id, [FromBody] Cuisine cuisine)
        {
           return _service.Update(id, cuisine);
        }
    }
}
