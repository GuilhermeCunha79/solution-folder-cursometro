using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.Utilizador_ExameIngresso;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Utilizador_ExameIngresso;

public class Utilizador_ExameIngressoEntityTypeConfiguration:IEntityTypeConfiguration<Domain.Utilizador_ExameIngresso.Utilizador_ExameIngresso>
{
    public void Configure(EntityTypeBuilder<Domain.Utilizador_ExameIngresso.Utilizador_ExameIngresso> builder)
    {
        builder.ToTable("Utilizador_ExameIngresso", SchemaNames.DDDSample1);
        builder.HasKey(b=> new {b.UtilizadorId,b.ExameIngressoCodigo});
        
        builder.Property(b => b.UtilizadorId).HasConversion(v=>v.StringValue,
            v=>new Identifier(v));
        builder.Property(b=>b.ExameIngressoCodigo).HasConversion(v=>v.StringValue,
            v=>new Identifier(v));
        builder.Property(b=>b.ExameIngressoNotaExame).HasConversion(v=>v.NotaExameIngresso,
            v=>new Utilizador_ExameIngressoNotaExame(v));
        builder.Property(b => b.IngressoBool).HasConversion(v=>v.BoolIngresso,
            v=>new IngressoBool(v));
    }
}