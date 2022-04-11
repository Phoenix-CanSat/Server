using Microsoft.AspNetCore.Mvc;
using PhoenixServer.BackEnd.Data;
using PhoenixServer.Core.Entities;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhoenixServer.BackEnd.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TemperatureController : ControllerBase
{
    private readonly ApplicationDBContext _context;
    public TemperatureController(ApplicationDBContext context)
    {
        _context = context;
    }

    // GET: api/<Temperature>
    [HttpGet]
    public Temperature Get()
    {
        return _context.Temperatures.OrderBy(temperature => temperature.ID).Last();
    }

    // GET api/<Temperature>/5
    [HttpGet("{id}")]
    public async Task<Temperature> Get(int id)
    {
        return await _context.Temperatures.FindAsync(id);
    }

    // POST api/<Temperature>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Temperature value)
    {
        if (!ModelState.IsValid)
            return BadRequest();
        await _context.Temperatures.AddAsync(value);
        _context.SaveChanges();
        return Ok();
    }
}

