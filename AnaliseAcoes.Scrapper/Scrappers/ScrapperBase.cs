using HtmlAgilityPack;

namespace AnaliseAcoes.Scrapper.Scrappers{

    public class ScrapperBase {
        public HtmlDocument DocumentToScrape { get; private set; }


        public ScrapperBase(string html)
        {                    
            this.DocumentToScrape = new HtmlDocument();
            this.DocumentToScrape.LoadHtml(html);
        }


    }



}