using Microsoft.AspNetCore.Mvc;
using PhoenixServer.BackEnd.Data;
using PhoenixServer.Core.Entities;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhoenixServer.BackEnd.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PositionController : ControllerBase
{
    private readonly ApplicationDBContext _context;
    public PositionController(ApplicationDBContext context)
    {
        _context = context;
    }

    // GET: api/<Position>
    [HttpGet]
    public Position Get()
    {
        return _context.Positions.OrderBy(position => position.ID).Last();
    }

    // GET api/<Position>/5
    [HttpGet("{id}")]
    public async Task<Position> Get(int id)
    {
        return await _context.Positions.FindAsync(id);
    }

    // POST api/<Position>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Position value)
    {
        if (!ModelState.IsValid)
            return BadRequest();
        await _context.Positions.AddAsync(value);
        _context.SaveChanges();
        return Ok();
    }
}