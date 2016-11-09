using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreMVC.Client.DomainModels
{
   public class Store
   {
      public int ID { get; set; }
      public string LocationID { get; set; }
      public String Address { get; set; }
      public String City { get; set; }
      public string State { get; set; }
      public string Zip { get; set; }
      public string Phone { get; set; }


   }
}