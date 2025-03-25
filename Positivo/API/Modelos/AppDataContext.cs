namespace Namespace;

using Microsoft.EntityFrameworkCore;

public class AppDataContext : DbContext
{
    public DbSet<Curso> cursos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=app.db");
    }
    
}