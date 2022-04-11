using Microsoft.AspNetCore.Mvc;
using PhoenixServer.BackEnd.Data;
using PhoenixServer.Core.Entities;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhoenixServer.BackEnd.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GroundPressureController : ControllerBase
{
    private readonly ApplicationDBContext _context;
    public GroundPressureController(ApplicationDBContext context)
    {
        _context = context;
    }

    // GET: api/<GroundPressure>
    [HttpGet]
    public GroundPressure Get()
    {
        return _context.GroundPressures.OrderBy(ground_pressure => ground_pressure.ID).Last();
    }

    // GET api/<GroundPressure>/5
    [HttpGet("{id}")]
    public async Task<GroundPressure> Get(int id)
    {
        return await _context.GroundPressures.FindAsync(id);
    }

    // POST api/<GroundPressure>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] GroundPressure value)
    {
        if (!ModelState.IsValid)
            return BadRequest();
        await _context.GroundPressures.AddAsync(value);
        _context.SaveChanges();
        return Ok();
    }
}