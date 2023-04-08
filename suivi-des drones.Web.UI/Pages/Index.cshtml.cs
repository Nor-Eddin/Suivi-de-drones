using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using suivi_des_drones.Core.Models;

namespace suivi_des_drones.Web.UI.Pages
{
    public class IndexModel : PageModel
    {
        #region Fields
        private readonly ILogger<IndexModel> _logger;

        #endregion

        #region Construstor
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        #endregion

        #region
        //facon de faire par defaut
        /*public void OnGet()
        {
            //Drone Drone = new ();
            
        }*/

        //deuxieme facon de faire
        /* public IActionResult OnGet()
         {
             IActionResult result = this.Page();

             if (true)
             {
                 result=this.BadRequest();
             }
             return result;
         }*/

        //Troisiemes facons de faire, de maniére asynchrone
        public async Task<IActionResult> OnGetAsync()
        {
            this.SetListOfDrones();
            this.SetListOfStatus();
            return this.Page();
        }
        #endregion

        #region Internal methods
        private void SetListOfDrones()
        {
            this.Drones.Add(new() { Matricule = "54XXD0", CreationDate = DateTime.Now });
            this.Drones.Add(new() { Matricule = "54XXD1", CreationDate = DateTime.Now.AddDays(-150) });
            this.Drones.Add(new() { Matricule = "54XXD2", CreationDate = DateTime.Now.AddDays(-25) });
            this.Drones.Add(new() { Matricule = "54XXD3", CreationDate = DateTime.Now.AddMonths(-14) });
        }
        private void SetListOfStatus()
        {
            this.StatusList.Add(new() { Label = "ok" });
            this.StatusList.Add(new() { Label = "broken" });
            this.StatusList.Add(new() { Label = "repair" });
        }
        #endregion

        #region Properties
        public List<Drone> Drones { get; set; } = new();
        public List<HealthStatus>StatusList { get; set; } = new();
        #endregion
    }
}