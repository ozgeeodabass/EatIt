using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EatItWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _service;

        public UsersController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<User> GetAll()
        {
           return _service.GetAll();
        }

        [HttpPost]
        public void Add([FromBody] User user)
        {
            _service.Add(user);
        }


    }
}
