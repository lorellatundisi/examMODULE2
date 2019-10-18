using exammodul2.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace exammodul2.Core.Managers.Interfaces
{
   
        public interface IManager<TEntity>
           where TEntity : class, IEntity
        {
            /// <summary>
            /// Crea l'entità passata sullo storage
            /// </summary>
            /// <param name="entityDaCreare">Entità da creare</param>
            void Crea(TEntity entityDaCreare);

            /// <summary>
            /// Aggiorna l'entità passata nello storage
            /// </summary>
            /// <param name="entityDaModificare">Entità da aggiornare</param>
            void Aggiorna(TEntity entityDaModificare);

            /// <summary>
            /// Cancella l'entità specificata dallo storage
            /// </summary>
            /// <param name="entityDaCancellare">Entità da cancellare</param>
            void Cancella(TEntity entityDaCancellare);

            /// <summary>
            /// Carica tutte le entità nello storage
            /// </summary>
            /// <returns>Ritorna la lista di entità presenti</returns>
            IList<TEntity> Carica();
        }
    
}
