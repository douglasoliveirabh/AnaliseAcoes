using System;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace AnaliseAcoes.Scrapper.Clients{

    public class AtivosClient : WebClientBase {

        private const string GET_ATIVOS_URL = "http://bvmf.bmfbovespa.com.br/cias-listadas/empresas-listadas/BuscaEmpresaListada.aspx?idioma=pt-br";

        public AtivosClient(){
        }

        public  Task<string> GetHtmlAsync(int page)
        {
            //var effectiveUrl = string.Format(GET_ATIVOS_URL, page);        
            return this.GetHtmlStringAsync(GET_ATIVOS_URL);            
        }

        public override Task<string> GetHtmlStringAsync(string url)
        {            
            this.WebDriver.Navigate().GoToUrl(GET_ATIVOS_URL);
            IWebElement element = this.WebDriver.FindElement(By.Name("ctl00$contentPlaceHolderConteudo$BuscaNomeEmpresa1$btnTodas"));
            element.Click();      

            var wait = new WebDriverWait(this.WebDriver, TimeSpan.FromSeconds(10));
            wait.Until((d) => d.FindElement(By.Id("ctl00_contentPlaceHolderConteudo_BuscaNomeEmpresa1_grdEmpresa_ctl01")) != null );
            var html = this.WebDriver.PageSource.ToString();
            this.WebDriver.Quit();
            return Task.FromResult(html);
        }
    }


}