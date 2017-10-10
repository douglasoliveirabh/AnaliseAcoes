using AnaliseAcoes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnaliseAcoes.Persistence.Mappings
{
    public class DadoFundamentalistaMap : IEntityTypeConfiguration<DadoFundamentalista>
    {
        public void Configure(EntityTypeBuilder<DadoFundamentalista> builder)
        {
            builder
                 .ToTable("DadosFundamentalistas");

            builder
                .HasKey(t => t.Id);

            builder
                .OwnsOne(p => p.DadosGerais, po =>
                {
                    po.Property(p => p.TipoPapel).HasColumnName("TipoPapel");
                    po.Property(p => p.Setor).HasColumnName("Setor");
                    po.Property(p => p.SubSetor).HasColumnName("SubSetor");
                    po.Property(p => p.Cotacao).HasColumnName("Cotacao");
                    po.Property(p => p.DataUltimaCotacao).HasColumnName("DataUltimaCotacao");
                    po.Property(p => p.MenorCotacaoUltimoAno).HasColumnName("MenorCotacaoUltimoAno");
                    po.Property(p => p.MaiorCotacaoUltimoAno).HasColumnName("MaiorCotacaoUltimoAno");
                    po.Property(p => p.ValorMercado).HasColumnName("ValorMercado");
                    po.Property(p => p.ValorFirma).HasColumnName("ValorFirma");
                    po.Property(p => p.DataUltimoBalancoProcessado).HasColumnName("DataUltimoBalancoProcessado");
                    po.Property(p => p.QuantidadeAcoesEmNegociacao).HasColumnName("QuantidadeAcoesEmNegociacao");                                        
                });

            builder
                .HasOne(t => t.Ativo)
                .WithMany(t => t.DadosFundamentalistas)
                .HasForeignKey(t => t.AtivoId);

        }
    }
}
