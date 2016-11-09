using PizzaStoreMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var pizzaModel = new PizzaOrderOptions();

            return View(pizzaModel);
        }
    }
}