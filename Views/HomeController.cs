using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PriorityDogs.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PriorityDogs.Controllers
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
            ViewBag.Message = "Priority Dogs is een hondenbegeleidingscentrum waar alleen instructeurs werken met ruime kennis op het gebied van hondengedrag. Er wordt niet alleen gewerkt in groepsverband zoals puppy- of gehoorzaamheidscursus, maar ook op locatie indien nodig. Wanneer u in huis problemen ervaart met uw hond, laat u Priority Dogs aan huis komen. Raymond Lahaije (gecertificeerd gedragsdeskundige en pijn- en voedingscoach bij honden) helpt u op basis van zijn scholing en ruime ervaring.";
            ViewBag.Message = "Priority Dogs is een stichting zonder winstoogmerk, dit wil zeggen dat de stichting enkel vrijwilligers in dienst heeft om het doel van de stichting Priority Dogs na te leven. Wij als instructeurs leven dus niet van Priority Dogs maar leven meer vóór Priority Dogs. Derhalve zijn we van mening dat een cursus betaalbaar moet blijven voor iedereen. Echter ook een Stichting heeft kosten ( denk hierbij aan verzekeringen, huur, vervoer, inhuren van workshops en lezingen, maar ook bijscholing hoort hierbij).";
            return View();
        }

        public IActionResult AboutUs()
        {
            ViewBag.Message = "Voel u vrij om vragen van welke aard dan ook te stellen. Dit kan altijd, tijdens de cursus, per e-mail of telefonisch. Bij ons heerst een open en eerlijke cultuur. Het is van belang dat een cursist zich bij ons op z’n gemak voelt en met plezier de lessen volgt.";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
