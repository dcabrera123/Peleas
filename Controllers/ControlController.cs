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
        public async Task<IActionResult> VerLuchadores(string nombre, string categoria, string diciplina)
        {
             var luchadores = from m in _context.Luchador
                 select m;

            if (!String.IsNullOrEmpty(nombre))
            {
                luchadores = luchadores.Where(l => l.Nombre.Contains(nombre));
            }
            if (!String.IsNullOrEmpty(categoria))
            {
                luchadores = luchadores.Where(l => l.Categoria.Contains(categoria));
            }
            if (!String.IsNullOrEmpty(diciplina))
            {
                luchadores = luchadores.Where(l => l.Diciplina.Contains(diciplina));
            }
            return View(await luchadores.ToListAsync());
        }
          
        public IActionResult RegistrarLuchador()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegistrarLuchador([Bind("Nombre","Apellidos","Categoria","Diciplina","Descripcion1","Descripcion2","Descripcion3")] Luchador luchador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(luchador);
                await _context.SaveChangesAsync();
                return RedirectToAction("VerLuchadores");
            }
            return View(luchador);
        }

        public IActionResult RegistrarLucha()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegistrarLucha([Bind("Codigo","Lugar","Fecha","Categoria","Diciplina","Descripcion1","Descripcion2","Descripcion3")] Lucha lucha)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lucha);
                await _context.SaveChangesAsync();
                return RedirectToAction("VerLuchas");
            }
            return View(lucha);
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

       

        

        public IActionResult VerLuchas()
        {
            return View();
        }

       
        
        
        
    }
}
