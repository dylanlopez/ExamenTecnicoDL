using AppParte02.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AppParte02.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login(string returnUrl = "")
        {
            var model = new LoginViewModel { ReturnUrl = returnUrl };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            //await _signManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            
            if (ModelState.IsValid)
            {
                
                if (model.Username == "Dylan" && model.Password == "123456")
                {
                    model.Role = "Administrador";
                    return RedirectToAction("Index", "OrdenPago");
                    
                } else if(model.Username == "Juan" && model.Password == "123456")
                {
                    model.Role = "Operador 1";
                    return RedirectToAction("Index", "OrdenPago");
                }
            }
            return View(model);
        }
    }
}