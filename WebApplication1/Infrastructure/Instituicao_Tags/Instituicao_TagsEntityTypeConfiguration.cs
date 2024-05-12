using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.Instituicao;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Instituicao_Tags;

public class Instituicao_TagsEntityTypeConfiguration:IEntityTypeConfiguration<Domain.Instituicao_Tags.Instituicao_Tags>
{
    public void Configure(EntityTypeBuilder<Domain.Instituicao_Tags.Instituicao_Tags> builder)
    {
        builder.ToTable("Instituicao_Tags", SchemaNames.DDDSample1);
        builder.HasKey(b => new{b.TagId,b.InstituicaoCodigo});

        builder.Property(b=>b.TagId).HasConversion(v=>v.IntValue,
            v=>new Identifier(v));
        builder.Property(b => b.InstituicaoCodigo).HasConversion(v=>v.IntValue,
            v=>new Identifier(v));
    }
}