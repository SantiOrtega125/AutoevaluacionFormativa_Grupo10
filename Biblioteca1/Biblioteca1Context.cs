using Microsoft.EntityFrameworkCore;

public class Biblioteca1Context(DbContextOptions<Biblioteca1Context> options) : DbContext(options)
{
    public DbSet<Biblioteca1.Models.Libro> Libro { get; set; } = default!;
}
