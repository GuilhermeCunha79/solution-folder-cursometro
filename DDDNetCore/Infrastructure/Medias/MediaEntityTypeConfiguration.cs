using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.Media;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Medias;

public class MediaEntityTypeConfiguration:IEntityTypeConfiguration<Media>
{
    public void Configure(EntityTypeBuilder<Media> builder)
    {
        builder.ToTable("Media", SchemaNames.DDDSample1);
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Id).HasConversion(v => v.StringValue,
            v => new Identifier(v))
            .HasColumnName("MediaId");
        builder.Property(b => b.MediaSecundario).HasConversion(v => v.SecundarioMedia,
            v=> new MediaSecundario(v.ToString()));
        builder.Property(b => b.MediaIngresso)
            .HasConversion(
                v => v == null ? "-" : v.IngressoMedia,
                v => v == "-" ? null : new MediaIngresso(v)
            );
        builder.Property(b => b.MediaIngressoDesporto)
            .HasConversion(
                v => v == null ? "-" : v.IngressoMediaDesporto,
                v => v == "-" ? null : new MediaIngressoDesporto(v)
            );
        builder.Property(b=>b.UtilizadorId).HasConversion(v=>v.StringValue,
            v=>new Identifier(v));
        
        builder
            .Property(e => e.Id)
            .ValueGeneratedOnAdd();
    }
}