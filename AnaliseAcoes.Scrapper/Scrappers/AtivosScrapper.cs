using System;
using System.Collections.Generic;
using System.IO;
using AnaliseAcoes.Domain.Entities;
using HtmlAgilityPack;

namespace AnaliseAcoes.Scrapper.Scrappers{
    public class AtivosScrapper : IScrapper<Ativo>
    {
        public HtmlDocument DocumentToScrape { get; private set; }


        public AtivosScrapper(Stream htmlStream)
        {                    
            this.DocumentToScrape = new HtmlDocument();
            this.DocumentToScrape.Load(htmlStream);
        }


        public IEnumerable<Ativo> ExecuteScrap()
        {




            throw new NotImplementedException();
        }
    }

}