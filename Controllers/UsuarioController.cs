using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PC4.Models;
using PC4.Models.PC4.Models;

namespace PC4.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly Practica4Context _context;

        public UsuarioController(PC4Context context)
        {
            _context = context;
        }

        public IActionResult Usuario()
        {
            return View();
        }

         [HttpPost]
        public IActionResult Usuario(Usuario n){
            if(ModelState.IsValid){
                _context.Add(n);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(n);
        }
    }
}