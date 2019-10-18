using System;

namespace exammodul2.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Visualizzo menu e richiedo selezione
            Console.WriteLine("*******************************");
            Console.WriteLine("* MENU                        *");
            Console.WriteLine("*******************************");
            Console.WriteLine("* A - Esegui CREA-SALVA BICI");
            Console.WriteLine("* B - Esegui CREA-SALVA AUTO");
         
            var selezione = //ConsoleUtils.LeggiLetteraDaConsole("A","B");

            //Selezione dell'opzione
            switch (selezione)
            {
                case "A":
                   // TO DO BiciWorkflow.CreaSalva(); 
                    break;
                case "B":
                    //TO DO AutoWorkflow.CreaSalva();
                    break;
               
                default:
                    Console.WriteLine("Opzione non valida!");
                    break;
            }

          
        }
    }
    
}
