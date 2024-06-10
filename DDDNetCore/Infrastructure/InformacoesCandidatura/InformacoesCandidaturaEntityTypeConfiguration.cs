using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.InformacoesCandidatura;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.InformacoesCandidatura;

public class InformacoesCandidaturaEntityTypeConfiguration:IEntityTypeConfiguration<Domain.InformacoesCandidatura.InformacoesCandidatura>
{
    public void Configure(EntityTypeBuilder<Domain.InformacoesCandidatura.InformacoesCandidatura> builder)
    {
        builder.ToTable("InfoCandidaturas", SchemaNames.DDDSample1);
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Id).HasConversion(v => v.IntValue,
            v => new Identifier(v))
            .HasColumnName("InformacoesCandidaturaId");
        builder.Property(b => b.NotaEntradaValor).HasConversion(v => v.ValorNotaEntrada,
            v=>new NotaEntradaValor(v));
        builder.Property(b => b.VagasNumero).HasConversion(v => v.NumeroVagas,
            v => new VagasNumero(v));

        builder
            .Property(e => e.Id)
            .ValueGeneratedOnAdd();
    }
}