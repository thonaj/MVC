using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzaStoreMVC.Client
{
   public class ValidName : ValidationAttribute
   {
      public override bool IsValid(object value)
      {
         if (string.IsNullOrWhiteSpace(value.ToString()))
         {
            return false;
         }
         return true;
      }
      
     
   }
}