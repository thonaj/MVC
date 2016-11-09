using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreMVC.Business.Abstract
{
   public class AIngredient
   {
      public int IngredientId { get; set; }
      public string Name { get; set; }
      public decimal Price { get; set; }
      public int Quantity { get; set; }

   }
}