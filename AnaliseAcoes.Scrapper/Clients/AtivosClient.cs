using System.Threading.Tasks;

namespace AnaliseAcoes.Scrapper.Clients{

    public class AtivosClient : WebClientBase {

        private const string GET_ATIVOS_URL = "http://www.guiainvest.com.br/lista-acoes/default.aspx?listaacaopage={0}";

        public AtivosClient(){
        }

        public  Task<string> GetHtmlStringAsync(int page)
        {
            return this.Client.GetStringAsync(string.Format(GET_ATIVOS_URL, page));            
        }

        public override Task<string> GetHtmlStringAsync()
        {
            return this.Client.GetStringAsync(GET_ATIVOS_URL);            
        }
    }


}