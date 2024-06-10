using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.Disciplina;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Disciplina;

public class DisciplinaEntityTypeConfiguration:IEntityTypeConfiguration<Domain.Disciplina.Disciplina>
{
    public void Configure(EntityTypeBuilder<Domain.Disciplina.Disciplina> builder)
    {
        builder.ToTable("Disciplina",SchemaNames.DDDSample1);
        builder.HasKey(b=>b.Id);

        builder.Property(b=>b.Id).HasConversion(v=>v.StringValue,
            v=>new Identifier(v)).HasColumnName("DisciplinaId");
        builder.Property(b=>b.DisciplinaNome).HasConversion(v=>v.NomeDisciplina,
            v=> new DisciplinaNome(v));
        builder.Property(b => b.DisciplinaTipo).HasConversion(v=>v.TipoDisciplina,
            v=>new DisciplinaTipo(v));
        
        builder.HasMany(e => e.Disciplina_CursoSecundario)
            .WithOne(j => j.Disciplina)
            .HasForeignKey(f => f.Id);
        
        builder.HasMany(e => e.Testes)
            .WithOne(j => j.Disciplina)
            .HasForeignKey(f => f.DisciplinaId);

    }
}