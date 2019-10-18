using exammodul2.Core;
using exammodul2.Storage.Json.Abstract;
using System;

namespace exammodul2.Storage.Json
{
    public class JsonBiciManager: JsonManagerBase<Bici>
    {
        protected override void RemapNuoviValoriSuEntityInLista(
            Bici entitySorgente, Bici entityDestinazione)
        {
            entityDestinazione. NumeroTelaio = entitySorgente.NumeroTelaio;
            entityDestinazione. IsElettrica = entitySorgente.IsElettrica;
        }

    }
}
