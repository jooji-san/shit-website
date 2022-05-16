using Assignment_5.Context;
using Assignment_5.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment_5.Controllers
{
    public class ContactController : Controller
    {
        private readonly DataContext _dataContext;
        public ContactController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IActionResult Contact()
        {

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
    }
}
