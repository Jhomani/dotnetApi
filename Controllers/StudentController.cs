using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using apiNet.Models;
using System.Linq;

namespace apiNet.Controllers
{
  [ApiController]
  [Route("[controller]")]

  public class StudentController : Controller
  {
    private StudentContext _studentContext;

    public StudentController(StudentContext context)
    {
      _studentContext = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Student>> Get()
    {
      return _studentContext.Students.ToList();
    }

    ~StudentController()
    {
      _studentContext.Dispose();
    }
  }
}