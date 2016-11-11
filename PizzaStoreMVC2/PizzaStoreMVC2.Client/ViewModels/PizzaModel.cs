using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace PizzaStoreMVC2.Client.ViewModels
{
   public class PizzaModel 
   {
      
      public int Id { get; set; }


      public List<SelectListItem> SauceOptions { get; set; }
      public List<SelectListItem> CrustOptions { get; set; }
      public List<SelectListItem>  CheeseOptions { get; set; }
      public List<SelectListItem> ToppingOptions { get; set; }
      public List<SelectListItem> SizeOptions { get; set; }


      public string Sauce { get; set; }
      public string Crust { get; set; }
      public  List<string> Cheeses { get; set; }
      public  List<string> Toppings { get; set; }
      public string Size { get; set; }


      public PizzaModel()
      {

         SauceOptions = ClientHelper.GetSauces();
         CrustOptions = ClientHelper.GetCrusts();
         CheeseOptions = ClientHelper.GetCheeses();
         ToppingOptions = ClientHelper.GetToppings();
         SizeOptions = ClientHelper.GetSizes();

      }

     

     

   }
}