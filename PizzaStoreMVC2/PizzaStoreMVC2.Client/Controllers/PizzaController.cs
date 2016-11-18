using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzaStoreMVC2.Client.DomainModels;
using PizzaStoreMVC2.Client;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net;
using System.Xml.Serialization;
using System.IO;
using Newtonsoft.Json;

namespace PizzaStoreMVC2.Client.Controllers
{
    public class PizzaController : Controller
    {
      static HttpClient client = new HttpClient();
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
        
         return string.Format("{0} pizza with {1} crust and {2} sauce loaded with {3}  cheese and topped with {4}", model.PizzaOptions.Size, model.PizzaOptions.Crust, model.PizzaOptions.Sauce, ClientHelper.ListPrint(model.PizzaOptions.Cheeses), ClientHelper.ListPrint(model.PizzaOptions.Toppings));

      }
      static async Task RunAsync()
      {
         
         client.BaseAddress = new Uri("http://localhost:55268/");
         client.DefaultRequestHeaders.Accept.Clear();
         client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

         Console.ReadLine();
      }
      static async Task<List<ToppingDTO>> GetProductAsync(string path)
      {
         List<ToppingDTO> toppings = null;
         string responsestring;
         HttpResponseMessage response = await client.GetAsync(path);
         if (response.IsSuccessStatusCode)
         {
            responsestring = await response.Content.ReadAsStringAsync();
            toppings = JsonConvert.DeserializeObject<List<ToppingDTO>>(responsestring);            
         }        
         return toppings;
      }
   }
}