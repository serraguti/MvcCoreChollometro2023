﻿using Microsoft.AspNetCore.Mvc;
using MvcCoreChollometro.Models;
using MvcCoreChollometro.Repositories;

namespace MvcCoreChollometro.Controllers
{
    public class ChollometroController : Controller
    {
        private RepositoryChollometro repo;

        public ChollometroController(RepositoryChollometro repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Chollo> chollos = this.repo.GetChollos();
            return View(chollos);
        }
    }
}
