﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzaStoreMVC2.Client.DomainModels
{
   public class CheeseDTO
   {
      public string Name { get; set; }

      public decimal Value { get; set; }
   }
}