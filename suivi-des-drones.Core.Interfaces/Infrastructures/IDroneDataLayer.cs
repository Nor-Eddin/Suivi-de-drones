using suivi_des_drones.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Interfaces.Infrastructures
{
    /// <summary>
    /// Isole l'accés a la base de données
    /// </summary>
    public interface IDroneDataLayer
    {
        /// <summary>
        /// Retourne la liste complete
        /// </summary>
        /// <returns></returns>
        List<Drone> GetList();
    }
}
