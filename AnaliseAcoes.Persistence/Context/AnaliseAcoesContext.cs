using Microsoft.EntityFrameworkCore;

namespace AnaliseAcoes.Persistence.Context {

    public class AnaliseAcoesContext : DbContext {
        
        public AnaliseAcoesContext (DbContextOptions<AnaliseAcoesContext> options) : base(options)
        {
                        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=AnaliseAcoes.db");
        }


    }

    
}