using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repasandopc2.Models;

namespace Repasandopc2.Controllers
{
    public class RegistroController:Controller
    {
        private readonly ILogger<RegistroController> _logger;

        public RegistroController(ILogger<RegistroController> logger)
        {
            _logger = logger;
        }

         public IActionResult Registro()
        {
            return View();
        }
        

       

        [HttpPost]
            public IActionResult Registro(Formulario Formulario)
        {
          return RedirectToAction("Confirmacion");
        }

        public IActionResult Confirmacion()
        {
            return View();
        }


    }
}