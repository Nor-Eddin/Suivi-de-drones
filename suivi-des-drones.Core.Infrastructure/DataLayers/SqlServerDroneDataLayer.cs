using suivi_des_drones.Core.Infrastructure.DataBases;
using suivi_des_drones.Core.Interfaces.Infrastructures;
using suivi_des_drones.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Infrastructure.DataLayers
{
    public class SqlServerDroneDataLayer : IDroneDataLayer
    {
        #region public Methods
        List<Drone> IDroneDataLayer.GetList()
        {
            #region a ne pas reproduire juste pour tester(a modifier)
            using var context=new DronesDbContext();            

            var query = from item in context.Drones
                        select item;
            return query.ToList();
            #endregion

            
        }
        #endregion
    }
}
