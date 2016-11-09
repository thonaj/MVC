using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreMVC.Client.DomainModels
{
   public class Crust
   {
      public int ID { get; set; }
      public string Name { get; set; }
      public decimal Value { get; set; }
   }
}