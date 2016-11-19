using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Net.Http.Headers;
using PizzaStoreMVC2.Client.DomainModels;
using System.Threading.Tasks;
using PizzaStoreMVC2.Client.ViewModels;
using Newtonsoft.Json;

namespace PizzaStoreMVC2.Client.Controllers
{
   public class PizzaSiteController : Controller
   {
      HttpClient client;
      PizzaSiteModel pizzaSiteModel = new PizzaSiteModel();
      // GET: PizzaSite
      public ActionResult Index()
      {
         client = new HttpClient();
         client.BaseAddress = new Uri("http://ec2-52-23-205-25.compute-1.amazonaws.com/pizzastoreapi/api/");
         client.MaxResponseContentBufferSize = 256000;
         client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
         var storeResult = getStoresAsync();
         if (storeResult != null)
         {
            pizzaSiteModel.StoreOptions = makeStoreList(storeResult);
            return View(pizzaSiteModel);
         }
         else
         {
            return View();
         }
      }

      //Post: PizzaSite
      [System.Web.Mvc.HttpPost]
      public RedirectToRouteResult Index(PizzaSiteModel model)

      {
         pizzaSiteModel.storeString = model.storeString;
         //return string.Format("You picked {0}.", pizzaSiteModel.storeString);
         TempData["model"] = pizzaSiteModel;
         return RedirectToAction("ChooseUser");

      }

      //Get: PizzaSite/ChooseUser
      public ActionResult ChooseUser()
      {
         pizzaSiteModel = TempData["model"] as PizzaSiteModel;
         client = new HttpClient();
         client.BaseAddress = new Uri("http://ec2-52-23-205-25.compute-1.amazonaws.com/pizzastoreapi/api/");
         client.MaxResponseContentBufferSize = 256000;
         client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
         var userResult = getCustomersAsync();
         if (userResult != null)
         {
            pizzaSiteModel.UserOptions = makeUserList(userResult);
            TempData["model"] = pizzaSiteModel;
            return View(pizzaSiteModel);
         }
         else
         {
            return View();
         }
      }

      //Post: PizzaSite/ChooseUser
      [System.Web.Mvc.HttpPost]
      public RedirectToRouteResult ChooseUser(PizzaSiteModel model)

      {
         pizzaSiteModel = TempData["model"] as PizzaSiteModel;
         pizzaSiteModel.userString = model.userString;
         //return string.Format("You picked {0}.", pizzaSiteModel.storeString);
         TempData["model"] = pizzaSiteModel;
         return RedirectToAction("Order");

      }

      //Get: PizzaSite/Order
      public ActionResult Order()
      {
         pizzaSiteModel = TempData["model"] as PizzaSiteModel;
         client = new HttpClient();
         client.BaseAddress = new Uri("http://ec2-52-23-205-25.compute-1.amazonaws.com/pizzastoreapi/api/");
         client.MaxResponseContentBufferSize = 256000;
         client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
         var toppingresult = getToppingsAsync().Result;
         var sauceresult = getSaucesAsync();
         var crustresult = getCrustAsync();
         var sizeresult = getSizesAsync();
         var cheeseresult = getCheesesAsync().Result;
         if (sauceresult != null && crustresult != null && sizeresult != null && toppingresult != null && cheeseresult != null)
         {
            pizzaSiteModel.SauceOptions = makeSauceList(sauceresult);
            pizzaSiteModel.CrustOptions = makeCrustList(crustresult);
            pizzaSiteModel.SizeOptions = makeSizeList(sizeresult);
            pizzaSiteModel.ToppingOptions = toppingresult;
            pizzaSiteModel.CheeseOptions = cheeseresult;
            TempData["model"] = pizzaSiteModel;
            return View(pizzaSiteModel);

         }
         else
         {
            return View();
         }
      }

      //Post: PizzaSite/Order
      [System.Web.Mvc.HttpPost]
      public RedirectToRouteResult Order(PizzaSiteModel model)
      {
         pizzaSiteModel = TempData["model"] as PizzaSiteModel;
         client = new HttpClient();
         client.BaseAddress = new Uri("http://ec2-52-23-205-25.compute-1.amazonaws.com/pizzastoreapi/api/");
         client.MaxResponseContentBufferSize = 256000;
         client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
         
        
         pizzaSiteModel.currentOrder.currentPizza.Sauce = getSaucesAsync().Result.Where(m => m.Name==model.sauceString).FirstOrDefault();
         pizzaSiteModel.currentOrder.currentPizza.Size = getSizesAsync().Result.Where(m => m.Name==model.sizeString).FirstOrDefault();
         pizzaSiteModel.currentOrder.currentPizza.Crust = getCrustAsync().Result.Where(m => m.Name == model.crustString).FirstOrDefault();
         foreach (var item in model.currentOrder.currentPizza.cheeses)
         {
            pizzaSiteModel.currentOrder.currentPizza.cheeses.Add(item);
         }
         foreach (var item in model.currentOrder.currentPizza.toppings)
         {
            pizzaSiteModel.currentOrder.currentPizza.toppings.Add(item);
         }
         pizzaSiteModel.currentOrder.Pizzas.Add(pizzaSiteModel.currentOrder.currentPizza);
         TempData["model"] = pizzaSiteModel;
         return RedirectToAction("revieworder");

      }

