using System;
using System.Collections.Generic;
using System.IO;
using AnaliseAcoes.Domain.Entities;
using HtmlAgilityPack;
using System.Linq;
using System.Net;

namespace AnaliseAcoes.Scrapper.Scrappers
{
    public class AtivosScrapper : ScrapperBase, IScrapper<IEnumerable<Ativo>>
    {

        public AtivosScrapper(string html) : base(html)
        {

        }

        public IEnumerable<Ativo> ExecuteScrap()
        {
            var documentNode = this.DocumentToScrape.DocumentNode;

            var descendants = documentNode.SelectNodes("//body//table[@id='ctl00_contentPlaceHolderConteudo_BuscaNomeEmpresa1_grdEmpresa_ctl01']//tr");

            return descendants
                        .ToList()
                        .Select(x =>
                        {

                            var tds = x.SelectNodes("td");

                            //td//a
                            if (tds != null)
                            {
                                Console.WriteLine(" Razão Social => " + Decode(tds[0].SelectSingleNode("a").InnerText) + "\n" +
                                                  " Nome Pregão => " + Decode(tds[1].SelectSingleNode("a").InnerText) + "\n" +
                                                  " Segmento => " + Decode(tds[2].InnerText) + "\n\n");
                            }
                            return new Ativo("", "", "");
                        }).ToList();
        }
    }

}