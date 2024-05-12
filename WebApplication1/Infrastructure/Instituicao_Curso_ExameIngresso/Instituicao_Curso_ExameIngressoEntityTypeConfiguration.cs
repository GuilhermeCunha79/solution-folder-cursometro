using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.ExameIngresso;
using WebApplication1.Domain.Instituicao_Curso;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Instituicao_Curso_ExameIngresso;

public class InstituicaoCursoExameIngressoEntityTypeConfiguration:
    IEntityTypeConfiguration<Domain.Insituicao_Curso_ExameIngresso.Instituicao_Curso_ExameIngresso>
{
    public void Configure(EntityTypeBuilder<Domain.Insituicao_Curso_ExameIngresso.Instituicao_Curso_ExameIngresso> builder)
    {
        builder.ToTable("Instituicao_Curso_ExameIngresso", SchemaNames.DDDSample1);
        builder.HasKey(b => new {b.ExameIngressoCodigo, b.InstituicaoCursoCodigo});

        builder.Property(b=>b.ExameIngressoCodigo).HasConversion(v=>v.IntValue,
            v=>new Identifier(v));
        builder.Property(b=>b.InstituicaoCursoCodigo).HasConversion(v=>v.StringValue,
            v=>new Identifier(v));
    }
}