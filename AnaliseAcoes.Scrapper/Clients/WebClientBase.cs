using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AnaliseAcoes.Scrapper.Clients{

    public abstract class WebClientBase : IDisposable {

        public HttpClient Client { get; private set; }
        public IWebDriver WebDriver {get; private set;}

        public WebClientBase()
        {
            this.Client = new HttpClient();    

           ChromeDriverService service = ChromeDriverService.CreateDefaultService($"{AppDomain.CurrentDomain.BaseDirectory}\\Driver\\");
            service.SuppressInitialDiagnosticInformation = true;
            service.HideCommandPromptWindow = true;

            this.WebDriver = new ChromeDriver(service);

            this.WebDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            this.WebDriver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(30);
            this.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public abstract Task<string> GetHtmlStringAsync(string url);

        public void Quit(){
            //this.WebDriver.Quit();
        }

        public void Dispose()
        {
            //this.Quit();
        }
    }


    
}