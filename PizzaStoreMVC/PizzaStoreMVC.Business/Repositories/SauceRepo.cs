﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PizzaStoreMVC.Business.Models;

namespace PizzaStoreMVC.Business.Repositories
{
   public static class SauceRepo
   {
      private static List<Sauce> sauces = new List<Sauce>
      {
         new Sauce() {Name = "Tomato", Price=1M, Quantity=100},
         new Sauce() {Name = "Marinara", Price=0.5M, Quantity=100},
         new Sauce() {Name = "No Sauce", Price=0M, Quantity=1}
      };

      public static List<Sauce> getSauces()
      {
         return sauces;
      }
   }
}