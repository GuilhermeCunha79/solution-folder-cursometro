using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.Tags;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Tags;

public class TagsEntityTypeConfiguration : IEntityTypeConfiguration<Domain.Tags.Tags>
{
    public void Configure(EntityTypeBuilder<Domain.Tags.Tags> builder)
    {
        builder.ToTable("Tags", SchemaNames.DDDSample1);
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Id).HasConversion(v=> v.IntValue,
            v=> new Identifier(v)).HasColumnName("TagsId");

        builder.Property(b => b.NomeTags).HasConversion(v => v.NomeTag,
            v => new NomeTags(v.ToString()));

        builder.Property(b => b.TagDescricao).HasConversion(v => v.Descricao,
            v => new TagDescricao(v.ToString()));


        builder.HasMany(e => e.CursoTags)
            .WithOne(j => j.Tags)
            .HasForeignKey(e => e.TagId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(e => e.InstituicaoTags)
            .WithOne(j => j.Tags)
            .HasForeignKey(e => e.TagId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder
            .Property(e => e.Id)
            .ValueGeneratedOnAdd();
    }
}