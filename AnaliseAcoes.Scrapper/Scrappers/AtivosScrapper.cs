using System;
using System.Collections.Generic;
using System.IO;
using AnaliseAcoes.Domain.Entities;
using HtmlAgilityPack;

namespace AnaliseAcoes.Scrapper.Scrappers{
    public class AtivosScrapper : ScrapperBase, IScrapper<Ativo>
    {        

        public AtivosScrapper(string html) : base(html){
            
        }

        public IEnumerable<Ativo> ExecuteScrap()
        {
            throw new NotImplementedException();
        }
    }

}