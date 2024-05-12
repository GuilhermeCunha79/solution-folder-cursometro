using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.Curso;
using WebApplication1.Domain.Instituicao_Curso;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Curso;

internal class CursoEntityTypeConfiguration : IEntityTypeConfiguration<Domain.Curso.Curso>
{
    public void Configure(EntityTypeBuilder<Domain.Curso.Curso> builder)
    {
        builder.ToTable("Curso", SchemaNames.DDDSample1);
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Id)
            .HasConversion(v => v.StringValue,
                v => new Identifier(v))
            .HasColumnName("CursoId");
        
        builder.Property(b => b.CursoNome)
            .HasConversion(v => v.Nome,
                v => new CursoNome(v.ToString()));

        builder.HasMany(e => e.Curso_Tags)
            .WithOne(j => j.Curso)
            .HasForeignKey(e => e.Id)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasOne(f => f.InstituicaoCurso)
            .WithOne(j => j.Curso)
            .HasForeignKey<Domain.Instituicao_Curso.Instituicao_Curso>(f => f.CursoCodigo);
    }
}