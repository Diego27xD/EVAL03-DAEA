using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Estudiantes.Models;
using Microsoft.EntityFrameworkCore;
namespace Estudiantes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DemoContext _context;

        public ValuesController(DemoContext context)
        {
            _context = context;
        }

        // GET: api/Estudent
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estudiante>>> GetPeople()
        {
            if (_context.Student == null)
            {
                return NotFound();
            }
            return await _context.Student.ToListAsync();
        }
    }
}
