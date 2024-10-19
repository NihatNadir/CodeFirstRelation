using CodeFirstRelation.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstRelation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly PatikaSecondDbContext _context;

        public UserController(PatikaSecondDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {

        }

        [HttpGet]
        public IActionResult AddUser()
        {

        }

        [HttpGet]
        public IActionResult EditUser()
        {

        }

        [HttpGet]
        public IActionResult DeleteUser()
        {

        }




    }
}
