using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Shared;

namespace WebApplication1.Infrastructure.Cif;

public class CifEntityTypeConfiguration : IEntityTypeConfiguration<ConsoleApp1.Domain.Cif.Cif>
{
    public void Configure(EntityTypeBuilder<ConsoleApp1.Domain.Cif.Cif> builder)
    {
        builder.ToTable("Cif", SchemaNames.DDDSample1);
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Id).HasConversion(v => v.IntValue,
            v => new Identifier(v));
        builder.OwnsOne(e => e.CifPortugues,
            np => { np.Property(p => p.PortuguesCif)
                .HasColumnName("PortuguesCif"); });
        builder.OwnsOne(e => e.CifEduFisica,
            np => { np.Property(p => p.EduFisicaCif)
                .HasColumnName("EduFisicaCif"); });
        builder.OwnsOne(e => e.CifFilosofia,
            np => { np.Property(p => p.FilosofiaCif)
                .HasColumnName("FilosofiaCif"); });
        builder.OwnsOne(e => e.CifLinguaEstrangeira,
            np => { np.Property(p => p.LinguaEstrangeiraCif)
                .HasColumnName("LinguaEstrangeiraCif"); });
        builder.OwnsOne(e => e.CifTrienal,
            np => { np.Property(p => p.TrienalCif)
                .HasColumnName("TrienalCif"); });
        builder.OwnsOne(e => e.CifBienal1,
            np => { np.Property(p => p.Bienal1Cif)
                .HasColumnName("Bienal1Cif"); });
        builder.OwnsOne(e => e.CifBienal2,
            np => { np.Property(p => p.Bienal2Cif)
                .HasColumnName("Bienal2Cif"); });
        builder.OwnsOne(e => e.CifAnual1,
            np => { np.Property(p => p.Anual1Cif)
                .HasColumnName("Anual1Cif"); });
        builder.OwnsOne(e => e.CifAnual2,
            np => { np.Property(p => p.Anual2Cif)
                .HasColumnName("Anual2Cif"); });
        
        builder
            .Property(e => e.Id)
            .ValueGeneratedOnAdd();
    }
}