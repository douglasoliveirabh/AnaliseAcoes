using HtmlAgilityPack;
using System.Net;

namespace AnaliseAcoes.Scrapper.Scrappers{

    public class ScrapperBase {
        public HtmlDocument DocumentToScrape { get; private set; }


        public ScrapperBase(string html)
        {                    
            this.DocumentToScrape = new HtmlDocument();
            this.DocumentToScrape.LoadHtml(html);
        }


        protected string Decode(string htmlText)
        {
            return WebUtility.HtmlDecode(htmlText).Trim();
        }

    }



}