using System.Net.Http;
using System.Threading.Tasks;

namespace AnaliseAcoes.Scrapper.Clients{

    public abstract class WebClientBase {

        public HttpClient Client { get; private set; }

        public WebClientBase()
        {
            this.Client = new HttpClient();            
        }

        public abstract Task<string> GetHtmlStringAsync(string url);

    }


    
}