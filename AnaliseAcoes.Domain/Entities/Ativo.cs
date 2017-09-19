namespace AnaliseAcoes.Domain.Entities
{
    public class Ativo : Entity
    {
        public string Sigla { get; private set; }
        public string NomePregao { get; private set; }
        public string Atividade { get; private set; }     
        public int PesoLiquidez { get; private set; }   

        public Ativo()
        {
            
        }
    }
    
}