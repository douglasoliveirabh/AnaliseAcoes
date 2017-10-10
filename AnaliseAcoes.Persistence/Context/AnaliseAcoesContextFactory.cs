using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnaliseAcoes.Persistence.Context
{
    public class AnaliseAcoesContextFactory : IDesignTimeDbContextFactory<AnaliseAcoesContext>
    {    
        public AnaliseAcoesContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AnaliseAcoesContext>();
            optionsBuilder.UseSqlite("Data source=AnaliseAcoes.db");
            return new AnaliseAcoesContext(optionsBuilder.Options);
        }
    }
}
