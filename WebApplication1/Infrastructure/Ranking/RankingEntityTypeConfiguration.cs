using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Domain.RankingNacional;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Ranking;

public class RankingEntityTypeConfiguration:IEntityTypeConfiguration<Domain.RankingNacional.Ranking>
{
    public void Configure(EntityTypeBuilder<Domain.RankingNacional.Ranking> builder)
    {
        builder.ToTable("Ranking", SchemaNames.DDDSample1);
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Id).HasConversion(v=>v.IntValue,
            v=>new Identifier(v))
            .HasColumnName("RankingId");
        builder.Property(b => b.Posicao).HasConversion(v => v.PosicaoRanking,
            v=> new RankingPosicao(v));
        builder.Property(b => b.RankingNome).HasConversion(v => v.NomeRanking,
            v=>new RankingNome(v));
        builder.Property(b => b.RankingNacional).HasConversion(v => v.BoolRanking,
            v=>new RankingNacional(v));
        
        builder.HasMany(e => e.InstituicaoRankings)
            .WithOne(j => j.Ranking)
            .HasForeignKey(e => e.IdRanking)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .Property(e => e.Id)
            .ValueGeneratedOnAdd();
    }
}