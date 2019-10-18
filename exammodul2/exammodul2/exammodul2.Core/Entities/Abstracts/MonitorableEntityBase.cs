using exammodul2.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace exammodul2.Core.Abstracts
{
    public abstract class MonitorableEntityBase : IEntity, IMonitorableEntity
    {
        /// <summary>
        /// Id primario
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Marca
        /// </summary>
        public string Marca { get; set; }

        /// <summary>
        /// Modello
        /// </summary>
        public string Modello { get; set; }

        
        
    }
}
