using exammodul2.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace exammodul2.Core
{
    class Auto : MonitorableEntityBase
    {
        //“NumeroCavalli”, “IsDiesel” e “DataImmatricolazione”.


        /// <summary>
        /// Descrizione sintetica del num telaio
        /// </summary>
        public int NumeroCavalli { get; set; }



        /// <summary>
        /// Descrizione sintetica 
        /// </summary>
        public bool IsDiesel { get; set; }


        /// <summary>
        /// Descrizione sintetica
        /// </summary>
        public DateTime DataAmmatricolazione { get; set; }



    }


}
