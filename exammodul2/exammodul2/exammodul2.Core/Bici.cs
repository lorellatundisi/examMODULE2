using exammodul2.Core.Abstracts;
using System;

namespace exammodul2.Core
{
    public class Bici : MonitorableEntityBase
    {
       
        /// <summary>
        /// Descrizione sintetica del num telaio
        /// </summary>
        public int NumeroTelaio { get; set; }

       
       
        /// <summary>
        /// Descrizione sintetica 
        /// </summary>
        public bool IsElettrica { get; set; }

    }
}
