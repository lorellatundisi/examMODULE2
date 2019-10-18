using System;
using System.Collections.Generic;
using System.Text;

namespace exammodul2.Core.Interfaces
{
    public interface IMonitorableEntity
    {
        

        /// <summary>
        /// Marca
        /// </summary>
         string Marca { get; set; }

        /// <summary>
        /// Modello
        /// </summary>
         string Modello { get; set; }
    }
}
