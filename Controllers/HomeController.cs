using Assignment_5.Context;
using Assignment_5.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment_5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _dataContext;
        public HomeController(DataContext dataContext, ILogger<HomeController> logger)
        { 
            _dataContext = dataContext;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Shoes()
        {
            return View();
        }
        public IActionResult Team()
        {
            return View();
        }
        public IActionResult Contact()
        {
            ViewData["messages"] = _dataContext.contactForms.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactModel obj)
        {
            if (ModelState.IsValid)
            {
                _dataContext.contactForms.Add(obj);
                _dataContext.SaveChanges();

                return RedirectToAction("Index");
            }
            else
                return View(obj);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}