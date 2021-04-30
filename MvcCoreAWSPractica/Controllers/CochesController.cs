using Microsoft.AspNetCore.Mvc;
using MvcCoreAWSPractica.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreAWSPractica.Controllers
{
    public class CochesController : Controller
    {
        RepositoryCoches repo;
        public CochesController(RepositoryCoches repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View(this.repo.GetCoches());
        }
        public IActionResult Details(int id)
        {
            return View(this.repo.BuscarCoche(id));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(String marca, String modelo, String conductor, String imagen)
        {
            this.repo.NuevoCoche(marca, modelo, conductor, imagen);
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            return View(this.repo.BuscarCoche(id));
        }
        [HttpPost]
        public IActionResult Update(int id,String marca, String modelo, String conductor, String imagen)
        {
            this.repo.modificarCoche(id, marca, modelo, conductor, imagen);
            return RedirectToAction("Index");
        }
    }
}
