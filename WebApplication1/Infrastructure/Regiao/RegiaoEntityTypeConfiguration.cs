using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.Escola;
using WebApplication1.Domain.Regiao;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Regiao;

public class RegiaoEntityTypeConfiguration:IEntityTypeConfiguration<Domain.Regiao.Regiao>
{
    public void Configure(EntityTypeBuilder<Domain.Regiao.Regiao> builder)
    {
        builder.ToTable("Regiao", SchemaNames.DDDSample1);
        builder.HasKey(b=>b.Id);

        builder.Property(b=>b.Id).HasConversion(v=>v.IntValue,
            v=>new Identifier(v))
            .HasColumnName("RegiaoId");
        builder.Property(b => b.RegiaoNome).HasConversion(v=>v.NomeRegiao,
            v=>new RegiaoNome(v));
        
        builder
            .HasOne(e => e.Distrito)
            .WithOne(j => j.Regiao)
            .HasForeignKey<Domain.Distrito.Distrito>(e=>e.RegiaoId);
        
        builder
            .Property(e => e.Id)
            .ValueGeneratedOnAdd();
    }
}