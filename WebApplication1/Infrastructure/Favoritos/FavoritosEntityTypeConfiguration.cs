using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.Instituicao_Curso;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Favoritos;

public class FavoritosEntityTypeConfiguration: IEntityTypeConfiguration<Domain.Favoritos.Favoritos>
{
    public void Configure(EntityTypeBuilder<Domain.Favoritos.Favoritos> builder)
    {
        builder.ToTable("Favoritos", SchemaNames.DDDSample1);
        builder.HasKey(b=>b.Id);

        builder.Property(b => b.Id)
            .HasColumnName("FavoritosId") // Nomeie a coluna como necessário
            .HasConversion(v => v.IntValue, v => new Identifier(v));
        builder.Property(b=>b.InstituicaoCursoCodigo).HasConversion(v=>v.StringValue,
            v=>new Identifier(v));
        builder.Property(b => b.UtilizadorId).HasConversion(v=>v.StringValue,
            v=>new Identifier(v));
        
    }
}