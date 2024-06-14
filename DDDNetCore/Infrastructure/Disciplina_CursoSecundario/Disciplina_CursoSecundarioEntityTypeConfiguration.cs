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
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Id).HasConversion(v => v.StringValue,
            v => new Identifier(v)).HasColumnName("Disciplina_CursoSecundarioId");
        builder.OwnsOne(e => e.DisciplinaCursoSecundarioNota,
            np =>
            {
                np.Property(p => p.NotaDecimo).HasColumnName("NotaDecimo");
                np.Property(p => p.NotaDecimoPrim).HasColumnName("NotaDecimoPrim");
                np.Property(p => p.NotaDecimoSeg).HasColumnName("NotaDecimoSeg");
            });
        builder.Property(b => b.DisciplinaCursoCifDisciplina).HasConversion(v => v.DisciplinaCif,
            v => new Disciplina_CursoCifDisciplina(v));
        builder.Property(b => b.DisciplinaCursoNotaExame).HasConversion(v => v.NotaExameIngresso,
            v => new Disciplina_CursoNotaExame(v));
        builder.Property(b => b.DisciplinaCursoIngressoBool).HasConversion(v => v.BoolIngresso,
            v => new Disciplina_CursoIngressoBool(v));
        
        builder.HasMany<Domain.Teste.Teste>(f => f.Testes)
            .WithOne(j => j.DisciplinaCursoSecundario)
            .HasForeignKey(f => f.UtilizadorId)
            .HasForeignKey(f=>f.DisciplinaId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}