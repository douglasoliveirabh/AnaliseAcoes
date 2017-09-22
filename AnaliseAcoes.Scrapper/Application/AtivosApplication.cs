
using AnaliseAcoes.Scrapper.Clients;
using System.Linq;
using System.Collections.Generic;
using AnaliseAcoes.Domain.Entities;

namespace AnaliseAcoes.Scrapper.Scrappers{

    public class AtivosApplication {
            public static async void LoadAtivosAsync() {
                var page = 1;
                var itemsPerPage = 20;
                var client = new AtivosClient();
                var ativos = new List<Ativo>();                        
                do{
                    var html = await client.GetHtmlStringAsync(page);
                    var scrapper = new AtivosScrapper(html);
                    ativos = scrapper.ExecuteScrap().ToList();
                    page ++;                    
                }
                while(ativos.Count == itemsPerPage);            
            }


        

    }
    
}