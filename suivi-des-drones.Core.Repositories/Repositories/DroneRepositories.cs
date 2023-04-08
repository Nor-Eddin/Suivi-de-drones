using suivi_des_drones.Core.Interfaces.Repositoties;
using suivi_des_drones.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Application.Repositories
{
    /// <summary>
    /// Repository qui gére les drones, la creation, la lecture,... le CRUD
    /// </summary>
    public class DroneRepositories:IDroneRepository
    {
        /// <summary>
        /// retourn la liste compléte des drones
        /// </summary>
        /// <returns></returns>
        #region public methods
        public List<Drone> GetAll()
        {
            return new()
            {
                new(),
                new()8/
            };
        }
        #endregion
    }
}
