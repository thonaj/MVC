using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PizzaStoreMVC2.Client.ViewModels
{
   public class Store
   {
      [Key]
      public int Id { get; set; }
      public string LocationId { get; set; }
      public Address Address { get; set; }
      public Phone Phone { get; set; }
   }
}