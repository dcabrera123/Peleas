using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Peleas.Models;

namespace Peleas.Controllers
{
    public class ControlController : Controller
    {
        
        
        private readonly MvcContext _context;

        public ControlController(MvcContext context)
        {
            _context = context;
        }

          // GET: Usuarios/Create
        public IActionResult RegistrarLuchador()
        {
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegistrarLuchador([Bind("Nombre","Apellidos","Apodo","Categoria","Diciplina","Descripcion1","Descripcion2","Descripcion3")] Luchador luchador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(luchador);
                await _context.SaveChangesAsync();
                return RedirectToAction("Control");
            }
            return View(luchador);
        }

        public async Task<IActionResult> Inicio(string contraseña)
        {
            var controles = from m in _context.Control
                 select m;
            controles = controles.Where(c => c.Contraseña.Equals(contraseña));
            return View(await controles.ToListAsync());
        }

        

        public async Task<IActionResult> Contraseña(string contraseña)
        {
             var controles = from m in _context.Control
                 select m;

            if (!String.IsNullOrEmpty(contraseña))
            {
               controles = controles.Where(u => u.Contraseña.Equals(contraseña));
                
                return RedirectToAction("Inicio");
            }
            
            return View(await controles.ToListAsync());
        }

        public IActionResult RegistrarLucha()
        {
            return View();
        }

        

        public IActionResult VerLuchadores()
        {
            return View();
        }

        public IActionResult VerLuchas()
        {
            return View();
        }

       
        
        
        
    }
}
