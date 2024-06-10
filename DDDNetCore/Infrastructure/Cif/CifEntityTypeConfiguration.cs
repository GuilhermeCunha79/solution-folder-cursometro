using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.Cif;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Cif;

public class CifEntityTypeConfiguration : IEntityTypeConfiguration<Domain.Cif.Cif>
{
    public void Configure(EntityTypeBuilder<Domain.Cif.Cif> builder)
    {
        builder.ToTable("Cif", SchemaNames.DDDSample1);
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Id).HasConversion(v => v.IntValue,
            v => new Identifier(v));
        builder.Property(b => b.CifDisciplina).HasConversion(v => v.DisciplinaCif,
            v => new CifDisciplina(v));

        builder
            .Property(e => e.Id)
            .ValueGeneratedOnAdd();
    }
}