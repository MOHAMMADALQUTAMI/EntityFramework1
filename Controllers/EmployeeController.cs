using EntityFramework.Data_Acces;
using EntityFramework.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    private EfContext _Context;
    public EmployeeController(EfContext context ){
     _Context = context;
    }
    [HttpGet]
    public List<Employee> Get(){
     return  _Context.Employees.ToList();  //Where(e =>e.Id >10)
       
    }
    [HttpPost]
    public void Creat(Employee employee)
    {
     _Context.Employees.Add(employee);
     _Context.SaveChanges();
    }
}
