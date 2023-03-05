using Catalogue.web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Catalogue.web.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Index(string returnUrl = null)
        {
            var model = new LoginModel { ReturnUrl = returnUrl };
            return View(model);
        }

        public ActionResult Login()
        {

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            try
            {
             
                return RedirectToAction("Index", "Home");
            }
            catch (KeyNotFoundException ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "An error occured. please try again later !");

                Console.Error.WriteLine($"---> {ex.Message} ");
            }

            return View("Index", model);
        }
    }
}
