using ExampleApp.WebApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ExampleApp.WebApi.Controllers;


[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {

        var employeeList = new List<Employee> {
            new Employee {
                Id = 1,
                Name = "John Watson",
                Address = "123 Trafalger Street, London"
             },
             new Employee {
                Id = 2,
                Name = "Sherlock Holmes",
                Address = "221 Bakers Street, London"
             },
             new Employee {
                Id = 3,
                Name = "Irene Adler",
             },
            };

        return Ok(employeeList);
    }

}