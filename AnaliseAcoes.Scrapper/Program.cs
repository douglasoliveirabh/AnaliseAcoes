using System;

namespace AnaliseAcoes.Scrapper
{
    class Program
    {
        static void Main(string[] args)
        {   
            var opcao = args.Length > 0 ?  args[0] : "";

            switch(opcao){
                case "acoes":
                    Console.WriteLine(opcao);                
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
