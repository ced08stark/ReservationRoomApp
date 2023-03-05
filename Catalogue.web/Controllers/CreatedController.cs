using Catalogue.web.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace Catalogue.web.Controllers
{
    public class CreatedController : Controller
    {
        public List<SalleModel> salles;
        public CreatedController()
        {

            salles = new List<SalleModel>(){   new SalleModel(1, "AC023", "salle de conference", "rien a signaler", "./images/salle1.jpg", true),
            new SalleModel(1, "yoyooy", "totototo", "roror", "./images/salle3.jpg", false)};
        }
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult CreateSalle(SalleModel salleModel)
        {
            salles.Add(new SalleModel(salleModel.Id, salleModel.Numero, salleModel.Libelle, salleModel.Description, salleModel.Picture, false));
            return RedirectToAction("Index", "Home", salles);
        }
    }
}
