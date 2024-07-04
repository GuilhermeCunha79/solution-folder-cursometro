using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.ExameIngresso;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.ExameIngresso;

public class ExameIngressoEntityTypeConfiguration:IEntityTypeConfiguration<Domain.ExameIngresso.ExameIngresso>
{
    public void Configure(EntityTypeBuilder<Domain.ExameIngresso.ExameIngresso> builder)
    {
        builder.ToTable("ExameIngresso", SchemaNames.DDDSample1);
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Id).HasConversion(v => v.StringValue,
            v=> new Identifier(v))
            .HasColumnName("ExameIngressoCodigo");
        
        builder.Property(b => b.ExameIngressoNome).HasConversion(v => v.NomeExameIngresso,
        v=>new ExameIngressoNome(v.ToString()));

        builder.HasMany(e => e.InstituicaoCursoExameIngressos)
            .WithOne(j => j.ExameIngresso)
            .HasForeignKey(e => e.ExameIngressoCodigo)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasMany(e => e.DisciplinaCursoSecundarios)
            .WithOne(j => j.ExameIngresso)
            .HasForeignKey(e => e.CodigoExame)
            .OnDelete(DeleteBehavior.Restrict);
    }
}