using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnaliseAcoes.Scrapper.Clients
{
    public class DadosFundamentalistasClient : WebClientBase
    {
        private const string GET_DADOSFUNDAMENTALISTAS_URL = "http://www.fundamentus.com.br/detalhes.php?papel={0}";

        public DadosFundamentalistasClient()
        {
        }

        public Task<string> GetHtmlAsync(string codigoAtivo)
        {
            var effectiveUrl = string.Format(GET_DADOSFUNDAMENTALISTAS_URL, codigoAtivo);
            return this.GetHtmlStringAsync(effectiveUrl);
        }

        public override async Task<string> GetHtmlStringAsync(string url)
        {
            var bytes = await this.Client.GetByteArrayAsync(url);
            string isocontent = Encoding.GetEncoding("ISO-8859-1").GetString(bytes, 0, bytes.Length);
            byte[] isobytes = Encoding.GetEncoding("ISO-8859-1").GetBytes(isocontent);
            byte[] ubytes = Encoding.Convert(Encoding.GetEncoding("ISO-8859-1"), Encoding.Unicode, isobytes);
            return Encoding.Unicode.GetString(ubytes, 0, ubytes.Length);
            //return Encoding.GetEncoding("ISO-8859-1").GetBytes(str); ;
        }
    }
}
