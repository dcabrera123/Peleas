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
    public class LuchadorController : Controller
    {
        private readonly MvcContext _context;

        public LuchadorController(MvcContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Luchadores()
        {
             var luchadores = from m in _context.Luchador
                 select m;

            
            return View(await luchadores.ToListAsync());
        }

        public async Task<IActionResult> Luchador(string nombre)
        {
            var luchadores = from m in _context.Luchador
                 select m;
            luchadores = luchadores.Where(c => c.Nombre.Equals(nombre));
            return View(await luchadores.ToListAsync());
        }

       
        
       
        
    }
}
