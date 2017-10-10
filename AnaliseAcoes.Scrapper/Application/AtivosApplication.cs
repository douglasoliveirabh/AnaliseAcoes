
using AnaliseAcoes.Scrapper.Clients;
using System.Linq;
using System.Collections.Generic;
using AnaliseAcoes.Domain.Entities;
using AnaliseAcoes.Persistence.Context;

namespace AnaliseAcoes.Scrapper.Scrappers
{

    public class AtivosApplication
    {
        public static async void LoadAtivosAsync()
        {

            try
            {
                var page = 1;
                var itemsPerPage = 20;
                var client = new AtivosClient();
                var ativos = new List<Ativo>();
                string[] args = {};
                var dbContext = new AnaliseAcoesContextFactory().CreateDbContext(args);

                do
                {
                    var html = await client.GetHtmlAsync(page);
                    var scrapper = new AtivosScrapper(html);
                    ativos = scrapper.ExecuteScrap().ToList();

                    dbContext.Ativos.AddRange(ativos);
                    dbContext.SaveChanges();
                    page++;
                }
                while (ativos.Count == itemsPerPage);
            }
            catch (System.Exception ex)
            {

                throw ex;
            }

        }




    }

}