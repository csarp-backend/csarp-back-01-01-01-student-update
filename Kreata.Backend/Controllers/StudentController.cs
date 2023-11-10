using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private IStudentRepo _studentRepo;

        public StudentController(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }
    }
}
