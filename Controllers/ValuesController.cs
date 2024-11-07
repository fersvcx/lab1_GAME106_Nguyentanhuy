using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeverGame106.Models;

namespace SeverGame106.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIGameController : ControllerBase
    {
        public IActionResult Get()
        {
            Game106 game106 = new Game106
            {
                CourseName = "Back-end Game programing",
                CourseCode = "GAM106",
                Name = "Nguyễn Văn A",
                StudentCode = "PS12345",
                Class = "GA19305"

            };
            int status = 1;
            string message = "get data sucess";
            var data = new {status, message, game106};
            return new JsonResult(data);
        }
    }
}
