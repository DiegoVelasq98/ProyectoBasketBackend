using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MarcadorApi.Data;
using MarcadorApi.Models;

namespace MarcadorApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PartidosController : ControllerBase
{
    private readonly MarcadorContext _context;
    public PartidosController(MarcadorContext context) => _context = context;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Partido>>> Get() =>
        await _context.Partidos.ToListAsync();

    [HttpGet("{id}")]
    public async Task<ActionResult<Partido>> GetById(int id)
    {
        var partido = await _context.Partidos.FindAsync(id);
        if (partido == null) return NotFound();
        return partido;
    }

    [HttpPost]
    public async Task<ActionResult<Partido>> Post(Partido partido)
    {
        _context.Partidos.Add(partido);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetById), new { id = partido.Id }, partido);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Partido partido)
    {
        if (id != partido.Id) return BadRequest();
        _context.Entry(partido).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var partido = await _context.Partidos.FindAsync(id);
        if (partido == null) return NotFound();
        _context.Partidos.Remove(partido);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
