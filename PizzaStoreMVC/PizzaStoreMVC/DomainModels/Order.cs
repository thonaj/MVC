using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreMVC.DomainModels
{
   public class Order
   {
      public int ID { get; set; }
      public string Name { get; set; }
      public decimal Value { get; set; }

   }
}