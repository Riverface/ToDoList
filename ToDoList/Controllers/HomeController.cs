using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;
namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            List<Item> itemSet = Item.GetAll();
            return View(itemSet);

        }

        [HttpGet("/items/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/items")]
        public ActionResult Create(string description)
        {
            Item myItem = new Item(description);
            return RedirectToAction("Index");
        }

    }
}