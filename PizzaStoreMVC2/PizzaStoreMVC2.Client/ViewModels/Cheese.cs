using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzaStoreMVC2.Client.ViewModels
{
   public class Cheese
   {
      [Key]
      public int Id { get; set; }
      public string Name { get; set; }
      public decimal Value { get; set; }
   }
}