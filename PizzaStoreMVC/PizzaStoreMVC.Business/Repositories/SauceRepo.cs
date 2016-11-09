using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PizzaStoreMVC.Business.Models;

namespace PizzaStoreMVC.Business.Repositories
{
   public class SauceRepo
   {
      private List<Sauce> sauces = new List<Sauce>
      {
         new Sauce() {Name = "Tomato", Price=1M, Quantity=100},
         new Sauce() {Name = "Marinar", Price=0.5M, Quantity=100},
         new Sauce() {Name = "Tomato", Price=0M, Quantity=1}
      };
   }
}