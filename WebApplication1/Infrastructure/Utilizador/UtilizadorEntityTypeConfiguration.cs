using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.Utilizador;
using WebApplication1.Domain.Utilizador_ExameIngresso;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Utilizador;

public class UtilizadorEntityTypeConfiguration : IEntityTypeConfiguration<Domain.Utilizador.Utilizador>
{
    public void Configure(EntityTypeBuilder<Domain.Utilizador.Utilizador> builder)
    {
        builder.ToTable("Utilizador", SchemaNames.DDDSample1);
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Id).HasConversion(v => v.Value,
            v=>new Identifier(v));
        builder.Property(b => b.IdCalculo).IsRequired(false).HasConversion(v => v.Value,
            v=>new Identifier(v));
        builder.Property(b => b.IdEscola).HasConversion(v => v.Value,
            v=>new Identifier(v));
        builder.Property(b => b.UtilizadorNome).HasConversion(v=>v.NomeUtilizador,
            v=>new UtilizadorNome(v));
        builder.Property(b=>b.UtilizadorPassword).HasConversion(v=>v.Password,
            v=>new UtilizadorPassword(v));
        builder.Property(b => b.UtilizadorIdade).HasConversion(v=>v.IdadeUtilizador,
            v=>new UtilizadorIdade(v));
        builder.Property(b=>b.UtilizadorAno).HasConversion(v=>v.AnoUtilizador,
            v=>new UtilizadorAno(v));

        builder.HasMany(e => e.UtilizadorExameIngresso)
            .WithOne(j => j.Utilizador)
            .HasForeignKey(e => e.Id)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasMany(e => e.Favoritos)
            .WithOne(j => j.Utilizador)
            .HasForeignKey(e => e.Id)
            .OnDelete(DeleteBehavior.Restrict);
    }
}