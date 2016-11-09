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
      public int MyProperty { get; set; }
      public Address ddress { get; set; }
      public Phone Phone { get; set; }
      public Email Email { get; set; }
      public List<Orders> History{ get; set; }
   }
}