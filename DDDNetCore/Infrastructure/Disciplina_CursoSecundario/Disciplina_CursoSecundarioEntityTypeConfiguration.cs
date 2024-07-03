using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.Disciplina_CursoSecundario;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Disciplina_CursoSecundario;

public class
    Disciplina_CursoSecundarioEntityTypeConfiguration : IEntityTypeConfiguration<
        Domain.Disciplina_CursoSecundario.Disciplina_CursoSecundario>
{
    public void Configure(EntityTypeBuilder<Domain.Disciplina_CursoSecundario.Disciplina_CursoSecundario> builder)
    {
        builder.ToTable("Disciplina_CursoSecundario", SchemaNames.DDDSample1);
        builder.HasKey(b => new { b.UtilizadorId, b.DisciplinaId });

        builder.Property(b => b.Id).HasConversion(v => v.StringValue,
            v => new Identifier(v)).HasColumnName("Disciplina_CursoSecundarioId");
        builder.OwnsOne(e => e.DisciplinaCursoSecundarioNota, np =>
        {
            np.Property(p => p.NotaDecimo).HasColumnName("NotaDecimo");
            np.Property(p => p.NotaDecimoPrim).HasColumnName("NotaDecimoPrim");
            np.Property(p => p.NotaDecimoSeg).HasColumnName("NotaDecimoSeg");
        });
        builder.Property(b => b.DisciplinaCursoCifDiscDisciplina).HasConversion(v => v.DisciplinaCif,
            v => new Disciplina_CursoCif(v));
        builder.Property(b => b.DisciplinaCursoNotaExameInterno1).HasConversion(v => v.NotaExameInterno1,
            v => new Disciplina_CursoNotaExameInterno1(v));
        builder.Property(b => b.DisciplinaCursoNotaExameInterno2).HasConversion(v => v.NotaExameInterno2,
            v => new Disciplina_CursoNotaExameInterno2(v));
        builder.Property(b => b.DisciplinaCursoNotaExameExterno1).HasConversion(v => v.NotaExameExterno1,
            v => new Disciplina_CursoNotaExameExterno1(v));
        builder.Property(b => b.DisciplinaCursoNotaExameExterno2).HasConversion(v => v.NotaExameExterno2,
            v => new Disciplina_CursoNotaExameExterno2(v));
        builder.Property(b => b.DisciplinaCursoIngresso).HasConversion(v => v.BoolIngresso,
            v => new Disciplina_CursoIngresso(v));

        builder.HasMany(f => f.Testes)
            .WithOne(j => j.DisciplinaCursoSecundario)
            .HasForeignKey(f => new { f.UtilizadorId, f.DisciplinaId })
            .OnDelete(DeleteBehavior.Restrict);
    }
}