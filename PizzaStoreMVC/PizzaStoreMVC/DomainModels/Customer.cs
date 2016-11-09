using PizzaStoreMVC.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreMVC.DomainModels
{
   public class Customer
   {
      public int CustomerId { get; set; }
      public Name Name { get; set; }
      public Address Address { get; set; }
      public string City { get; set; }
      public string State { get; set; }
      public string Zip { get; set; }
      public Phone Phone { get; set; }
      public Email Email { get; set; }
      public List<Order> History{ get; set; }
   }
}