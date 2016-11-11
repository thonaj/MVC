using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PizzaStoreMVC2.Client.ViewModels
{
   public class Crust
   {
      [Key]
      public int Id { get; set; }
      public string Name { get; set; }
      public decimal Value { get; set; }
   }
}