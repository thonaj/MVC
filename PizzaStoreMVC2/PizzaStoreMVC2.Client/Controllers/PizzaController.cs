using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzaStoreMVC2.Client.ViewModels;

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

         return string.Format("{0} {1} {2} {3} {4}", model.Crust,model.Size,model.Sauce,model.Cheeses,model.Toppings);

      }
   }
}