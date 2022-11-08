using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI1.repository;

namespace WebAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _emprepo;

        public EmployeeController(IEmployee emprepo)
        {
            
            _emprepo = emprepo;
        }

        [HttpGet("")]
        public async Task<IActionResult> getAllbooks()
        {
            var books = await _emprepo.getAllBooks();

            return Ok(books);
        }

    }
}
