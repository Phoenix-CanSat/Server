using Microsoft.AspNetCore.Mvc;
using PhoenixServer.BackEnd.Data;
using PhoenixServer.Core.Entities;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhoenixServer.BackEnd.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AltitudeController : ControllerBase
{
    private readonly ApplicationDBContext _context;
    public AltitudeController(ApplicationDBContext context)
    {
        _context = context;
    }

    // GET: api/<Altitude>
    [HttpGet]
    public Altitude Get()
    {
        return _context.Altitudes.OrderBy(altitude => altitude.ID).Last();
    }

    // GET api/<Altitude>/5
    [HttpGet("{id}")]
    public async Task<Altitude> Get(int id)
    {
        return await _context.Altitudes.FindAsync(id);
    }

    // POST api/<Altitude>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Altitude value)
    {
        if (!ModelState.IsValid)
            return BadRequest();
        await _context.Altitudes.AddAsync(value);
        _context.SaveChanges();
        return Ok();
    }
}