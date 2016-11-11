using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PizzaStoreMVC2.Client.ViewModels
{
   public class Pizza
   {
      [Key]
      public int PizzaId { get; set; }
      public Crust Crust { get; set; }
      public Sauce Sauce { get; set; }
      public Size Size { get; set; }
      public List<Cheese> Cheeses { get; set; }
      public List<Topping> Toppings { get; set; }
   }
}