using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.ExameIngresso;
using WebApplication1.Domain.Instituicao_Curso;

namespace WebApplication1.Infrastructure.Instituicao_Curso_ExameIngresso;

public class Instituicao_Curso_ExameIngressoEntityTypeConfiguration:
    IEntityTypeConfiguration<Domain.Insituicao_Curso_ExameIngresso.Instituicao_Curso_ExameIngresso>
{
    public void Configure(EntityTypeBuilder<Domain.Insituicao_Curso_ExameIngresso.Instituicao_Curso_ExameIngresso> builder)
    {
        builder.ToTable("Instituicao_Curso_ExameIngresso", SchemaNames.DDDSample1);
        builder.HasKey(b=> new {b.InstituicaoCursoCodigo, b.ExameIngressoCodigo});

        builder.Property(b=>b.InstituicaoCursoCodigo).HasConversion(v=>v.Codigo,
            v=>new Instituicao_CursoCodigo(v));
        builder.Property(b=>b.ExameIngressoCodigo).HasConversion(v=>v.CodigoExameIngresso,
            v=>new ExameIngressoCodigo(v));
    }
}