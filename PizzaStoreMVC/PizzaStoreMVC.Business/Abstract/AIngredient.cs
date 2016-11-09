using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreMVC.Business.Abstract
{
   public class AIngredient
   {
      public virtual long IngredientId
      public virtual int IngredientId { get; set; }
      public virtual string Name { get; set; }
      public virtual decimal Price { get; set; }
      public virtual int Quantity { get; set; }

      public AIngredient()
         {
         IngredientId = DateTime.Now.Ticks();
         }

   }
}