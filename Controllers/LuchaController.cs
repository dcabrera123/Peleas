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
    public class LuchaController : Controller
    {
        private readonly MvcContext _context;

        public LuchaController(MvcContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Luchas()
        {
             var luchas = from m in _context.Lucha
                 select m;
            return View(await luchas.ToListAsync());
        }
       
        public async Task<IActionResult> Lucha(string codigo)
        {
            var luchas = from m in _context.Lucha
                 select m;
            luchas = luchas.Where(c => c.Codigo.Equals(codigo));
            return View(await luchas.ToListAsync());
        }
        
        
    }
}
