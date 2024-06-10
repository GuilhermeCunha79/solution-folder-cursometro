using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.Candidatura;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Candidatura;

public class CandidaturaEntityTypeConfiguration:IEntityTypeConfiguration<Domain.Candidatura.Candidatura>
{
    public void Configure(EntityTypeBuilder<Domain.Candidatura.Candidatura> builder)
    {
        builder.ToTable("Candidatura", SchemaNames.DDDSample1);
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Id).HasConversion(v => v.IntValue,
            v => new Identifier(v))
            .HasColumnName("CandidaturaId");
        builder.Property(b => b.CandidaturaAno).HasConversion(v => v.Ano,
            v => new CandidaturaAno(v));
        builder.Property(b => b.CandidaturaFase).HasConversion(v => v.Fase,
            v => new CandidaturaFase(v));
        
        builder.HasOne(f => f.InformacoesCandidatura)
            .WithOne(j => j.Candidatura)
            .HasForeignKey<Domain.Candidatura.Candidatura>(f => f.Id);
        
        builder
            .Property(e => e.Id)
            .ValueGeneratedOnAdd();
    }
}