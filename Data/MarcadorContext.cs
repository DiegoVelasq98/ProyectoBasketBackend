using Microsoft.EntityFrameworkCore;
using MarcadorApi.Models;

namespace MarcadorApi.Data;

public class MarcadorContext : DbContext
{
    public MarcadorContext(DbContextOptions<MarcadorContext> options) : base(options) { }

    public DbSet<Partido> Partidos { get; set; }
}
