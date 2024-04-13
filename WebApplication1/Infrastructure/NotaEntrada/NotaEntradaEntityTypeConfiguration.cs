using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.NotaEntrada;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.NotaEntrada;

public class NotaEntradaEntityTypeConfiguration : IEntityTypeConfiguration<Domain.NotaEntrada.NotaEntrada>
{
    public void Configure(EntityTypeBuilder<Domain.NotaEntrada.NotaEntrada> builder)
    {
        builder.ToTable("NotaEntrada", SchemaNames.DDDSample1);
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Id).HasConversion(v => v.Value,
            v => new Identifier(v.ToString()));
        builder.Property(b => b.NotaEntradaValor).HasConversion(v => v.ValorNotaEntrada,
            v => new NotaEntradaValor(v.ToString()));
    }
}