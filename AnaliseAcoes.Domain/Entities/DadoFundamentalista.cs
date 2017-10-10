using AnaliseAcoes.Domain.ValueObjects;

namespace AnaliseAcoes.Domain.Entities{


    public class DadoFundamentalista : Entity
    {
        public Ativo Ativo { get; private set; }
        public int AtivoId { get; private set; }

        public DadosGerais DadosGerais { get; set; }

        protected DadoFundamentalista() { }


        public DadoFundamentalista(DadosGerais dadosGerais)
        {        
            DadosGerais = dadosGerais;
        }


        public DadoFundamentalista ChangeAtivo(int ativoId) {
            this.AtivoId = ativoId;
            return this;
        }

    }
}