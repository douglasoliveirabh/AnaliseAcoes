using System;
using AnaliseAcoes.Scrapper.Scrappers;

namespace AnaliseAcoes.Scrapper
{
    class Program
    {
        static void Main(string[] args)
        {   
            var opcao = args.Length > 0 ?  args[0] : "ativos";

            switch(opcao){
                case "ativos":
                    AtivosApplication.LoadAtivosAsync();            
                    break;
                case "analises":
                    Console.WriteLine(opcao);
                    break;
                case "":
                    Console.WriteLine("tipo de execução inválido!");
                    Environment.Exit(0);
                    break;
            }

            
        }
    }
}
