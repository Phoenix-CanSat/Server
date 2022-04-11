using Microsoft.AspNetCore.Mvc;
using PhoenixServer.BackEnd.Data;
using PhoenixServer.Core.Entities;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhoenixServer.BackEnd.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HumidityController : ControllerBase
{
    private readonly ApplicationDBContext _context;
    public HumidityController(ApplicationDBContext context)
    {
        _context = context;
    }

    // GET: api/<Humidity>
    [HttpGet]
    public Humidity Get()
    {
        return _context.Humidities.OrderBy(humidity => humidity.ID).Last();
    }

    // GET api/<Humidity>/5
    [HttpGet("{id}")]
    public async Task<Humidity> Get(int id)
    {
        return await _context.Humidities.FindAsync(id);
    }

    // POST api/<Humidity>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Humidity value)
    {
        if (!ModelState.IsValid)
            return BadRequest();
        await _context.Humidities.AddAsync(value);
        _context.SaveChanges();
        return Ok();
    }
}