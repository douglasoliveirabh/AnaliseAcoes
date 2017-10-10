using System;
using System.Collections.Generic;
using AnaliseAcoes.Domain.Entities;
using System.Linq;
using AnaliseAcoes.Domain.ValueObjects;
using HtmlAgilityPack;

namespace  AnaliseAcoes.Scrapper.Scrappers{
    public class DadosFundamentalistasScrapper : ScrapperBase, IScrapper<DadoFundamentalista>
    {

        public DadosFundamentalistasScrapper(string html) : base(html)
        {
                
        }

        public DadoFundamentalista ExecuteScrap()
        {            
            var documentNode = this.DocumentToScrape.DocumentNode;
            var descendants = documentNode.SelectNodes("//table[@class='w728']")?.ToList();

            if (descendants != null) {
                var dadosGerais = GetDadosGerais(descendants[0]);

                return new DadoFundamentalista(dadosGerais);
            }
            
            return null;
        }

        private DadosGerais GetDadosGerais(HtmlNode tableNode) {

            var trs = tableNode.SelectNodes("tr");

            var primeiralinha = trs[0].SelectNodes("td");
            var segundalinha = trs[1].SelectNodes("td");
            var terceiralinha = trs[2].SelectNodes("td");
            var quartalinha = trs[3].SelectNodes("td");
            var quintalinha = trs[4].SelectNodes("td");

            var tipoPapel = Decode(segundalinha[1].FirstChild.InnerText);
            var setor = Decode(quartalinha[1].FirstChild.FirstChild.InnerText);
            var subSetor = Decode(quintalinha[1].FirstChild.FirstChild.InnerText);
            var cotacao = Decode(primeiralinha[3].FirstChild.InnerText);
            var dataUltimaCotacao = Decode(segundalinha[3].FirstChild.InnerText);
            var menorCotacaoUltimoAno = Decode(terceiralinha[3].FirstChild.InnerText);
            var maiorCotacaoUltimoAno = Decode(quartalinha[3].FirstChild.InnerText);
            //var valorMercado = valorMercado;
            //var valorFirma = ValorFirma;
            //var dataUltimoBalancoProcessado = dataUltimoBalancoProcessado;
            //var quantidadeAcoesEmNegociacao = quantidadeAcoesEmNegociacao;           

            Console.WriteLine(@"Cotação =>" + primeiralinha[3].FirstChild.InnerText + "\n" +
                               "Tipo => " + segundalinha[1].FirstChild.InnerText + "\n" +
                               "Data últ cot => " + segundalinha[3].FirstChild.InnerText + "\n" +
                               "Empresa => " + terceiralinha[1].FirstChild.InnerText + "\n" +
                               "Min 52 sem => " + terceiralinha[3].FirstChild.InnerText + "\n" +
                               "Setor => " + quartalinha[1].FirstChild.FirstChild.InnerText + "\n" +
                               "Max 52 sem => " + quartalinha[3].FirstChild.InnerText + "\n" +
                               "Subsetor => " + quintalinha[1].FirstChild.FirstChild.InnerText + "\n" +
                               "Vol $ méd(2m) => " + quintalinha[3].FirstChild.InnerText + "\n\n\n");

            return new DadosGerais(tipoPapel, setor, subSetor, Convert.ToDecimal(cotacao), Convert.ToDateTime(dataUltimaCotacao), 
                                   Convert.ToDecimal(menorCotacaoUltimoAno), Convert.ToDecimal(maiorCotacaoUltimoAno), 
                                   0,0, DateTime.Now, 0);            
        }


    }



}