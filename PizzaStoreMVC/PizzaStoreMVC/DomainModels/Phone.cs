using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreMVC.DomainModels
{
   public class Phone
   {
      [Required]
      [DataType(DataType.PhoneNumber)]
      public string Number { get; set; }
   }
}