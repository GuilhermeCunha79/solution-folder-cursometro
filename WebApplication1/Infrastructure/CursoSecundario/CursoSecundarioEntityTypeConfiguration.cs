using ConsoleApp1.Domain.CursoSecundario;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.CursoSecundario;

public class
    CursoSecundarioEntityTypeConfiguration : IEntityTypeConfiguration<
        ConsoleApp1.Domain.CursoSecundario.CursoSecundario>
{
    public void Configure(EntityTypeBuilder<ConsoleApp1.Domain.CursoSecundario.CursoSecundario> builder)
    {
        builder.ToTable("CursoSecundario", SchemaNames.DDDSample1);
        builder.HasKey(b => b.CursoSecundarioCodigo);

        builder.Property(b => b.CursoSecundarioCodigo).HasConversion(v => v.IntValue,
                v => new Identifier(v))
            .HasColumnName("CursoSecundarioCodigo");

        builder.Property(b => b.CursoSecundarioNome).HasConversion(v => v.NomeCursoSecundario,
            v => new CursoSecundarioNome(v));

        builder.HasMany(e => e.Disciplina_CursoSecundario)
            .WithOne(j => j.CursoSecundario)
            .HasForeignKey(f => f.CodigoCursoSecundario);
    }
}