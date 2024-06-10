using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.Distrito;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Distrito;

public class DistritoEntityTypeConfiguration:IEntityTypeConfiguration<Domain.Distrito.Distrito>
{
    public void Configure(EntityTypeBuilder<Domain.Distrito.Distrito> builder)
    {
        builder.ToTable("Distrito", SchemaNames.DDDSample1);
        builder.HasKey(b=>b.Id);

        builder.Property(b=>b.Id).HasConversion(v=>v.StringValue,
            v=>new Identifier(v))
            .HasColumnName("DistritoId");
        builder.Property(b=>b.DistritoNome).HasConversion(v=>v.NomeDistrito,
            v=>new DistritoNome(v));
        
        builder
            .HasOne(e => e.Escola)
            .WithOne(j => j.Distrito)
            .HasForeignKey<Domain.Escola.Escola>(e=>e.DistritoId);
    }
}