using Microsoft.AspNetCore.Mvc;
using PetShop.Repositories;
using PetShop.Models;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using System;


namespace PetShop.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;
        public HomeController(IRepository _repository)
        {
            repository = _repository;
        }
        public IActionResult Index()
        {
           

            return View(repository.GetAnimals().OrderByDescending(((Animal a)=> {
                return a.Comments.Count;
                })).Take(4));
        }
       
    }
}
