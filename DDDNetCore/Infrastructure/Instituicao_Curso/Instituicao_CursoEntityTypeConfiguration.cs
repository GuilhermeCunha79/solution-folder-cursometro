using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.Instituicao;
using WebApplication1.Domain.Instituicao_Curso;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Instituicao_Curso;

public class Instituicao_CursoEntityTypeConfiguration:IEntityTypeConfiguration<Domain.Instituicao_Curso.Instituicao_Curso>
{
    public void Configure(EntityTypeBuilder<Domain.Instituicao_Curso.Instituicao_Curso> builder)
    {
        builder.ToTable("Instituicao_Curso",SchemaNames.DDDSample1);
        builder.HasKey(b=>b.Id);

        builder.Property(b=>b.Id).HasConversion(v=>v.StringValue,
            v=>new Identifier(v))
            .HasColumnName("InstituicaoCursoCodigo");
        builder.Property(b=>b.InstituicaoCursoEcts).HasConversion(v=>v.ECTS,
            v=>new Instituicao_CursoECTS(v));
        builder.Property(b=>b.InstituicaoCodigo).HasConversion(v=>v.StringValue,
            v=>new Identifier(v));
        builder.Property(b=>b.InstituicaoArea).HasConversion(v=>v.AreaInstituicao,
            v=>new InstituicaoArea(v));
        builder.Property(b => b.InstituicaoCursoDuracao).HasConversion(v=>v.Duracao,
            v=>new Instituicao_CursoDuracao(v));
        builder.Property(b=>b.InstituicaoCursoGrau).HasConversion(v=>v.Grau,
            v=>new Instituicao_CursoGrau(v));
        
        builder.HasMany(e => e.Candidaturas)
            .WithOne(j => j.InstituicaoCurso)
            .HasForeignKey(e => e.Instituicao_CursoCodigo)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasMany(e => e.Instituicao_Curso_ExameIngressos)
            .WithOne(j => j.InstituicaoCurso)
            .HasForeignKey(e => e.InstituicaoCursoCodigo)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasMany(e => e.Favoritos)
            .WithOne(j => j.InstituicaoCurso)
            .HasForeignKey(e => e.InstituicaoCursoCodigo)
            .OnDelete(DeleteBehavior.Restrict);
    }
}