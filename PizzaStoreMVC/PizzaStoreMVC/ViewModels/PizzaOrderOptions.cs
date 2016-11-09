using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreMVC.ViewModels
{
   public class PizzaOrderOptions
   {
      public SelectList sauces { get; set; }
      public SelectList crust { get; set; }
      public SelectList cheeses{ get; set; }
      public SelectList sizes { get; set; }
      public SelectList toppings { get; set; }

   }
}