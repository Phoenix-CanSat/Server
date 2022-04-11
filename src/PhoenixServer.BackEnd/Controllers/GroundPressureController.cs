using Microsoft.AspNetCore.Mvc;
using PhoenixServer.BackEnd.Data;
using PhoenixServer.Core.Entities;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhoenixServer.BackEnd.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PressureController : ControllerBase
{
    private readonly ApplicationDBContext _context;
    public PressureController(ApplicationDBContext context)
    {
        _context = context;
    }

    // GET: api/<Pressure>
    [HttpGet]
    public Pressure Get()
    {
        return _context.Pressures.OrderBy(pressure => pressure.ID).Last();
    }

    // GET api/<Pressure>/5
    [HttpGet("{id}")]
    public async Task<Pressure> Get(int id)
    {
        return await _context.Pressures.FindAsync(id);
    }

    // POST api/<Pressure>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Pressure value)
    {
        if (!ModelState.IsValid)
            return BadRequest();
        await _context.Pressures.AddAsync(value);
        _context.SaveChanges();
        return Ok();
    }
}