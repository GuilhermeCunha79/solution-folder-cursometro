using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.ExameIngresso;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Calculo_ExameIngresso;

public class Calculo_ExameIngressoEntityTypeConfiguration:IEntityTypeConfiguration<Domain.Calculo_ExameIngresso.Calculo_ExameIngresso>
{
    public void Configure(EntityTypeBuilder<Domain.Calculo_ExameIngresso.Calculo_ExameIngresso> builder)
    {
        builder.ToTable("Calculo_ExameIngresso", SchemaNames.DDDSample1);
        builder.HasKey(b => new { b.ExameIngressoCodigo, b.CalculoIdentifier });

        builder.Property(b => b.ExameIngressoCodigo).HasConversion(v => v.CodigoExameIngresso,
            v => new ExameIngressoCodigo(v.ToString()));
        builder.Property(b => b.CalculoIdentifier).HasConversion(v => v.Value,
            v=>new Identifier(v.ToString()));
    }
}