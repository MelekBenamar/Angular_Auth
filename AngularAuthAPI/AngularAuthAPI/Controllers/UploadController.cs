using AngularAuthAPI.Context;
using AngularAuthAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularAuthAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UploadController : ControllerBase
    {
        private readonly DataDbContext _context;

        public UploadController(DataDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] List<Student> data)
        {
            if (data == null || data.Count == 0)
            {
                return BadRequest(new { message = "No data provided" });
            }

            foreach (var item in data)
            {
                _context.Students.Add(item);
            }

            await _context.SaveChangesAsync();
            return Ok(new { message = "Data imported successfully" });
        }
    }
}
