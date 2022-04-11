using Microsoft.EntityFrameworkCore;
using PhoenixServer.Core.Entities;

namespace PhoenixServer.BackEnd.Data;
public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions options) : base(options) {}

    public DbSet<Temperature> Temperatures { get; set; }
    public DbSet<GroundTemperature> GroundTemperatures { get; set; }
    public DbSet<Humidity> Humidities { get; set; }
    public DbSet<Altitude> Altitudes { get; set; }
    public DbSet<Pressure> Pressures { get; set; }
    public DbSet<GroundPressure> GroundPressures { get; set; }
    public DbSet<Position> Positions { get; set; }
}