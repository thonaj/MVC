using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PizzaStoreMVC2.Client.ViewModels
{
   public class Customer
   {
      [Key]
      public int CustomerId { get; set; }
      public Name Name { get; set; }
      public Address Address { get; set; }
      public Phone Phone { get; set; }
      public Email Email { get; set; }
      public List<Order> History { get; set; }
   }
}