using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    public DbSet<ComprasDetalles> ComprasDetalles {get; set;}
    public DbSet<Productos>? Productos {get; set;}
    public DbSet<Compras>? Compras {get; set;}
    
    public Contexto (DbContextOptions<Contexto> options) : base (options)
    {
        
    }
}