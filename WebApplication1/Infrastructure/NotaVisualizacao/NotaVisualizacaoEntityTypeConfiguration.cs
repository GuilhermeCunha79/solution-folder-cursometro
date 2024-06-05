using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.NotaVisualizacao;

public class NotaVisualizacaoEntityTypeConfiguration:IEntityTypeConfiguration<Domain.NotaVisualizacao.NotaVisualizacao>
{
    public void Configure(EntityTypeBuilder<Domain.NotaVisualizacao.NotaVisualizacao> builder)
    {
        builder.ToTable("NotaVisualizacao", SchemaNames.DDDSample1);
        builder.HasKey(b=>b.Id);
        
        builder.Property(b=>b.Id).HasConversion(v=>v.IntValue,
                v=>new Identifier(v))
            .HasColumnName("NotaVisualizacaoId");
        builder.OwnsOne(e => e.NotaPortugues,
            np =>
            {
                np.Property(p => p.NotaPortuguesDecimo).HasColumnName("NotaPortuguesDecimo");
                np.Property(p => p.NotaPortuguesDecimoPrim).HasColumnName("NotaPortuguesDecimoPrim");
                np.Property(p => p.NotaPortuguesDecimoSeg).HasColumnName("NotaPortuguesDecimoSeg");
            });
        builder.OwnsOne(e => e.NotaEduFisica,
            np =>
            {
                np.Property(p => p.NotaEduFisicaDecimo).HasColumnName("NotaEduFisicaDecimo");
                np.Property(p => p.NotaEduFisicaDecimoPrim).HasColumnName("NotaEduFisicaDecimoPrim");
                np.Property(p => p.NotaEduFisicaDecimoSeg).HasColumnName("NotaEduFisicaDecimoSeg");
            });
        builder.OwnsOne(e => e.NotaFilosofia,
            np =>
            {
                np.Property(p => p.NotaFilosofiaDecimo).HasColumnName("NotaFilosofiaDecimo");
                np.Property(p => p.NotaFilosofiaDecimoPrim).HasColumnName("NotaFilosofiaDecimoPrim");
            });
        builder.OwnsOne(e => e.NotaTrienal,
            np =>
            {
                np.Property(p => p.IdDisciplinaTrienal).HasColumnName("DisciplinaTrienalId");
                np.Property(p => p.NotaTrienalDecimo).HasColumnName("NotaTrienalDecimo");
                np.Property(p => p.NotaTrienalDecimoPrim).HasColumnName("NotaTrienalDecimoPrim");
                np.Property(p => p.NotaTrienalDecimoSeg).HasColumnName("NotaTrienalDecimoSeg");
            });
        builder.OwnsOne(e => e.NotaBienal1,
            np =>
            {
                np.Property(p => p.IdNotaBienal1).HasColumnName("DisciplinaBienal1Id");
                np.Property(p => p.NotaBienal1Decimo).HasColumnName("NotaBienal1Decimo");
                np.Property(p => p.NotaBienal1DecimoPrim).HasColumnName("NotaBienal1DecimoPrim");
            });
        builder.OwnsOne(e => e.NotaBienal2,
            np =>
            {
                np.Property(p => p.IdNotaBienal2).HasColumnName("DisciplinaBienal2Id");
                np.Property(p => p.NotaBienal2Decimo).HasColumnName("NotaBienal2Decimo");
                np.Property(p => p.NotaBienal2DecimoPrim).HasColumnName("NotaBienal2DecimoPrim");
            });
        builder.OwnsOne(e => e.NotaAnual1,
            np =>
            {
                np.Property(p => p.IdNotaAnual1).HasColumnName("DisciplinaAnual1Id");
                np.Property(p => p.NotaAnual1DecimoSeg).HasColumnName("NotaAnual1DecimoSeg");
            });
        builder.OwnsOne(e => e.NotaAnual2,
            np =>
            {
                np.Property(p => p.IdNotaAnual2).HasColumnName("DisciplinaAnual2Id");
                np.Property(p => p.NotaAnual2DecimoSeg).HasColumnName("NotaAnual2DecimoSeg");
            });
        
        builder
            .Property(e => e.Id)
            .ValueGeneratedOnAdd();
    }
}