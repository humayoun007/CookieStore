using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CookieStore.Models;
using CookieStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CookieStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository;
        
        public HomeController(IRepository repository)
        {
            _repository = repository;

        }

        public IActionResult Index()
        {
            //ViewBag.Title = "Cookies and only Cookies";
            //var cookies = _repository.GetAllCookies().OrderByDescending(x => x.Price);

            var cookies = _repository.GetAllCookies().OrderBy(x => x.Name);
            var homeViewModel = new HomeViewModel
            {
                Title = "Cookies and only Cookies",
                Cookies = cookies.ToList()
            };
            return View(homeViewModel);
        }

        public IActionResult Details(int id)
        {
            var cookie = _repository.GetCookieById(id);
            return View(cookie);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}