      //Get: PizzaSite/ReviewOrder
      public ActionResult ReviewOrder()
      {
         pizzaSiteModel = TempData["model"] as PizzaSiteModel;
         return View(pizzaSiteModel);
      }








      public List<SelectListItem> makeStoreList(Task<List<StoreDTO>> result)
      {
         var list = new List<SelectListItem>();
         foreach (var item in result.Result)
         {
            var itm = new SelectListItem();
            itm.Text = item.LocationId;
            itm.Value = item.LocationId;
            list.Add(itm);
         }
         return list;
      }

      public List<SelectListItem> makeUserList(Task<List<CustomerDTO>> result)
      {
         var list = new List<SelectListItem>();
         foreach (var item in result.Result)
         {
            var itm = new SelectListItem();
            itm.Text = item.Name.First + " " + item.Name;
            itm.Value = item.Name.ToString();
            list.Add(itm);
         }
         return list;
      }

      public async Task<List<StoreDTO>> getStoresAsync()
      {
         List<StoreDTO> list = null;
         HttpResponseMessage response = client.GetAsync("store").Result;
         if (response.IsSuccessStatusCode)
         {
            var data = await response.Content.ReadAsStringAsync();
            var product = JsonConvert.DeserializeObject<List<StoreDTO>>(data);
            list = product;
         }
         return list;
      }
      public async Task<List<CustomerDTO>> getCustomersAsync()
      {
         List<CustomerDTO> list = null;
         HttpResponseMessage response = client.GetAsync("customer").Result;
         if (response.IsSuccessStatusCode)
         {
            var data = await response.Content.ReadAsStringAsync();
            var product = JsonConvert.DeserializeObject<List<CustomerDTO>>(data);
            list = product;
         }
         return list;
      }

      public List<SelectListItem> makeSauceList(Task<List<SauceDTO>> result)
      {
         var list = new List<SelectListItem>();
         foreach (var item in result.Result)
         {
            var itm = new SelectListItem();
            itm.Text = item.Name;
            itm.Value = item.Name;
            list.Add(itm);
         }
         return list;
      }
      public List<SelectListItem> makeCrustList(Task<List<CrustDTO>> result)
      {
         var list = new List<SelectListItem>();
         foreach (var item in result.Result)
         {
            var itm = new SelectListItem();
            itm.Text = item.Name;
            itm.Value = item.Name;
            list.Add(itm);
         }
         return list;
      }
      public List<SelectListItem> makeSizeList(Task<List<SizeDTO>> result)
      {
         var list = new List<SelectListItem>();
         foreach (var item in result.Result)
         {
            var itm = new SelectListItem();
            itm.Text = item.Name;
            itm.Value = item.Name;
            list.Add(itm);
         }
         return list;
      }
      public async Task<List<ToppingDTO>> getToppingsAsync()
      {
         List<ToppingDTO> list = null;
         HttpResponseMessage response = client.GetAsync("topping").Result;
         if (response.IsSuccessStatusCode)
         {
            var data = await response.Content.ReadAsStringAsync();
            var product = JsonConvert.DeserializeObject<List<ToppingDTO>>(data);
            list = product;
         }
         return list;
      }
      public async Task<List<CrustDTO>> getCrustAsync()
      {
         List<CrustDTO> list = null;
         HttpResponseMessage response = client.GetAsync("crust").Result;
         if (response.IsSuccessStatusCode)
         {
            var data = await response.Content.ReadAsStringAsync();
            var product = JsonConvert.DeserializeObject<List<CrustDTO>>(data);
            list = product;
         }
         return list;
      }
      public async Task<List<SizeDTO>> getSizesAsync()
      {
         List<SizeDTO> list = null;
         HttpResponseMessage response = client.GetAsync("size").Result;
         if (response.IsSuccessStatusCode)
         {
            var data = await response.Content.ReadAsStringAsync();
            var product = JsonConvert.DeserializeObject<List<SizeDTO>>(data);
            list = product;
         }
         return list;
      }
      public async Task<List<SauceDTO>> getSaucesAsync()
      {
         List<SauceDTO> list = null;
         HttpResponseMessage response = client.GetAsync("sauce").Result;
         if (response.IsSuccessStatusCode)
         {
            var data = await response.Content.ReadAsStringAsync();
            var product = JsonConvert.DeserializeObject<List<SauceDTO>>(data);
            list = product;
         }
         return list;
      }
      public async Task<List<CheeseDTO>> getCheesesAsync()
      {
         List<CheeseDTO> list = null;
         HttpResponseMessage response = client.GetAsync("cheese").Result;
         if (response.IsSuccessStatusCode)
         {
            var data = await response.Content.ReadAsStringAsync();
            var product = JsonConvert.DeserializeObject<List<CheeseDTO>>(data);
            list = product;
         }
         return list;
      }

















      //// GET: api/PizzaSite
      //public IEnumerable<string> Get()
      //{
      //    return new string[] { "value1", "value2" };
      //}

      //// GET: api/PizzaSite/5
      //public string Get(int id)
      //{
      //    return "value";
      //}

      //// POST: api/PizzaSite
      //public void Post([FromBody]string value)
      //{
      //}

      //// PUT: api/PizzaSite/5
      //public void Put(int id, [FromBody]string value)
      //{
      //}

      //// DELETE: api/PizzaSite/5
      //public void Delete(int id)
      //{
      //}


   }
}
