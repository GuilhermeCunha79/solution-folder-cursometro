using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.Vagas;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Vagas;

public class VagasEntityTypeConfiguration : IEntityTypeConfiguration<Domain.Vagas.Vagas>
{
    public void Configure(EntityTypeBuilder<Domain.Vagas.Vagas> builder)
    {
        builder.ToTable("Vagas", SchemaNames.DDDSample1);
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Id).HasConversion(v => v.Value,
            v => new Identifier(v.ToString()));

        builder.Property(b => b.VagasNumero).HasConversion(v => v.NumeroVagas,
            v => new VagasNumero(v.ToString()));
    }
}