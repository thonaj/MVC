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
        [HttpGet]
        public ActionResult Index()
        {
            var orderModel = new PizzaOrder();

            return View(orderModel);
        }

        [HttpPost]
        public string Index(PizzaOrder order)
        {
         var sauce = order.Option.sauces.FirstOrDefault(s => s.Selected);
         return sauce.Text;
        }
    }
}