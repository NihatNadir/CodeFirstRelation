using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstRelation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {

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
