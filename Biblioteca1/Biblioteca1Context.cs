using Microsoft.EntityFrameworkCore;

public class Biblioteca1Context(DbContextOptions<Biblioteca1Context> options) : DbContext(options)
{
    public DbSet<Biblioteca1.Models.Libro> Libro { get; set; } = default!;
    public DbSet<Biblioteca1.Models.Maestro> Maestro { get; set; } = default!;

    public DbSet<Biblioteca1.Models.Estudiante> Estudiante { get; set; } = default!;
}
