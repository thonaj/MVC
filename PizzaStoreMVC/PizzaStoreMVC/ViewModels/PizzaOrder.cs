using PizzaStoreMVC.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreMVC.ViewModels
{
   public class PizzaOrder
   {
      public List<PizzaOrderDetail> details { get; set; }
      public Customer customer { get; set; }
   }
}