using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Xml.Serialization;
using PizzaStoreMVC.DomainModels;
using System.IO;

namespace PizzaStoreMVC.Client.Controllers
{
    public class PizzaController : Controller
    {
      

      // GET: Pizza
      public ActionResult Index()
      {
         return View();
      }

      // GET: Pizza/Details/5
      public ActionResult Details(int id)
      {
         return View();
      }

      // GET: Pizza/Create
      public ActionResult Create()
      {
         return View();
      }

      // POST: Pizza/Create
      [HttpPost]
      public ActionResult Create(FormCollection collection)
      {
         try
         {
               // TODO: Add insert logic here

               return RedirectToAction("Index");
         }
         catch
         {
               return View();
         }
      }

      // GET: Pizza/Edit/5
      public ActionResult Edit(int id)
      {
         return View();
      }

      // POST: Pizza/Edit/5
      [HttpPost]
      public ActionResult Edit(int id, FormCollection collection)
      {
         try
         {
               // TODO: Add update logic here

               return RedirectToAction("Index");
         }
         catch
         {
               return View();
         }
      }

      // GET: Pizza/Delete/5
      public ActionResult Delete(int id)
      {
         return View();
      }

      // POST: Pizza/Delete/5
      [HttpPost]
      public ActionResult Delete(int id, FormCollection collection)
      {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


      public async void customer()
      {
         var client = new HttpClient();
         var message = await client.GetAsync(@"http://ec2-52-23-205-25.compute-1.amazonaws.com/pizzastore/pizza");//this is to connect to web api

         var result = await message.Content.ReadAsStreamAsync();

         var serializer = new XmlSerializer(typeof(List<Customer>));

         var customers = new List<Customer>();


         var output = serializer.Deserialize(result) as List<Customer>;
      }
    }
}
