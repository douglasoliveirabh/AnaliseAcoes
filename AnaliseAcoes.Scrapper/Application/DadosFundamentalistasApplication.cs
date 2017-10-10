using AnaliseAcoes.Domain.Entities;
using AnaliseAcoes.Persistence.Context;
using AnaliseAcoes.Scrapper.Clients;
using AnaliseAcoes.Scrapper.Scrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnaliseAcoes.Scrapper.Application
{
    public class DadosFundamentalistasApplication
    {

        public static async void LoadDadosFundamentalistasAsync()
        {

            try
            {                          
                var client = new DadosFundamentalistasClient();
                var ativos = new List<Ativo>();
                string[] args = { };
                var dbContext = new AnaliseAcoesContextFactory().CreateDbContext(args);

                var todosAtivos = dbContext.Ativos.ToList();

                foreach (var ativo in todosAtivos) {

                    var html = await client.GetHtmlAsync(ativo.Sigla);
                    var scrapper = new DadosFundamentalistasScrapper(html);
                    var dadoFundamentalista = scrapper.ExecuteScrap();

                    if (dadoFundamentalista != null) {
                        dadoFundamentalista.ChangeAtivo(ativo.Id);
                        dbContext.DadosFundamentalistas.Add(dadoFundamentalista);
                        dbContext.SaveChanges();
                    }

                }             
            }
            catch (System.Exception ex)
            {
                Console.Write(ex.Message);
            }

        }


    }
}
