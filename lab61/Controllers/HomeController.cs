using Microsoft.AspNetCore.Mvc;

namespace lab6.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IResult GetStudent(IConfiguration appConfig)
        {
            var student = new Student();
            student.Name = appConfig["student:name"];
            student.University = appConfig["student:universaty"];
            return Results.Json(student);
        }

        [HttpGet]
        public IResult GetEmployee(IConfiguration appConfig)
        {
            var emp = new Employee();
            emp.Name = appConfig["name"];
            emp.Company = appConfig["company"];
            return Results.Json(emp);
        }

        [HttpGet]
        public IResult GetArgs(IConfiguration appConfig)
        {
            var args = appConfig["args"];
            return Results.Json(args);
        }


    }
}
