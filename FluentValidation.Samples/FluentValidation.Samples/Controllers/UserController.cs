using FluentValidation.Samples.Filters;
using FluentValidation.Samples.Models.Input;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidation.Samples.Controllers
{
    [Route("[controller]/[action]")]
    public class UserController : Controller
    {
        [HttpGet]
        public string Index()
        {
            return "Hello world!";
        }

        [HttpPost, ActionName("AddUser")]
        [ModelStateValidation]
        public IActionResult AddUserComfirmed([FromBody] UserInput input)
        {
            return Ok("successed.");
        }
    }
}
