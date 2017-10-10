using AnaliseAcoes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnaliseAcoes.Persistence.Mappings
{
    public class AtivoMap : IEntityTypeConfiguration<Ativo>
    {
        public void Configure(EntityTypeBuilder<Ativo> builder)
        {
            builder
                .ToTable("Ativos");

            builder
                .HasKey(t => t.Id);


            builder
               .HasMany(t => t.DadosFundamentalistas)
               .WithOne(t => t.Ativo)
               .HasForeignKey(t => t.AtivoId);
        }        
    }
}
