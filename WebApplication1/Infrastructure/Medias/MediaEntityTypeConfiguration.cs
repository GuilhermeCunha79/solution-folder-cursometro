using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.Calculo;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Calculo;

public class MediaEntityTypeConfiguration:IEntityTypeConfiguration<Media>
{
    public void Configure(EntityTypeBuilder<Domain.Calculo.Media> builder)
    {
        builder.ToTable("Media", SchemaNames.DDDSample1);
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Id).HasConversion(v => v.StringValue,
            v => new Identifier(v))
            .HasColumnName("MediaId");
        builder.Property(b => b.MediaSecundario).HasConversion(v => v.SecundarioMedia,
            v=> new MediaSecundario(v.ToString()));
        builder.Property(b => b.MediaIngresso).HasConversion(v => v.IngressoMedia,
            v=> new MediaIngresso(v!.ToString()));
        builder.Property(b => b.MediaIngressoDesporto).HasConversion(v => v.IngressoMediaDesporto,
            v=> new MediaIngressoDesporto(v!.ToString()));
        builder.Property(b=>b.UtilizadorId).HasConversion(v=>v.StringValue,
            v=>new Identifier(v));
        
        builder
            .Property(e => e.Id)
            .ValueGeneratedOnAdd();
    }
}