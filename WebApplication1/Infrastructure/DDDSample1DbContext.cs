using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Infrastructure;

public class DDDSample1DbContext : DbContext
{
    public DbSet<Domain.Instituicao.Instituicao> Instituicoes { get; set; }


    public int ObterNumeroDeJogadores()
    {
        return Instituicoes.Count()+1;
    }

    public DDDSample1DbContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
       // modelBuilder.ApplyConfiguration(new JogadorEntityTypeConfiguration());
    }
}