using GestionPersonas.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionPersonas.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Persona> Personas { get; set; } = null!;

    public DbSet<Ciudad> Ciudades { get; set; } = null!;

    public DbSet<Pais> Paises { get; set; } = null!;
}