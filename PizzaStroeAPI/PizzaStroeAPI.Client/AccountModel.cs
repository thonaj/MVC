using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PizzaStroeAPI.Client
{
   public class AccountModel : DbContext
   {
      public AccountModel() : base("DefaultCollection")
      {

      }
   }
}