using suivi_des_drones.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Interfaces.Repositoties
{
    /// <summary>
    /// Contrat pour tout repository gerant des drones
    /// </summary>
    public interface IDroneRepository
    {
        List<Drone> GetAll();
    }
}
