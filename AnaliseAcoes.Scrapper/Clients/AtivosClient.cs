using System.Threading.Tasks;

namespace AnaliseAcoes.Scrapper.Clients{

    public class AtivosClient : WebClientBase {

        private const string GET_ATIVOS_URL = "http://www.guiainvest.com.br/lista-acoes/default.aspx?listaacaopage={0}";

        public AtivosClient(){
        }

        public  Task<string> GetHtmlAsync(int page)
        {
            var effectiveUrl = string.Format(GET_ATIVOS_URL, page);        
            return this.GetHtmlStringAsync(effectiveUrl);            
        }

        public override Task<string> GetHtmlStringAsync(string url)
        {
            return this.Client.GetStringAsync(url);            
        }
    }


}