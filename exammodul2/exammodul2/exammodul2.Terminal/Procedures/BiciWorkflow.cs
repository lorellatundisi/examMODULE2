using exammodul2.Core;
using exammodul2.Core.Managers.Interfaces;
using exammodul2.Storage.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace exammodul2.Terminal.Procedures
{
    public static class BiciWorkflow
    {

        public static void CreaSalva()
        {
            //Istanzio il manager delle bici
            Console.WriteLine();
            Console.WriteLine("ESECUZIONE DEL WORKFLOW BICI...");
            Console.WriteLine();
            
            IManager<Bici> manager = new JsonBiciManager();

            //Visualizzazione contenuto database
            Console.WriteLine("Lettura del database...");
            var BiciInArchivio = manager.Carica();
            Console.WriteLine($"Trovati {BiciInArchivio.Count} bici in archivio");
            foreach (var currentBici in BiciInArchivio)
                Console.WriteLine($"Lettura: {currentBici.Modello} (ID:{currentBici.Id})");
            Console.WriteLine("");

            //Creazione di una nuova "bici"
            Console.WriteLine("Creazione di un nuovo articolo bicicletta...");


            var nuovoBici = new Bici
            {
                Modello= "Speed" , 
                NumeroTelaio = 1000 , 


            };
            manager.Crea(nuovoBici);
            Console.WriteLine("La bici dovrebbe essere stata creata su disco!");
            Console.WriteLine();
        }
    }
}
