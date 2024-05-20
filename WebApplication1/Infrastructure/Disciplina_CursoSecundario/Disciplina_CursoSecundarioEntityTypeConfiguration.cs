using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Disciplina_CursoSecundario;

public class Disciplina_CursoSecundarioEntityTypeConfiguration:IEntityTypeConfiguration<ConsoleApp1.Domain.Disciplina_CursoSecundario.Disciplina_CursoSecundario>
{
    public void Configure(EntityTypeBuilder<ConsoleApp1.Domain.Disciplina_CursoSecundario.Disciplina_CursoSecundario> builder)
    {
        builder.ToTable("Disciplina_CursoSecundario", SchemaNames.DDDSample1);
        builder.HasKey(b=>b.Id);
        
        builder.Property(b => b.Id).HasConversion(v => v.IntValue,
                v => new Identifier(v)).HasColumnName("Disciplina_CursoSecundarioId");
        
        
    }
}