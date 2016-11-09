using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreMVC.ViewModels
{
   public class PizzaOrderOptions
   {

      public List<SelectListItem> sauces { get; set; }
      public List<SelectListItem> crust { get; set; }
      public List<SelectListItem> cheeses { get; set; }
      public List<SelectListItem> sizes { get; set; }
      public List<SelectListItem> toppings { get; set; }

      public PizzaOrderOptions()
      {
         sauces = new List<SelectListItem>();
         crust = new List<SelectListItem>();
         cheeses = new List<SelectListItem>();
         sizes = new List<SelectListItem>();
         toppings = new List<SelectListItem>();
      }
   }
}