using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.Curso;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Curso_Tags;

public class CursoTagsEntityTypeConfiguration : IEntityTypeConfiguration<Domain.Curso_Tags.Curso_Tags>
{
    public void Configure(EntityTypeBuilder<Domain.Curso_Tags.Curso_Tags> builder)
    {
        builder.ToTable("Curso_Tags", SchemaNames.DDDSample1);
        builder.HasKey(b => new { b.TagId, b.CursoCodigo});

        builder.Property(b => b.Id).HasConversion(v => v.Value,
            v => new Identifier(v.ToString()));

        builder.Property(b => b.CursoCodigo).HasConversion(v => v.Codigo,
            v => new CursoCodigo(v.ToString()));
        
        builder.Property(b => b.TagId).HasConversion(v => v.Value,
            v => new Identifier(v.ToString()));
        
    }
}