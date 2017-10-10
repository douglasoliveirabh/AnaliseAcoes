using System;
using System.Collections.Generic;
using System.Text;

namespace AnaliseAcoes.Domain.ValueObjects
{
    public class DadosGerais
    {
        public string TipoPapel { get; set; }
        public string Setor { get; set; }
        public string SubSetor { get; set; }
        public decimal Cotacao { get; set; }
        public DateTime DataUltimaCotacao { get; set; }
        public decimal MenorCotacaoUltimoAno { get; set; }
        public decimal MaiorCotacaoUltimoAno { get; set; }
        public double ValorMercado { get; set; }
        public double ValorFirma { get; set; }
        public DateTime DataUltimoBalancoProcessado { get; set; }
        public long QuantidadeAcoesEmNegociacao { get; set; }

        public DadosGerais(string tipoPapel, string setor, string subsetor, decimal cotacao, DateTime dataUltimaCotacao, decimal menorCotacaoUltimoAno,
                           decimal maiorCotacaoUltimoAno, double valorMercado, double valorFirma, DateTime dataUltimoBalancoProcessado, long quantidadeAcoesEmNegociacao)
        {



            TipoPapel = tipoPapel;
            Setor = setor;
            SubSetor = subsetor;
            Cotacao = cotacao;
            DataUltimaCotacao = dataUltimaCotacao;
            MenorCotacaoUltimoAno = MenorCotacaoUltimoAno;
            MaiorCotacaoUltimoAno = maiorCotacaoUltimoAno;
            ValorMercado = valorMercado;
            ValorFirma = ValorFirma;
            DataUltimoBalancoProcessado = dataUltimoBalancoProcessado;
            QuantidadeAcoesEmNegociacao = quantidadeAcoesEmNegociacao;

        }
    }
}
