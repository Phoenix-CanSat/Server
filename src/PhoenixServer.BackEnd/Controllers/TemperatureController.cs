using Microsoft.AspNetCore.Mvc;
using PhoenixServer.BackEnd.Data;
using PhoenixServer.Core.Entities;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhoenixServer.BackEnd.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GroundTemperatureController : ControllerBase
{
    private readonly ApplicationDBContext _context;
    public GroundTemperatureController(ApplicationDBContext context)
    {
        _context = context;
    }

    // GET: api/<GroundTemperature>
    [HttpGet]
    public GroundTemperature Get()
    {
        return _context.GroundTemperatures.OrderBy(ground_temperature => ground_temperature.ID).Last();
    }

    // GET api/<GroundTemperature>/5
    [HttpGet("{id}")]
    public async Task<GroundTemperature> Get(int id)
    {
        return await _context.GroundTemperatures.FindAsync(id);
    }

    // POST api/<GroundTemperature>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] GroundTemperature value)
    {
        if (!ModelState.IsValid)
            return BadRequest();
        await _context.GroundTemperatures.AddAsync(value);
        _context.SaveChanges();
        return Ok();
    }
}

