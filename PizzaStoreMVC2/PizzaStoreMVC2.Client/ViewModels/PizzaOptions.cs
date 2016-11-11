using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PizzaStoreMVC2.Client.ViewModels
{
   public class PizzaOptions
   {
      [Key]
      public int Id { get; set; }
      public List<SelectListItem> Sauces { get; set; }
   }
}