using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PizzaStoreMVC2.Client.ViewModels
{
   public class Email
   {
      [Key]
      public int Id { get; set; }
      public string EmailString { get; set; }
   }
}