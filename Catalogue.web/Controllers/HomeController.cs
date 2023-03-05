using Catalogue.web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Catalogue.web.Controllers
{
   
    public class HomeController : Controller
    {

        public List<SalleModel> salles;
        public HomeController()
        {
            salles = new List<SalleModel>(){
            new SalleModel(1, "AC023", "salle de conference", "rien a signaler", "./images/salle1.jpg", true),
            new SalleModel(1, "CH044", "amphis 150", "roror", "./images/salle2.jpg", false),
            new SalleModel(1, "CE059", "salle de conference 2", "roror", "./images/salle3.jpg", false),
            new SalleModel(1, "CF590", "salle de cour commun", "roror", "./images/salle4.jpg", false),
            new SalleModel(1, "AD390", "salle informatique", "roror", "./images/salle5.jpg", false),
            new SalleModel(1, "AJ033", "salle de fete", "roror", "./images/salle6.jpg", true),
            };
            
        }

        public ActionResult Index()
        {

            return View(salles);
        }

        public ActionResult Privacy()
        {
            return View();
        }

       
    }
}