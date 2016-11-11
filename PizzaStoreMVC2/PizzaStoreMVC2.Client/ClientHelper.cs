using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzaStoreMVC2.Client.ViewModels;

namespace PizzaStoreMVC2.Client
{
   public class ClientHelper
   {
      public static List<SelectListItem> GetSauces()
      {
         var sauces = new List<SelectListItem>()
         {
              new SelectListItem() { Text = "Alfredo", Value = "0" },

              new SelectListItem() { Text = "Tomato", Value = "1", Selected = true },

              new SelectListItem() { Text = "Marinara", Value = "2" }
         };
         return sauces;
      }

      internal static List<SelectListItem> GetCrusts()
      {
         var Crusts = new List<SelectListItem>()
         {
              new SelectListItem() { Text = "Hand Tossed", Value = "0" },

              new SelectListItem() { Text = "Pan Style", Value = "1", Selected = true },

              new SelectListItem() { Text = "Thin and Crispy", Value = "2" }
         };
         return Crusts;
      }

      internal static List<SelectListItem> GetCheeses()
      {
         var cheeses = new List<SelectListItem>()
         {
              new SelectListItem() { Text = "Italian Blend", Value = "0" },

              new SelectListItem() { Text = "Mozzerella", Value = "1", Selected = true },

              new SelectListItem() { Text = "Pepper Jack", Value = "2" }
         };
         return cheeses;
      }

      internal static List<SelectListItem> GetSizes()
      {
         var sizes = new List<SelectListItem>()
         {
              new SelectListItem() { Text = "Medium", Value = "0" },

              new SelectListItem() { Text = "Large", Value = "1", Selected = true },

              new SelectListItem() { Text = "Small", Value = "2" }
         };
         return sizes;
      }

      internal static List<SelectListItem> GetToppings()
      {
         var toppings = new List<SelectListItem>()
         {
              new SelectListItem() { Text = "Mushroom", Value = "0" },

              new SelectListItem() { Text = "Pepperoni", Value = "1", Selected = true },

              new SelectListItem() { Text = "Diced Tomato", Value = "2" }
         };
         return toppings;
      }
   }
}