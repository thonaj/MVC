using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzaStoreMVC2.Client.ViewModels;
using PizzaStoreMVC2.Client;

namespace PizzaStoreMVC2.Client.Controllers
{
    public class PizzaController : Controller
    {
      // GET: Pizza

      public ActionResult Index()

      {

         var model = new PizzaModel();
         var list = new List<PizzaModel>();
         list.Add(model);
         return View(list);

      }



      [HttpPost]

      public string Index(PizzaModel model)

      {
        
         return string.Format("{0} pizza with {1} crust and {2} sauce loaded with {3}  cheese and topped with {4}", model.Size, model.Crust, model.Sauce, ClientHelper.ListPrint(model.Cheeses), ClientHelper.ListPrint(model.Toppings));

      }
   }
}