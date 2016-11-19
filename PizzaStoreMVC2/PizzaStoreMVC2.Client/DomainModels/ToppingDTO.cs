using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PizzaStoreMVC2.Client.DomainModels
{
   public class ToppingDTO
   {
      public string Name { get; set; }

      public decimal Value { get; set; }
      public bool chosen { get; set; }
   }
}