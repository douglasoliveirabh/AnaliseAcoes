using System;
using System.Collections.Generic;
using System.IO;
using AnaliseAcoes.Domain.Entities;
using HtmlAgilityPack;
using System.Linq;
using System.Net;

namespace AnaliseAcoes.Scrapper.Scrappers
{
    public class AtivosScrapper : ScrapperBase, IScrapper<Ativo>
    {

        public AtivosScrapper(string html) : base(html)
        {

        }

        public IEnumerable<Ativo> ExecuteScrap()
        {
            var documentNode = this.DocumentToScrape.DocumentNode;

            var descendants = documentNode.SelectNodes("//a[@id='hlNome']").ToList();

            return descendants
                        .ToList()
                        .Select(x =>
                        {
                            Console.WriteLine(" Nome => " + Decode(x.InnerText) + "\n" +
                                              " Sigla => " + Decode(x.ParentNode.ParentNode.ChildNodes[2].InnerText) + "\n" +
                                              " Segmento => " + Decode(x.ParentNode.ParentNode.ChildNodes[3].InnerText) + "\n\n");
                          
                            return new Ativo(Decode(x.ParentNode.ParentNode.ChildNodes[2].InnerText),
                                             Decode(x.InnerText),
                                             Decode(x.ParentNode.ParentNode.ChildNodes[3].InnerText));
                            
                        }).ToList();            
        }

        private string Decode(string htmlText) {
            return WebUtility.HtmlDecode(htmlText).Trim();
        }
    }

}