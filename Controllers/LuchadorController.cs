using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Peleas.Models;

namespace Peleas.Controllers
{
    public class LuchadorController : Controller
    {
        public IActionResult Luchadores()
        {
            return View();
        }

       
        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
