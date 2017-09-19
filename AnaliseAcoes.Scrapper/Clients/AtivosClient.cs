using System.Threading.Tasks;

namespace AnaliseAcoes.Scrapper.Clients{

    public class AtivosClient : WebClientBase {

        private const string GET_ATIVOS_URL = "http://www.guiainvest.com.br/lista-acoes/default.aspx";

        public AtivosClient(){
        }

        public override Task<string> GetHtmlStringAsync(string url)
        {
            return this.Client.GetStringAsync(GET_ATIVOS_URL);            
        }
    }


}