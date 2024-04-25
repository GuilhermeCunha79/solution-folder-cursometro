using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.ExameIngresso;
using WebApplication1.Domain.Utilizador_ExameIngresso;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Utilizador_ExameIngresso;

public class Utilizador_ExameIngressoEntityTypeConfiguration:IEntityTypeConfiguration<Domain.Utilizador_ExameIngresso.Utilizador_ExameIngresso>
{
    public void Configure(EntityTypeBuilder<Domain.Utilizador_ExameIngresso.Utilizador_ExameIngresso> builder)
    {
        builder.ToTable("Utilizador_ExameIngresso", SchemaNames.DDDSample1);
        builder.HasKey(b=> new {b.IdUtilizador,b.ExameIngressoCodigo});

        builder.Property(b=>b.Id).HasConversion(v=>v.Value,
            v=>new Identifier(v));
        builder.Property(b => b.IdUtilizador).HasConversion(v=>v.Value,
            v=>new Identifier(v));
        builder.Property(b=>b.ExameIngressoCodigo).HasConversion(v=>v.CodigoExameIngresso,
            v=>new ExameIngressoCodigo(v));
        builder.Property(b=>b.ExameIngressoNotaExame).HasConversion(v=>v.NotaExameIngresso,
            v=>new Utilizador_ExameIngressoNotaExame(v));
        builder.Property(b => b.IngressoBool).HasConversion(v=>v.BoolIngresso,
            v=>new IngressoBool(v));
    }
}