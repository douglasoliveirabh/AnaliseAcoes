using System.Collections.Generic;

namespace AnaliseAcoes.Domain.Entities
{
    public class Ativo : Entity
    {
        public string Sigla { get; private set; }
        public string NomePregao { get; private set; }
        public string Atividade { get; private set; }

        public List<DadoFundamentalista> DadosFundamentalistas { get; set; }

        protected Ativo() { }

        public Ativo(string sigla, string nomePregao, string atividade)
        {
            Sigla = sigla;
            NomePregao = nomePregao;
            Atividade = atividade;
        }
    }

}