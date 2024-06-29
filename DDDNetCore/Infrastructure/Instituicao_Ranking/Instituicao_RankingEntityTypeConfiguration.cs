using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Instituicao_Ranking;

public class Instituicao_RankingEntityTypeConfiguration:IEntityTypeConfiguration<Domain.Instituicao_Ranking.Instituicao_Ranking>
{
    public void Configure(EntityTypeBuilder<Domain.Instituicao_Ranking.Instituicao_Ranking> builder)
    {
        builder.ToTable("Instituicao_Ranking", SchemaNames.DDDSample1);
        builder.HasKey(b => new {b.IdRanking,b.InstituicaoCodigo});

        builder.Property(b=> b.IdRanking).HasConversion(v=>v.IntValue,
            v=>new Identifier(v));
        builder.Property(b=>b.InstituicaoCodigo).HasConversion(v=>v.StringValue,
            v=>new Identifier(v));
    }
}