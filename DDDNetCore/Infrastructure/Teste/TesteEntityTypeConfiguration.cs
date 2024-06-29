using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.Teste;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Teste;

public class TesteEntityTypeConfiguration : IEntityTypeConfiguration<Domain.Teste.Teste>
{
    public void Configure(EntityTypeBuilder<Domain.Teste.Teste> builder)
    {
        builder.ToTable("Teste", SchemaNames.DDDSample1);
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Id).HasConversion(v => v.StringValue,
                v => new Identifier(v))
            .HasColumnName("TesteId");

        builder.Property(b => b.TesteNota).HasConversion(v => v.NotaTeste,
            v => new TesteNota(v));
        builder.Property(b => b.TesteAno).HasConversion(v => v.AnoTeste,
            v => new TesteAno(v));
        builder.Property(b => b.TestePeriodo).HasConversion(v => v.PeriodoTeste,
            v => new TestePeriodo(v));
        builder.Property(b => b.TesteDescricao).HasConversion(v => v.DescricaoTeste,
            v => new TesteDescricao(v));
    }
}
