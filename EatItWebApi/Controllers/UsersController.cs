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

        [HttpGet(Name ="GetAllUsers")]
        public List<User> GetAll()
        {
           return _service.GetAll();
        }

        [HttpGet("{id:int}", Name = "GetOneUserById")]
        public User GetById([FromRoute] int id)
        {
            return _service.GetById(id);
        }

        [HttpGet("{name}", Name ="GetOneUserByUserName")]
        public User GetByUserName([FromRoute] string name)
        {
            return _service.GetByUserName(name);
        }

        [HttpPost(Name ="CreateUser")]
        public void Add([FromBody] User user)
        {
            _service.Add(user);
        }

        [HttpDelete("{id:int}", Name ="DeleteOneUser")]
        public void Delete([FromRoute] int id)
        {
            _service.Delete(id);
        }

        [HttpPut("{id:int}", Name ="UpdateOneUser")]
        public void Update([FromRoute] int id, [FromBody] User user)
        {
            _service.Update(id, user);
        }


    }
}
