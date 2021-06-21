using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using atividade_iii.Models;

namespace atividade_iii.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Servicos()
        {
            return View();
        }
        public IActionResult Agendamento()
        {
            return View();
        }
        public IActionResult Mostrar(Agendamento agenda){
            ListaAgendamento.incluir(agenda);
            List<Agendamento> lista = ListaAgendamento.listar();
            return View(lista);

        }

    }
}
