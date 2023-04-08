using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Models
{
    /// <summary>
    /// Drone de l'application
    /// </summary>
    public class Drone
    {
        #region Properties
        public string Matricule { get; set; } = string.Empty;
        public DateTime CreationDate { get; set; }
        //Facon avec enum
        //public HealthStatus HealthStatus { get; set; }= HealthStatus.ok;

        //Facons class
        //public HealthStatus HealthStatus { get; set; } = HealthStatus.OK;

        //facons record en 2exemples
        // public HealthStatus HearthStatus { get; set; } = new HealthStatus(0, "");
        public HealthStatus HearthStatus { get; set; } = HealthStatus.OK;
        #endregion
    }
}
