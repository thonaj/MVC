using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PizzaStoreMVC2.Client.DomainModels
{
   public class NameDTO
   {
      public string First { get; set; }

      public string Last { get; set; }

      public override string ToString()
      {
         return string.Format("{0}_{1}", First, Last);
      }
   }
}