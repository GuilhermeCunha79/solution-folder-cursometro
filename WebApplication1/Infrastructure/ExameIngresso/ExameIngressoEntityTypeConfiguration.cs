using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.ExameIngresso;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.ExameIngresso;

public class ExameIngressoEntityTypeConfiguration:IEntityTypeConfiguration<Domain.ExameIngresso.ExameIngresso>
{
    public void Configure(EntityTypeBuilder<Domain.ExameIngresso.ExameIngresso> builder)
    {
        builder.ToTable("ExameIngresso", SchemaNames.DDDSample1);
        builder.HasKey(b => b.ExameIngressoCodigo);

        builder.Property(b => b.ExameIngressoCodigo).HasConversion(v => v.CodigoExameIngresso,
            v=> new ExameIngressoCodigo(v.ToString()));
        builder.Property(b => b.ExameIngressoNome).HasConversion(v => v.NomeExameIngresso,
        v=>new ExameIngressoNome(v.ToString()));
        
        builder.HasMany(e => e.CalculoExameIngresso)
            .WithOne(j => j.ExameIngresso)
            .HasForeignKey(e => e.ExameIngressoCodigo)
            .OnDelete(DeleteBehavior.Restrict);
    }
}