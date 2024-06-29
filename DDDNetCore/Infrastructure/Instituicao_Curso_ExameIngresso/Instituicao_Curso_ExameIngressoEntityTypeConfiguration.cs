using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Instituicao_Curso_ExameIngresso;

public class InstituicaoCursoExameIngressoEntityTypeConfiguration:
    IEntityTypeConfiguration<Domain.Instituicao_Curso_ExameIngresso.Instituicao_Curso_ExameIngresso>
{
    public void Configure(EntityTypeBuilder<Domain.Instituicao_Curso_ExameIngresso.Instituicao_Curso_ExameIngresso> builder)
    {
        builder.ToTable("Instituicao_Curso_ExameIngresso", SchemaNames.DDDSample1);
        builder.HasKey(b => new {b.ExameIngressoCodigo, b.InstituicaoCursoCodigo});
        
    }
}