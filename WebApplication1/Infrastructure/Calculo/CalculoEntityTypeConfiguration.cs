using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.Calculo;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Calculo;

public class CalculoEntityTypeConfiguration:IEntityTypeConfiguration<Domain.Calculo.Calculo>
{
    public void Configure(EntityTypeBuilder<Domain.Calculo.Calculo> builder)
    {
        builder.ToTable("Calculo", SchemaNames.DDDSample1);
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Id).HasConversion(v => v.Value,
            v => new Identifier(v.ToString()));
        builder.Property(b => b.MediaSecundario).HasConversion(v => v.SecundarioMedia,
            v=> new MediaSecundario(v!.ToString()));
        builder.Property(b => b.MediaIngresso).HasConversion(v => v.IngressoMedia,
            v=> new MediaIngresso(v!.ToString()));
        builder.Property(b => b.MediaIngressoDesporto).HasConversion(v => v.IngressoMediaDesporto,
            v=> new MediaIngressoDesporto(v!.ToString()));

        builder.HasMany(e => e.CalculoExameIngresso)
            .WithOne(j => j.Calculo)
            .HasForeignKey(e => e.CalculoIdentifier)
            .OnDelete(DeleteBehavior.Restrict);
    }
}