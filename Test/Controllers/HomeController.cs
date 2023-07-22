using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using Test.Models;
using Test.Services;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServicioEmail _servicioEmail;

        public HomeController(ILogger<HomeController> logger, IServicioEmail servicioEmail)
        {
            _logger = logger;
            _servicioEmail = servicioEmail;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]

        public IActionResult Enviartest(ModelTest model)
        {
            if (ModelState.IsValid)
            {
                int score = 0;

                score += model.Pregunta1;
                score += model.Pregunta2;
                score += model.Pregunta3;
                score += model.Pregunta4;
                score += model.Pregunta5;

                score += (5 - model.Pregunta6);
                score += (5 - model.Pregunta7);
                score += (5 - model.Pregunta8);
                score += (5 - model.Pregunta9);
                score += (5 - model.Pregunta10);

                

                try
                {
                    _servicioEmail.EnviarCorreo(model, score);
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error que pueda ocurrir durante el envío
                    _logger.LogError(ex, "Error al enviar el correo");
                    return View("Error");
                }


                TempData["Message"] = "El test se ha enviado correctamente. Por favor, revisa tu correo para ver los resultados.";

                return RedirectToAction("Index");


            }
            else
            {
                // Redirigir a la vista de error o mostrar los errores de validación
                return View("Index");
            }
        }
    }
}