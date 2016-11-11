﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzaStoreMVC2.Client.ViewModels
{
   public class Address
   {
      [Key]
      public int Id { get; set; }
      public string Street { get; set; }
      public string City { get; set; }
      public string State { get; set; }
      public string Zip { get; set; }
   }
}