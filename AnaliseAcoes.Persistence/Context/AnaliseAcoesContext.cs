using AnaliseAcoes.Domain.Entities;
using AnaliseAcoes.Persistence.Mappings;
using Microsoft.EntityFrameworkCore;

namespace AnaliseAcoes.Persistence.Context {

    public class AnaliseAcoesContext : DbContext
    {


        public DbSet<Ativo> Ativos { get; set; }
        public DbSet<DadoFundamentalista> DadosFundamentalistas { get; set; }


        public AnaliseAcoesContext(DbContextOptions<AnaliseAcoesContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Ativo>(new AtivoMap());
            modelBuilder.ApplyConfiguration<DadoFundamentalista>(new DadoFundamentalistaMap());

        }

    }
}